using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Repository
{
    public class MovieRepo
    {
        private MovieDBContext db = new MovieDBContext();

        public void createMovie(Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();
        }
        public Movie readMovie(int id)
        {
            return db.Movies.Find(id); ; 
        }
        public void updateMovie(Movie movie)
        {
            db.Entry(movie).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void deleteMovie(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
        }

        public List<Movie> getMovies()
        {
            List<Movie> movies = new List<Movie>();

            foreach(Movie m in db.Movies)
            {
                movies.Add(m);
            }
            return (List<Movie>) movies;
        }
        
    }
}