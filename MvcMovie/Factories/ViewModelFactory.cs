using MvcMovie.Models;
using MvcMovie.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.Factories
{
    /**
     * Note: For our application we did not need a View Model Factory. However, our client's uses one and wanted to keep it. 
     * Builds View Model objects out of model objects so the view can directly bind to them.
     */
    public class ViewModelFactory
    {
        public MovieVM buildMovie(Movie movie)
        {
            return null; 
        }
    }
}