namespace Ordering.Application.Orders.Querys.GetOrdersByName;

public record GetOrdersByCustomerQuery(Guid CustomerId) 
    : IQuery<GetOrdersByCustomerResult>;

public record GetOrdersByCustomerResult(IEnumerable<OrderDto> Orders);
