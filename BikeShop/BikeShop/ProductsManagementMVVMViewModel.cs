using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop
{
    class ProductsManagementMVVMViewModel : Notifier
    {
        ProductsFactory factory = new ProductsFactory();
        public ProductsManagementMVVMViewModel()
        {
            FoundProducts = Enumerable.Empty<Product>();
        }
        private void OnSearchInputChanged()
        {
            SelectedProduct = null;
            FoundProducts = factory.FindProducts(SearchInput);
        }

        #region 입력과 출력 속성
        private string searchInput;
        public string SearchInput
        {
            get { return searchInput; }
            set
            {
                searchInput = value;
                OnPropertyChanged(nameof(SearchInput));
                OnSearchInputChanged();
            }
        }

        private IEnumerable<Product> foundProducts;
        public IEnumerable<Product> FoundProducts
        {
            get { return foundProducts; }
            set
            {
                foundProducts = value;
                OnPropertyChanged(nameof(FoundProducts));
            }
        }

        private Product selectedProduct;
        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set
            {
                selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
            }
        }
        #endregion
    }
}
