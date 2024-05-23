namespace ModuleReview
{
     class ModuleOneReview
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number higher than zero");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter one more number higher than zero");
            double y = double.Parse(Console.ReadLine());


            SquareArea(x);

            CalculateAreaRectangle(x, y);

            CalculateAreaTriangle(x, y);

            CalculateArea(y);
        }

        public static double SquareArea(double side)
        {
            double area = side * side;
            Console.WriteLine($"{area}");
            return area;
        }

        public static double CalculateAreaRectangle(double length, double width)
        {
           
            if (length < 0 || width < 0)
            {
                throw new ArgumentException("Length and width cannot be negative.");
            }

            // Calculate the area using the formula
            double area = length * width;
            Console.WriteLine($"{area}");
            return area; 
        }

        public static double CalculateAreaTriangle(double baseLength, double height)
        {
          

            // Check if the base length or height is negative
            if (baseLength < 0 || height < 0)
            {
                throw new ArgumentException("Base length and height cannot be negative.");
            }

            // Calculate the area using the formula
            double area = 0.5 * baseLength * height;
            Console.WriteLine($"{area}");
            return area;
        }

        public static double CalculateArea(double radius)
        {
            
            if (radius < 0)
            {
                throw new ArgumentException("Radius cannot be negative.");
            }

            // Calculate the area using the formula
            double area = Math.PI * radius * radius;
            Console.WriteLine($"{area}");
            return area;
        }


    }

}

