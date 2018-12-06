using System.Collections.Generic;
using ApiTesting.Framework.BaseObjects;
using ApiTesting.Framework.Models;
using NLog;
using RestSharp;
using System;

namespace ApiTesting.Framework.Clients
{
    public class VenuesObject : ResourceObject
    {
        private const string GetAllVenuesAPI = "GetAllVenues?";
        private const string GetVenueByIDAPI = "GetVenueByID?";

        private string code = ""; // put in config later

        private new static readonly RestClient RestClient = new RestClient(GlobalConfiguration.Venues);
        private new static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public VenuesObject() : base(RestClient, Logger)
        {
        }

        // get all venues API

        public IRestResponse<List<Venues>> GetVenues()
        {
            RestRequest request = new RestRequest(GetAllVenuesAPI, Method.GET);
            return Execute<List<Venues>>(request);
        }


        public IRestResponse<List<Venues>> GetAllVenues(Venues venues, String JSON)
        {
            RestRequest request = new RestRequest(GetAllVenuesAPI ,Method.GET);

            request.AddParameter("code", code);
            request.AddHeader("accept", "application/json");
            //request.AddHeader("api-key", GlobalConfiguration.Venues_Key);
            request.AddHeader("indexes", "index-Venues-awardorg");
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("application/json", JSON, ParameterType.RequestBody);
            return Execute<List<Venues>>(request);
        }

        // get venue by ID

        public IRestResponse<List<Venues>> GetVenueByID()
        {
            RestRequest request = new RestRequest(GetVenueByIDAPI, Method.GET);
            return Execute<List<Venues>>(request);
        }


        public IRestResponse<List<Venues>> GetVenueByID(Venues venues, String id)
        {
            RestRequest request = new RestRequest(GetVenueByIDAPI, Method.GET);

            request.AddParameter("code", code);
            request.AddParameter("id", id);
            request.AddHeader("accept", "application/json");
            //request.AddHeader("api-key", GlobalConfiguration.Venues_Key);
            request.AddHeader("indexes", "index-Venues-awardorg");
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
           // request.AddParameter("application/json", "", ParameterType.RequestBody);
            return Execute<List<Venues>>(request);
        }



    }
}
