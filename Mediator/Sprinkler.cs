using Mediator.Requests;

namespace Mediator;

public class Sprinkler
{
    public void Check(CalendarEventRequest request)
    {
        if (request == null)
        {
            throw new ArgumentNullException(nameof(request), "Недопустимое значение");
        }
           
        Console.WriteLine($"Система орошения будет включена {request.DateOnly}");
            
    }

    public void Check(AlarmRequest request)
    {
        if (request == null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        Console.WriteLine($"Система орошения будет включена {request.TimeOnly}");
    }
}