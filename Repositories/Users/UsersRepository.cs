using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace CallingExternalApi
{
    public class UsersRepository
    {
        public string GetUsers()
        {
            string usersObject = null;
            WebRequest requestObject = WebRequest.Create("https://jsonplaceholder.typicode.com/users/");
            requestObject.ContentType = "application/json; charset=utf-8";
            requestObject.Method = WebRequestMethods.Http.Get;
            HttpWebResponse responseObject = (HttpWebResponse)requestObject.GetResponse();

            using(Stream stream = responseObject.GetResponseStream())
            {
                StreamReader streamReader = new StreamReader(stream);
                usersObject = streamReader.ReadToEnd();
                streamReader.Close();
            }

            return usersObject;
        }
    }
}