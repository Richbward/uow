using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uow.Entities;

namespace uowAPI.Entities.Configuration
{
    public class GarageConfiguration : IEntityTypeConfiguration<Garage>
    {
        public void Configure(EntityTypeBuilder<Garage> builder)
        {
            builder.ToTable("Garages");

            builder.HasData(
                new Garage
                {
                    Id = new Guid("F98FAC6E-5CBF-42BE-8CFB-1A22CCD224D1"),
                    Name = "NYC Parking West 145th Garage Corp.",
                    Street1 = "53 Bradhurst Ave",
                    City = "New York",
                    State = "NY",
                    Zip = "10039",
                    Contact = "Josh Murdock",
                    Phone = "(646) 243-6930",
                    ClientSince = new DateTime(1969,03,03),
                    Active = true
                },
                new Garage
                {
                    Id = new Guid("454EDE90-B9E4-472C-A4BE-762145BC6149"),
                    Name = "iPark - Hudson Yards Parking",
                    Street1 = "552 W 30th St",
                    City = "New York",
                    State = "NY",
                    Zip = "10001",
                    Contact = "Alyssa Grittani",
                    Phone = "(212) 243-1234",
                    Url = "https://www.spotangels.com/#id=2152284&?ref=google_maps_website",
                    ClientSince = new DateTime(1982,03,07),
                    Active = true
                },
                new Garage
                {
                    Id = new Guid("D594BF03-422C-4009-89B3-98460D6C4A10"),
                    Name = "NYC Parking 80 John Garage Corp.",
                    Street1 = "27 Platt St",
                    City = "New York",
                    State = "NY",
                    Zip = "10038",
                    Contact = "Theodore Syrianos",
                    Phone = "(315) 599-2737",
                    Url = "https://www.bestparking.com/new-york-ny-parking/",
                    ClientSince = new DateTime(1989, 04, 01),
                    Active = true
                },
                new Garage
                {
                    Id = new Guid("48BD5AFF-5D85-4EE3-8CF3-B53286093530"),
                    Name = "NYC Parking West 90TH Garage Corp.",
                    Street1 = "103 W 90th St",
                    City = "New York",
                    State = "NY",
                    Zip = "10024",
                    Contact = "Eleanor Cortez",
                    Phone = "(212) 721-5265",
                    Url = "https://www.spotangels.com/#id=2151849&?ref=google_maps_website",
                    ClientSince = new DateTime(1975, 06, 17),
                    Active = true
                },
                new Garage
                {
                    Id = new Guid("9213E455-CE51-44CA-99FA-D9B5046DE802"),
                    Name = "Continental Garage Parking - Tower 111 Garage Parking NYC",
                    Street1 = "103 W 90th St",
                    City = "New York",
                    State = "NY",
                    Zip = "10001",
                    Contact = "Elizabeth Lee",
                    Phone = "(800) 836-6666",
                    Url = "https://www.spotangels.com/#id=2152373&?ref=google_maps_website",
                    ClientSince = new DateTime(1979, 08, 22),
                    Active = true
                }
            );
        }
    }
}
