using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrutBeam.MVVM.Views
{
    public partial class View10ClienteId : Form
    {
        public View10ClienteId()
        {
            InitializeComponent();
        }

        private async void View10ClienteId_Load(object sender, EventArgs e)
        {
            using (var dbContext = new DataContext())
            {
                var id = await dbContext.TabelaClienteId.FirstOrDefaultAsync();
                if(id is not null)
                    txtId.Text = id.CustomerId;
            }
        }
    }
}
