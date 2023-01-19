using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.CONTROLLER.Shapes
{
    public class SeeShapes : Interfacial
    {
        public ApplicationDbContext DbContext { get; set; }
        public SeeShapes(ApplicationDbContext db)
        {
            DbContext= db;
        }

        public void Run()
        {
            Console.Clear();

            Console.WriteLine("\tALL SHAPES AND CALCULATIONS ");

            foreach (var shapes in DbContext.Shapes)
            {
                Console.WriteLine($"\nID: {shapes.ShapeID}");
                Console.WriteLine($"Shape: {shapes.Type}");
                Console.WriteLine($"Area: {shapes.Area}cm");
                Console.WriteLine($"Perimeter {shapes.Perimeter}cm");
            }

            Console.WriteLine("\n Press to Exit");
            Console.ReadLine();
        }
    }
}
