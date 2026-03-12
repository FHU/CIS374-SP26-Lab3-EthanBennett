using System;

namespace Lab3;
class Program
{
    static void Main(string[] args)
    {
        MinHeap<int> heap0 = new MinHeap<int>();
            heap0.Add(160);
            heap0.Add(130);
            heap0.Add(100);
            heap0.Add(90);
            heap0.Add(60);

            heap0.Update(60, 65);
            System.Console.WriteLine(heap0.Count);
            System.Console.WriteLine(heap0.Contains(60));
            System.Console.WriteLine(heap0.Contains(65));
            // Assert.AreEqual(5, heap0.Count);
            // Assert.IsFalse(heap0.Contains(60));
            // Assert.IsTrue(heap0.Contains(65));

            heap0.Update(130, 125);
            System.Console.WriteLine(heap0.Count);
            System.Console.WriteLine(heap0.Contains(130));
            System.Console.WriteLine(heap0.Contains(125));
            // Assert.AreEqual(5, heap0.Count);
            // Assert.IsFalse(heap0.Contains(130));
            // Assert.IsTrue(heap0.Contains(125));

            heap0.Update(90, 95);
            System.Console.WriteLine(heap0.Count);
            System.Console.WriteLine(heap0.Contains(90));
            System.Console.WriteLine(heap0.Contains(95));
            // Assert.AreEqual(5, heap0.Count);
            // Assert.IsFalse(heap0.Contains(90));
            // Assert.IsTrue(heap0.Contains(95));

            heap0.Update(160, 50);
            System.Console.WriteLine(heap0.Count);
            System.Console.WriteLine(heap0.Contains(160));
            System.Console.WriteLine(heap0.Contains(50));
            System.Console.WriteLine(heap0.Peek());
            // Assert.AreEqual(5, heap0.Count);
            // Assert.IsFalse(heap0.Contains(160));
            // Assert.IsTrue(heap0.Contains(50));
            // Assert.AreEqual(50, heap0.Peek());

            // Assert.Throws<InvalidOperationException>(() => { heap0.Update(0, 10); });
    }
}


