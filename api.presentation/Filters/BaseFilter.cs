using System;
using System.Linq;

namespace api.presentation.Filters
{
    public class BaseFilter
    {
        const int MaxPageSize = 20;

        public int Page { get; set; } = 1;

        private int _pageSize = 10;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = value > MaxPageSize ? MaxPageSize : value;
        }

        private int SkipSize => (Page - 1) * PageSize;

        private int _totalPages => (int)Math.Ceiling(_totalCount / (decimal)PageSize);
        public int GetTotalPages() 
            => _totalPages;

        private int _totalCount = 0;
        public int GetTotalCount()
            => _totalCount;

        private bool _hasPrevious => Page > 1;
        public bool GetHasPrevious()
            => _hasPrevious;

        private bool _hasNext => Page < _totalPages;
        public bool GetHasNext()
            => _hasNext;

        public bool Paginated { get; set; } = true;

        public string OrderBy { get; set; }

        public string OrderDirection { get; set; }

        public IQueryable<T> Paginate<T>(IQueryable<T> query)
        {
            if (Paginated)
            {
                _totalCount = query.Count();
                AdjustPageNumber();
                return query.Skip(SkipSize).Take(PageSize);
            }
            else
            {
                return query;
            }
        }

        public void AdjustPageNumber()
        {
            Page = Page > _totalPages ? _totalPages : Page < 1 ? 1 : Page;
        }
    }

}
