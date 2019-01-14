using System.Threading;
using NUnit.Framework;
using OWASPZAPDotNetAPI;
using System;
using System.Diagnostics;
using System.Configuration;
using System.IO;
using FluentAssertions;


namespace SecurityTesting.ProviderPortal.ZAPTests
//namespace SecurityTesting.APIs.ZAP_Tests
{
    [TestFixture]
    public class ProviderPortal
    {
        private static readonly string ZapApiKey = ConfigurationManager.AppSettings["zapAPIKey"];
        private static readonly string ZapUrl = ConfigurationManager.AppSettings["zapHost"];
        private static readonly string ZapPort = ConfigurationManager.AppSettings["zapPort"];
        private static readonly string TargetUrl = ConfigurationManager.AppSettings["TargetURL"];
        private static readonly string ReportPath = AppDomain.CurrentDomain.BaseDirectory  + ConfigurationManager.AppSettings["zapReportPath"];
        private static ClientApi zap;
        private IApiResponse response;
         
        public ProviderPortal()
        {
           // StartProc(@"C:\Program Files\OWASP\Zed Attack Proxy\zap.sh", "start");
           // Thread.Sleep(40000);


            zap = new ClientApi(ZapUrl, Convert.ToInt32(ZapPort), ZapApiKey);
            zap.core.excludeFromProxy("^(?:(?!" + TargetUrl + ").)+$");
        }


        private enum ReportFileExtention
        {
            Html,
            Xml,
            Md
        }

        [Test, Category("SecurityTests")]
        public void FirstRunSpiderScan()
        {
            if (Convert.ToBoolean(ConfigurationManager.AppSettings.Get("RunZAPScans").ToLower()))
            {
                var spiderId = StartSpidering();
                CheckSpideringProgress(spiderId);
            }
        }

        public void CheckAlerts()
        {
            ApiResponseSet alertSummary = (ApiResponseSet)zap.core.alertsSummary(TargetUrl);
            alertSummary.Dictionary.TryGetValue("High", out var high);
            alertSummary.Dictionary.TryGetValue("Medium", out var medium);

            Convert.ToInt32(high).Should().Be(0);
            Convert.ToInt32(medium).Should().Be(0);
        }

        [Test, Category("SecurityTests")]
        public void SecondRunActiveScan()
        {
            if (Convert.ToBoolean(ConfigurationManager.AppSettings.Get("RunZAPScans").ToLower()))
            {
                var activeScanId = StartActiveScan();
                CheckActiveScanProgress(activeScanId);
                var reportFilename = $"{DateTime.Now:dd.MM.yy-hh.mm.ss}-ZAP_Report";
                SaveSession(reportFilename);
                zap.Dispose();

                GenerateScanReport(reportFilename, ReportFileExtention.Html);
                //StopProc();
            }
        }

        private static void CheckActiveScanProgress(string activeScanId)
        {
            int progress;
            while (true)
            {
                Thread.Sleep(10000);
                progress = int.Parse(((ApiResponseElement)zap.ascan.status(activeScanId)).Value);

                if (progress >= 100)
                {
                    break;
                }
            }
            Thread.Sleep(5000);
        }

        private static void GenerateScanReport(string filename, ReportFileExtention fileExtention)
        {
            var fileName = $@"{ReportPath}\{filename}.{fileExtention.ToString().ToLower()}";
            File.WriteAllBytes(fileName, zap.core.htmlreport());
        }

        private static void SaveSession(string reportFilename)
        {
            var sessionReportPath = ReportPath + "\\Sessions\\" + DateTime.Now.ToString("dd.MM.yy");
            zap.core.saveSession($@"{sessionReportPath}\{reportFilename}", "true");
        }

        private static void CheckSpideringProgress(string spideringId)
        {
            int progress;
            while (true)
            {
                Thread.Sleep(10000);
                progress = int.Parse(((ApiResponseElement)zap.spider.status(spideringId)).Value);
                if (progress >= 100)
                {
                    break;
                }
            }

            Thread.Sleep(5000);
        }

        private string StartSpidering()
        {
            response = zap.spider.scan(TargetUrl, string.Empty, string.Empty, string.Empty, string.Empty);
            return ((ApiResponseElement)response).Value;
        }

        private string StartActiveScan()
        {
            //response = zap.core.sendRequest(TargetUrl, string.Empty);
            response = zap.ascan.scan(TargetUrl, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            return ((ApiResponseElement)response).Value;

        }

        private Process StartProc(string procname, string processCmd)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = procname;

            switch (processCmd)
            {
                case "start":
                    proc.Start();
                    return proc;

                case "stop":
                    proc.Kill();
                    return proc;

                default:
                    throw new Exception("Process not recognised");
            }
        }

        private void StopProc()
        {
            Process[] zapInstances = Process.GetProcessesByName("java");

            foreach (Process p in zapInstances)
                p.Kill();
        }
    }
}