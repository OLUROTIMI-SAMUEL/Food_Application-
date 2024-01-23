using SammyFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SammyFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;  //list is private here

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott Pizza", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Mr Biggs", Cuisine = CuisineType.French },
                new Restaurant { Id = 3, Name = "Mumbai", Cuisine = CuisineType.Indian },

            };

        }

        public void Add(Restaurant restaurant)
        {
           // throw new NotImplementedException();
           restaurants.Add(restaurant);
            restaurant.Id = restaurants.Max(x => x.Id) + 1;
        }

        public void Delete(int id)
        {
            var restaurant = Get(id);
            if (restaurant != null)
            {
                restaurants.Remove(restaurant);
            }
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }   

        public IEnumerable<Restaurant> GetAll()
        {
            //  throw new NotImplementedException();
            // return restaurants;    //we can return this it still runs
            //OR BY ORDER BY
            return restaurants.OrderBy(v => v.Name);
        }

        public void Update(Restaurant restaurant)
        {
           // throw new NotImplementedException();
         //  restaurants.(restaurant);
         var existing  = Get(restaurant.Id);
            if(existing != null)
            {
                existing.Name = restaurant.Name;
                existing.Cuisine = restaurant.Cuisine;  
            }

        }
    }
}
