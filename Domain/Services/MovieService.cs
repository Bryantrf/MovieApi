using System;
using Domain.Data;
using Domain.Dtos;
using Domain.Helpers;
using Domain.Models;
using Domain.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Services
{
	public class MovieService : IMovieService
	{
		private readonly BsMovieContext _context;

		public MovieService(BsMovieContext context)
		{
			_context = context;
		}
        public MovieDto GetMovieDetail(int id)
        {
			var data = _context.Movies.Where(Mv => Mv.Id == id).FirstOrDefault();
            if (data == null)
                throw new Exception("Pelicula no encontrada");

            MovieDto result = new MovieDto()
			{
				Name = data.Name,
				Gender = data.Gender,
			}; 

			result.Reviews = GetReviews(data.Id);

			return result;
        }

        public List<ReviewsListDto> GetReviews(int movieId)
        {
			var data = _context.Reviews.Where(r => r.MovieId == movieId).ToList();
            if (data == null)
                throw new Exception("Pelicula no posee reviews");

			List<ReviewsListDto> result = new List<ReviewsListDto>();
			data.ForEach(d =>{
            ReviewsListDto model = new ReviewsListDto()
            {
                Description = d.Review,
                CreationDate = d.CreatedDate
            };
				result.Add(model);
			});
			
            return result;
        }

        public MovieReview GetMovieReviews(int movieId)
        {

			List<ReviewsListDto> reviews = GetReviews(movieId);

            MovieReview result = new MovieReview()
			{
				Reviews = reviews
			};

            return result;
        }

        public void SaveNewMovie(NewMovieDto model)
		{
			Movies movie = new Movies()
			{
				Name = model.Name,
				Gender = model.Gender,
				Cancelled = false
			};

			_context.Movies.Add(movie);
			_context.SaveChanges();
		}

        public void SaveNewMovieReview(ReviewDto model)
        {
			Reviews review = new Reviews()
			{
				Review = model.Review,
				MovieId = model.MovieId,
				Cancelled = false,
				CreatedDate = DateTime.Now,
            };

            _context.Reviews.Add(review);
            _context.SaveChanges();
        }

        public void DisableMovie(int id)
        {
			var movie = _context.Movies.Where(Mv => Mv.Id == id).FirstOrDefault();

            if (movie == null)
                throw new Exception("Pelicula no encontrada");

            movie.Cancelled = true;

			_context.Update(movie);
            _context.SaveChanges();
        }

        public IEnumerable<Movies> GetMovies(PaginationModel parameterts)
		{
            return _context.Movies.Where(Mv => Mv.Name.Contains(parameterts.Search))
                                   .OrderBy(on => on.Name)
                                   .Skip((parameterts.PageNumber - 1) * parameterts.PageSize)
                                   .Take(parameterts.PageSize)
                                   .ToList();
        }

    }
}

