using System.Net;
using Domain.Data;
using Domain.Dtos;
using Domain.Helpers;
using Domain.Models;
using Domain.Services;
using Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MovieApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MoviesController : ControllerBase
{
    private readonly ILogger<MoviesController> _logger;
    private IMovieService _repository;


    public MoviesController(ILogger<MoviesController> logger, IMovieService repository)
    {
        _logger = logger;
        _repository = repository;
    }

    [Route("NewMovie")]
    [HttpPost]
    public HttpResponseMessage PostMovie([FromBody] NewMovieDto movie)
    {
        _repository.SaveNewMovie(movie);
        return new HttpResponseMessage(HttpStatusCode.OK);
    }

    [Route("NewMovieReview")]
    [HttpPost]
    public HttpResponseMessage PostReview([FromBody] ReviewDto review)
    {
        _repository.SaveNewMovieReview(review);
        return new HttpResponseMessage(HttpStatusCode.OK);
    }

    [Route("MovieDetail")]
    [HttpGet]
    public MovieDto GetMovie([FromQuery] int id)
        => _repository.GetMovieDetail(id);

    [Route("MovieReviews")]
    [HttpGet]
    public MovieReview GetMovieReviews([FromQuery] int movieId)
       => _repository.GetMovieReviews(movieId);

    [Route("Movie")]
    [HttpDelete]
    public HttpResponseMessage DisableMovie([FromQuery] int id)
    {
        _repository.DisableMovie(id);
        return new HttpResponseMessage(HttpStatusCode.OK);
    }

    [Route("MovieList")]
    [HttpGet]
    public IEnumerable<Movies> GetMoviesList([FromQuery] PaginationModel parameters)
     => _repository.GetMovies(parameters);

}

