
using Basket.API.Data;

namespace Basket.API.Basket.GetBasket;

public record DeleteBasketCommand(string UserName) : ICommand<DeleteBasketResult>;
public record DeleteBasketResult(bool IsSuccess);

public class DeleteBasketValidotro : AbstractValidator<DeleteBasketCommand>
{
    public DeleteBasketValidotro()
    {
        RuleFor(x => x.UserName).NotNull().WithMessage("Username is required");
    }
}

public class DeleteBasketCommmandHandler
    (IBasketRepository repository)
    : ICommandHandler<DeleteBasketCommand, DeleteBasketResult>
{
    public async Task<DeleteBasketResult> Handle(DeleteBasketCommand request, CancellationToken cancellationToken)
    {
        await repository.DeleteBasket(request.UserName, cancellationToken);
        return new DeleteBasketResult(true);
    }
}
