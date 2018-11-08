using System;
using System.Collections.Generic;
using ApiTesting.Framework.Clients;
using ApiTesting.Framework.Models;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Newtonsoft.Json;

namespace ApiTesting.ApiTests.Steps
{
    [Binding]
    public class LARSSteps
    {
        private UserContext UserContext;
        private LARSObject LARSObject;
        //private string JSON;

        public LARSSteps(UserContext userContext)
        {
            UserContext = userContext;
        }

        [Given(@"a user is using the LARS resource")]
        public void GivenAUserIsUsingResource()
        {
            LARSObject = new LARSObject();
        }


        [When(@"user sends LARS request with no facets (.*)")]
        public void SendsAPostWithOneFacet(string search)
        {
             string JSON = "{ \"search\": \"" + search + "\", \"count\": true}";
            //Console.WriteLine(JSON);                                                              //Debug
            ScenarioContext.Current.Add("Response", LARSObject.SendLARS(UserContext.LARS, JSON));
            ScenarioContext.Current["SearchTerm"] = search;
        }


        [When(@"user sends LARS request with facets (.*), (.*), (.*), (.*), (.*), (.*)'")]
        public void WhenUserSendsLARSRequestWithFacets(string search, string count, string facet1, string facet2, string filter1, string filter2)
        {
            string JSON = "{ \"search\": \"" + search
                                + "\",\"count\": \"" + count
                                + "\", \"facets\": [ \"" + facet1
                                + "\", \"" + facet2
                                + "\"],\"filter\": \"" + filter1
                                + " and " + filter2
                                + "'\"}";
            //Console.WriteLine("JSON Request: " +JSON);
            ScenarioContext.Current.Add("Response", LARSObject.SendLARS(UserContext.LARS, JSON));
            ScenarioContext.Current["SearchTerm"] = search;
        }


        [When(@"user sends LARS request with one facet:")]
        public void SendsAPostWithOneFacet(Table table)
        {
            UserContext.LARSSearch = table.CreateInstance<LARSSearch>();

            foreach (var row in table.Rows)
            {
                ScenarioContext.Current["SearchTerm"] = row[0].ToString();

                string JSON = "{ \"search\": \"" + row[0].ToString()
                                                + "\",\"count\": \"" + row[1].ToString()
                                                + "\",\"facets\": [\"" + row[2].ToString()
                                                + "\"],\"filter\": \"" + row[3].ToString()
                                                + "\"}";
                //Console.WriteLine(JSON);                                                          //Debug
                ScenarioContext.Current.Add("Response", LARSObject.SendLARS(UserContext.LARS, JSON));
            }
        }


        [When(@"user sends LARS request with two facets:")]
        public void SendsAPostWithTwoFacet(Table table)
        {
            UserContext.LARSSearch = table.CreateInstance<LARSSearch>();

            foreach (var row in table.Rows)
            {
                ScenarioContext.Current["SearchTerm"] = row[0].ToString();

                string JSON = "{ \"search\": \"" + row[0].ToString()
                                                + "\", \"count\": " + row[1].ToString()
                                                + ", \"facets\": [ \"" + row[2].ToString()
                                                + "\", \"" + row[3].ToString()
                                                + "\"],\"filter\": \"" + row[4].ToString()
                                                + " and " + row[5].ToString()
                                                + "\"}";
                //Console.WriteLine("JSON Request: " +JSON);                                        //Debug
                ScenarioContext.Current.Add("Response", LARSObject.SendLARS(UserContext.LARS, JSON));
            }
        }

        [Then(@"Response should contain the correct information")]
        public void ThenResponsesContainsCorrectInfo()
        {
            var response = JsonConvert.DeserializeObject(ScenarioContext.Current.Get<IRestResponse<List<LARS>>>("Response").Content).ToString();
            LARS lars = JsonConvert.DeserializeObject<LARS>(response);
            Console.WriteLine("JSON Response: " + response);                           //Debug

            Console.WriteLine("LARS Record Found for Search: " + response.Remove(0, 132).Split(',')[0]);

            foreach (var course in lars.value)
            {
                Assert.Multiple(() =>
                {
                    Assert.IsNotNull(course.LearnAimRef);
                    //Console.WriteLine("LARS REF :" + course.LearnAimRef );              //Debug
                    Assert.IsNotNull(course.LearnAimRefTitle);
                    Assert.True(course.LearnAimRefTitle.ToString().ToLower().Contains(ScenarioContext.Current["SearchTerm"].ToString().ToLower()));
                    Assert.IsNotNull(course.NotionalNVQLevelv2);
                    Assert.IsNotNull(course.AwardOrgCode);
                    Assert.IsNotNull(course.AwardOrgName);

                });
            }
        }


        [Then(@"Response should contains zero records")]
        public void ThenResponsesContainsZeroRecords()
        {
            var response = JsonConvert.DeserializeObject(ScenarioContext.Current.Get<IRestResponse<List<LARS>>>("Response").Content).ToString();
            LARS lars = JsonConvert.DeserializeObject<LARS>(response);
            Console.WriteLine("JSON Response: " + response);                           //Debug

            Console.WriteLine("LARS Record Found for Search: " + response.Remove(0, 132).Split(',')[0]);

            if( !response.Remove(0, 132).Split(',')[0].StartsWith("0"))
            {
                throw new Exception("Unexpected response - \r\n expected zero records, but \r\n" + response.Remove(0, 132).Split(',')[0] + " found");
            }
        }

    }

}
