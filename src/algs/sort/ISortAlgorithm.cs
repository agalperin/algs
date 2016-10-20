using System;

namespace agalperin.algorithms.sort
{
    public interface ISortAlgorithm<T>
    {
        void Sort(T[] input, Comparison<T> comparison);
    }
}