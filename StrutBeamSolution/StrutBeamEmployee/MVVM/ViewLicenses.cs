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
    public partial class ViewLicenses : Form
    {
        string uri = string.Empty;
        public ViewLicenses(string uri)
        {
            InitializeComponent();
            this.uri = uri;
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewLicenses_Load(object sender, EventArgs e)
        {
            GetAllCustomersLicenses();
        }

        private async void GetAllCustomersLicenses()
        {
            using (var cliente = new HttpClient())
            {
                using (var response = await cliente.GetAsync($"https://{uri}.ngrok-free.app/select/licenses"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var CustomersJsonString = await response.Content.ReadAsStringAsync();
                        dataGrid.DataSource = JsonConvert.DeserializeObject<List<Licenses>>(CustomersJsonString).ToList();
                        try
                        {
                            dataGrid.Sort(this.dataGrid.Columns["License"], ListSortDirection.Ascending);
                        }
                        catch
                        {

                        }                        
                        dataGrid.Columns["Id"].Visible = false;
                        dataGrid.Columns["StateLicense"].Visible = false;
                        dataGrid.Columns["IdClient"].Visible = false;
                        dataGrid.Columns["MSN"].Visible = false;

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
        }

        private async void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {                
                //var employee = new LicenseClientDTO();
                //using (HttpClient clientHttp = new HttpClient())
                //{
                //    string key = dataGrid.SelectedRows[0].Cells[1].Value.ToString();
                //    using (var response = await clientHttp.GetAsync($"https://{uri}.ngrok-free.app/get/license-client?license={key}"))
                //    {
                //        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                //        {
                //            var clientJsonString = await response.Content.ReadAsStringAsync();
                //            employee = JsonConvert.DeserializeObject<LicenseClientDTO>(clientJsonString);
                //            if (employee != null)
                //            {
                //                textBox1.Text = employee.NameCliente;
                //            }
                //        }
                //    }
                //}                
            }
            catch
            {

            }
        }
    }
}
//412e-105-168-251-41