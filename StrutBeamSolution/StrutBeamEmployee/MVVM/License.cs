using Newtonsoft.Json;
using StrutBeamEmployee.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrutBeamEmployee.MVVM
{
    public partial class License : Form
    {
        int Id = 0;
        string? name = string.Empty;
        private string uri = string.Empty;
        public License(int idCustomer, string? customer, string uri)
        {
            InitializeComponent();
            Id = idCustomer;
            name = customer;
            this.uri = uri;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox2.Text)) 
            {
                new View00ErrorMessage("Error", "Enter the license duration").ShowDialog();
                textBox2.Focus();
            }
            else if (string.IsNullOrEmpty(textBox3.Text)) 
            {
                new View00ErrorMessage("Error", "Enter the total users").ShowDialog();
                textBox3.Focus();
            }
            else
            {
                var license = new Licenses()
                {
                    License = key,
                    Month = Convert.ToInt32(textBox2.Text),
                    ActivationDate = "No data",
                    ExpiractionDate = "No data",
                    TotalUsers = Convert.ToInt32(textBox3.Text),
                    IdClient = Id,
                    StateLicense = 1
                };
                try
                {
                    _ = CreateEmployee(license);
                    this.Close();
                }
                catch
                {

                }
            }
        }

        public async Task<string> CreateEmployee(Licenses license)
        {
            string response = string.Empty;
            try
            {
                using (var clientHttp = new HttpClient())
                {
                    var clientSerialized = JsonConvert.SerializeObject(license);
                    var content = new StringContent(clientSerialized, Encoding.UTF8, "application/json");
                    var result = await clientHttp.PostAsync($"https://{uri}.ngrok-free.app/create/license", content);
                    response = await result.Content.ReadAsStringAsync();
                }
                using (var cliente = new HttpClient())
                {
                    using (var response2 = await cliente.GetAsync($"https://{uri}.ngrok-free.app/select/licenses"))
                    {
                        if (response2.IsSuccessStatusCode)
                        {
                            var CustomersJsonString = await response2.Content.ReadAsStringAsync();
                            var lista = JsonConvert.DeserializeObject<List<Licenses>>(CustomersJsonString).ToList();

                            foreach (var item in lista)
                            {
                                if (item.License == license.License)
                                {
                                    license.Id = item.Id;
                                    break;
                                }
                            }
                        }
                    }
                }
                var Lc = new LicenseClients() 
                {
                    IdLicense = license.Id,
                    IdClient = Id,
                };
                using (var clientHttp = new HttpClient())
                {
                    var clientSerialized = JsonConvert.SerializeObject(Lc);
                    var content = new StringContent(clientSerialized, Encoding.UTF8, "application/json");
                    var result = await clientHttp.PostAsync($"https://{uri}.ngrok-free.app/create/license-client", content);
                    response = await result.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                response = ex + "\nUnavailable server. Try again or later";
            }
            return response;
        }

        private string key = string.Empty;
        private void License_Load(object sender, EventArgs e)
        {            
            key = Guid.NewGuid().ToString("D");
            textBox1.Text = key;    
            textBox4.Text = name;            
        }
    }
}
