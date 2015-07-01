using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace EntityFramework.Microbenchmarks.Core
{
    public class BenchmarkVariationAttribute : DataAttribute
    {
        public BenchmarkVariationAttribute(string variationName, params object[] data)
        {
            VariationName = variationName;
            Data = data;
        }

        public string VariationName { get; private set; }

        public object[] Data { get; private set; }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            return new[] { Data };
        }
    }

}
