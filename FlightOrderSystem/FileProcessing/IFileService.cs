using FlightOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightOrderSystem.Interfaces;
public interface IFileService
{
    public List<Tuple<string, OrderDetail>> GetOrderDetails();  
}

