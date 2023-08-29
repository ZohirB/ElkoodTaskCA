using MediatR;

namespace ElkoodTaskCA.Application.CQRS.BranchType.Commands.Create;

public class CreateBranchTypeCommand : IRequest<Domain.Models.MainEntities.BranchType>
{
    [MaxLength(100)] public string Name { get; set; }
}