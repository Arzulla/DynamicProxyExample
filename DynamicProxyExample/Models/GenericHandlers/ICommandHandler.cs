

namespace DynamicProxyExample.Models.GenericHandlers
{
    public interface ICommandHandler<TCommand>
    {
        void Handle(TCommand command);
    }
}
