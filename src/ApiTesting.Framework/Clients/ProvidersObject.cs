using System.Collections.Generic;
using ApiTesting.Framework.BaseObjects;
using NLog;
using RestSharp;

namespace ApiTesting.Framework.Clients
{
    public class ProvidersObject : ResourceObject
    {
        private string ProvidersRoute = "SyncProviders?code=" + GlobalConfiguration.UKRLP_Key;
        private string ProvidersByRefRoute = "SyncProviders?code=" + GlobalConfiguration.UKRLP_Key + "&UnitedKingdomProviderReferenceNumber=";

        private new static readonly RestClient RestClient = new RestClient(GlobalConfiguration.UKRLP);
        private new static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public ProvidersObject() : base(RestClient, Logger)
        {
        }

        public IRestResponse<List<Providers>> GetProviders()
        {
            System.Console.WriteLine(ProvidersRoute);
            RestRequest request = new RestRequest(ProvidersRoute, Method.GET);

            return Execute<List<Providers>>(request);
        }

        public IRestResponse<List<Providers>> GetProviders(string providerRef)
        {
            RestRequest request = new RestRequest(ProvidersRoute, Method.GET);
            request.AddParameter("UnitedKingdomProviderReferenceNumber", providerRef);

            return Execute<List<Providers>>(request);
        }

        public IRestResponse<Providers> GetProvider(int providerRef)
        {
            RestRequest request = new RestRequest(ProvidersByRefRoute, Method.GET);
           
            return Execute<Providers>(request);
        }

        public IRestResponse<Providers> SendProviders(Providers Providers)
        {
            RestRequest request = new RestRequest(ProvidersRoute, Method.POST);
            request.AddParameter("id", Providers.UnitedKingdomProviderReferenceNumber);
            request.AddParameter("name", Providers.ProviderName);

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
