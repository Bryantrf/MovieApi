using System;
using Domain.Dtos;
using Domain.Helpers;
using Domain.Models;

namespace Domain.Services.Interfaces
{
	public interface IMovieService
	{
        MovieDto GetMovieDetail(int id);
        List<ReviewsListDto> GetReviews(int movieId);
        void SaveNewMovie(NewMovieDto model);
        void DisableMovie(int id);
        void SaveNewMovieReview(ReviewDto model);
        MovieReview GetMovieReviews(int movieId);
        IEnumerable<Movies> GetMovies(PaginationModel parameterts);

    }
}

