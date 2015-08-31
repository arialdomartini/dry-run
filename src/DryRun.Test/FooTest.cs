using NUnit.Framework;
using FluentAssertions;

namespace DryRun.Test
{
    public class FooTest
    {
        [Test]
        public void ShouldPass()
        {
            new Foo().True().Should().BeTrue();
        }
    }
}
