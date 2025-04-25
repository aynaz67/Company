using Customers.Command;
using Customers.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace Customers.ViewModels
{
    public class CustomerViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Customer> Customers { get; set; } = new ObservableCollection<Customer>();

        private Customer _selectedCustomer;
        public Customer SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                _selectedCustomer = value;
                OnPropertyChanged(nameof(SelectedCustomer));
            }
        }

        public ICommand AddCommand { get; }
        public ICommand UpdateCommand { get; }

        public CustomerViewModel()
        {
            LoadSampleData();

            AddCommand = new RelayCommand(AddCustomer);
            UpdateCommand = new RelayCommand(UpdateCustomer);
        }

        private void LoadSampleData()
        {
            Customers.Add(new Customer { ID = 2, Name = "Ali", Age = 30, Height = 175, PostCode = "TW2 2AB" });
            Customers.Add(new Customer { ID = 3, Name = "Sara", Age = 28, Height = 160, PostCode = "TW2 2AC" });
            Customers.Add(new Customer { ID = 4, Name = "John", Age = 35, Height = 180, PostCode = "TW2 2AD" });
            Customers.Add(new Customer { ID = 5, Name = "Emma", Age = 22, Height = 165, PostCode = "TW2 2AE" });
            Customers.Add(new Customer { ID = 6, Name = "Michael", Age = 40, Height = 185, PostCode = "TW2 2AF" });
            Customers.Add(new Customer { ID = 7, Name = "Sophia", Age = 27, Height = 170, PostCode = "TW2 2AG" });
            Customers.Add(new Customer { ID = 8, Name = "David", Age = 32, Height = 178, PostCode = "TW2 2AH" });
            Customers.Add(new Customer { ID = 9, Name = "Olivia", Age = 24, Height = 162, PostCode = "TW2 2AI" });
            Customers.Add(new Customer { ID = 10, Name = "James", Age = 29, Height = 177, PostCode = "TW2 2AJ" });

        }

        private void AddCustomer()
        {
            var dialog = new CustomersPage();
            if (dialog.ShowDialog() == true && dialog._customer != null)
            {
                Customers.Add(dialog._customer);
            }
        }

        private void UpdateCustomer()
        {
            var dialog = new CustomersPage { _customer = SelectedCustomer };
            if (dialog.ShowDialog() == true && dialog._customer != null)
            {
                var updated = dialog._customer;
                SelectedCustomer.Name = updated.Name;
                SelectedCustomer.Age = updated.Age;
                SelectedCustomer.Height = updated.Height;
                SelectedCustomer.PostCode = updated.PostCode;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }
}
