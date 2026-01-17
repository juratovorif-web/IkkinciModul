using lesson4.Models;
using lesson4.Models2;
using System.Globalization;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //DomesticAnimal domesticAnimal = new DomesticAnimal("Rex");

            //Dog dog = new Dog();



            //Dog dog1 = new Dog()
            //{
            //    Color = "Black",
            //    Weight = 15,
            //    Height = 50,
            //    Speed = 30,
            //    NickName = "Balu"

            //};

            //dog1.Sound();


            //Cat cat1 = new Cat()
            //{
            //    Color = "Black",
            //    Weight = 2,
            //    Height = 20,
            //    Speed = 55,
            //    NickName = "Tigr"
            //};

           
            Point3D point3D = new Point3D(3,4,5);
           
        }

        
        
        class Point2D 
        {
            public Point2D(int x, int y)
            {
                X = x;
                Y = y;
                Console.WriteLine("Point2D caqrldi");
            }
            public int X {  get; set; }
            public int Y { get; set; }
        }

        class Point3D : Point2D
        {
            public Point3D(int x,int y, int z):base(x,y)
            {
                Z = z;
                Console.WriteLine("Point3D caqrldi");
            }
            public int Z { get; set; }
        }
      
       
             
            














    }
}
