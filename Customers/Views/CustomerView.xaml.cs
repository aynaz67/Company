using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Customers.Models;

namespace Customers.Views
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : UserControl
    {
        public ObservableCollection<Customer> Customers { get; set; } = new ObservableCollection<Customer>();

        public CustomerView()
        {
            InitializeComponent();
            //List<Customer> customerList = new List<Customer>();
            Customers.Add(new Customer { ID = 2, Name = "Ali", Age = 30, Height = 175, PostCode = "TW2 2AB" });
            Customers.Add(new Customer { ID = 3, Name = "Sara", Age = 28, Height = 160, PostCode = "TW2 2AC" });
            Customers.Add(new Customer { ID = 4, Name = "John", Age = 35, Height = 180, PostCode = "TW2 2AD" });
            Customers.Add(new Customer { ID = 5, Name = "Emma", Age = 22, Height = 165, PostCode = "TW2 2AE" });
            Customers.Add(new Customer { ID = 6, Name = "Michael", Age = 40, Height = 185, PostCode = "TW2 2AF" });
            Customers.Add(new Customer { ID = 7, Name = "Sophia", Age = 27, Height = 170, PostCode = "TW2 2AG" });
            Customers.Add(new Customer { ID = 8, Name = "David", Age = 32, Height = 178, PostCode = "TW2 2AH" });
            Customers.Add(new Customer { ID = 9, Name = "Olivia", Age = 24, Height = 162, PostCode = "TW2 2AI" });
            Customers.Add(new Customer { ID = 10, Name = "James", Age = 29, Height = 177, PostCode = "TW2 2AJ" });

            gridCustomer.ItemsSource = Customers;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CustomerPage customerPage = new CustomerPage();
            bool? result = customerPage.ShowDialog();

            if (result == true && customerPage._customer != null)
            {
                Customers.Add(customerPage._customer);
                //     gridCustomer.ItemsSource = Customers;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Customer selectedCustomer = (Customer)gridCustomer.SelectedItem;

            if (selectedCustomer != null)
            {
                CustomerPage customerPage = new CustomerPage();
                customerPage._customer = selectedCustomer;
                bool? result = customerPage.ShowDialog();

                if (result == true && customerPage._customer != null)
                {
                    var original = Customers.FirstOrDefault(c => c.ID == selectedCustomer.ID);
                    if (original != null)
                    {
                        original.Name = customerPage._customer.Name;
                        original.Age = customerPage._customer.Age;
                        original.Height = customerPage._customer.Height;
                        original.PostCode = customerPage._customer.PostCode;

                        //           gridCustomer.ItemsSource = Customers;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to update");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
