using Elkood.Application.OperationResponses;
using ElkoodTaskCA.Domain.Entities.General;
using MediatR;

namespace ElkoodTaskCA.Application.BranchInfos.Commands.Create;

public class CreateBranchInfoCommand
{
    public class Request : IRequest<OperationResponse<BranchInfo>>
    {
        [MaxLength(100)] public string Name { get; set; }

        public int BranchTypeId { get; set; }
        
        public int CompanyInfoId { get; set; }

        [MaxLength(100)] public string Location { get; set; }
        
    }
}