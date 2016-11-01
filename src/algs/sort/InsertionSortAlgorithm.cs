using System;

namespace agalperin.algorithms.sort
{
    public sealed class InsertionSortAlgorithm<T> : ISortAlgorithm<T>
    {
        public void Sort(T[] input, Comparison<T> comparison)
        {
            if(input.Length == 0)
            {
                return;
            }

            for(int j=1; j<input.Length; j++)
            {
                T key = input[j];

                int i = j-1;

                while(i>=0 && comparison.Invoke(input[i], key) == 1)
                {
                    input[i+1] = input[i];
                    --i;
                }

                input[i+1] = key;
            }
        }
    }
}