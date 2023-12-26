namespace Mediator.Requests;

public class CalendarRequest : IRequest
{
    public DateOnly DateOnly { get; private set; }

    public CalendarRequest(DateOnly dateOnly)
    {
        DateOnly = dateOnly;
    }
}