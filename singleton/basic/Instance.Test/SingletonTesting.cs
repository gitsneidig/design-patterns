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
    }


}
