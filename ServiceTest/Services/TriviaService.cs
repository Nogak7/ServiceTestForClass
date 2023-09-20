using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ServiceTest.Services
{
    public class TriviaService
    { 
        private HttpClient Client { get; set; }
        private JsonSerializerOptions JSO { get; set; }
        const string URL = @" https://zr8z94hw-44376.euw.devtunnels.ms/AmericanQuestions/";
        public TriviaService() 
        {
            Client = new HttpClient();
           JSO = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true , WriteIndented = true};
        }
        public async Task<string> CheackConectionStatus()
        {
            try
            {
                var response = await Client.GetAsync($"{URL}0GetQuestions");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return content;
                }
                else
                    return "Error";
            }
            catch { }
            return null;
        }
    }
}
