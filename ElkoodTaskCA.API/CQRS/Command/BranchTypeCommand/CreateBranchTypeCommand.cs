﻿using MediatR;

namespace ElkoodTaskCA.API.CQRS.Command.BranchTypeCommand;

public class CreateBranchTypeCommand : IRequest<BranchType>
{
    [MaxLength(100)] public string Name { get; set; }
}