using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Movie
    {
        public string Title { get; set; }
        public string Catagory { get; set; }
        public Movie(string _title, string _catagory)
        {
            Title= _title;
            Catagory= _catagory;
        }

        public Movie()
        {
        }
    }
    //Methods


}
