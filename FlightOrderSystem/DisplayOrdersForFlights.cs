using FlightOrderSystem.Interfaces;
using FlightOrderSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightOrderSystem
{
    public class DisplayOrdersForFlights
    {
        public static void GetOrderDetailsForFlights()
        {
            FileService fileService = new FileService();
            var OrderData = fileService.GetOrderDetails();
            var FlightData = DisplayFlightSchedules.flights;
            var FlightOrderResult = (from o in OrderData
                         join f in FlightData
                         on o.Item2.destination equals f.Destination into t
                         from f1 in t.DefaultIfEmpty()
                         select new
                         {
                             order = o.Item1,
                             flightNumber = f1 == null ? "not scheduled" : f1.Id,
                             departure = f1 == null ? string.Empty : f1.Start,
                             arrival = f1 == null ? string.Empty : f1.Destination,
                             day = f1 == null ? string.Empty : f1.ScheduledDay
                         }).ToList();
            Console.WriteLine();
            Console.WriteLine("The order itineraries");
            foreach(var result in FlightOrderResult)
            {
                if (result.flightNumber != "not scheduled")
                {
                    Console.WriteLine($"order: {result.order}, flightNumber: {result.flightNumber} ,departure: {result.departure}, arrival: {result.arrival}, day: {result.day}");
                }
                else
                {
                    Console.WriteLine($"order: {result.order}, flightNumber: {result.flightNumber}");
                }

            }
        }
    }
}
