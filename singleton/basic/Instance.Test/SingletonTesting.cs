using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
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

        [Fact]
        public void CallsConstructorMultipeTimesGivenThreeParallelInstanceCalls()
        {

            // Test to confirm the singleton class is naive, in that it is not thread safe
            // A singleton class should not call the constructor more than once
            // even in a multithreaded environment

            Assert.Null(SingletonTestHelpers.GetPrivateStaticInstance<NaiveSingleton>());

            var strings = new List<string>() { "one", "two", "three" };
            var instances = new List<NaiveSingleton>();
            var options = new ParallelOptions() { MaxDegreeOfParallelism = 3 };

            Parallel.ForEach(strings, options, instance =>
            {
                instances.Add(NaiveSingleton.Instance);
            });

            // This assertion needs updated to assert multiple instansiations of the singleton
            Assert.True(instances[0].Equals(instances[1]));
        }
    }
}
