using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action...";
        }


        // GET: /HelloWorld/Welcome
        public string Welcome()
        {
            return "This is the welcome action method...";
        }

        public string Hello(string name, int numTimes)
        {
            //  return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            return HtmlEncoder.Default.Encode("Hello " + name + ", NumTimes is: "+ numTimes);
        }

        public string HelloWho( int id)
        {
            switch (id)
            {
                case 1: return "Hello Maaike";
                case 2: return "Hello Tom";
                default: return "Hello stranger"; 
            }
               
        }

    }
}