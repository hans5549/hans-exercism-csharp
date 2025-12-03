namespace Examer.Extension;

public static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        if (string.IsNullOrWhiteSpace(appointmentDateDescription)) 
        {
            throw new ArgumentException("Appointment date description cannot be null or empty.");
        }

        if (DateTime.TryParse(appointmentDateDescription, out DateTime appointmentDate))
        {
            return appointmentDate;
        }
        else
        {
            throw new NotImplementedException("Please implement the (static) Appointment.Schedule() method");
        }
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate < DateTime.Now;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        TimeOnly startAfternoon = new TimeOnly(12, 0);
        TimeOnly endAfternoon = new TimeOnly(18, 00);
        TimeOnly time = TimeOnly.FromDateTime(appointmentDate);
        if (startAfternoon <= time && time < endAfternoon)
        {
            return true;
        }
        return false;
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate.ToString("M/d/yyyy h:mm:ss tt")}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
    }
}