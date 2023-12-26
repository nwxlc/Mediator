using Mediator.Requests;

namespace Mediator;

public class Calendar
{
    private CalendarMediator _mediator;

    public Calendar(CalendarMediator calendarMediator)
    {
        if (calendarMediator == null)
        {
            throw new ArgumentNullException(nameof(calendarMediator), "Недопустимое значение");
        }
        _mediator = calendarMediator;
    }

    public void OnEvent()
    {
        _mediator.Execute(new NewDayRequest());
    }
}