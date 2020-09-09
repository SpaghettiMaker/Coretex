using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Coretex.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime AddDate { get; set; }

        public string VehicleName { get; set; }
        public decimal VehicleSpeed { get; set; }
        public decimal VehicleLatitude { get; set; }
        public decimal VehicleLongitude { get; set; }
        public decimal VehicleTemperature { get; set; }
        public decimal VehiclePressure { get; set; }

        public string DriverName { get; set; }
        public string DriverAddress { get; set; }
        public string DriverLicense { get; set; }
    }
}
