using Newtonsoft.Json;
using StrutBeamEmployee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace StrutBeamEmployee.MVVM
{
    public class ViewModelCliente
    {
        private string uri;
        public ViewModelCliente(string uri)
        {
            this.uri = uri;
        }
        public async Task<List<Clients>> GetAllCostumers() 
        {
            var ListCustomers = new List<Clients>();    
            using (var cliente = new HttpClient())
            {
                using (var response = await cliente.GetAsync($"https://{uri}.ngrok-free.app/select/clients"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var CustomersJsonString = await response.Content.ReadAsStringAsync();
                        ListCustomers = JsonConvert.DeserializeObject<List<Clients>>(CustomersJsonString).ToList();
                        
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter os dados: " + response.StatusCode);
                    }
                }
            }
            return ListCustomers;
        }
    }
}
