using FlightOrderSystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightOrderSystem.Interfaces
{
    public class FileService : IFileService
    {
        public List<Tuple<string, OrderDetail>> GetOrderDetails()
        {
            string json = File.ReadAllText("E:\\technicalassessment\\FlightOrderSystem\\FlightOrderSystem\\Data\\coding-assigment-orders.json");

            var orders = JsonConvert.DeserializeObject<Dictionary<string, OrderDetail>>(json);
            return orders.Select(x => Tuple.Create(x.Key, x.Value)).ToList();
        }

    }
}
