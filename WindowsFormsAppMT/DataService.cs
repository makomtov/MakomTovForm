﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebApiMTModel.Models.Models.View;

namespace WindowsFormsAppMT
{
    class DataService
    {
        public DataService()
        {
            
        }
        string URI = "http://localhost:53698/api/";
        /// <summary>
        /// שליפת כלבים של משתמש
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public  List<DogDetailsViewManager> GetDogsInformationAsync(int userid)
       
        {
            string ans = "";
            DogsForManagerView userDogs = new DogsForManagerView();
            URI += "Users/GetUserDogsByManager";
            try
            {
                List<OrderDetailsViewManager> filesinformation = new List<OrderDetailsViewManager>();
                
                string jsonContent = JsonConvert.SerializeObject(userid);
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                using (var client = new HttpClient())
                {
                    if (!string.IsNullOrWhiteSpace(LogIn.token))
                    {
                        var t = JsonConvert.DeserializeObject<Token>(LogIn.token);

                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + t.access_token);
                    }
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                   
                    var response =  client.PostAsync(URI, content).Result;
                    //var response = client.GetAsync(url).Result;
                    if (response.StatusCode != HttpStatusCode.Unauthorized)
                        ans= response.Content.ReadAsStringAsync().Result;
                    else
                        ans= response.ReasonPhrase;
                    //var response = await HttpClient.PostAsync(url, encodedContent).ConfigureAwait(false);


                    //ans = JsonConvert.DeserializeObject<DogsForManagerView>(response.Result.Content.);
                    //else
                    //    ans = response.ReasonPhrase;
                }
                if (ans != "Unauthorized")
                {
                    userDogs = JsonConvert.DeserializeObject<DogsForManagerView>(ans);
                    return userDogs.UserDogs; ;
                }
                else
                    throw new WebException(ans);
            }
          
            catch (WebException ex)
            {

                throw ex;
            }
          
        }

        /// <summary>
        /// שליפת כל המשתמשים
        /// </summary>
        /// <returns></returns>
        public List<UserDetailsView> GetUsersInformation(LoginView loginView)
        {

            try
            {

                List<UserDetailsView> filesinformation = new List<UserDetailsView>();
                URI += "Users";
              
                // string response = CallApi(URI, token,null);
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                using (var client = new HttpClient())
                {
                    if (!string.IsNullOrWhiteSpace(LogIn.token))
                    {
                        var t = JsonConvert.DeserializeObject<Token>(LogIn.token);

                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + t.access_token);
                    }

                    //var encodedContent = new FormUrlEncodedContent(parameters);
                    //var response = await HttpClient.PostAsync(url, encodedContent).ConfigureAwait(false);
                    var response = client.GetAsync(URI).Result;


                    if (response.StatusCode != HttpStatusCode.Unauthorized)
                    {
                        filesinformation = JsonConvert.DeserializeObject<List<UserDetailsView>>(response.Content.ReadAsStringAsync().Result);
                        return filesinformation;
                    }

                    else
                        throw new WebException(response.ReasonPhrase);
                }
            }
            catch (WebException ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// שליפת כל ההזמנות
        /// </summary>
        /// <returns></returns>
        public List<OrderDetailsViewManager> GetFileOrderList(LoginView loginView)
        {
            List<OrderDetailsViewManager> filesinformation = new List<OrderDetailsViewManager>();
            URI += "Reservation/GetAllOrdersAndDogsManager";
          
           
            string response = CallApi(URI, LogIn.token,null);
            filesinformation = JsonConvert.DeserializeObject<List<OrderDetailsViewManager>>(response);
            return filesinformation;



        }
        /// <summary>
        /// שליפת כל הסטטוסים של הזמנה
        /// </summary>
        /// <param name="url"></param>
        public List<StatusView> GetFileOrderStaus(LoginView loginView)
        {
            List<StatusView> filesinformation = new List<StatusView>();
            URI += "Reservation/OrderStatusList";
           
            string response = CallApi(URI, LogIn.token, null);
            filesinformation = JsonConvert.DeserializeObject<List<StatusView>>(response);
            return filesinformation;


        }

        /// <summary>
        /// שליפת שעות הפתיחה
        /// </summary>
        /// <param name="url"></param>
        public List<ShiftView> GetOpenHours()
        {
            List<ShiftView> filesinformation = new List<ShiftView>();
            URI += "Reservation/OpenHoursList";

            string response = CallApi(URI, LogIn.token, null);
            filesinformation = JsonConvert.DeserializeObject<List<ShiftView>>(response);
            return filesinformation;


        }
        /// <summary>
        /// עדכון הזמנות 
        /// </summary>
        /// <param name="listOrder"></param>
        public void UpdateUserResarvations(List<OrderDetailsViewManager> listOrder)

        {
            
            URI += "Reservation/UpdateOrdersByManager";
            string ans = "";
            try
            {
               

                string jsonContent = JsonConvert.SerializeObject(listOrder);
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                using (var client = new HttpClient())
                {
                    if (!string.IsNullOrWhiteSpace(LogIn.token))
                    {
                        var t = JsonConvert.DeserializeObject<Token>(LogIn.token);

                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + t.access_token);
                    }
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");


                    var response = client.PutAsync(URI, content).Result;
                    //var response = client.GetAsync(url).Result;
                    if (response.StatusCode != HttpStatusCode.Unauthorized)
                        ans = response.Content.ReadAsStringAsync().Result;
                    else
                        ans = response.ReasonPhrase;
                    //var response = await HttpClient.PostAsync(url, encodedContent).ConfigureAwait(false);


                    //ans = JsonConvert.DeserializeObject<DogsForManagerView>(response.Result.Content.);
                    //else
                    //    ans = response.ReasonPhrase;
                }
                if (ans == "Unauthorized")
                
                    throw new WebException(ans);
            }

           

            catch (WebException ex)
                {

                    throw ex;
                }
            }
       

        /// <summary>
        /// יצירת הזמנה 
        /// </summary>
        /// <param name="listOrder"></param>
        public int InsertUserResarvations(OrderDetailsView order)

        {
            
            // POST a JSON string
            URI += "Reservation/CreateOrder";
            string ans = "";
            
            try
            {
                

                string jsonContent = JsonConvert.SerializeObject(order);
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                using (var client = new HttpClient())
                {
                    if (!string.IsNullOrWhiteSpace(LogIn.token))
                    {
                        var t = JsonConvert.DeserializeObject<Token>(LogIn.token);

                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + t.access_token);
                    }
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");


                    var response = client.PostAsync(URI, content).Result;
                    //var response = client.GetAsync(url).Result;
                    if (response.StatusCode != HttpStatusCode.Unauthorized)
                        ans = response.Content.ReadAsStringAsync().Result;
                    else
                        ans = response.ReasonPhrase;
                    //var response = await HttpClient.PostAsync(url, encodedContent).ConfigureAwait(false);


                    //ans = JsonConvert.DeserializeObject<DogsForManagerView>(response.Result.Content.);
                    //else
                    //    ans = response.ReasonPhrase;
                }
                if (ans != "Unauthorized")
                {
                    return JsonConvert.DeserializeObject<int>(ans);
                    
                }
                else
                    throw new WebException(ans);
            }

            catch (WebException ex)
            {

                throw ex;
            }

            
           
        }
        /// <summary>
        /// עדכון כלבים למשתמש
        /// </summary>
        /// <param name="listOrder"></param>
        public void UpdateUserDogs(DogsForManagerView userMDogs)

        {
            URI += "Users/UpdateUserDogsByManager";
            string ans = "";

            try
            {


                string jsonContent = JsonConvert.SerializeObject(userMDogs);
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                using (var client = new HttpClient())
                {
                    if (!string.IsNullOrWhiteSpace(LogIn.token))
                    {
                        var t = JsonConvert.DeserializeObject<Token>(LogIn.token);

                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + t.access_token);
                    }
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");


                    var response = client.PostAsync(URI, content).Result;
                    //var response = client.GetAsync(url).Result;
                    if (response.StatusCode != HttpStatusCode.Unauthorized)
                        ans = response.Content.ReadAsStringAsync().Result;
                    else
                        ans = response.ReasonPhrase;
                    //var response = await HttpClient.PostAsync(url, encodedContent).ConfigureAwait(false);


                    //ans = JsonConvert.DeserializeObject<DogsForManagerView>(response.Result.Content.);
                    //else
                    //    ans = response.ReasonPhrase;
                }
                if (ans == "Unauthorized")
                {

                    throw new WebException(ans);
                }
            }

            catch (WebException ex)
            {

                throw ex;
            }
        }

     public   static string GetToken(string url, string userName, string password)
        {
            try
            {
                var pairs = new List<KeyValuePair<string, string>>
                    {
                        new KeyValuePair<string, string>( "grant_type", "password" ),
                        new KeyValuePair<string, string>( "username", userName ),
                        new KeyValuePair<string, string> ( "Password", password )
                    };
                var content = new FormUrlEncodedContent(pairs);
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                using (var client = new HttpClient())
                {
                    var response = client.PostAsync(url + "Token", content).Result;
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception("אינך מורשה להכנס לאתר");
                    return response.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        static string CallApi(string url, string token,Dictionary<string,string> parameters)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            using (var client = new HttpClient())
            {
                if (!string.IsNullOrWhiteSpace(token))
                {
                    var t = JsonConvert.DeserializeObject<Token>(token);

                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + t.access_token);
                }
               
                //var encodedContent = new FormUrlEncodedContent(parameters);
                //var response = await HttpClient.PostAsync(url, encodedContent).ConfigureAwait(false);
                var response = client.GetAsync(url).Result;
                if (response.StatusCode != HttpStatusCode.Unauthorized)
                    return response.Content.ReadAsStringAsync().Result;
                else
                    return response.ReasonPhrase;
            }
        }
        /// <summary>
        /// שליפת משתמש 
        /// </summary>
        /// <param name="loginView"></param>
        /// <returns>UserDetailsView</returns>
        public UserDetailsView GetUser (LoginView loginView)
        {

            

              //  UserDetailsView userDetailsView = null;
                // POST a JSON string
                URI += "Users/GetUser";


               

            string ans = "";

            try
            {


                string jsonContent = JsonConvert.SerializeObject(loginView);
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                using (var client = new HttpClient())
                {
                    if (!string.IsNullOrWhiteSpace(LogIn.token))
                    {
                        var t = JsonConvert.DeserializeObject<Token>(LogIn.token);

                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + t.access_token);
                    }
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");


                    var response = client.PostAsync(URI, content).Result;
                    //var response = client.GetAsync(url).Result;
                    if (response.StatusCode != HttpStatusCode.Unauthorized)
                        ans = response.Content.ReadAsStringAsync().Result;
                    else
                        ans = response.ReasonPhrase;
                    //var response = await HttpClient.PostAsync(url, encodedContent).ConfigureAwait(false);


                    //ans = JsonConvert.DeserializeObject<DogsForManagerView>(response.Result.Content.);
                    //else
                    //    ans = response.ReasonPhrase;
                }
                if (ans != "Unauthorized")
                {
                    return JsonConvert.DeserializeObject<UserDetailsView>(ans);

                }
                else
                    throw new WebException(ans);
            }

            catch (WebException ex)
            {

                throw ex;
            }


            //// HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI);
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI);
            //    //  request.Method = "POST";
            //    request.Method = WebRequestMethods.Http.Post;

            //    UTF8Encoding encoding = new UTF8Encoding();
            //    Byte[] byteArray = encoding.GetBytes(jsonContent);



            //    request.ContentLength = byteArray.Length;
            //    request.ContentType = @"application/json";

            //    using (Stream dataStream = request.GetRequestStream())
            //    {
            //        dataStream.Write(byteArray, 0, byteArray.Length);
            //    }

            //    try
            //    {


            //        //byte[] credentialBuffer = new UTF8Encoding().GetBytes(loginView.UserEmail + ":" + loginView.UserPassword);
            //        //request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(credentialBuffer);
            //        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            //        {
            //            using (Stream webStream = response.GetResponseStream())
            //            {
            //                if (webStream != null)
            //                {
            //                    using (StreamReader responseReader = new StreamReader(webStream))
            //                    {
            //                        string responseST = responseReader.ReadToEnd();
            //                        // Console.Out.WriteLine(response);
            //                        userDetailsView = JsonConvert.DeserializeObject<UserDetailsView>(responseST);
                                
            //                    }
            //                }
            //            }
            //        }
            //        return userDetailsView;
            //    }

            //    catch (WebException e)
            //    {
            //        throw e;
            //    }
           

            }
        /// <summary>
        /// עדכון פרטי משתמש
        /// </summary>
        /// <param name="userDetailsView"></param>
        public void UpdateUser(UserDetailsView userDetailsView)
        {

            URI += "Users/UpdateUserDetails";
            string ans = "";

            try
            {


                string jsonContent = JsonConvert.SerializeObject(userDetailsView);
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                using (var client = new HttpClient())
                {
                    if (!string.IsNullOrWhiteSpace(LogIn.token))
                    {
                        var t = JsonConvert.DeserializeObject<Token>(LogIn.token);

                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + t.access_token);
                    }
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");


                    var response = client.PostAsync(URI, content).Result;
                    //var response = client.GetAsync(url).Result;
                    if (response.StatusCode != HttpStatusCode.Unauthorized)
                        ans = response.Content.ReadAsStringAsync().Result;
                    else
                        ans = response.ReasonPhrase;
                    //var response = await HttpClient.PostAsync(url, encodedContent).ConfigureAwait(false);


                    //ans = JsonConvert.DeserializeObject<DogsForManagerView>(response.Result.Content.);
                    //else
                    //    ans = response.ReasonPhrase;
                }
                if (ans == "Unauthorized")
                {

                    throw new WebException(ans);
                }
            }

            catch (WebException ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Add new user
        /// </summary>
        /// <param name="userDetailsView"></param>
        public void RegisterUser(UserDetailsView userDetailsView)
        {
            // POST a JSON string
            URI += "Users/InsertUserDetailsByManager";
            string ans = "";

            try
            {


                string jsonContent = JsonConvert.SerializeObject(userDetailsView);
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                using (var client = new HttpClient())
                {
                    if (!string.IsNullOrWhiteSpace(LogIn.token))
                    {
                        var t = JsonConvert.DeserializeObject<Token>(LogIn.token);

                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + t.access_token);
                    }
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");


                    var response = client.PostAsync(URI, content).Result;
                    //var response = client.GetAsync(url).Result;
                    if (response.StatusCode != HttpStatusCode.Unauthorized)
                        ans = response.Content.ReadAsStringAsync().Result;
                    else
                        ans = response.ReasonPhrase;
                    //var response = await HttpClient.PostAsync(url, encodedContent).ConfigureAwait(false);


                    //ans = JsonConvert.DeserializeObject<DogsForManagerView>(response.Result.Content.);
                    //else
                    //    ans = response.ReasonPhrase;
                }
                if (ans == "Unauthorized")
               
                    throw new WebException(ans);
            }

            catch (WebException ex)
            {

                throw ex;
            }
        }

        //  AddOneUserDog

        /// <summary>
        /// Add new dog user
        /// </summary>
        /// <param name="DogDetailsView"></param>
        public void AddOneUserDog(DogDetailsView dogDetailsView)
        {
            // POST a JSON string
            URI += "Users/AddOneUserDog";
            string ans = "";

            try
            {


                string jsonContent = JsonConvert.SerializeObject(dogDetailsView);
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                using (var client = new HttpClient())
                {
                    if (!string.IsNullOrWhiteSpace(LogIn.token))
                    {
                        var t = JsonConvert.DeserializeObject<Token>(LogIn.token);

                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + t.access_token);
                    }
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");


                    var response = client.PostAsync(URI, content).Result;
                    //var response = client.GetAsync(url).Result;
                    if (response.StatusCode != HttpStatusCode.Unauthorized)
                        ans = response.Content.ReadAsStringAsync().Result;
                    else
                        ans = response.ReasonPhrase;
                    //var response = await HttpClient.PostAsync(url, encodedContent).ConfigureAwait(false);


                    //ans = JsonConvert.DeserializeObject<DogsForManagerView>(response.Result.Content.);
                    //else
                    //    ans = response.ReasonPhrase;
                }
                if (ans == "Unauthorized")

                    throw new WebException(ans);
            }

            catch (WebException ex)
            {

                throw ex;
            }
        }
        //if (result.IsSuccessStatusCode)
        //{
        //    var fileJsonString = await result.Content.ReadAsStringAsync();

        //}
        //return result.IsSuccessStatusCode;
        //if(!result.IsSuccessStatusCode)
        //{
        //    var x = result.Content.ReadAsStringAsync().Result;

        //    var errors = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(x);

        //  //  var message = errors[HttpErrorKeys.MessageKey];
        //}
        // throw result.




        //catch 
        //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI);
        //request.Method = "POST";

        //UTF8Encoding encoding = new UTF8Encoding();
        //Byte[] byteArray = encoding.GetBytes(jsonContent);

        //request.ContentLength = byteArray.Length;
        //request.ContentType = @"application/json";

        //using (Stream dataStream = request.GetRequestStream())
        //{
        //    dataStream.Write(byteArray, 0, byteArray.Length);
        //}

        //try
        //{

        //    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        //    {
        //        using (Stream webStream = response.GetResponseStream())
        //        {
        //            if (webStream != null)
        //            {
        //                using (StreamReader responseReader = new StreamReader(webStream))
        //                {
        //                    string responseST = responseReader.ReadToEnd();
        //                    // Console.Out.WriteLine(response);
        //                    userDetailsView = JsonConvert.DeserializeObject<UserDetailsView>(responseST);

        //                }
        //            }
        //        }
        //    }
        //   // return userDetailsView;
        //}

        //catch (HttpRequestException e)
        //{
        //    throw e;
        //}


        //using (var client = new HttpClient())
        //{
        //    var uri = new Uri(URI + "Users/InsertUserDetails");
        //    client.BaseAddress = uri;
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //    HttpResponseMessage response = await client.PostAsJsonAsync(uri, userDetailsView);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        bool result = await response.Content.ReadAsAsync<bool>();
        //        //if (result)
        //        //    Console.WriteLine("Report Submitted");
        //        //else
        //        //    Console.WriteLine("An error has occurred");
        //    }
        //}
        //using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
        //{
        //    try
        //    {

        //       // URI += "Users/InsertUserDetails";
        //        string userst = JsonConvert.SerializeObject(userDetailsView);
        //        client.UseDefaultCredentials = true;
        //        client.Headers.Add("Content-Type:application / json; charset = utf - 8");
        //        client.Headers.Add("Accept:application/json");
        //        var uri = new Uri(URI + "Users/InsertUserDetails");
        //        var response = client.UploadString(uri, "POST", userst);
        //    }
        //    catch (WebException ex)
        //    {

        //        throw ex;
        //    }

        //using (var client = new HttpClient()) //{ Encoding = Encoding.UTF8 })
        //{
        //    try
        //    {
        //        URI += "Users/InsertUserDetails";
        //        //string userst = JsonConvert.SerializeObject(userDetailsView);
        //        //client.UseDefaultCredentials = true;
        //        //client.Headers.Add("Content-Type:application/json; charset = utf - 8");
        //        //var response = client.UploadString(URI, "POST", userst);


        //        var serializedProduct = JsonConvert.SerializeObject(userDetailsView);
        //        var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
        //        var result = await client.PostAsync(URI, content);


        //    }
        //    catch (WebException ex)
        //    {

        //        throw ex;

        //    }
        //}

        /// <summary>
        /// שליפת רשימת ערים
        /// </summary>
        /// <param name="url"></param>
        public DataTable GetFileCities()
        {

            URI += "XML/cities";
            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {

                var json = client.DownloadString(URI);
                //  CitiesTable = JsonConvert.DeserializeObject<DataTable>(json.ToString());
                //  CitiesTable = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

                DataTable CitiesTable = dataSet.Tables[0];

                return CitiesTable;


            }

        }

        public DataTable GetFileDogTypes()
        {

            URI += "Xml/DogsTypes";
            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {

                var json = client.DownloadString(URI);
                //  CitiesTable = JsonConvert.DeserializeObject<DataTable>(json.ToString());
                //  CitiesTable = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

                DataTable dogTypesTable = dataSet.Tables[0];

                return dogTypesTable;


            }

        }
    }
}

