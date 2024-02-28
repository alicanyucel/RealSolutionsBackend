using MediatR;

namespace NTierArchitecture.Business.Features.Categories.RemoveCategoryById;
public sealed record RemoveCategoryByIdCommand(
    int Id): IRequest;
