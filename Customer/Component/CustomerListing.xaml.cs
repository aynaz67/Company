using Customer.Models;
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

namespace Customer.Component
{
    /// <summary>
    /// Interaction logic for CustomerListing.xaml
    /// </summary>
    public partial class CustomerListing : UserControl
    {
        public CustomerListing()
        {
            InitializeComponent();
            List<Customers> customerList = new List<Customers>();
            customerList.Add(new Customers { ID = 2, Name = "Ali", Age = 30, Height = 175, PostCode = "TW2 2AB" });
            customerList.Add(new Customers { ID = 3, Name = "Sara", Age = 28, Height = 160, PostCode = "TW2 2AC" });
            customerList.Add(new Customers { ID = 4, Name = "John", Age = 35, Height = 180, PostCode = "TW2 2AD" });
            customerList.Add(new Customers { ID = 5, Name = "Emma", Age = 22, Height = 165, PostCode = "TW2 2AE" });
            customerList.Add(new Customers { ID = 6, Name = "Michael", Age = 40, Height = 185, PostCode = "TW2 2AF" });
            customerList.Add(new Customers { ID = 7, Name = "Sophia", Age = 27, Height = 170, PostCode = "TW2 2AG" });
            customerList.Add(new Customers { ID = 8, Name = "David", Age = 32, Height = 178, PostCode = "TW2 2AH" });
            customerList.Add(new Customers { ID = 9, Name = "Olivia", Age = 24, Height = 162, PostCode = "TW2 2AI" });
            customerList.Add(new Customers { ID = 10, Name = "James", Age = 29, Height = 177, PostCode = "TW2 2AJ" });

            gridCustomer.ItemsSource = customerList;
        }
    }
}
