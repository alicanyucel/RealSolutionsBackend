using MediatR;

namespace NTierArchitecture.Business.Features.Products.RemoveProductById;
public sealed record RemoveProductByIdCommand(
    int Id): IRequest;
