using System;
namespace Domain.Dtos
{
	public class MovieReview
	{
		public List<ReviewsListDto> Reviews { get; set; } = new List<ReviewsListDto>();
	}

	public class ReviewsListDto
	{
		public DateTime CreationDate { get; set; }
		public string Description { get; set; } = string.Empty;
	}
}

