﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ElkoodTaskCA.Contracts.Dtos.MainDtos;

namespace ElkoodTaskCA.Domain.Repositories;

public interface IProductProducedService
{
    Task<List<ProductProducedDetailsDto>> GetAllProductProduced(string companyName, DateTime startDate,
        DateTime endDate);

    Task<bool> IsValidCompanyName(string companyName);
}