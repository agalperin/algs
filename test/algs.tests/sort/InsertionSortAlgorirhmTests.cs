using System.Collections.Generic;
using Xunit;
using FluentAssertions;

namespace agalperin.algorithms.sort.tests
{
    public sealed class InsertionSortTTests
    {
        [Fact]
        public void should_sort_an_empty_array()
        {
            int[] input = new int[] {};;
            var sut = new InsertionSortAlgorithm<int>();
            
            sut.Sort(input, ComparisonUtility.CompareInts);

            input.Should().BeEmpty();
        }

        [Fact]
        public void should_sort_array_with_one_element()
        {
            int[] input = new[] { 1 };
            var sut = new InsertionSortAlgorithm<int>();

            sut.Sort(input, ComparisonUtility.CompareInts);

            input.Should().Equal(1);
        }

        [Theory]
        [ClassData(typeof(SortData))]
        public void should_sort_array(int[] input, IEnumerable<int> expected)
        {
            var sut = new InsertionSortAlgorithm<int>();

            sut.Sort(input, ComparisonUtility.CompareInts);

            input.Should().Equal(expected);
        }
    }
}