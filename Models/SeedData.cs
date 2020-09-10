using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Coretex.Data;

namespace Coretex.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CoretexContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CoretexContext>>()))
            {
                // Look for any movies.
                if (context.Vehicle.Any())
                {
                    return;   // DB has been seeded
                }

                context.Vehicle.AddRange(
                    new Vehicle
                    {
                        AddDate = DateTime.Now,
                        VehicleName = "Default Vehicle",
                        VehicleSpeed = 0,
                        VehicleLatitude = 1,
                        VehicleLongitude = 2,
                        VehicleTemperature = 20,
                        VehiclePressure = 100,
                        DriverName = "Bob",
                        DriverAddress = "Adress1",
                        DriverLicense = "123yes"
                    }
                );
                context.SaveChanges();
            }
        }
    }

}
