using System;

namespace agalperin.algorithms.sort
{
    public sealed class BubbleSortAlgorithm<T> : ISortAlgorithm<T>
    {
        public T[] Sort(T[] input)
        {
            if(input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if(input.Length == 0)
            {
                return input;
            }

            throw new NotImplementedException();
        }
    }
}