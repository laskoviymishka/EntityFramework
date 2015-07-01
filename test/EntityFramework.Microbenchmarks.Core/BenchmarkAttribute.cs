using Xunit;
using Xunit.Sdk;

namespace EntityFramework.Microbenchmarks.Core
{
    [XunitTestCaseDiscoverer("EntityFramework.Microbenchmarks.Core.BenchmarkTestCaseDiscoverer", "EntityFramework.Microbenchmarks.Core")]
    public class BenchmarkAttribute : FactAttribute
    {
        public int Iterations { get; set; } = 1;
        public int WarmupIterations { get; set; } 
    }

}
