using FluentValidation;

namespace ProductAPI.DTOs
{
    public class ProductGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double SalePrice { get; set; }
        public double CostPrice { get; set; }

    }
    public class ProductGetDtoValidation : AbstractValidator<ProductGetDto>
    {
        public ProductGetDtoValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Bosh ola bilmez")
                .NotNull().WithMessage("Null ola bilmez")
                .MinimumLength(3).WithMessage("Min 3 olmalidir")
                .MaximumLength(100).WithMessage("Max 100 olmalidir");
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Bosh ola bilmez")
                .NotNull().WithMessage("Null ola bilmez")
                .MinimumLength(3).WithMessage("Min 3 olmalidir")
                .MaximumLength(100).WithMessage("Max 200 olmalidir");
            RuleFor(x => x.SalePrice)
            .NotEmpty().WithMessage("Bosh ola bilmez")
            .NotNull().WithMessage("Null ola bilmez");
            RuleFor(x => x.CostPrice)
           .NotEmpty().WithMessage("Bosh ola bilmez")
           .NotNull().WithMessage("Null ola bilmez");

        }
    }
}
