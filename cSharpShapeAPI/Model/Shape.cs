using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharpShapeAPI.Model
{
    public class Shape
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public double width { get; set; } = 0;
        public double height { get; set; } = 0;
        public double perimeter { get; set; } = 0;
        public double area { get; set; } = 0;

    }
}
