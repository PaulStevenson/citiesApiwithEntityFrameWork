﻿using CityInfoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI.Services
{
    public interface ICityInfoRepository
    {
        bool CityExisits(int cityId);

        IEnumerable<City> GetCities();

        City GetCity(int cityId, bool includePointsOfInterest);

        IEnumerable<PointOfInterest> GetPointOfInterests(int cityId);

        PointOfInterest GetPointOfInterest(int cityId, int pointOfInterestId);
    }
}
