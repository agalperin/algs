using agalperin.algorithms.sort;
using FluentAssertions;
using Xunit;

namespace agalperin.algorithms.tests
{
    public class BubbleSortAlgorithmTests
    {
        [Fact]
        public void should_sort_an_empty_array()
        {
            int[] input = new int[]{};
            var sut = new BubbleSortAlgorithm<int>();
            
            var output = sut.Sort(input);
            output.Should().HaveCount(0);
        }
    }
}