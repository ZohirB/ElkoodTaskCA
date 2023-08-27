﻿using ElkoodTaskCA.API.CQRS.Queries.ProductTypeQuery;
using ElkoodTaskCA.API.Repositories.ProductTypeRepository;
using MediatR;

namespace ElkoodTaskCA.API.CQRS.Handlers.ProductTypeHandler;

public class GetProductTypeHandler : IRequestHandler<GetProductTypeQuery, IEnumerable<ProductType>>
{
    private readonly IProductTypesService productTypesService;

    public GetProductTypeHandler(IProductTypesService productTypesService)
    {
        this.productTypesService = productTypesService;
    }

    public async Task<IEnumerable<ProductType>> Handle(GetProductTypeQuery request, CancellationToken cancellationToken)
    {
        var productTypes = await productTypesService.GetAllProductTypes();
        return productTypes;
    }
}