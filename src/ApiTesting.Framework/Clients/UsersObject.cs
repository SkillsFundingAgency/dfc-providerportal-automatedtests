using System.Collections.Generic;
using ApiTesting.Framework.BaseObjects;
using ApiTesting.Framework.Models;
using NLog;
using RestSharp;
using System;

namespace ApiTesting.Framework.Clients
{
    public class UsersObject : ResourceObject
    {
        private const string UsersRoute = "users";
        private const string UsersByIdRoute = "users/{id}";

        private new static readonly RestClient RestClient = new RestClient(GlobalConfiguration.Url);
        private new static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public UsersObject() : base(RestClient, Logger)
        {
        }

        public IRestResponse<List<Users>> GetUsers()
        {
            RestRequest request = new RestRequest(UsersRoute, Method.GET);

            return Execute<List<Users>>(request);
        }

        public IRestResponse<List<Users>> GetUsers(string userId)
        {
            RestRequest request = new RestRequest(UsersRoute, Method.GET);
            request.AddParameter("userId", userId);

            return Execute<List<Users>>(request);
        }

        public IRestResponse<Users> GetUser(int UserId)
        {
            RestRequest request = new RestRequest(UsersByIdRoute, Method.GET);
            request.AddUrlSegment("id", UserId);

            return Execute<Users>(request);
        }

        public IRestResponse<Users> SendUsers(Users Users)
        {
            RestRequest request = new RestRequest(UsersRoute, Method.POST);
            request.AddParameter("id", Users.Id);
            request.AddParameter("name", Users.Name);
            request.AddParameter("userName", Users.Username);

            return Execute<Users>(request);
        }

        public IRestResponse<Users> UpdateUsers(string UsersId, string propertyName, string propertyValue)
        {
            RestRequest request = new RestRequest(UsersByIdRoute, Method.PATCH);
            request.AddUrlSegment("id", UsersId);
            request.AddParameter(propertyName, propertyValue);

            return Execute<Users>(request);
        }

        public IRestResponse<Users> ReplaceUsers(Users Users)
        {
            RestRequest request = new RestRequest(UsersByIdRoute, Method.PUT);
            request.AddParameter("id", Users.Id);
            request.AddParameter("name", Users.Name);
            request.AddParameter("userName", Users.Username);

            return Execute<Users>(request);
        }

        public IRestResponse DeleteUsers(Users Users)
        {
            RestRequest request = new RestRequest(UsersByIdRoute, Method.DELETE);
            request.AddUrlSegment("id", Users.Id.ToString());

            return Execute(request);
        }
    }
}
