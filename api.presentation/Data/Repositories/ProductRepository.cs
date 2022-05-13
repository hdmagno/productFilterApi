using System;
using System.Collections.Generic;
using System.Linq;
using api.presentation.Filters;
using api.presentation.Models;
using Microsoft.EntityFrameworkCore;

namespace api.presentation.Data.Repositories
{
    public class ProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> SelectAll(ProductFilter filter)
        {
            try
            {
                IQueryable<Product> query = _context.Products.AsNoTracking();

                var filteredQuery = FilterFunction(query, filter);

                var orderedQuery = OrderBy(filteredQuery, filter);

                var paginatedQuery = filter.Paginate(orderedQuery);

                return paginatedQuery;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Repository: {ex.InnerException}");
            }

        }

        public IQueryable<Product> FilterFunction(IQueryable<Product> query, ProductFilter filter)
        {
            if (!string.IsNullOrEmpty(filter.Title) && filter.Price > 0)
            {
                query = query.Where(x => x.Title.Contains(filter.Title)
                    && x.Price == filter.Price);
                
                return query;
            }
            
            if (!string.IsNullOrEmpty(filter.Title))
            {
                query = query.Where(x => x.Title.Contains(filter.Title));

                return query;
            }

            if (filter.Price > 0)
            {
                query = query.Where(x => x.Price == filter.Price);

                return query;
            }

            return query;
        }

        public IQueryable<Product> OrderBy(IQueryable<Product> filteredQuery, ProductFilter filter)
        {
            switch (filter.OrderBy)
            {
                case "title":
                    filteredQuery = OrderByAscOrDesc(filteredQuery, filter.OrderDirection);
                    break;

                case "price":
                    filteredQuery = OrderByAscOrDesc(filteredQuery, filter.OrderDirection);
                    break;

                default:
                    filteredQuery = filteredQuery.OrderBy(x => x.Id);
                    break;
            }

            return filteredQuery;
        }

        public IQueryable<Product> OrderByAscOrDesc(IQueryable<Product> filteredQuery, string direction)
        {
            if (string.IsNullOrEmpty(direction))
            {
                filteredQuery = filteredQuery.OrderBy(x => x.Title);
            }
            else
            {
                filteredQuery = filteredQuery.OrderByDescending(x => x.Title);
            }

            return filteredQuery;
        }
    }
}
