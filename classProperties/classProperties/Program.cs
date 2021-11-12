using System;

namespace classProperties
{
    public class Shape
    {
        private int Sides;
        public int GetSides()
        {
            return Sides;
        }

        public void SetSides(int value)
        {
            if (value > 2) Sides = value;
        }
    }
}
