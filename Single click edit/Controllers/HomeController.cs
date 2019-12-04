
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestSample.Models;
using System.Data;

namespace TestSample.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            DataTable dt = new DataTable("Student");
            dt.Columns.Add("value", typeof(Int32));
            dt.Columns.Add("text", typeof(string));

            dt.Rows.Add(1, "MANISH");
            dt.Rows.Add(2, "PASTA");
            List<detail> studentList = new List<detail>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                detail customer = new detail();
                customer.value = Convert.ToInt32(dt.Rows[i]["value"].ToString());
                customer.text = dt.Rows[i]["text"].ToString();
                studentList.Add(customer);
            }
            ViewBag.dataSource = OrdersDetails.GetAllRecords().ToList();
            ViewBag.DropDownData = studentList.ToList() ;
            return View();
        }
    }
    
    public class OrdersDetails
    {
        public static List<OrdersDetails> order = new List<OrdersDetails>();
        public OrdersDetails()
        {

        }
        public OrdersDetails(int OrderID, int Yellowmin, int Redmin, int Greenmin, string CustomerId, int EmployeeId, double Freight, Boolean Verified, DateTime OrderDate, string ShipCity, string ShipName, string ShipCountry, DateTime ShippedDate, string Email)
        {
            this.OrderID = OrderID;
            this.Yellowmin = Yellowmin;
            this.Redmin = Redmin;
            this.Greenmin = Greenmin;
            this.CustomerID = CustomerId;
            this.EmployeeID = EmployeeId;
            this.Freight = Freight;
            this.ShipCity = ShipCity;
            this.Verified = Verified;
            this.OrderDate = OrderDate;
            this.ShipName = ShipName;
            this.ShipCountry = ShipCountry;
            this.ShippedDate = ShippedDate;
            this.Email = Email;
        }
        public static List<OrdersDetails> GetAllRecords()
        {
            if (order.Count() == 0)
            {
                int code = 10000;
                for (int i = 1; i < 10; i++)
                {
                    order.Add(new OrdersDetails(code + 2, 10, 20, 30, "ALFKI", i + 0, Convert.ToDouble("2,3") * i, true, new DateTime(1991, 05, 15), "Berlin", "Simons bistro", "Denmark", new DateTime(1996, 7, 16), "priya@gmail.com"));
                    order.Add(new OrdersDetails(code + 2, 50, 60, 70, "ANATR", i + 2, Convert.ToDouble("3,3") * i, false, new DateTime(1990, 04, 04), "Madrid", "Queen Cozinha", "Brazil", new DateTime(1996, 9, 11), "kavi@gmail.com"));
                    order.Add(new OrdersDetails(code + 3, 40, 50, 60, "HANAR", i + 1, Convert.ToDouble("4,3") * i, true, new DateTime(1957, 11, 30), "Cholchester", "Frankenversand", "Germany", new DateTime(1996, 10, 7), "hello@gmail.com"));
                    order.Add(new OrdersDetails(code + 4, 70, 80, 90, "BLONP", i + 3, Convert.ToDouble("5,3") * i, true, new DateTime(1930, 10, 22), "Marseille", "Ernst Handel", "Austria", new DateTime(1996, 12, 30), "nivi@gmail.com"));
                    order.Add(new OrdersDetails(code + 5, 30, 40, 50, "BOLID", i + 4, Convert.ToDouble("6,3") * i, false, new DateTime(1953, 02, 18), "Tsawassen", "Hanari Carnes", "Switzerland", new DateTime(1997, 12, 3), "hasan@gmail.com"));
                    code += 5;
                }
            }
            return order;
        }

        public int? OrderID { get; set; }
        public int? Yellowmin { get; set; }
        public int? Redmin { get; set; }
        public int? Greenmin { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public double? Freight { get; set; }
        public string ShipCity { get; set; }
        public Boolean Verified { get; set; }
        public DateTime OrderDate { get; set; }

        public string ShipName { get; set; }

        public string ShipCountry { get; set; }

        public DateTime ShippedDate { get; set; }
        public string Email { get; set; }
    }


    public class OrdersDetails1
    {
        public static List<OrdersDetails1> order = new List<OrdersDetails1>();
        public OrdersDetails1()
        {

        }
        public OrdersDetails1(int OrderID, string CustomerId, int EmployeeId, double Freight, bool Verified, DateTime OrderDate, string ShipCity, string ShipName, string ShipCountry, DateTime ShippedDate, string ShipAddress)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerId;
            this.EmployeeID = EmployeeId;
            this.Freight = Freight;
            this.ShipCity = ShipCity;
            this.Verified = Verified;
            this.OrderDate = OrderDate;
            this.ShipName = ShipName;
            this.ShipCountry = ShipCountry;
            this.ShippedDate = ShippedDate;
            this.ShipAddress = ShipAddress;
        }
        public static List<OrdersDetails1> GetAllRecords()
        {
            if (order.Count() == 0)
            {
                int code = 10000;
                for (int i = 1; i < 10; i++)
                {
                    order.Add(new OrdersDetails1(code + 1, "kavi", i + 0, 2.3 * i, false, new DateTime(1991, 05, 15), "Berlin", "Simons bistro", "Denmark", new DateTime(1996, 7, 16), "Kirchgasse 6"));
                    order.Add(new OrdersDetails1(code + 2, "vivin", i + 2, 3.3 * i, true, new DateTime(1990, 04, 04), "Madrid", "Queen Cozinha", "Brazil", new DateTime(1996, 9, 11), "Avda. Azteca 123"));
                    order.Add(new OrdersDetails1(code + 3, "kavitha", i + 1, 4.3 * i, true, new DateTime(1957, 11, 30), "Cholchester", "Frankenversand", "Germany", new DateTime(1996, 10, 7), "Carrera 52 con Ave. Bolívar #65-98 Llano Largo"));
                    order.Add(new OrdersDetails1(code + 4, "hanar", i + 3, 5.3 * i, false, new DateTime(1930, 10, 22), "Marseille", "Ernst Handel", "Austria", new DateTime(1996, 12, 30), "Magazinweg 7"));
                    order.Add(new OrdersDetails1(code + 5, "hasan", i + 4, 6.3 * i, true, new DateTime(1953, 02, 18), "Tsawassen", "Hanari Carnes", "Switzerland", new DateTime(1997, 12, 3), "1029 - 12th Ave. S."));
                    code += 5;
                }
            }
            return order;
        }

        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public double? Freight { get; set; }
        public string ShipCity { get; set; }
        public bool Verified { get; set; }
        public DateTime OrderDate { get; set; }

        public string ShipName { get; set; }

        public string ShipCountry { get; set; }

        public DateTime ShippedDate { get; set; }
        public string ShipAddress { get; set; }
    }
}
