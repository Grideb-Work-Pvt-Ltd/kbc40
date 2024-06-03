//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Net;
//using System.Text;
//using System.IO;

//namespace forex.Services
//{
//    public class jou
//    {
//        [Obsolete]
//        public string fun(string temail, string tname, string subject, string body)
//        {
           
//            string url = "https://api2.juvlon.com/v4/httpSendMail";
//            HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
//            myHttpWebRequest.Method = "POST";
//            string postData = "{\"ApiKey\":\"OTQwNTkjIyMyMDIzLTAyLTE3IDEzOjQ5OjA4\"" +

//                              ",\"requests\":[{\"subject\":\""+subject+"\"" +
//                                                ",\"from\":\"magikarpfinance7@gamil.com\"" +
//                                                ",\"body\":\""+body+"\"" +
//                                                  ",\"to\":\""+temail+"\"}]}";

//            byte[] data = Encoding.ASCII.GetBytes(postData);
//            myHttpWebRequest.ContentType = "application/json";
//            ServicePointManager.SecurityProtocol =  SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
//            myHttpWebRequest.ContentLength = data.Length;
//            Stream requestStream = myHttpWebRequest.GetRequestStream();
//            requestStream.Write(data, 0, data.Length);
//            requestStream.Close();

//            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
//            Stream responseStream = myHttpWebResponse.GetResponseStream();
//            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
//            string pageContent = myStreamReader.ReadToEnd();
//            Console.WriteLine(pageContent);
//            myStreamReader.Close();
//            responseStream.Close();
//            myHttpWebResponse.Close();
//            return "success";
//        }
//    }
//}
