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

        [When(@"user requests all updated providers")]
        public void WhenRequestsAllProviders()

        {
            ScenarioContext.Current.Add("Response", ProvidersObject.GetProviders());
        }

        [When(@"he requests details for provider (.*)")]
        public void WhenHeRequestsDetailsForProviderId(int Id)
        {
            ScenarioContext.Current.Add("Response", ProvidersObject.GetProvider(Id));
        }


        [Then(@"the response should contain (.*) providers")]
        public void ThenTheResponseShouldContainProviders(string provCount)
        {
            var response = JsonConvert.DeserializeObject(ScenarioContext.Current.Get<IRestResponse<Providers>>("Response").Content);
            var Providers = JsonConvert.DeserializeObject<List<Providers>>(response.ToString());

            if (Providers.Count.ToString() != FeatureContext.Current["ProviderCount"].ToString())
            {
                throw new Exception("No. of Provider updates is incorrect, \n Expected: " 
                                    + FeatureContext.Current["ProviderCount"].ToString() 
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
                        //store first provider to use in other scenarios within feature
                        FeatureContext.Current["ProviderRef"] = provider.UnitedKingdomProviderReferenceNumber;
                        i++;
                    }
                    
                    Assert.IsNotNull(provider.ProviderName);

                    foreach (var contact in provider.ProviderContact)
                    {
                        System.Console.WriteLine(contact.ContactType);
                        System.Console.WriteLine(contact.ContactWebsiteAddress);
                        System.Console.WriteLine(contact.ContactPersonalDetails.PersonFamilyName);
                    }

                    foreach (var verify in provider.VerificationDetails)
                    {
                        System.Console.WriteLine(verify.VerificationAuthority);
                    }

                });
            }
        }


        [Then(@"the response should contain provider (.*)")]
        public void ThenTheResponseShouldContainProvider(int Id)
        {
            var response = JsonConvert.DeserializeObject(ScenarioContext.Current.Get<IRestResponse<Providers>>("Response").Content);
            var Providers = JsonConvert.DeserializeObject<List<Providers>>(response.ToString()); 

            if (!response.ToString().Contains(FeatureContext.Current["ProviderRef"].ToString()))
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
