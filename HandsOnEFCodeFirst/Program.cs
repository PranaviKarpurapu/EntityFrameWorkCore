using System;
using HandsOnEFCodeFirst.Models;
using HandsOnEFCodeFirst.Context;
using System.Linq;
using System.Collections.Generic;

namespace HandsOnEFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using(MyContext db=new MyContext())
            {
                //insert new record 
                //Student s = new Student() { Sname = "Giri", Age = 12, Std = "IV" };
                //db.Students.Add(s);
                //db.SaveChanges();

                //Fetch Record
                //Student s = db.Students.Find(1);
                //Console.WriteLine("Welcome {0}", s.Sname);


                //Fetch One Record using NON-Primary Key
                Student s = db.Students.SingleOrDefault(i => i.Sname=="Giri");

                //Fetching Multiple Records 
                List<Student> list1 = db.Students.Where(i => i.Age==12).ToList();
                //Fetching  with Multiple Conditons
                List<Student> list2 = db.Students.Where(i => i.Age == 12 && i.Std=="IV").ToList();

                //Updates value
                Student s2 = db.Students.Find(2);
                s2.Age = 14;  
                db.SaveChanges();


                //Delete Record
                Student s3 = db.Students.SingleOrDefault(i => i.Sname == "Rohan");
                db.Students.Remove(s3);
                db.SaveChanges();


                
            }
        }
    }
}
