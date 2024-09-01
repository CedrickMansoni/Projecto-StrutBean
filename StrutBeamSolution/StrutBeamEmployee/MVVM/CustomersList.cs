using Newtonsoft.Json;
using StrutBeamEmployee.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrutBeamEmployee.MVVM
{
    public partial class CustomersList : Form
    {
        private string uri = string.Empty;
        public CustomersList(string uri)
        {
            InitializeComponent();
            this.uri = uri;
        }

        private async void CustomersList_Load(object sender, EventArgs e)
        {
            using (var cliente = new HttpClient())
            {
                using (var response = await cliente.GetAsync($"https://{uri}.ngrok-free.app/select/clients"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var CustomersJsonString = await response.Content.ReadAsStringAsync();
                        dataGrid.DataSource = JsonConvert.DeserializeObject<List<Clients>>(CustomersJsonString).ToList();
                        dataGrid.Columns["Id"].Visible = false;
                        dataGrid.Columns["Password"].Visible = false;
                        dataGrid.Columns["Enable"].Visible = false;
                        dataGrid.RowsDefaultCellStyle.BackColor = Color.LightCyan;
                        dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                        dataGrid.AutoResizeColumns();
                        dataGrid.AutoResizeRows();

                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter os dados: " + response.StatusCode);
                    }
                }
            }
            //dataGrid.DataSource = new ViewModelCliente(uri).GetAllCostumers();
        }
    }
}
