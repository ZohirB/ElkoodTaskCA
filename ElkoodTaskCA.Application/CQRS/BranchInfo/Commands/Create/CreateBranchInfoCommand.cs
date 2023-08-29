using Elkood.Application.OperationResponses;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.BranchInfo.Commands.Create;

public class CreateBranchInfoCommand : IRequest<OperationResponse<Domain.Models.MainEntities.BranchInfo>>
{
    [MaxLength(100)] public string Name { get; set; }

    public int BranchTypeId { get; set; }

    public int CompanyInfoId { get; set; }

    [MaxLength(100)] public string Location { get; set; }
}