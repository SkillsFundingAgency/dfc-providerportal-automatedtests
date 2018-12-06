using System;
using System.Collections.Generic;
using ApiTesting.Framework.Clients;
using ApiTesting.Framework.Models;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Newtonsoft.Json;

namespace ApiTesting.ApiTests
{
    [Binding]
    public class VenuesSteps
    {
        private UserContext UserContext;
        private VenuesObject VenuesObject;

        public VenuesSteps(UserContext userContext)
        {
            UserContext = userContext;
        }

        [Given(@"a provider service issues a View Live Venues request")]
        public void GivenAProviderServiceIssuesAViewLiveVenuesRequest()
        {
            VenuesObject = new VenuesObject();
            string JSON = ""; 

            ScenarioContext.Current.Add("Response", VenuesObject.GetAllVenues(UserContext.Venues, JSON));
        }


        [Given(@"a provider service issues a View Live Venues request for (.*)")]
        public void GivenAProviderServiceIssuesAViewLiveVenuesRequestFor(string p0)
        {
            VenuesObject = new VenuesObject();

            String RecordID = p0;
            //string  = "{ \"id\"= \"" + RecordID +"} ";

            ScenarioContext.Current.Add("Response", VenuesObject.GetVenueByID(UserContext.Venues, RecordID));
        }

        [When(@"the request header specifies a specific venue id cebdc(.*)-c(.*)c(.*)e-cbab(.*)db(.*)f(.*)")]
        public void WhenTheRequestHeaderSpecifiesASpecificVenueIdCebdc_Cce_Cbabdbf(int p0, string p1, string p2, int p3, string p4, int p5)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the venue specified in search cebdc(.*)-c(.*)c(.*)e-cbab(.*)db(.*)f(.*) is returned in response")]
        public void ThenTheVenueSpecifiedInSearchCebdc_Cce_CbabdbfIsReturnedInResponse(int p0, string p1, string p2, int p3, string p4, int p5)
        {
            ScenarioContext.Current.Pending();
        }




        [When(@"the request header has no specified parameters")]
        public void WhenTheRequestHeaderHasNoSpecifiedParameters()
        {

            Console.WriteLine("...miss this step");
            //string JSON = ""; ////{ \"PROVIDER_ID\": \"303529\"}";
                                                         
            //ScenarioContext.Current.Add("Response", VenuesObject.GetAllVenues(UserContext.Venues, JSON));
            //ScenarioContext.Current["SearchTerm"] = search;
            //Do nothing to request header for now - not able to take parameters yet
        }

        [When(@"the request body contains no data")]
        public void WhenTheRequestBodyContainsNoData()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the request body contains an invalid parameter")]
        public void WhenTheRequestBodyContainsAnInvalidParameter()
        {
            ScenarioContext.Current.Pending();
        }



        [Given(@"a service creates a search request")]
        public void GivenAServiceCreatesASearchRequest()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the request body includes (.*)")]
        public void WhenTheRequestBodyIncludes(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the request body incudes (.*)")]
        public void WhenTheRequestBodyIncudes(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the search body details course details")]
        public void WhenTheSearchBodyDetailsCourseDetails()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the request body includes \\ a special character")]
        public void WhenTheRequestBodyIncludesASpecialCharacter()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the request header does not contain a valid Auth Key")]
        public void WhenTheRequestHeaderDoesNotContainAValidAuthKey()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the response should contain (.*) venues")]
        public void ThenTheResponseShouldContainVenues(string p0)
        {
            Console.WriteLine("Got here");
            // does nothing
        }
        
        [Then(@"the response returns a status of (.*)")]
        public void ThenTheResponseReturnsAStatusOf(int p0)
        {

            Assert.IsNotEmpty(ScenarioContext.Current.Get<IRestResponse<List<Venues>>>("Response").Content);
            Console.WriteLine("API response not empty");

            var response = JsonConvert.DeserializeObject(ScenarioContext.Current.Get<IRestResponse<List<Venues>>>("Response").Content).ToString();
            Venues Venues = JsonConvert.DeserializeObject<Venues>(response);

            //var header = JsonConvert.DeserializeObject(ScenarioContext.Current.Get<IRestResponse<List<Venues>>>("Header").Content).ToString();

            int lengthOfResponse = response.Length;
        

            Console.WriteLine("Response Length: " + lengthOfResponse);
            Console.WriteLine("Venues? " + Venues);
            Console.WriteLine("JSON Response: " + response);                           //Debug
        }


        [Then(@"the response contains venue record: (.*)Castle Street Community CentreCA(.*) Castle Street CentreCastle StreetKendalCumbriaLA(.*)AD")]
        public void ThenTheResponseContainsVenueRecordCastleStreetCommunityCentreCACastleStreetCentreCastleStreetKendalCumbriaLAAD(Decimal p0, int p1, int p2)
        {
            var response = JsonConvert.DeserializeObject(ScenarioContext.Current.Get<IRestResponse<List<Venues>>>("Response").Content).ToString();
            Console.WriteLine("JSON Response: " + response);
        }



        [Then(@"each record returned should contain correct address information:")]
        public void ThenEachRecordReturnedShouldContainCorrectAddressInformation()
        {
            {
                var response = JsonConvert.DeserializeObject(ScenarioContext.Current.Get<IRestResponse<List<Venues>>>("Response").Content).ToString();
                Venues Venues = JsonConvert.DeserializeObject<Venues>(response);
                Console.WriteLine("JSON Response: " + response);                           //Debug

                Console.WriteLine("Venue Record/s Found for Search: " + response.Remove(0, 132).Split(',')[0]);

                foreach (var venueItem in Venues.value)
                {
                    Assert.Multiple(() =>
                    {
                        Assert.IsNotNull(venueItem.UKPRN);
                        //Console.WriteLine("LARS REF :" + course.LearnAimRef );              //Debug
                        //Assert.IsNotNull(course.LearnAimRefTitle);
                        //Assert.True(course.LearnAimRefTitle.ToString().ToLower().Contains(ScenarioContext.Current["SearchTerm"].ToString().ToLower()));
                        //Assert.IsNotNull(course.NotionalNVQLevelv2);
                        //Assert.IsNotNull(course.AwardOrgCode);
                        //Assert.IsNotNull(course.AwardOrgName);

                    });
                }
            }
        }
        
        [Then(@"response code is (.*)")]
        public void ThenResponseCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the response should contains zero records")]
        public void ThenTheResponseShouldContainsZeroRecords()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
