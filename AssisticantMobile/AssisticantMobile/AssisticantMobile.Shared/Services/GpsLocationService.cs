using Assisticant.Fields;
using System;
using Windows.Devices.Geolocation;

namespace AssisticantMobile.Services
{
    public class GpsLocationService : ILocationService
    {
        private Geolocator _geolocator;
        private Observable<Geocoordinate> _coordinate = new Observable<Geocoordinate>();

        public GpsLocationService()
        {
            _geolocator = new Geolocator();
            _geolocator.MovementThreshold = 3.0;
        }

        public Geocoordinate Coordinate
        {
            get
            {
                lock (this)
                {
                    return _coordinate;
                }
            }
        }
    }
}
