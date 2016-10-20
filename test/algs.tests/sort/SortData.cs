using System;
using System.Collections;
using System.Collections.Generic;

namespace agalperin.algorithms.sort.tests
{
    internal class SortData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>{
            new object[] {new[] { 2, 1, 3, 4 }, new[] { 1, 2, 3 ,4 }},
            new object[] {new[] { 5, 1, 4, 2, 8}, new[] {1, 2, 4, 5, 8}}
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}