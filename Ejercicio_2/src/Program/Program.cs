using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            //Console.WriteLine(appointmentResult);
            Patient StevenJhonson = new Patient("Steven Jhonson", "", "5555-555-555", "24");
            Doctor Armand = new Doctor("Armand", "123123", "Cardiología");
            string newAppointments = AppointmentService.CreateAppointment(StevenJhonson, Armand, DateTime.Now, "Wall Street");

            Console.WriteLine(newAppointments);
            //string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            //string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            //Console.WriteLine(appointmentResult2);
        }
    }
}