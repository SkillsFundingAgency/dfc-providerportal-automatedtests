using System;
using System.Collections.Generic;
using ApiTesting.Framework.BaseObjects;
using NLog;
using RestSharp;

namespace ApiTesting.Framework.Clients
{
    public class ProvidersObject : ResourceObject
    {
        private string SyncProvidersFunction = "SyncProviders?code=" + GlobalConfiguration.UKRLP_Key;
        private string GetAllProvidersFunction = "GetAllProviders?code=" + GlobalConfiguration.UKRLP_Key;
        private string GetProvidersByPRNFunction = "GetProviderByPRN?PRN=";
        private string GetProvidersByPRNFunctionPOST = "GetProviderByPRN?code=" + GlobalConfiguration.UKRLP_Key;
        private string GetProvidersByNameFunction = "GetProvidersByName?name=";
        private string GetProvidersByNameFunctionPOST = "GetProvidersByName?code=" + GlobalConfiguration.UKRLP_Key;
        private string ProvidersByRefRoute = "SyncProviders?code=" + GlobalConfiguration.UKRLP_Key + "&UnitedKingdomProviderReferenceNumber=";

        private new static readonly RestClient RestClient = new RestClient(GlobalConfiguration.UKRLP);
        private new static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public ProvidersObject() : base(RestClient, Logger)
        {
        }

        public IRestResponse<List<Providers>> SyncProviders()
        {
            System.Console.WriteLine(SyncProvidersFunction);
            RestRequest request = new RestRequest(SyncProvidersFunction, Method.GET);

            return Execute<List<Providers>>(request);
        }


        public IRestResponse<List<Providers>> GetAllProviders()
        {
            System.Console.WriteLine(GetAllProvidersFunction);
            RestRequest request = new RestRequest(GetAllProvidersFunction, Method.GET);

            return Execute<List<Providers>>(request);
        }


        public IRestResponse<Providers> GetProviderByPRN(int UKPRN)
        {
            RestRequest request = new RestRequest(GetProvidersByPRNFunction+UKPRN+"&code="+ GlobalConfiguration.UKRLP_Key, Method.GET);
           
            return Execute<Providers>(request);
        }


        public IRestResponse<Providers> GetProviderByName(string Name)
        {
            RestRequest request = new RestRequest(GetProvidersByNameFunction + Name + "&code=" + GlobalConfiguration.UKRLP_Key, Method.GET);

            return Execute<Providers>(request);
        }


        public IRestResponse<Providers> GetProviderByPRNPOST(Providers Providers, String JSON)
        {
            RestRequest request = new RestRequest(GetProvidersByPRNFunctionPOST, Method.POST);
            request.AddHeader("accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("application/json", JSON, ParameterType.RequestBody);

            return Execute<Providers>(request);
        }


        public IRestResponse<Providers> GetProviderByNamePOST(Providers Providers, String JSON)
        {
            RestRequest request = new RestRequest(GetProvidersByNameFunctionPOST, Method.POST);
            request.AddHeader("accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("application/json", JSON, ParameterType.RequestBody);

            return Execute<Providers>(request);
        }


        public IRestResponse<Providers> UpdateProviders(string UnitedKingdomProviderReferenceNumber, string propertyName, string propertyValue)
        {
            RestRequest request = new RestRequest(ProvidersByRefRoute, Method.PATCH);
            request.AddUrlSegment("UnitedKingdomProviderReferenceNumber", UnitedKingdomProviderReferenceNumber);
            request.AddParameter(propertyName, propertyValue);

            return Execute<Providers>(request);
        }


        public IRestResponse<Providers> ReplaceProviders(Providers Providers)
        {
            RestRequest request = new RestRequest(ProvidersByRefRoute, Method.PUT);
            request.AddParameter("id", Providers.UnitedKingdomProviderReferenceNumber);
            request.AddParameter("name", Providers.ProviderName);

            return Execute<Providers>(request);
        }


        public IRestResponse DeleteProviders(Providers Providers)
        {
            RestRequest request = new RestRequest(ProvidersByRefRoute, Method.DELETE);
            request.AddUrlSegment("UnitedKingdomProviderReferenceNumber", Providers.UnitedKingdomProviderReferenceNumber.ToString());

            return Execute(request);
        }
    }
}
