namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Height
        {
            get { return height; }
            set 
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value; 
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }


        public double Length
        {
            get { return length; }
            set 
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                length = value; 
            }
        }
        public double SurfaceArea()
        {
            return 2 * (Length * Width + Length * Height + Width * Height);
        }

        public double LateralSurfaceArea()
        {
            return 2 * (Length * Height + Width * Height);
        }

        public double Volume()
        {
            return Length * Width * Height;
        }

    }
}