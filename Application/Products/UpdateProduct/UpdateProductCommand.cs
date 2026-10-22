using Application.Common.Interfaces;
using MediatR;

namespace Application.Products.Commands.UpdateProduct;

public record UpdateProductCommand(
    Guid Id,
    string Sku,
    string Name,
    string Description,
    decimal Price
) : IRequest<Unit>;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
{
    private readonly IApplicationDbContext _context;

    public UpdateProductCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _context.Products.FindAsync(new object[] { request.Id }, cancellationToken);

        if (product != null)
        {
            product.SKU = request.Sku; // Ekhane SKU boro hater hobe
            product.Name = request.Name;
            product.Description = request.Description;
            product.Price = request.Price;

            await _context.SaveChangesAsync(cancellationToken);
        }

        return Unit.Value;
    }
}