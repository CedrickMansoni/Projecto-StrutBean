using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrutBeam.MVVM.Models
{
    public class SafeLoadAssessment
    {
        #region Monorail Basic Input
        public string Lift_Plan { get; set; } = string.Empty;
        public int Lift_PlanNumber { get; set; } = 0;
        public string Lift_PlanAsset { get; set; } = string.Empty;
        #endregion

        #region Underrun Monorail Beam Calculator
        public string BeamSectioSize { get; set; } = string.Empty;
        public string BeamSectioType { get; set; } = string.Empty;
        public decimal Lift_Plan_Fy { get; set; } = 0;
        public decimal Lift_Plan_E { get; set; } = 0;
        public decimal Lift_Plan_V { get; set; } = 0;
        public decimal Lift_Plan_L { get; set; } = 0;
        public decimal Lift_Plan_Lb { get; set; } = 0;
        public decimal Lift_Plan_Cb { get; set; } = 0;
        public decimal Lift_Plan_Lo { get; set; } = 0;
        public decimal Lift_Plan_Lbo { get; set; } = 0;
        public decimal Lift_Plan_Cbo { get; set; } = 0;
        #endregion

        #region Weights And Loads
        public decimal Lift_Plan_Tl { get; set; } = 0;
        public decimal Lift_Plan_Hw { get; set; } = 0;
        public decimal Lift_Plan_Ll { get; set; } = 0;
        public decimal Lift_Plan_Df { get; set; } = 0;
        public decimal Lift_Plan_Hf { get; set; } = 0;
        public decimal Lift_Plan_Ang1 { get; set; } = 0;
        public decimal Lift_Plan_Ang2 { get; set; } = 0;
        public decimal Lift_Plan_HLF { get; set; } = 0;
        public decimal Lift_Plan_LLF { get; set; } = 0;
        public decimal Lift_Plan_S1 { get; set; } = 0;
        public decimal Lift_Plan_Wsps { get; set; } = 0;
        public decimal Lift_Plan_Cs { get; set; } = 0;
        public decimal Lift_Plan_Wps0 { get; set; } = 0;
        public decimal Lift_Plan_Wps2 { get; set; } = 0;
        public decimal Lift_Plan_Alift { get; set; } = 0;
        public decimal Lift_Plan_Calift { get; set; } = 0;
        public decimal Lift_Plan_Wps { get; set; } = 0;
        public decimal Lift_Plan_ah { get; set; } = 0;
        public decimal Lift_Plan_Wel1 { get; set; } = 0;
        public decimal Lift_Plan_Wel { get; set; } = 0;
        public decimal Lift_Plan_Pblk { get; set; } = 0;
        public decimal Lift_Plan_Bspac { get; set; } = 0;
        public decimal Lift_Plan_Pld { get; set; } = 0;


        #endregion
    }
}
