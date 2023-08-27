using ElkoodTaskCA.Contracts.Models;
using MediatR;

namespace ElkoodTaskCA.Contracts.CQRS.Command.BranchTypeCommand;

public class CreateBranchTypeCommand : IRequest<BranchType>
{
    [MaxLength(100)] public string Name { get; set; }
}