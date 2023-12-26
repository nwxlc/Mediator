using Mediator.Requests;

namespace Mediator;

public interface IMediator
{
    public void Execute(IRequest request);
}