using System;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace Instance.Test
{

    public class NaiveSingletonInstance
    {
        private readonly ITestOutputHelper _output;

        public NaiveSingletonInstance(ITestOutputHelper output)
        {
            _output = output;
            SingletonTestHelpers.Reset(typeof(NaiveSingleton));
        }

        [Fact]
        public void ReturnsNonNullSingletonInstance()
        {
            Assert.Null(SingletonTestHelpers.GetPrivateStaticInstance<NaiveSingleton>());

            var result = NaiveSingleton.Instance;

            Assert.NotNull(result);
            Assert.IsType<NaiveSingleton>(result);

        }

        [Fact]
        public void OnlyCallConstructorOnceGivenThreeInstanceCalls()
        {
            Assert.Null(SingletonTestHelpers.GetPrivateStaticInstance<NaiveSingleton>());

            var one =   NaiveSingleton.Instance;
            var two =   NaiveSingleton.Instance;
            var three = NaiveSingleton.Instance;

            Assert.True(one.Equals(two));
            Assert.True(two.Equals(three));
            Assert.True(three.Equals(one));

        }
    }
}
