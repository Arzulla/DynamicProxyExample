

namespace DynamicProxyExample.Models.GenericHandlers
{
    public interface IQueryHandler<TQuery,TResult>
    {
        TResult Handle(TQuery query);
    }
}
