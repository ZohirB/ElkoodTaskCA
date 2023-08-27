using Elkood.Application.OperationResponses;
using ElkoodTaskCA.Contracts.Models;
using MediatR;

namespace ElkoodTaskCA.Contracts.CQRS.Command.BranchInfoCommand;

public class CreateBranchInfoCommand : IRequest<OperationResponse<BranchInfo>>
{
    [MaxLength(100)] public string Name { get; set; }

    public int BranchTypeId { get; set; }

    public int CompanyInfoId { get; set; }

    [MaxLength(100)] public string Location { get; set; }
}