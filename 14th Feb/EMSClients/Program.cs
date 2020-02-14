using System;
using EFDataAccessLayer;
using EFDataAccessLayer.Context;
using EFDataAccessLayer.Models;

namespace EMSClients
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext())
            {
                Project p = new Project() { ProjectName = "BFS" };
                db.Add(p);
                db.SaveChanges();
            }
        }
    }
}
