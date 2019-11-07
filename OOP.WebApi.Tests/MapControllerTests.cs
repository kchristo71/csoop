using System;
using System.Collections.Generic;
using NUnit.Framework;
using OOP.DataLayer.Contracts;
using OOP.Domain.Contracts;
using OOP.Domain.Implementations;
using OOP.WebAPI.Controllers;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MapDataAccessShouldBeNotNull()
        {
            // arrange

            // act-assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                new MapController(null);
            });
        }

        [Test]
        public void Save_HappyDay()
        {
            // arrange
            const string MapName = "Map1";
            var mapDataAccess = new MapDataAccessMock();
            var controller = new MapController(mapDataAccess);
            var map = Map.NewMap();
            map.Name = MapName; 

            // act
            controller.Save(map);

            // assert
            Assert.IsNotNull(controller.MapDataAccess);
            Assert.AreEqual(mapDataAccess, controller.MapDataAccess);
            Assert.IsNotNull(mapDataAccess.MapToSave);
            Assert.AreEqual(map, mapDataAccess.MapToSave);
        }

        [Test]
        public void SaveMapWithName_HappyDay()
        {
            // arrange
            const string MapName = "Map1";
            var mapDataAccess = new MapDataAccessMock();
            var controller = new MapController(mapDataAccess);

            // act
            controller.NewMap(MapName);

            // assert
            Assert.IsNotNull(controller.MapDataAccess);
            Assert.AreEqual(mapDataAccess, controller.MapDataAccess);
            Assert.IsNotNull(mapDataAccess.MapToSave);
            Assert.AreEqual(MapName, mapDataAccess.MapToSave.Name);
            Assert.AreNotEqual(Guid.Empty, mapDataAccess.MapToSave.Id);
        }

        private class MapDataAccessMock : IMapDataAccess
        {
            public IMap MapToSave { get; private set; }
            public IMap Get(Guid mapId)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<IMap> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Save(IMap map)
            {
                MapToSave = map;
            }
        }
    }
}