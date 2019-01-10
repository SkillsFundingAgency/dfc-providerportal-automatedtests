using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;

namespace UITesting.CourseDirectory.Models
{
    public class Venue
    {
        /*Venue Web Elements*/
        public string FILTER_VENUE_NAME = "//*[@id='DataTables_Table_0']/tfoot/tr/td[2]/input";
        public string VENUE_TABLE_NAME_COL = "//*[@id='DataTables_Table_0']/tbody/tr/td[2]";
        public string ALL_VENUES_MENU = "//a[@href='/Venue/List']";
        public string VENUE_PAGE_TITLE_TEXT = "/html/body/div[3]/div[1]/div[1]/h2";
        public string ADD_VENUE_TITLE_TEXT = "/html/body/div[3]/ h2";
        public string ADD_VENUE_MENU = "//a[@href='/Venue/Create']";
        public string VENUE_ID = "//*[@id='ProviderOwnVenueRef']";
        public string VENUE_NAME = "//*[@id='VenueName']";
        public string VENUE_POSTCODE= "//*[@id='Address_Postcode']";
        public string FIND_ADDRESS = "//*[@id='aFindAddress']";
        public string ADDRESS_DROPDOWN = "//*[@id='ddlChooseAddress']";
        public string CREATE_VENUE_BUTTON = "/html/body/div[3]/form/div/div[16]/div/input";
        public string ADD_VENUE_SUCCESS_MSG = "/html/body/div[3]/div[1]/div[1]/div";
        public string EDIT_LINK = "//*[@id='DataTables_Table_0']/tbody/tr/td[9]/a";
        public string SAVE_VENUE = "/html/body/div[3]/form/div/div[16]/div/input[1]";
        public string SAVE_VENUE_MESSAGE = "/html/body/div[3]/div[1]/div[1]/div";
        public string VENUE_EMAIL= "//*[@id='Email']";


        public string ProviderId=RandomDataGenerator.GenerateRandomAlphanumericString(4);
        public string VenueName = "New Venue";
        public string PostCode = "cv12wt";
         
    }
}
