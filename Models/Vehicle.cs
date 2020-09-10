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
        [Display(Name = "Add Date")]
        [DataType(DataType.Date)]
        public DateTime AddDate { get; set; }
        [Display(Name = "Vehicle Name")]
        public string VehicleName { get; set; }
        [Display(Name = "Vehicle Speed")]
        public decimal VehicleSpeed { get; set; }
        [Display(Name = "Vehicle Latitude")]
        public decimal VehicleLatitude { get; set; }
        [Display(Name = "Vehicle Longitude")]
        public decimal VehicleLongitude { get; set; }
        [Display(Name = "Vehicle Temperature")]
        public decimal VehicleTemperature { get; set; }
        [Display(Name = "Vehicle Pressure")]
        public decimal VehiclePressure { get; set; }
        [Display(Name = "Driver Name")]
        public string DriverName { get; set; }
        [Display(Name = "Driver Address")]
        public string DriverAddress { get; set; }
        [Display(Name = "Driver License")]
        public string DriverLicense { get; set; }
    }
}
