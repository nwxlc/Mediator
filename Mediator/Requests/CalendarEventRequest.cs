namespace Mediator.Requests;

public class CalendarEventRequest : CalendarRequest
{
    public CalendarEventRequest(DateOnly dateOnly)
        :base(dateOnly)
    { }
}