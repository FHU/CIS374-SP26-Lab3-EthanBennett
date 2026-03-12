using System;

namespace Lab3;
class Program
{
    static void Main(string[] args)
    {
        MaxHeap<int> heap1 = new MaxHeap<int>();

            heap1.Add(4);
            heap1.Add(3);
            heap1.Add(2);
            heap1.Add(1);
            heap1.Add(0);
            System.Console.WriteLine(heap1.Count + " Should be 5");
            // Assert.AreEqual(5, heap1.Count);
            
            System.Console.WriteLine(heap1.ExtractMax() + " Should be 4");
            // Assert.AreEqual(4, heap1.ExtractMax());

            

            // Assert.AreEqual(4, heap1.Count);
            System.Console.WriteLine(heap1.Count + " Should be 4");

            // Assert.AreEqual(3, heap1.ExtractMax());
            System.Console.WriteLine(heap1.ExtractMax() + " Should be 3");

            // Assert.AreEqual(3, heap1.Count);
            System.Console.WriteLine(heap1.Count + " Should be 3");

            // Assert.AreEqual(2, heap1.ExtractMax());
            System.Console.WriteLine(heap1.ExtractMax() + " Should be 2");

            // Assert.AreEqual(2, heap1.Count);
            System.Console.WriteLine(heap1.Count + " Should be 2");

            // Assert.AreEqual(1, heap1.ExtractMax());
            System.Console.WriteLine(heap1.ExtractMax() + " Should be 1");

            // Assert.AreEqual(1, heap1.Count);
            System.Console.WriteLine(heap1.Count + " Should be 1");

            // Assert.AreEqual(0, heap1.ExtractMax());
            System.Console.WriteLine(heap1.ExtractMax() + " Should be 0");

            // Assert.AreEqual(0, heap1.Count);
            System.Console.WriteLine(heap1.Count + " Should be 0");

            // Assert.Throws<InvalidOperationException>(() => heap1.ExtractMax());
            System.Console.WriteLine(heap1.ExtractMax() + " Should be InvalidOperationException");

            // Assert.AreEqual(0, heap1.Count);
            System.Console.WriteLine(heap1.Count + " Should be 0");

            // Assert.Throws<InvalidOperationException>(() => heap1.ExtractMax());
            System.Console.WriteLine(heap1.ExtractMax() + " Should be InvalidOperationException");

            // Assert.AreEqual(0, heap1.Count);   
            System.Console.WriteLine(heap1.Count + " Should be 0");

    }
}


