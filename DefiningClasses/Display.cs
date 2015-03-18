namespace DefiningClasses
{
    using System;

    public class Display
    {
        private double diagonal;
        private int displayColors;

        public double Diagonal
        {
            get
            {
                return this.diagonal;
            }
            private set
            {
                if (value == 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Display size should be less than 10!");
                }
                else
                {
                    this.diagonal = value;
                }
            }
        }

        public int DisplayColors
        {
            get
            {
                return this.displayColors;
            }
            private set
            {
                if (value < 256 || value > int.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("The number of display colors should be 256 or more!");
                }
                else
                {
                    this.displayColors = value;
                }
            }
        }

        public Display() : this(3.5, 256)
        {

        }

        public Display(double size) : this(size, 256)
        {

        }

        public Display(double size, int colors)
        {
            this.Diagonal = size;
            this.DisplayColors = colors;
        }

        public override string ToString()
        {
            return String.Format("Diagonal length: {0}, Display colors: {1}",
                this.Diagonal, this.DisplayColors);
        }
    }
}
