using Microsoft.EntityFrameworkCore;
using SammyFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammyFood.Data.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly SammyFoodDbContext db;

        public SqlRestaurantData(SammyFoodDbContext db)
        {
            this.db = db;
        }
        public void Add(Restaurant restaurant)
        {
           // throw new NotImplementedException();
           db.Restaurants.Add(restaurant);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var restaurant = db.Restaurants.Find(id);
            db.Restaurants.Remove(restaurant);
            db.SaveChanges();
        }

        public Restaurant Get(int id)
        {
            return db.Restaurants.FirstOrDefault(x => x.Id == id);
        }

       public IEnumerable<Restaurant> GetAll()
        {
            // return db.Restaurants.OrderBy(x => x.Name);

            //             OR   {any one goes};

         //   return db.Restaurants;   //You can return the dbset direct becuase it returns IEnumerable of restuarant

            //             OR   {any one goes};


           return from r in db.Restaurants
            orderby r.Name
            select r;  //IN ACCENDING ORDER     modle 37

       }

        public void Update(Restaurant restaurant)
        {
            //OPTIMISTIC CUNCURRENCY
            var entry = db.Entry(restaurant);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
