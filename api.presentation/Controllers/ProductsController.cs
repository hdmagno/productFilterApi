using System;
using System.Collections.Generic;
using api.presentation.Data.Repositories;
using api.presentation.Filter;
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

        [HttpGet("frontend")]
        public IActionResult FrontEnd()
        {
            return Ok(_repository.All());
        }

        [HttpGet("backend")]
        public IActionResult BackEnd([FromQuery] ProductFilter filter)
        {
            try
            {
                var entity = _repository.Query(filter);

                var result = _mapper.Map<IEnumerable<ResponseProductViewModel>>(entity);

                return Ok(new
                {
                    data = result,
                    metadata = new
                    {
                        page = filter.Page,
                        pageSize = filter.PageSize,
                        totalPages = filter.TotalPages,
                        totalCount = filter.TotalCount,
                        hasPrevious = filter.HasPrevious,
                        hasNext = filter.HasNext
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
