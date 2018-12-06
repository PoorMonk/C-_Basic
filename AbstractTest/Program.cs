using System;

namespace AbstractTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paint paint = new Paint();
            Paint paint = new LandscapePainting();
            paint.Show();
        }
    }
}
