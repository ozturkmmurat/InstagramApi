using InstagramApi.Models.ResponseModel;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramApi.Core.ExternalServices.InstagramApi
{
    public class InstagramManager
    {
        public List<Datum> GetAllImage(string accesToken)
        {
            var client = new RestClient();
            var request = new RestRequest($"https://graph.instagram.com/me/media?fields=id,media_url,caption&access_token={accesToken}", Method.Get);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Bearer {accesToken}");
            request.AddHeader("Cookie", "ig_did=85220BB5-4440-4D23-9A9C-1B5C5396A6B0; ig_nrcb=1; mid=Yi27lQAEAAEH0f0lhhZ--F22tdjC");
            var body = @"";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            var response = client.ExecuteGetAsync<ImageResponseModel>(request).Result;

            return response.Data.data.ToList();           
        }
      
    }
}
