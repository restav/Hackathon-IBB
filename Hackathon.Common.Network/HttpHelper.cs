using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Hackathon.Common.Network
{
    public class HttpHelper
    {
        public static string PostCall(string url, string data, string contentType)
        {
            byte[] requestDataStream = Encoding.UTF8.GetBytes(data);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = contentType;
            request.ContentLength = requestDataStream.Length;
            request.KeepAlive = false;

            using (Stream newStream = request.GetRequestStream())
            {
                newStream.Write(requestDataStream, 0, requestDataStream.Length);
                newStream.Close();
            }

            string responseString = "";

            using (WebResponse webResponse = request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(webResponse.GetResponseStream()))
                {
                    responseString = reader.ReadToEnd();
                    reader.Close();
                }
                webResponse.Close();
            }

            return responseString;
        }

        public static string GetCall(string url, Dictionary<string, object> urlParams = null)
        {
            string requestUrl;
            if (urlParams == null)
            {
                requestUrl = url;
            }
            else 
            {
                requestUrl = url + "?";
                string paramsTemp = String.Empty;
                urlParams.Keys.ToList().ForEach(key =>
                {
                    paramsTemp += key.Replace("&", "%26");
                    paramsTemp += "=";
                    paramsTemp += urlParams[key].ToString().Replace("&", "%26");
                    paramsTemp += "&";
                });
                paramsTemp = paramsTemp.Remove(paramsTemp.Length - 1);
                requestUrl += HttpUtility.UrlEncode(paramsTemp);
            }
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUrl);
            //request.Accept = "application/json";
            //request.Headers.Add("X-IBM-Client-Id", "45703946-bcba-4411-9b24-ade454a1d3cf");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream(), Encoding.UTF8).ReadToEnd();
            return responseString;
        }
    }
}
