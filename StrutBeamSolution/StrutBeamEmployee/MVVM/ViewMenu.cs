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
    public partial class ViewMenu : Form
    {
        private string uri = string.Empty;
        public ViewMenu(string txtHOST)
        {
            InitializeComponent();
            uri = txtHOST;

            GetAllCustomers();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            new CustomersList(uri).ShowDialog();
        }

        private async void GetAllCustomers()
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
        }

        private void btnGenerateLicense_Click(object sender, EventArgs e)
        {
            try
            {
                int idCustomer = Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value);
                string? Customer = dataGrid.SelectedRows[0].Cells[1].Value.ToString();
                new License(idCustomer, Customer, uri).ShowDialog();
            }
            catch 
            {
                new View00ErrorMessage("Error", "There is no user registered in the system").ShowDialog();
            }
        }

        private void btnViewLicenses_Click(object sender, EventArgs e)
        {
            new ViewLicenses(uri).ShowDialog();
        }

        private void ViewMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
