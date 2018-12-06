using System;

namespace InheritTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Base bs = new Child();
            bs.Test1();
            //bs.Test2();
        }
    }
}
