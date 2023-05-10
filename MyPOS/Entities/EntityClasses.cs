using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPOS.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        public int PinCode { get; set; }
    }

    public class Item
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string LookupCode { get; set; }
        public string Department { get; set; }
        public string Category { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public string UOM { get; set; }
        public int Quantity { get; set; }
        public int TaxID { get; set; }
        public decimal Tax { get; set; }
        public bool Discount { get; set; }
        public decimal Total { get; set; }
        public bool Action { get; set; }
    }

    public class SalesItem
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string LookupCode { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public decimal ItemPrice { get; set; }
        //public decimal Weight { get; set; }
        public int Quantity { get; set; }
        public int TaxID { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public bool Action { get; set; }
    }

    public class Items
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
    }
    public class Tax
    {
        public int ID { get; set; }
        public decimal Percentage { get; set; }
        public string Name { get; set; }
    }

    public class Invoice
    {
        //Select ID, ItemTotal, Discount, Tax, Price, TotalAmount, Customer, InvDate from tbInvoice
        public int InvoiceId { get; set; }
        public int ItemTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal Price { get; set; }
        public decimal TotalAmount { get; set; }
        public string Customer { get; set; }
        public DateTime InvDate { get; set; }
    }
}
