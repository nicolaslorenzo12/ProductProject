using ProductBackend.Dto;

namespace ProductBackend.Service.Interfaces
{
    public interface ILocationService
    {
        Task AddLocation(LocationDto locationDto);
        Task DeleteLocation(int locationId);
    }
}
