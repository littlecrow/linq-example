﻿using ACM.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACM.Win
{
    public partial class CustomerWin : Form
    {
        CustomerRepository customerRepository = new CustomerRepository();

        public CustomerWin()
        {
            InitializeComponent();
        }
        private void CustomerWin_Load(object sender, EventArgs e)
        {
            var customerList = customerRepository.Retrieve();

            CustomerComboBox.DisplayMember = "Name";
            CustomerComboBox.ValueMember = "CustomerId";
            CustomerComboBox.DataSource = customerRepository.GetNamesAndId(customerList);
        }

        private void GetCustomersButton_Click(object sender, EventArgs e)
        {
            var customerList = customerRepository.Retrieve();
            //CustomerGridView.DataSource = customerRepository.SortByName(customerList).ToList();

            CustomerTypeRepository customerTypeRepository = new CustomerTypeRepository();
            var customerTypeList = customerTypeRepository.Retrieve();

            CustomerGridView.DataSource = customerRepository.GetNamesAndType(customerList, customerTypeList);
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CustomerComboBox.SelectedValue != null)
            {
                int customerId;
                if(int.TryParse(CustomerComboBox.SelectedValue.ToString(), out customerId))
                {
                    var customerList = customerRepository.Retrieve();
                    CustomerGridView.DataSource = new List<Customer>() { customerRepository.Find(customerList, customerId) };
                }
            }
        }
    }
}
