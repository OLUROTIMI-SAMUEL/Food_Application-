using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammyFood.Data.Models
{
    public class Restaurant
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Display(Name = "Type Of Food In Different Country")]
        public CuisineType Cuisine { get; set; }
    }
}

//When you create an MVC Application and you need to look for the start up project for your application
// the file to look for the "Global.asax" file 

//Minification is the process of making a download as small as possible by removing any uneccessary character
//from the files e.g unessary wide space. This is to help the browser receive the style sheet as quick as possible

//The proccess of mapping an incoming URL e.g "https://localhost:44379/Home/Contact" to a piece of software is
// called ROUTING which tells our ASP .NET how to fing a piece of software that can respond to a given URL 