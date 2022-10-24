using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace MovieProDemo.Models.Settings
{
    public class AppSettings
    {
        public MovieProSettings MovieProSettings { get; set; }
        public TMDBSettings TMDBSettings  { get; set; }
    }
}

