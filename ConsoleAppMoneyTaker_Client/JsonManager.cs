using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMoneyTaker_Client
{
    //해당 클래스는 싱글톤으로 구성할 것
    class JsonManager
    {
        private static JsonManager _instance;
        
        protected JsonManager()
        {

        }
        public static JsonManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instance)
                    {
                        _instance = new JsonManager();
                        string requestJson = "someJsonRequestString";
                        WebClient webClient = new WebClient();
                        webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                        webClient.Encoding = UTF8Encoding.UTF8;
                    }
                }
                return _instance;
            }
        }

        //public JsonManager()
        //{
        //    string requestJson = "someJsonRequestString";
        //    WebClient webClient = new WebClient();
        //    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
        //    webClient.Encoding = UTF8Encoding.UTF8;
        //    string responseJSON = webClient.UploadString(url, requestJson);
        //}
    }
}
