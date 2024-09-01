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
    public partial class View00ErrorMessage : Form
    {
        public View00ErrorMessage(string title, string msn)
        {
            InitializeComponent();
            this.lblTitle.Text = title;
            this.lblMessage.Text = msn;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
