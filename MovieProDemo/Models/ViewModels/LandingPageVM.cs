﻿using System;
using System.Collections.Generic;
using MovieProDemo.Models.Database;
using MovieProDemo.Models.TMDB;

namespace MovieProDemo.Models.ViewModels
{
    public class LandingPageVM
    {
        public List<Collection> CustomCollections { get; set; }

        public MovieSearch NowPlaying { get; set; }
        public MovieSearch Popular { get; set; }

        public MovieSearch TopRated { get; set; }

        public MovieSearch Upcoming { get; set; }

    }
}

