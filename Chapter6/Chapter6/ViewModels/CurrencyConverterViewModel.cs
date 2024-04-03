using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6.ViewModels
{
    public class CurrencyConverterViewModel : Notifier
    {
        #region 유로값
        private decimal euros;
        public decimal Euros
        {
            get { return euros; }
            set
            {
                euros = value;
                OnPropertyChanged(nameof(Euros));
                string tmp = nameof(Euros);
                OnEurosChanged();
            }
        }
        #endregion

        #region 달러값
        private decimal dollars;
        public decimal Dollars
        {
            get { return dollars; }
            set
            {
                dollars = value;
                OnPropertyChanged(nameof(Dollars));
            }
        }
        #endregion

        private void OnEurosChanged()
        {
            Dollars = Euros * 1.1M;
        }
    }
}
