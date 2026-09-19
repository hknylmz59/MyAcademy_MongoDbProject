using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Travel.Web.DTOs.RouteDtos;
using Travel.Web.Services.RouteServicex;

namespace Travel.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RouteController(IRouteService _routeService, IMapper _mapper) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var routes = await _routeService.GetAllAsync();
            return View(routes);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost] 
        public async Task<IActionResult> Create(CreateRouteDto routeDto)
        {
            if (!ModelState.IsValid)
            {
                return View(routeDto);
            }
            await _routeService.CreateAsync(routeDto);
            return RedirectToAction("Index");
        }
    }
}
