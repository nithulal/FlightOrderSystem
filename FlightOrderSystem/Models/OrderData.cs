using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightOrderSystem.Models;
public class OrderData
{
    public Dictionary<string, OrderDetail> Order { get; set; }
}

public class OrderDetail
{
    public string destination { get; set; }
}