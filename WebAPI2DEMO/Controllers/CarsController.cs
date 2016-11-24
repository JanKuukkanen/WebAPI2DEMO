using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI2DEMO.Models;

namespace WebAPI2DEMO.Controllers
{
    // Tämä kontrolleri sisältää kakis metodia Auto-tietojen palauttamiseen
    // GetAllCars metodi palauttaa kaikki autot
    // GetCar metodi palauttaa yhden auton ID:n avulla
    public class CarsController : ApiController
    {
        Car[] cars = new Car[]
        {
            new Car {Id=1, Name="Audi", Model="A4", Price=24000, Url="http://buyersguide.caranddriver.com/media/assets/submodel/7085.jpg"},
            new Car {Id=2, Name="Audi", Model="A6", Price=29000, Url="http://www.autowiki.fi/images/3/30/Audi_A6_2.0_TDI_%28C7%29_%E2%80%93_Frontansicht.jpg"},
            new Car {Id=3, Name="BMW", Model="320", Price=22000, Url="http://www.shauntmax30.com/data/out/6/967289-high-quality-bmw-320-wallpaper-full-hd-pictures.jpeg"},
            new Car {Id=4, Name="Volvo", Model="V90", Price=47000, Url="http://student.labranet.jamk.fi/~salesa/mat/VolvoV90.PNG"}
        };
        public IEnumerable<Car> GetAllCars()
        {
            return cars;
        }

        public IHttpActionResult GetCar(int id)
        {
            var car = cars.FirstOrDefault((c) => c.Id == id);
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }
    }
}
