using Mediator.Requests;

namespace Mediator;

public class Alarm
{
    private AlarmMediator _mediator;

    public Alarm(AlarmMediator mediator)
    {
        if (mediator == null) 
        { 
            throw new ArgumentNullException(nameof(mediator), "Недопустимое значение"); 
        }

        _mediator = mediator;
    }

    public void OnEvent()
    {
        _mediator.Execute(new AlarmRequest(new TimeOnly(9, 30)));
    }
}