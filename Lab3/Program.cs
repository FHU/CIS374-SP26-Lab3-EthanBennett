using System;

namespace Lab3;
class Program
{
    static void Main(string[] args)
    {

            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            MinHeap<int> heap1 = new MinHeap<int>(array);
            System.Console.WriteLine(heap1.ExtractMax());
            System.Console.WriteLine(heap1.ExtractMax());
            System.Console.WriteLine(heap1.ExtractMax());
            // Assert.AreEqual(7, heap1.ExtractMax());
            // Assert.AreEqual(6, heap1.ExtractMax());
            // Assert.AreEqual(5, heap1.ExtractMax());
        
    }
}


