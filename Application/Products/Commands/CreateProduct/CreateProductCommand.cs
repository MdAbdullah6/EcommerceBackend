using MediatR;

namespace Application.Products.Commands.CreateProduct;

// 1. The Command Request
public record CreateProductCommand(
    string Name,
    string Description,
    decimal Price,
    int Stock,
    string SKU
) : IRequest<Guid>; // Returns the newly created Product's Id