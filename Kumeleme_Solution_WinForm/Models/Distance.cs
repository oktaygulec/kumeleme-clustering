using Kumeleme_Solution_WinForm.Utils;
using System.ComponentModel;

namespace Kumeleme_Solution_WinForm.Models
{
    public class Distance
    {
        [Browsable(false)]
        public Center Center { get; private set; }
        [Browsable(false)]
        public Data Data { get; private set; }
        public string DisplayName { get; private set; }
        public double Value { get; private set; }

        public Distance(Center center, Data data)
        {
            Center = center;
            Data = data;
            DisplayName = Center.Name + ", " + Data.Name;
            SetNewValue(center, data);
        }

        public void SetNewValue(Center center, Data data)
        {
            Value = Calculate.Distance(center, data);
        }
    }
}
