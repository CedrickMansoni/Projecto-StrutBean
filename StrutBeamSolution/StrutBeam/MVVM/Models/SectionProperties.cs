using Newtonsoft.Json;

namespace StrutBeam.MVVM.Models
{
    public class SectionProperties
    {
        private readonly string _beam;
        public SectionProperties(string beam)
        {
            _beam = beam;
        }
        public bool StandarizedBeam()
        {
            bool find = false;
            string beam_ = string.Empty;
            if (_beam != string.Empty)
            {
                var stream = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\ascsec.json");

                var ascsecList = JsonConvert.DeserializeObject<List<Ascsec>>(stream);

                if (ascsecList != null && ascsecList.Count > 0)
                    foreach (var item in ascsecList)
                    {
                        if (item.AISC_MANUAL_LABEL == _beam)
                        {
                            find =
                                Convert.ToDecimal(item.TW.Replace(".", ",")) == 0 ||
                                Convert.ToDecimal(item.BF.Replace(".", ",")) == 0 ||
                                Convert.ToDecimal(item.TF.Replace(".", ",")) == 0 ||
                                Convert.ToDecimal(item.KDES.Replace(".", ",")) == 0 ||
                                Convert.ToDecimal(item.IY.Replace(".", ",")) == 0 ||
                                Convert.ToDecimal(item.SY.Replace(".", ",")) == 0 ||
                                Convert.ToDecimal(item.ZY.Replace(".", ",")) == 0 ||
                                Convert.ToDecimal(item.J.Replace(".", ",")) == 0 ||
                                Convert.ToDecimal(item.CW.Replace(".", ",")) == 0
                                ? true : false;
                            break;
                            /*
                                item.A == 0.ToString() || item.TW == 0.ToString() ||
                                item.BF == 0.ToString() || item.TF == 0.ToString() ||
                                item.K1 == 0.ToString() || item.IX == 0.ToString() ||
                                item.SX == 0.ToString() || item.RX == 0.ToString() ||
                                item.ZX == 0.ToString() || item.IY == 0.ToString() ||
                                item.SY == 0.ToString() || item.RY == 0.ToString() ||
                                item.ZY == 0.ToString() || item.J == 0.ToString() ||
                                item.CW == 0.ToString() || item.BWT == 0.ToString() */
                        }
                    }
            }
            return find;
        }       
    }
}
