namespace AlgoPractise_Design_Principles
{
    public static class LiskovSubstitution
    {
        static public int Area(Rectangle r) => r.Width* r.Height;

        static void Main()
        {
            Rectangle rc = new Rectangle(2,3);
            System.Console.WriteLine($"area is : {Area(rc)}");

            
            
        }
    }
   

    public class Rectangle
    {

        public virtual int Width {get; set;}
        public virtual int Height { get; set; }
        
        public override string ToString()
        {
            return $"Width : {Width}, Heught : {Height}";
        }
        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }

        public Rectangle()
        {
            
        }

       
    }

    public class Square : Rectangle
    {
        public override int Width { set{base.Width = base.Height = value;} }
        public override int Height { set{base.Width = base.Height = value;} }
        
    }
}