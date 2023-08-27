using ElkoodTaskCA.Application.Models;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Command.BranchTypeCommand;

public class CreateBranchTypeCommand : IRequest<BranchType>
{
    [MaxLength(100)] public string Name { get; set; }
}