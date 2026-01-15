namespace Ordering.Application.Orders.Querys.GetOrdersByName;

public record GetOrdersQuery(PaginationRequest PaginationRequest) 
    : IQuery<GetOrdersResult>;

public record GetOrdersResult(PaginationResult<OrderDto> Orders);
