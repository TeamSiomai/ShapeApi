using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cSharpShapeAPI.Model;

namespace cSharpShapeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShapesController : ControllerBase
    {
        List<Shape> _Shapes = new List<Shape>()
        {
            new Shape () {Id =1 ,Name="rectangle",height = 7,width = 5},
            new Shape () {Id =2 ,Name="square",height = 12,width = 3},
            new Shape () {Id =3 ,Name="rhombus",height = 1,width = 5}
            //new Shape () {Id =2 ,Name="Square"}
        };
        [HttpGet]
        public IActionResult Gets()
        {
            if (_Shapes.Count == 0)
            {
                return NotFound("Shapes List not found!");
            }
            return Ok(_Shapes);
        }
        [HttpGet("GetShape")]
        public IActionResult Get(int Id)
        {
            var shapes = _Shapes.SingleOrDefault(x => x.Id == Id);
            if (shapes == null)
            {
                return NotFound("Shape not found!");
            }
            shapes.area = shapes.height * shapes.width;
            shapes.perimeter = 2 * (shapes.height + shapes.width);
            return Ok(shapes);
        }

        [HttpPost]
        public IActionResult Save(Shape shape)
        {
            _Shapes.Add(shape);
            if (_Shapes.Count == 0)
            {
                return NotFound("No Shape List found!");
            }
            return Ok(_Shapes);
        }
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            var shapes = _Shapes.SingleOrDefault(x => x.Id == Id);
            if (shapes == null)
            {
                return NotFound("Shape not found!");
            }
            _Shapes.Remove(shapes);

            if (_Shapes.Count == 0)
            {
                return NotFound("No Shape List found!");
            }
            return Ok(_Shapes);
        }

    }
}
