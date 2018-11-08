using System.Collections.Generic;
using ApiTesting.Framework.BaseObjects;
using ApiTesting.Framework.Models;
using NLog;
using RestSharp;
using System;

namespace ApiTesting.Framework.Clients
{
    public class LARSObject : ResourceObject
    {
        private const string LARS = "search?api-version=2017-11-11";

        private new static readonly RestClient RestClient = new RestClient(GlobalConfiguration.LARS);
        private new static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public LARSObject() : base(RestClient, Logger)
        {
        }

        public IRestResponse<List<LARS>> GetLARS()
        {
            RestRequest request = new RestRequest(LARS, Method.GET);
            return Execute<List<LARS>>(request);
        }


        public IRestResponse<List<LARS>> SendLARS(LARS lars, String JSON)
        {
            RestRequest request = new RestRequest(LARS,Method.POST);
            request.AddHeader("accept", "application/json");
            request.AddHeader("api-key", GlobalConfiguration.LARS_Key);
            request.AddHeader("indexes", "index-lars-awardorg");
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("application/json", JSON, ParameterType.RequestBody);
            return Execute<List<LARS>>(request);
        }

    }
}
