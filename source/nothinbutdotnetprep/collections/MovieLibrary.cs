using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nothinbutdotnetprep.collections
{
    public class MovieLibrary
    {
        IList<Movie> movies;

        public MovieLibrary(IList<Movie> list_of_movies)
        {
            this.movies = list_of_movies;
        }

        public IEnumerable<Movie> all_movies()
        {
            return this.movies;
        }

        public void add(Movie movie)
        {
            movies.Add(movie);
        }

        public IEnumerable<Movie> sort_all_movies_by_title_descending()
        {
            return (IEnumerable<Movie>)movies.OrderByDescending(movie => movie.title);
        }

        public IEnumerable<Movie> all_movies_published_by_pixar()
        {
            return (IEnumerable<Movie>)movies.Select(movie => movie.production_studio == ProductionStudio.Pixar).ToList();
        }

        public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
        {
            return (IEnumerable<Movie>)movies.Select(movie =>  movie.production_studio == ProductionStudio.Pixar || movie.production_studio == ProductionStudio.Disney).ToList();
        }

        public IEnumerable<Movie> sort_all_movies_by_title_ascending()
        {
            return (IEnumerable<Movie>) movies.OrderBy(movie => movie.title);
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
        {
            return (IEnumerable<Movie>)movies.OrderBy(movie => movie.production_studio).ThenBy(movie => movie.date_published);               
        }

        public IEnumerable<Movie> all_movies_not_published_by_pixar()
        {
            return (IEnumerable<Movie>)movies.Select(movie => movie.production_studio != ProductionStudio.Pixar );               
        }

        public IEnumerable<Movie> all_movies_published_after(int year)
        {
            return (IEnumerable<Movie>) movies.Select(movie => movie.date_published.Year > year);
        }

        public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
        {
            return (IEnumerable<Movie>)movies.Select(movie => movie.date_published.Year > startingYear && movie.date_published.Year < endingYear);
        }

        public IEnumerable<Movie> all_kid_movies()
        {
            return (IEnumerable<Movie>) movies.Select(movie => movie.genre == Genre.kids);
        }

        public IEnumerable<Movie> all_action_movies()
        {
            return (IEnumerable<Movie>)movies.Select(movie => movie.genre == Genre.action);
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
        {
            return (IEnumerable<Movie>)movies.OrderByDescending(movie => movie.date_published);
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
        {
            return (IEnumerable<Movie>)movies.OrderByDescending(movie => movie.date_published);
        }
    }
}