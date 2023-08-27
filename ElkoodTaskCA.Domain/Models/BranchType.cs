﻿using System.ComponentModel.DataAnnotations.Schema;
using MediatR;

namespace ElkoodTaskCA.Domain.Models;

public class BranchType : IRequest<Unit>
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(100)] public string Name { get; set; }
}