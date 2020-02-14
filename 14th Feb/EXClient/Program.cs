using System;
using ExOnDataAccessLayer;
using ExOnDataAccessLayer.Models;
using ExOnDataAccessLayer.Context;
namespace EXClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext())
            {
                Item i = new Item() { ItemName = "dev", ItemPrice=500 };
               // Order o = new Order() { ItemID = 1, OrderDate = DateTime.Now, DeliveryDate=DateTime.Now };
                db.Add(i);
                //db.Add(o);
                db.SaveChanges();
            }
        }
    }
}
