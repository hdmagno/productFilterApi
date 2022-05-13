using System;
using System.Collections.Generic;
using api.presentation.Data.Repositories;
using api.presentation.Filters;
using api.presentation.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api.presentation.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductsController(ProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] ProductFilter filter)
        {
            try
            {
                var entity = _repository.SelectAll(filter);

                var result = _mapper.Map<IEnumerable<ResponseProductViewModel>>(entity);

                return Ok(new
                {
                    data = result,
                    metadata = new
                    {
                        page = filter.Page,
                        pageSize = filter.PageSize,
                        totalPages = filter.GetTotalPages(),
                        totalCount = filter.GetTotalCount(),
                        hasPrevious = filter.GetHasPrevious(),
                        hasNext = filter.GetHasNext()
                    }
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }
    }
}
