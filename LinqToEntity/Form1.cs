using LinqToEntity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToEntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();

        private void btnGetProducts_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.ToList();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees
                .OrderByDescending(y => SqlFunctions.DateDiff("Year", y.BirthDate, DateTime.Now))
                .Select(x => new

                {
                x.TitleOfCourtesy,
                FullName = x.FirstName + " " + x.LastName,
                x.Title,
                Age = SqlFunctions.DateDiff("Year", x.BirthDate, DateTime.Now)

            }).ToList();
        }

        private void btnExpensiveProduct_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products
                .OrderByDescending(x => x.UnitPrice)
                .Take(1)
                .Select(y => new

                {
                y.ProductName,
                y.UnitPrice

            }).ToList();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.Products
                .GroupBy(c => c.Category.CategoryName)
                .Select(x => new
                {
                    CategoryName = x.Key,
                    TotalStock = x.Sum(y => y.UnitsInStock)

                }).ToList();
        }

        private void btnAddBeverage_Click(object sender, EventArgs e)
        {
                db.Categories
               .FirstOrDefault(x => x.CategoryName == "Beverages")
               .Products.Add(new Product
               {
                   ProductName = "mavzy Coffe",
                   UnitPrice = 13,
                   UnitsInStock = 1337
               });

                db.SaveChanges();

                dataGridView1.DataSource = db.Products.ToList();
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Customers
                .Where(w => w.CompanyName.Contains("restaurant")).ToList();

        }

        private void btnJoin1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products
                .Join(db.Categories, p => p.CategoryID, c => c.CategoryID, (p, c) => new
                {

                    p.ProductID,
                    p.ProductName,
                    p.CategoryID,
                    p.Category.CategoryName

                }).ToList();
        }

        private void btn2050Price_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.Products
                .Where(x => x.UnitPrice >= 20 && x.UnitPrice <= 50)
                .OrderBy(y => y.UnitPrice)
                .Select(m => new
                {
                    m.ProductID,
                    m.ProductName,
                    m.UnitPrice,
                    m.UnitsInStock,
                    m.Category

                }).ToList();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Orders
                .OrderBy(o=> o.OrderDate)
                .Select(x => new
                {
                    x.Customer.CompanyName,
                    FullName = x.Employee.FirstName + " " + x.Employee.LastName,
                    x.OrderID,
                    x.OrderDate,
                    ShipperCompanyName = x.Shipper.CompanyName

                }).ToList();
        }

        private void btnDatePart_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees
                .Where(x => SqlFunctions.DatePart("Year", x.BirthDate) >= 1950 && SqlFunctions.DatePart("Year", x.BirthDate) <= 1960)
                .OrderBy(o=> o.BirthDate)
                .Select(y => new
                {
                    FullName = y.FirstName + " " + y.LastName,
                    y.BirthDate

                }).ToList();
        }
    }
}
