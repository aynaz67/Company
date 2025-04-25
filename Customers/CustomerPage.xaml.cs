using Customers.Models;
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
using System.Windows.Shapes;

namespace Customers
{
    public partial class CustomerPage : Window
    {
        public Customer _customer;

        public CustomerPage()
        {
            InitializeComponent();

        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtCustomerName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a customer name");
                txtCustomerName.Focus();
            }
            else
            {
                if (_customer != null && _customer.ID != 0)
                {
                    //customer = new Customer();
                    // customer.ID = customer.ID;


                    _customer.Name = txtCustomerName.Text.Trim();
                    _customer.Age = Convert.ToInt32(txtCustomerAge.Text.Trim());
                    _customer.PostCode = txtCustomerPostCode.Text.Trim();
                    _customer.Height = Convert.ToDouble(txtCustomerHeight.Text.Trim());

                    MessageBox.Show("Customer updated successfully");
                    this.DialogResult = true;
                    this.Close();
                }
                else
                {
                    _customer = new Customer();
                    _customer.ID = new Random().Next(1000, 9999);
                    _customer.Name = txtCustomerName.Text.Trim();
                    _customer.Age = Convert.ToInt32(txtCustomerAge.Text.Trim());
                    _customer.PostCode = txtCustomerPostCode.Text.Trim();
                    _customer.Height = Convert.ToDouble(txtCustomerHeight.Text.Trim());

                    txtCustomerName.Text = "";
                    txtCustomerAge.Text = "";
                    txtCustomerPostCode.Text = "";
                    txtCustomerHeight.Text = "";
                    txtCustomerName.Focus();

                    MessageBox.Show("Customer saved successfully");
                    this.DialogResult = true;
                    this.Close();
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (_customer != null && _customer.ID != 0)
            {
                txtCustomerName.Text = _customer.Name;
                txtCustomerAge.Text = _customer.Age.ToString();
                txtCustomerPostCode.Text = _customer.PostCode;
                txtCustomerHeight.Text = _customer.Height.ToString();
            }
            else
            {
                txtCustomerName.Text = "";
                txtCustomerAge.Text = "";
                txtCustomerPostCode.Text = "";
                txtCustomerHeight.Text = "";
            }
        }
    }
}
