using Projekt1.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.CONTROLLER.Shapes
{
    internal class DeleteShape : Interfacial
    {
        public ApplicationDbContext DbContext { get; set; } 

        public DeleteShape(ApplicationDbContext db)
        {
            DbContext = db;
        }   

        public void Run()
        {
            Console.Clear();

            Console.WriteLine("\tDELETE A SHAPE ");
            
            foreach (var shape in DbContext.Shapes)
            {
              
                Console.WriteLine($"\nID: {shape.Type}");
                Console.WriteLine($"Shape: {shape.ShapeID}");

            }

            try
            {

                Console.WriteLine("Type in shape ID: ");
                var shapeType = Convert.ToInt32(Console.ReadLine());
                var shapeRemoval = DbContext.Shapes.First(s => s.ShapeID == shapeType);
                DbContext.Shapes.Remove(shapeRemoval);

                DbContext.SaveChanges();

               
                Console.WriteLine("\nDONE");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("\nINVALID INPUT");
                Console.ReadLine();
            }

        }
    }
}
