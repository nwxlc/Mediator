using Mediator.Requests;

namespace Mediator;

public class CalendarMediator : IMediator
{
    private CoffeePot _coffeePot;
    private Sprinkler _sprinkler;

    public CalendarMediator(CoffeePot coffeePot, Sprinkler sprinkler)
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
            throw new ArgumentNullException(nameof(request));
        }

        if (request is NewDayRequest newDayRequest)
        {
            _coffeePot.Check(newDayRequest);
        }

        if (request is CalendarEventRequest calendarRequest)
        {
            _sprinkler.Check(calendarRequest);
        }
    }
}