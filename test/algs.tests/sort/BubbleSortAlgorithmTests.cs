using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace agalperin.algorithms.sort.tests
{
    public class BubbleSortAlgorithmTests
    {
        [Fact]
        public void should_sort_an_empty_array()
        {
            int[] input = new int[]{};
            var sut = new BubbleSortAlgorithm<int>();

            sut.Sort(input, ComparisonUtility.CompareInts);

            input.Should().BeEmpty();
        }

        [Fact]
        public void should_sort_array_of_one_element()
        {
            int[] input = new[] {1};
            var sut = new BubbleSortAlgorithm<int>();

            sut.Sort(input, ComparisonUtility.CompareInts);

            input.Should().Equal(1);
        }

        [Theory]
        [ClassData(typeof(SortData))]
        public void should_sort_array(int[] input, IEnumerable<int> expected)
        {
            var sut = new BubbleSortAlgorithm<int>();

            sut.Sort(input, ComparisonUtility.CompareInts);

            input.Should().Equal(expected);
        }
    }
}