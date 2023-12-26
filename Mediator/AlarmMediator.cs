using Mediator.Requests;

namespace Mediator;

public class AlarmMediator : IMediator
{
    private CoffeePot _coffeePot;
    private Sprinkler _sprinkler;

    public AlarmMediator(CoffeePot coffeePot, Sprinkler sprinkler)
    {
        if (coffeePot == null)
        {
            throw new ArgumentNullException(nameof(coffeePot), "Недопустимое значение");
        }

        if (sprinkler == null)
        {
            throw new ArgumentNullException(nameof(sprinkler), "Недопустимое значение");
        }

        _coffeePot = coffeePot;
        _sprinkler = sprinkler;
    }

    public void Execute(IRequest request)
    {
        if (request == null)
        {
            throw new ArgumentNullException(nameof(request), "Недопустимое значение");
        }

        if (request is AlarmRequest alarmRequest)
        {
            _coffeePot.Check(alarmRequest);
            _sprinkler.Check(alarmRequest);
        }
    }
}