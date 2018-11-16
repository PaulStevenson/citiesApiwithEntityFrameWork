using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfoAPI.Entities;
using CityInfoAPI.Models;

namespace CityInfoAPI
{
    public static class CityInfoContextExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            var cities = new List<City>()
            {


                new City()
                {
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Central Park",
                            Description = "Most visited urban park in the USA."
                        },
                        new PointOfInterest()
                        {
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper."
                        },
                    }

                },

                new City()
                {
                    Name = "Antwerp",
                    Description = "The one with the Cathedral that was never really finished.",
                    PointOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Some Cathedral",
                            Description = "It's half built."
                        },
                        new PointOfInterest()
                        {
                            Name = "No idea",
                            Description = "Never been."
                        },
                    }
                },

                new City()
                {
                    Name = "Paris",
                    Description = "Capital of France",
                    PointOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Eiffle Tower",
                            Description = "Big metal thing"
                        },
                        new PointOfInterest()
                        {
                            Name = "Mona Lisa Painting",
                            Description = "A cheeky grin."
                        },
                    }
                }


            };

            context.Cities.AddRange(cities);
            context.SaveChanges();

        }
    }
}