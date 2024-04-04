using Chapter6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6.ViewModels
{
    public class CurrencyConverterViewModel : Notifier
    {
        public CurrencyConverterViewModel()
        {
            Currencies = new List<Currency>()
            {
                new Currency("US Dollar", 1.1M),
                new Currency("British Pound", 0.9M)
            };
        }

        private void OnEurosChanged()
        {
            ComputeConverted();
        }
        private void OnSelectedCurrencyChanged()
        {
            ComputeConverted();
        }
        private void ComputeConverted()
        {
            if (SelectedCurrency == null) return;

            Converted = Euros * SelectedCurrency.Rate;
            ResultText = $"Amount in {SelectedCurrency.Title}";
        }

        #region 유로값
        private decimal euros;
        public decimal Euros
        {
            get { return euros; }
            set
            {
                euros = value;
                OnPropertyChanged(nameof(Euros));
                OnEurosChanged();
            }
        }
        #endregion

        #region 변환값
        private decimal converted;
        public decimal Converted
        {
            get { return converted; }
            set
            {
                converted = value;
                OnPropertyChanged(nameof(Converted));
            }
        }
        #endregion

        #region 선택된값
        private Currency selectedCurrency;
        public Currency SelectedCurrency
        {
            get { return selectedCurrency; }
            set
            {
                selectedCurrency = value;
                OnPropertyChanged(nameof(SelectedCurrency));
                OnSelectedCurrencyChanged();
            }
        }
        #endregion

        #region 리스트
        private IEnumerable<Currency> currencies;
        public IEnumerable<Currency> Currencies
        { 
            get { return  currencies; }
            set
            {
                currencies = value;
                OnPropertyChanged(nameof(Currencies));
            }
        }
        #endregion

        #region 보여줄 값
        private string resultText;
        public string ResultText
        {
            get { return resultText; }
            set
            {
                resultText = value;
                OnPropertyChanged(nameof(ResultText));
            }
        }
        #endregion


    }
}
