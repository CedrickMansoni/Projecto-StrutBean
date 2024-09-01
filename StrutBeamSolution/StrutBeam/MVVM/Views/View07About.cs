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
    public partial class View07About : Form
    {
        public View07About()
        {
            InitializeComponent();
        }

        private void View07About_Load(object sender, EventArgs e)
        {
            lblText.Text = "\n\nThe Strut hoist, is a  beam lifting load calculation software developed by oil and gas Engineers with a vast experience in lifting operations and lifting equipment management based on the acceptance criteria outlined by AISC-American Institute for steel Construction  WSD 9th edition and CMAA specification  74 - 2000 and 2014.\r\n\nWith the total lifted load and weight, the  Software evaluates the following:\r\n\n1) Bottom flange bending, local capacity check, fatigue check and deflection check.\r\n2) Beam stress due to strong axis bending moment.\r\n3) Beam stress due to weak axis bending moment and shear force.\r\n4)  Beam Stresses due to torsion.\r\n5)  Bottom flange local stress due to Trolley wheeler.\r\n6) Bi- axial stress by combination  of global and local stresses.\r\n7) Crane utilization\r\n8) Wind loads\r\n\n" +
                "The information presented in this software is based on academic principles  and working knowledge of strength of material and fracture mechanics about steel beams sections by Additech Engineers and partners  supported by the guidelines from AISC- American Institute of steel construction manuals  WSD 9th and 14th editions, CMAA-74-2000 and 2014";
        }
    }
}
