
using Microsoft.Extensions.Logging;

namespace Catalog.API.Products.DeleteProduct;

public record DeleteProductCommand(Guid Id) : ICommand<DeleteProductResult>;

public record DeleteProductResult(bool isSuccess);

internal class DeleteProductHandler
    (IDocumentSession session, ILogger<GetProductByIdQueryHandler> logger)
    : ICommandHandler<DeleteProductCommand, DeleteProductResult>
{
    public async Task<DeleteProductResult> Handle(DeleteProductCommand command, CancellationToken cancellationToken)
    {
        logger.LogInformation("DeleteProductHandler.Handle called with {@Command}", command);

        session.Delete<Product>(command.Id);
        await session.SaveChangesAsync();

        return new DeleteProductResult(true);
    }
}
