namespace Mediator.Requests;

public class AlarmRequest : IRequest
{
    public TimeOnly TimeOnly { get; private set; }

    public AlarmRequest(TimeOnly timeOnly)
    {
        TimeOnly = timeOnly;
    }
}