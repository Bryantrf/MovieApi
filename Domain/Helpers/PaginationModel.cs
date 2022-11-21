using System;
namespace Domain.Helpers
{
	public class PaginationModel
	{
        const int maxPageSize = 50;
        public string Search { get; set; } = string.Empty;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 10;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}

