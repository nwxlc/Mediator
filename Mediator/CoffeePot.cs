namespace Mediator.Requests;

public class CoffeePot
{
    public void Check(NewDayRequest request)
    {
        if (request == null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        var day = request.DateOnly.DayOfWeek;
        if (day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
        {
            Console.WriteLine("Сегодня выходной");
        }
        else
        {
            Console.WriteLine("Сегодня будний день");
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("Кофе готовится");
            }
        }
    }

    public void Check(AlarmRequest request)
    {
        if (request == null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        Console.WriteLine($"Кофе будет готов в {request.TimeOnly}");
    }
}