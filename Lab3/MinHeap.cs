using System;
using System.Reflection.Metadata.Ecma335;

namespace Lab3;

public class MinHeap<T> where T : IComparable<T>
{
    private T[] array;
    private const int initialSize = 8;

    public int Count { get; private set; }

    public int Capacity => array.Length;

    public bool IsEmpty => Count == 0;


    public MinHeap(T[] initialArray = null)
    {
        array = new T[initialSize];

        if (initialArray == null) return;

        foreach (var item in initialArray)
        {
            Add(item);
        }

    }


    /// <summary>
    /// Returns the min item but does NOT remove it.
    /// Time complexity: O( 1 )
    /// </summary>
    public T Peek()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException();
        }

        return array[0];
    }

    // TODO
    /// <summary>
    /// Adds given item to the heap.
    /// Time complexity: O(log(n)) ***BUT*** it might be O(N) if we have to resize
    /// </summary>
    public void Add(T item)
    {
        array[Count] = item;
        TrickleUp(Count);
        Count++;

        if (Count == Capacity)
        {
            DoubleArrayCapacity();
        }
    }

    public T Extract()
    {
        return ExtractMin();
    }

    /// <summary>
    /// Removes and returns the max item in the min-heap.
    /// Time complexity: O( n )
    /// </summary>
    public T ExtractMax()
    {
        if (IsEmpty) throw new InvalidOperationException();
        int largest = 0;
        for (int i=0; i<Count; i++)
        {
            if (array[i].CompareTo(array[largest]) > 0)
            {
                largest = i;
            }
        }
        T maxValue = array[largest];

        array[largest] = array[Count - 1];
        Count--;

        TrickleUp(largest);
        TrickleDown(largest);

        return maxValue;
    }
    // TODO
    /// <summary>
    /// Removes and returns the min item in the min-heap.
    /// Time complexity: O( log(n) )
    /// </summary>
    public T ExtractMin()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException();
        }

        // save the min from the root
        T min = array[0];

        // swap the min with the last item
        array[0] = array[Count - 1];

        // remove the "last" item
        Count--;

        // trickle down from root
        TrickleDown(0);

        return min;
    }

    /// <summary>
    /// Returns true if the heap contains the given value; otherwise false.
    /// Time complexity: O( n )
    /// </summary>
    public bool Contains(T value)
    {
        for (int i = 0; i < Count; i++)
        {
            if (array[i].CompareTo(value) == 0)
            {
                return true;
            }
        }

        return false;
    }

    // TODO
    /// <summary>
    /// Updates the first element with the given value from the heap.
    /// Time complexity: O( n )
    /// </summary>
    public void Update(T oldValue, T newValue)
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException();
        }
        // find the node to update - O(n)
        int index = -1;
        for (int i = 0; i < Count; i++)
        {
            // update value - O(1)
            if (array[i].CompareTo(oldValue) == 0)
            {
                index = i;
                break;
            }
        }
        if (index == -1) throw new InvalidOperationException();
        array[index] = newValue;

        // trickle up or trickle down - O( log(n) )
        TrickleUp(index);
        TrickleDown(index);

    }

    // TODO
    /// <summary>
    /// Removes the first element with the given value from the heap.
    /// Time complexity: O( n )
    /// </summary>
    public void Remove(T value)
    {
        if (IsEmpty)
            throw new InvalidOperationException();

        int index = -1;

        // Find the value
        for (int i = 0; i < Count; i++)
        {
            if (array[i].CompareTo(value) == 0)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
            throw new InvalidOperationException();

        // Replace removed node with last element
        array[index] = array[Count - 1];

        // Count--
        Count--;

        // trickleX
        TrickleUp(index);
        TrickleDown(index);

    }

    // TODO
    // Time Complexity: O( log n )
    private void TrickleUp(int index)
    {
        while (index > 0)
        {
            int parent = Parent(index);

            if (array[index].CompareTo(array[parent]) >= 0)
                break;

            Swap(index, parent);
            index = parent;
        }
    }

    // TODO
    // Time Complexity: O( log n )
    private void TrickleDown(int index)
    {
        while (LeftChild(index) < Count)
        {
            int left = LeftChild(index);
            int right = RightChild(index);
            int smallest = left;

            if (right < Count && array[right].CompareTo(array[left]) < 0)
                smallest = right;

            if (array[index].CompareTo(array[smallest]) <= 0)
                break;

            Swap(index, smallest);
            index = smallest;
        }
    }

    // TODO
    /// <summary>
    /// Gives the position of a node's parent, the node's position in the heap.
    /// </summary>
    private static int Parent(int position)
    {
        return (position - 1) / 2;
    }

    // TODO
    /// <summary>
    /// Returns the position of a node's left child, given the node's position.
    /// </summary>
    private static int LeftChild(int position)
    {
        return 2 * position + 1;
    }

    // TODO
    /// <summary>
    /// Returns the position of a node's right child, given the node's position.
    /// </summary>
    private static int RightChild(int position)
    {
        return 2 * position + 2;
    }

    private void Swap(int index1, int index2)
    {
        var temp = array[index1];

        array[index1] = array[index2];
        array[index2] = temp;
    }

    private void DoubleArrayCapacity()
    {
        Array.Resize(ref array, array.Length * 2);
    }
}