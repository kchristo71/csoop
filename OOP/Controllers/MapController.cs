using System;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using OOP.DataLayer.Contracts;
using OOP.Domain.Contracts;
using OOP.Domain.Implementations;

namespace OOP.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapController : ControllerBase
    {
        public IMapDataAccess MapDataAccess { get; }

        public MapController(IMapDataAccess dataAccess)
        {
            MapDataAccess = dataAccess ?? throw new ArgumentNullException($"Null dependency injected {nameof(dataAccess)}");
        }

        [HttpPost]
        public void Save(Map map)
        {
            MapDataAccess.Save(map);
        }

        [HttpPost("WithName")]
        public void NewMap(string name)
        {
            var map = Map.NewMap();
            map.Name = name;

            MapDataAccess.Save(map);
        }
    }
}