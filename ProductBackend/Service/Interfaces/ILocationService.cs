namespace ProductBackend.Service.Interfaces
{
    public interface ILocationService
    {
        Task AddLocation(string street, int houseNumber, string city, string zipCode);
    }
}
