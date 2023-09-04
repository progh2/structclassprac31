using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structclassprac31
{
    internal class Program
    {
        class PointClass
        {
            public int x;
            public int y;
            public PointClass(int x, int y)
            {
                this.x = x; this.y = y;
            }
        }
        struct PointStruct
        {
            public int x;
            public int y;
            public PointStruct(int x, int y)
            {
                this.x = x; this.y = y;
            }
        }
        static void Main(string[] args)
        {
            PointClass pcA = new PointClass(10, 20);
            PointClass pcB = pcA;
            pcB.x = 100;
            pcB.y = 200;
            Console.WriteLine($"pcA: {pcA.x}, {pcA.y}");
            Console.WriteLine($"pcB: {pcB.x}, {pcB.y}");
            Console.WriteLine();
            PointStruct psA = new PointStruct(10, 20);
            PointStruct psB = psA;
            psB.x = 100;
            psB.y = 200;
            Console.WriteLine($"psA: {psA.x}, {psA.y}");
            Console.WriteLine($"psB: {psB.x}, {psB.y}");
            Console.WriteLine();
        }
    }
}
