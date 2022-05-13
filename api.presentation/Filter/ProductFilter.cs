using api.presentation.Models;

namespace api.presentation.Filter
{
    public class ProductFilter : BaseFilter
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }
}
