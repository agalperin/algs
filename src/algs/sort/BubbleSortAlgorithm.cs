using System;

namespace agalperin.algorithms.sort
{
    public sealed class BubbleSortAlgorithm<T> : ISortAlgorithm<T>
    {
        public void Sort(T[] input, Comparison<T> comparison)
        {
            if(input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if(comparison == null)
            {
                throw new ArgumentNullException(nameof(comparison));
            }

            if(input.Length == 0)
            {
                return;
            }

            var tmp = default(T); 
            bool found = false;

            for(int i=0; i<input.Length-1; i++)
            {
                for(int j=i+1; j<input.Length; j++)
                {
                    if(comparison(input[j-1], input[j]) > 0)
                    {
                        tmp = input[j-1];
                        input[j-1] = input[j];
                        input[j] = tmp;
                        found = true;
                    }
                }      

                if(!found)
                {
                    break;
                }          
            }
        }
    }
}