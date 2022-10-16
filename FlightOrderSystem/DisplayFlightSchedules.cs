using FlightOrderSystem.Models;

namespace FlightOrderSystem
{
    public class DisplayFlightSchedules
    {
        public static readonly List<Flight> flights = new List<Flight>
        {
              new Flight { Id = "1", Start = "YUL", Destination = "YYZ", ScheduledDay = "1" },
              new Flight { Id = "2", Start = "YUL", Destination = "YYC", ScheduledDay = "1"  },
              new Flight { Id = "3", Start = "YUL", Destination = "YVR", ScheduledDay = "1"  },
              new Flight { Id = "4", Start = "YUL", Destination = "YYZ", ScheduledDay = "2"  },
              new Flight { Id = "5", Start = "YUL", Destination = "YYC", ScheduledDay = "2"  },
              new Flight { Id = "6", Start = "YUL", Destination = "YVR", ScheduledDay = "2" },
        };

        public static void FlightSchedule()
        {
            Console.WriteLine("The flight schedule is:");
            foreach(var flight in flights)
            {
                Console.WriteLine($"Flight: {flight.Id}, departure: {flight.Start}, arrival: {flight.Destination}, day: {flight.ScheduledDay}");
            }

        }
    }
}
