using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } //Atributes
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() //Construtor
        {
        }

        public Department(int id, string name) //Construtor
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller) //Method to add seller in department.
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final) //Method to return total of the sales.
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
