using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApiMTModel.Models.Models.View;

namespace WindowsFormsAppMT
{
    class PriceService
    {
        const string URI = "http://localhost:53697/api/Prices/";
        /// <summary>
        /// עדכון הזמנות 
        /// </summary>
        /// <param name="listOrder"></param>
        public void UpdatePricesByManager(List<PricesView> listPrices)

        {

            string uri = URI + "UpdatePricesByManager";
            string ans = "";
            try
            {


                string jsonContent = JsonConvert.SerializeObject(listPrices);
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


                    var response = client.PutAsync(uri, content).Result;
                    //var response = client.GetAsync(url).Result;
                    if (response.StatusCode == HttpStatusCode.OK)
                        ans = response.Content.ReadAsStringAsync().Result;
                    else
                    {
                        ans = response.ReasonPhrase;
                        throw new WebException(ans);
                    }
                    //var response = await HttpClient.PostAsync(url, encodedContent).ConfigureAwait(false);


                    //ans = JsonConvert.DeserializeObject<DogsForManagerView>(response.Result.Content.);
                    //else
                    //    ans = response.ReasonPhrase;
                }
                
                    
            }



            catch (WebException ex)
            {

                throw ex;
            }
        }

    }
}
