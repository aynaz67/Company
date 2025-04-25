using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Customer.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        public CustomerListingViewModel CustomerListingViewModel { get; }
        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }

        public CustomerViewModel()
        {
            CustomerListingViewModel = new CustomerListingViewModel();

        }
    }
}
