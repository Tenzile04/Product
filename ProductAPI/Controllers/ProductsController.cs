using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Data;
using ProductAPI.DTOs;
using ProductAPI.Entities;
using System.Security.Cryptography.X509Certificates;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public ProductsController(AppDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> products = _context.Products.ToList();
            IEnumerable<ProductGetDto> productGetDtos = new List<ProductGetDto>();
            productGetDtos = products.Select(x => new ProductGetDto { Id = x.Id, Name = x.Name, Description = x.Description });

            return Ok(productGetDtos);

        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Product product= _context.Products.FirstOrDefault(x => x.Id == id);
            if (product == null) return NotFound();
            var productgetDto=_mapper.Map<ProductGetDto>(product);
            return Ok(productgetDto);
        }
       

    }
}
