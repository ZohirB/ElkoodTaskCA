using ElkoodTaskCA.Domain.Entities.General;
using MediatR;

namespace ElkoodTaskCA.Application.BranchTypes.Commands.Create;

public class CreateBranchTypeCommand : IRequest<BranchType>
{
    [MaxLength(100)] public string Name { get; set; }
}