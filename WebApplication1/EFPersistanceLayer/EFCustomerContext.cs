
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.EFModels;


namespace WebApplication1.EFPersistanceLayer
{
    public class EFCustomerContext
    {
    

        public static bool create(Customer customer)
        {
            string connectionString = "Server=(localdb)\\RahulAudree;DataBase=PracticeBank;User Id=Rahul;Password=Rahul12;encrypt=false";
            try
            {
                DbContextOptionsBuilder<PracticeBankContext> optionsBuilder = new DbContextOptionsBuilder<PracticeBankContext>();
                optionsBuilder.UseSqlServer(connectionString);
                PracticeBankContext db = new PracticeBankContext(optionsBuilder.Options);
                db.Customers.Add(customer);
                db.SaveChanges();
                return true;
            }
            catch (System.Exception ex)
            {
                throw;
            }
            finally
            {

            }
        }

        public static Customer GetCustomerById(int id)
        {
            string connectionString = "Server=(localdb)\\RahulAudree;DataBase=PracticeBank;User Id=Rahul;Password=Rahul12;encrypt=false";
            try
            {
                DbContextOptionsBuilder<PracticeBankContext> optionsBuilder = new DbContextOptionsBuilder<PracticeBankContext>();
                optionsBuilder.UseSqlServer(connectionString);
                PracticeBankContext db = new PracticeBankContext(optionsBuilder.Options);
                Customer customer = db.Customers.Find(id);
                return customer;
            }
            catch(Exception ex)
            {
                throw;
            }

        }

        public static List<Customer> GetCustomers()
        {
            string connectionString = "Server =(localdb)\\RahulAudree;Database=PracticeBank;User Id=Rahul;Password=Rahul12;encrypt=false";
            try
            {
                DbContextOptionsBuilder<PracticeBankContext> optionsBuilder = new DbContextOptionsBuilder<PracticeBankContext>();
                optionsBuilder.UseSqlServer(connectionString);
                PracticeBankContext db = new PracticeBankContext(optionsBuilder.Options);
                List<Customer> customers = db.Customers.ToList();
                return (customers);
            }
            catch(Exception ex)
            {
                throw;
            }


        }

        public static bool Delete(int id)
        {
            string connectionString = "Server =(localdb)\\RahulAudree;Database=PracticeBank;User Id=Rahul;Password=Rahul12;encrypt=false";

            try
            {
                DbContextOptionsBuilder<PracticeBankContext> optionsBuilder = new DbContextOptionsBuilder<PracticeBankContext>();
                optionsBuilder.UseSqlServer(connectionString);
                PracticeBankContext db = new PracticeBankContext(optionsBuilder.Options);

                Customer customer = db.Customers.Find(id);
                db.Customers.Remove(customer);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool UpdateCustomer(Customer customer)
        {
            string connectionString = "Server =(localdb)\\RahulAudree;Database=PracticeBank;User Id=Rahul;Password=Rahul12;encrypt=false";
            try
            {
                DbContextOptionsBuilder<PracticeBankContext> optionsBuilder = new DbContextOptionsBuilder<PracticeBankContext>();
                optionsBuilder.UseSqlServer(connectionString);
                PracticeBankContext db = new PracticeBankContext(optionsBuilder.Options);
                db.Customers.Update(customer);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw;

            }

        }

    }
}
