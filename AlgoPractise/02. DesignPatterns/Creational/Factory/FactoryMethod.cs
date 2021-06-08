

using System;


namespace DP.Creational.Factory
    {
    public class Point
    {
        private double x,y;

        internal Point(double x, double y){
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"X = {this.x} and y = {this.y}";
        }

        public static Point PointOrigin = new Point(0,0);

        public static class Factory{

            public static Point NewCartesianPoint(double x, double y){

                var point = new Point(x,y);
                return point;
            }

            public static Point NewPolarPoint(double rho, double theta)
            {
                var point = new Point(rho* Math.Cos(theta), rho * Math.Sin(theta));
                return point;
            }
        }


    }


    public static class ExecuteFactory
    {
        public static void Run()
        {
            var polarPoint = Point.Factory.NewPolarPoint(42,1).ToString();
            Console.WriteLine(polarPoint);

            var curtesianPoint = Point.Factory.NewCartesianPoint(15,23);
            Console.WriteLine(curtesianPoint);




        }

    }
}