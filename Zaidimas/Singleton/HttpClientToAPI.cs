using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using RestSharp;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace Zaidimas.Singleton
{
     public class HttpClientToAPI
    {
        private static RestClient _client;
        private static HttpClientToAPI _instance;


        private HttpClientToAPI()
        {
            if (_client == null)
            {

                _client = new RestClient("https://ktumangirdas.azurewebsites.net/api");

            }
        }

        public static HttpClientToAPI Instance()
        {
            if (_instance == null)
            {
                _instance = new HttpClientToAPI();
            }
            return _instance;
        }

        //public HttpClient GetHttp()
        //{
        //    return _httpClient;
        //}

        public string GetData(string req)
        {

            IRestRequest request = new RestRequest(req, Method.GET);
            IRestResponse response = _client.Execute(request);
            var content = response.Content; // raw content as string

            return content; //TODO change return JSON
        }

        public string Post(string req, string json)
        {

            IRestRequest request = new RestRequest(req, Method.POST);
            // Json to post.
            //string jsonToSend = JsonHelper.ToJson(json);

            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            string resp = "";

            try
            {
                var response = _client.Execute(request);
                //_client.Execute(request, response =>
                //{
                if (response.StatusCode == HttpStatusCode.Created)
                {
                    resp = response.Content;
                    Logger.Instance().Info("post to " + req + " success");
                }
                else
                {
                    Logger.Instance().Error("post to " + req + " unsuccess");
                }
                //});
            }
            catch (Exception error)
            {
                Logger.Instance().Error("post to " + req + " unsuccess: " + error );

            }

            return resp;
        }

        public string Put(string req, string json)
        {

            IRestRequest request = new RestRequest(req, Method.PUT);
            // Json to post.
            //string jsonToSend = JsonHelper.ToJson(json);

            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            string resp = "";

            try
            {
                var response = _client.Execute(request);
                //_client.Execute(request, response =>
                //{
                if (response.StatusCode == HttpStatusCode.NoContent)
                {
                    resp = response.Content;
                    Logger.Instance().Info("Put to " + req + " success");
                }
                else
                {
                    Logger.Instance().Error("Put to " + req + " unsuccess");
                }
                //});
            }
            catch (Exception error)
            {
                Logger.Instance().Error("Put to " + req + " unsuccess: " + error);

            }

            return resp;
        }

    }
}
