using Basket.API.Data;

namespace Basket.API.Basket.GetBasket;

public record GetBasketQuery(string username): IQuery<GetBasketResult>;
public record GetBasketResult(ShoppingCart Cart);

public class GetBasketQueryHandler
    (IBasketRepository repository) : 
    IQueryHandler<GetBasketQuery, GetBasketResult>
{
    public async Task<GetBasketResult> Handle(GetBasketQuery query, CancellationToken cancellationToken)
    {
        var basket = await repository.GetBasket(query.username, cancellationToken);
        return new GetBasketResult(basket);
    }
}
