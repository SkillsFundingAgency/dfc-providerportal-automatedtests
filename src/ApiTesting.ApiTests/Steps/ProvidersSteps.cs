using System;
using System.Collections.Generic;
using System.Reflection;
using ApiTesting.Framework.Clients;
using ApiTesting.Framework.Models;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;
using Newtonsoft.Json;


namespace ApiTesting.ApiTests.Steps
{
    [Binding]
    public class ProviderSteps
    {
        private UserContext UserContext;
        private ProvidersObject ProvidersObject;

        public ProviderSteps(UserContext userContext)
        {
            UserContext = userContext;
        }

        [Given(@"a user is using the providers resource")]
        public void GivenAUserIsUsingTheProvidersResource()
        {
            ProvidersObject = new ProvidersObject();
        }

        [When(@"user requests sync providers")]
        public void WhenRequestsSyncProviders()

        {
            ScenarioContext.Current.Add("Response", ProvidersObject.SyncProviders());
        }

        [When(@"user requests all providers")]
        public void WhenRequestsGetAllProviders()

        {
            ScenarioContext.Current.Add("Response", ProvidersObject.GetAllProviders());
        }


        [When(@"he requests details for provider (.*) By UKPRN")]
        public void RequestProviderByUKPRN(int UKPRN)
        {
            ScenarioContext.Current.Add("Response", ProvidersObject.GetProviderByPRN(UKPRN));
        }


        [When(@"he requests details for provider (.*) By Name")]
        public void RequestProviderByName(string ProviderName)
        {
            ScenarioContext.Current.Add("Response", ProvidersObject.GetProviderByName(ProviderName));
        }

        [When(@"he requests details for provider (.*) By UKPRN POST Method")]
        public void RequestProviderByUKPRNPOST(int UKPRN)
        {
            string JSON = "{ \"PRN\":\"" + UKPRN + "\"}";
            ScenarioContext.Current.Add("Response", ProvidersObject.GetProviderByPRNPOST(UserContext.Providers, JSON));
        }


        [When(@"he requests details for provider (.*) By Name POST Method")]
        public void RequestProviderByUKNamePOST(string ProviderName)
        {
            string JSON = "{ \"Name\":\"" + ProviderName + "\"}";
            ScenarioContext.Current.Add("Response", ProvidersObject.GetProviderByNamePOST(UserContext.Providers, JSON));
        }


        [Then(@"the response should contain (.*) providers")]
        public void ThenTheResponseShouldContainProviders(int provCount)
        {
            var response = JsonConvert.DeserializeObject(ScenarioContext.Current.Get<IRestResponse<Providers>>("Response").Content);
            var Providers = JsonConvert.DeserializeObject<List<Providers>>(response.ToString());

            if (Providers.Count != provCount)
            //if (Providers.Count.ToString() != FeatureContext.Current["ProviderCount"].ToString())
            {
                throw new Exception("No. of Provider updates is incorrect, \n Expected: " 
                                    + provCount
                                   // + FeatureContext.Current["ProviderCount"].ToString() 
                                    + "\n Found: " 
                                    + Providers.Count.ToString());
            }
        }


        [Then(@"all providers should contain required properties")]
        public void ThenAllProvidersShouldContainRequiredProperties()
        {
            int i = 0;
            var response = JsonConvert.DeserializeObject(ScenarioContext.Current.Get<IRestResponse<List<Providers>>>("Response").Content);
            var Providers = JsonConvert.DeserializeObject<List<Providers>>(response.ToString());

            FeatureContext.Current["ProviderCount"] = Providers.Count;
            System.Console.WriteLine(Providers.Count);  //Debug


            foreach (var provider in Providers)
            {
                Assert.Multiple(() =>
                {
                    Assert.IsNotNull(provider.UnitedKingdomProviderReferenceNumber);
                    if (i==0)
                    {
                        //store first provider to use in other scenarios within feature - if you want to
                        FeatureContext.Current["ProviderRef"] = provider.UnitedKingdomProviderReferenceNumber;
                        i++;
                    }
                    
                    Assert.IsNotNull(provider.ProviderName);

                    foreach (var contact in provider.ProviderContact)
                    {
                        Assert.IsNotNull(contact.ContactType);
                        if (contact.ContactType != "L")
                        {
                            if (contact.ContactType != "P")
                            {
                                throw new Exception("Incorrect Contact Type Returned");
                            }
                        }

                    }

                    foreach (var verify in provider.VerificationDetails)
                    {
                        Assert.IsNotNull(verify.VerificationAuthority);
                    }

                });
            }
        }


        [Then(@"the response should contain provider (.*)")]
        public void ThenTheResponseShouldContainProvider(string Provider)
        {
            var response = JsonConvert.DeserializeObject(ScenarioContext.Current.Get<IRestResponse<Providers>>("Response").Content);
            var Providers = JsonConvert.DeserializeObject<List<Providers>>(response.ToString());

            if (!response.ToString().Contains(Provider))
            //if (!response.ToString().Contains(FeatureContext.Current["ProviderRef"].ToString()))
            {
                throw new Exception("Provider not found");
            }

        }

        [Then(@"the response contains provider UKPRN (.*)")]
        public void ResponseShouldContainProviderPRN(string Provider)
        {

            var response = JsonConvert.DeserializeObject(ScenarioContext.Current.Get<IRestResponse<Providers>>("Response").Content); 
            
            if (!response.ToString().Contains(Provider))
            //if (!response.ToString().Contains(FeatureContext.Current["ProviderRef"].ToString()))
            {
                throw new Exception("Provider not found");
            }

        }


        private static int GetRandomIntBetween(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max);
        }

        private static object GetPropertyValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName)?.GetValue(src, null);
        }

        private static void TrySetProperty(object obj, string property, object value)
        {
            var prop = obj.GetType().GetProperty(property, BindingFlags.Public | BindingFlags.Instance);
            if (prop != null && prop.CanWrite)
                prop.SetValue(obj, value, null);
        }

    }
}
