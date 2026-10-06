using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate < DateTime.Now;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        return appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
    }
}

class AppointmentProgram
{
    static void Main(string[] args)
    {
        // 1. Agendar una cita
        string dateText = "7/25/2026 13:45:00";
        DateTime appointment = Appointment.Schedule(dateText);
        Console.WriteLine($"Cita agendada: {appointment}");

        // 2. Comprobar si ya pasó la fecha
        bool passed = Appointment.HasPassed(appointment);
        Console.WriteLine($"¿Ya pasó la cita?: {passed}");

        // 3. Comprobar si es en la tarde (12:00 a 17:59)
        bool isAfternoon = Appointment.IsAfternoonAppointment(appointment);
        Console.WriteLine($"¿Es en la tarde?: {isAfternoon}");

        // 4. Mostrar la descripción
        string description = Appointment.Description(appointment);
        Console.WriteLine(description);

        // 5. Fecha de aniversario del año en curso
        DateTime anniversary = Appointment.AnniversaryDate();
        Console.WriteLine($"Fecha de aniversario: {anniversary}");
    }
}