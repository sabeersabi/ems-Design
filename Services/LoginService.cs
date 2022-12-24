using ems.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems.Services
{
    internal class LoginService : Interfaceservice
    {
        private string _baseUrl = "http://172.16.1.114:7037";
        public async Task<List<GetLoginModel>> GetAllLoginList()
        {
            var text = "Please wait";
            var returnRespone = new List<GetLoginModel>();
            try
            {
                using (var httpClient = new HttpClient())
                {
                    string url = $"{_baseUrl}/local/logindetails";
                    var apiResponse = await httpClient.GetAsync(url);
                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        returnRespone =
                            JsonConvert.DeserializeObject<List<GetLoginModel>>(response.ToString());
                    }
                    else
                    {
                        text = "Network Error!";
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnRespone;
        }

       
    }
}
