using MediatR;

namespace NTierArchitecture.Business.Features.Categories.UpdateCategory;
public sealed record UpdateCategoryCommand(
    int Id,
    string Name): IRequest;
