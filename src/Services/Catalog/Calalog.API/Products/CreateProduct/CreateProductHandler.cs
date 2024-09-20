using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildingBlocks.CQRS;
using Calalog.API.Models;
using MediatR;

namespace Calalog.API.Products.CreateProduct;

public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price) : ICommand<CreateProductResult>;
public record CreateProductResult(Guid Id);
internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        // create product entity from command object
        var product = new Product
        {
            Name = command.Name,
            Category = command.Category,
            Description = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price
        };

        // save to database

        // return CreateProductResult
        return new CreateProductResult(Guid.NewGuid());
    }
}