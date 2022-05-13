using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace api.presentation.Models
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

        public int TotalPages => (int)Math.Ceiling(TotalCount / (decimal)PageSize);

        public int TotalCount { get; set; }

        public bool HasPrevious => Page > 1;

        public bool HasNext => Page < TotalPages;

        public bool Paginated { get; set; } = true;

        public string OrderBy { get; set; }

        public string OrderDirection { get; set; }
        
        public IQueryable<T> Paginate<T>(IQueryable<T> query)
        {
            if (Paginated)
            {
                TotalCount = query.Count();
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
            Page = Page > TotalPages ? Math.Max(TotalPages, 1) : Page;
        }
    }

}
