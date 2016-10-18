﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL.Test
{
    [TestClass]
    public class InvoiceRepositoryTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void CalculateTotalAmountInvoicedTest()
        {
            // Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrieve();

            // Act
            var actual = repository.CalculateTotalAmountInvoiced(invoiceList);

            // Assert
            Assert.AreEqual(1333.14M, actual);
        }

        [TestMethod]
        public void CalculateTotalUnitsSoldTest()
        {
            // Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrieve();

            // Act
            var actual = repository.CalculateTotalUnitsSold(invoiceList);

            // Assert
            Assert.AreEqual(136, actual);
        }

        [TestMethod]
        public void GetInvoiceTotalByIsPaidTest()
        {
            // Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrieve();

            // Act
            var query = repository.GetInvoiceTotalByIsPaid(invoiceList);
        }

        [TestMethod]
        public void GetInvoiceTotalByIsPaidAndMonthTest()
        {
            // Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrieve();

            // Act
            var query = repository.GetInvoiceTotalByIsPaidAndMonth(invoiceList);
        }

        [TestMethod]
        public void GetInvoiceTotalByCustomerTypeTest()
        {
            // Arrange
            CustomerRepository customerRepository = new CustomerRepository();
            var customerList = customerRepository.Retrieve();

            CustomerTypeRepository customerTypeRepository = new CustomerTypeRepository();
            var customerTypeList = customerTypeRepository.Retrieve();

            InvoiceRepository invoiceRepository = new InvoiceRepository();
            var invoiceList = invoiceRepository.Retrieve();

            // Act
            var query = invoiceRepository.GetInvoiceTotalByCustomerType(customerList, customerTypeList);
        }
    }
}
