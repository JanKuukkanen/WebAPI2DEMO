using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI2DEMO.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public float Price { get; set; }
        public string Url { get; set; }
    }
}