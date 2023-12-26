using Mediator;
using Mediator.Requests;

AlarmMediator alarmMediator = new(new CoffeePot(), new Sprinkler());
CalendarMediator calendarMediator = new(new CoffeePot(), new Sprinkler());

Alarm alarm = new(alarmMediator);
Calendar calendar = new(calendarMediator);

calendar.OnEvent();
alarm.OnEvent();