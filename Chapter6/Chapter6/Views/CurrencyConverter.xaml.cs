using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Chapter6.ViewModels;

namespace Chapter6.Views
{
    /// <summary>
    /// CurrencyConverter.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CurrencyConverter : Page
    {
        public CurrencyConverter()
        {
            InitializeComponent();
            this.DataContext = new CurrencyConverterViewModel();
        }
    }
}
