using MvcMovie.Models;
using MvcMovie.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.Services
{
    public class MovieService
    {
        MovieRepo repo = new MovieRepo();

        public List<Movie> getMovies()
        {
            return repo.getMovies();
        }
        public void createMovie(Movie movie)
        {
            repo.createMovie(movie);
        }
        public Movie getMovie(int id)
        {
            return repo.readMovie(id); 

        }
        public void deleteMovie(int id)
        {
            repo.deleteMovie(id);
        }

        internal void update(Movie movie)
        {
            repo.updateMovie(movie);
        }
    }

    
}