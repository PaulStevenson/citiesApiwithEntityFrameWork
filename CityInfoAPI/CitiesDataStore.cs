using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfoAPI.Models;
using Microsoft.EntityFrameworkCore.Design;

namespace CityInfoAPI
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "Most visited urban park in the USA."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper."
                        },
                    }

                },

                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the Cathedral that was never really finished.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Some Cathedral",
                            Description = "It's half built."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "No idea",
                            Description = "Never been."
                        },
                    }


                },

                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "Capital of France",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Eiffle Tower",
                            Description = "Big metal thing"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Mona Lisa Painting",
                            Description = "A cheeky grin."
                        },
                    }


                }

            };
        }
    }
}

