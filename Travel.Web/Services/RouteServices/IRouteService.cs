using Travel.Web.DTOs.RouteDtos;

namespace Travel.Web.Services.RouteServicex
{
    public interface IRouteService
    {
        Task<List<ResultRouteDto>> GetAllByCityAsync(string city); // o şehre ait rotaları filtrelemek için bir metot
        Task<List<ResultRouteDto>> GetAllAsync();
        Task<ResultRouteDto> GetbyIdAsync(string id);
        Task CreateAsync(CreateRouteDto createRouteDto);
        Task updateAsync(UpdateRouteDto updateRouteDto);
        Task DeleteAsync(string id);

    }
}
