using Windows.Devices.Geolocation;

namespace AssisticantMobile.Services
{
    public interface ILocationService
    {
        Geocoordinate Coordinate { get; }
    }
}
