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
    public partial class View06SlingLoadAssessment : Form
    {
        public View06SlingLoadAssessment()
        {
            InitializeComponent();
        }

        private void View06SlingLoad_Load(object sender, EventArgs e)
        {
            PainelCentral.Location = new Point((this.Width / 2) - PainelCentral.Width / 2, (this.Height / 2) - PainelCentral.Height / 2);
            lblPEW.Text = ((9 * 4 * 1 * 490 / Math.Pow(12, 3)) * 3).ToString();
        }

        #region SEGUNDA LINHA DA TABELA
        private double lo_weight;
        public double LO_Weight
        {
            get => lo_weight;
            set
            {
                lo_weight = value;

            }
        }

        private double lo_factor;
        public double LO_Factor
        {
            get => lo_factor;
            set
            {
                lo_factor = value;
            }
        }

        private double lo_factoredweight;
        public double LO_FactoredWeight
        {
            get => lo_factoredweight;
            set
            {
                lo_factoredweight = value;
            }
        }
        #endregion

        #region TERCEIRA LINHA DA TABELA
        private double bc_weight;
        public double BC_Weight
        {
            get => bc_weight;
            set
            {
                bc_weight = value;
            }
        }
        private double bc_factor;
        public double BC_Factor
        {
            get => bc_factor;
            set
            {
                bc_factor = value;
            }
        }
        private double bc_factoredweight;
        public double BC_Factoredweight
        {
            get => bc_factoredweight;
            set
            {
                bc_factoredweight = value;
            }
        }
        #endregion

        #region QUARTA LINHA DA TABELA
        private double sw_weight;
        public double SW_Weight
        {
            get => sw_weight;
            set
            {
                sw_weight = value;
            }
        }
        private double sw_factor;
        public double SW_Factor
        {
            get => sw_factor;
            set
            {
                sw_factor = value;
            }
        }
        private double sw_factoredweight;
        public double SW_Factoredweight
        {
            get => sw_factoredweight;
            set
            {
                sw_factoredweight = value;
            }
        }
        #endregion

        #region QUINTA LINHA DA TABELA
        private double pe_weight;
        public double PE_Weight
        {
            get => pe_weight;
            set
            {
                pe_weight = ((9 * 4 * 1 * 490) / Math.Pow(12, 3)) * 3;
            }
        }
        private double pe_factor;
        public double PE_Factor
        {
            get => pe_factor;
            set
            {
                pe_factor = value;
            }
        }
        private double pe_factoredweight;
        public double PE_Factoredweight
        {
            get => pe_factoredweight;
            set
            {
                pe_factoredweight = value;
            }
        }
        #endregion

        #region SEXTA LINHA DA TABELA
        private double tw_weight;
        public double TW_Weight
        {
            get => tw_weight;
            set
            {
                tw_weight = value;
            }
        }
        private double tw_factor;
        public double TW_Factor
        {
            get => tw_factor;
            set
            {
                tw_factor = value;
            }
        }
        private double tw_factoredweight;
        public double TW_Factoredweight
        {
            get => tw_factoredweight;
            set
            {
                tw_factoredweight = value;
            }
        }
        #endregion
        #region SÉTIMA LINHA DA TABELA
        private double esl_factoredweight;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            LO_Weight = double.Parse(txtLOW.Text, System.Globalization.CultureInfo.InvariantCulture);
            LO_Factor = double.Parse(txtLOF.Text, System.Globalization.CultureInfo.InvariantCulture);
            LO_FactoredWeight = LO_Weight * LO_Factor;
            lblLOFW.Text = LO_FactoredWeight.ToString("N");

            BC_Weight = double.Parse(txtBCW.Text, System.Globalization.CultureInfo.InvariantCulture);
            BC_Factor = double.Parse(txtBCF.Text, System.Globalization.CultureInfo.InvariantCulture);
            BC_Factoredweight = BC_Weight * BC_Factor;
            lblBCFW.Text = BC_Factoredweight.ToString("N");

            SW_Weight = double.Parse(txtSWW.Text, System.Globalization.CultureInfo.InvariantCulture);
            SW_Factor = double.Parse(txtSWF.Text, System.Globalization.CultureInfo.InvariantCulture);
            SW_Factoredweight = SW_Weight * SW_Factor;
            lblSWFW.Text = SW_Factoredweight.ToString("N");

            PE_Weight = double.Parse(lblPEW.Text, System.Globalization.CultureInfo.InvariantCulture);
            PE_Factor = double.Parse(txtPEF.Text, System.Globalization.CultureInfo.InvariantCulture);
            PE_Factoredweight = PE_Weight * PE_Factor;
            lblPEFW.Text = PE_Factoredweight.ToString("N");

            TW_Weight = LO_Weight + BC_Weight + SW_Weight + PE_Weight;
            lblTWW.Text = TW_Weight.ToString("N");

            TW_Factor = LO_Factor + BC_Factor + SW_Factor + PE_Factor;
            lblTWF.Text = TW_Factor.ToString("N");

            TW_Factoredweight = LO_FactoredWeight + BC_Factoredweight + SW_Factoredweight + PE_Factoredweight;
            lblTWFW.Text = TW_Factoredweight.ToString("N");

            ESL_Factoredweight = TW_Factoredweight / 3;
            lblESLFW.Text = ESL_Factoredweight.ToString("N");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLOW.Text = "0.00";
            LO_Weight = double.Parse(txtLOW.Text, System.Globalization.CultureInfo.InvariantCulture);
            txtLOF.Text = "0.00";
            LO_Factor = double.Parse(txtLOF.Text, System.Globalization.CultureInfo.InvariantCulture);
            LO_FactoredWeight = LO_Weight * LO_Factor;
            lblLOFW.Text = LO_FactoredWeight.ToString("N2");

            txtBCW.Text = "0.00";
            BC_Weight = double.Parse(txtBCW.Text, System.Globalization.CultureInfo.InvariantCulture);
            txtBCF.Text = "0.00";
            BC_Factor = double.Parse(txtBCF.Text, System.Globalization.CultureInfo.InvariantCulture);
            BC_Factoredweight = BC_Weight * BC_Factor;
            lblBCFW.Text = BC_Factoredweight.ToString("N2");

            txtSWW.Text = "0.00";
            SW_Weight = double.Parse(txtSWW.Text, System.Globalization.CultureInfo.InvariantCulture);
            txtSWF.Text = "0.00";
            SW_Factor = double.Parse(txtSWF.Text, System.Globalization.CultureInfo.InvariantCulture);
            SW_Factoredweight = SW_Weight * SW_Factor;
            lblSWFW.Text = SW_Factoredweight.ToString("N2");

            txtPEF.Text = "0.00";
            PE_Factor = double.Parse(txtPEF.Text, System.Globalization.CultureInfo.InvariantCulture);
            PE_Factoredweight = PE_Weight * PE_Factor;
            lblPEFW.Text = PE_Factoredweight.ToString("N2");

            TW_Weight = LO_Weight + BC_Weight + SW_Weight;
            lblTWW.Text = TW_Weight.ToString("N2");

            TW_Factor = LO_Factor + BC_Factor + SW_Factor + PE_Factor;
            lblTWF.Text = TW_Factor.ToString("N2");

            TW_Factoredweight = LO_FactoredWeight + BC_Factoredweight + SW_Factoredweight + PE_Factoredweight;
            lblTWFW.Text = TW_Factoredweight.ToString("N2");

            ESL_Factoredweight = TW_Factoredweight / 3;
            lblESLFW.Text = ESL_Factoredweight.ToString("N2");
        }

        private void txtLOW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44) { e.Handled = true; }
            if (e.KeyChar == '.') { e.Handled = false; }
            if (e.KeyChar == ',') { e.Handled = true; }
        }

        public double ESL_Factoredweight
        {
            get => esl_factoredweight;
            set
            {
                esl_factoredweight = value;
            }
        }
        #endregion

    }
}
