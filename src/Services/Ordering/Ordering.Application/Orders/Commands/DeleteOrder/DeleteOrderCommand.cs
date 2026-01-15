using FluentValidation;
using Ordering.Application.Orders.Commands.UdpateOrder;

namespace Ordering.Application.Orders.Commands.DeleteOrder;

public record DeleteOrderCommand(Guid OrderId)
    : ICommand<DeleteOrderResult>;

public record DeleteOrderResult (bool IsSuccess);

public class DeleteOrderResultOrderCommandValidator : AbstractValidator<DeleteOrderCommand>
{
    public DeleteOrderResultOrderCommandValidator()
    {
        RuleFor(x => x.OrderId).NotEmpty().WithMessage("orderId is required");
    }
}


