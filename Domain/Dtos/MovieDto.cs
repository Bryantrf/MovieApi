using System;
namespace Domain.Dtos
{
    public class NewMovieDto 
    {
        public string Name { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
    }
    public class MovieDto : NewMovieDto
    {
        public List<ReviewsListDto> Reviews { get; set; } = new List<ReviewsListDto>();
    }
}

