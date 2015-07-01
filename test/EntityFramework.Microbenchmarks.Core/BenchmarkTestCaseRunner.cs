using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace EntityFramework.Microbenchmarks.Core
{
    public class BenchmarkTestCaseRunner : XunitTestCaseRunner
    {
        public BenchmarkTestCaseRunner(
                BenchmarkTestCase testCase,
                string displayName,
                string skipReason,
                object[] constructorArguments,
                object[] testMethodArguments,
                IMessageBus messageBus,
                ExceptionAggregator aggregator,
                CancellationTokenSource cancellationTokenSource)
            : base(testCase, displayName, skipReason, constructorArguments, testMethodArguments, messageBus, aggregator, cancellationTokenSource)
        {
            TestCase = testCase;
        }

        public new BenchmarkTestCase TestCase { get; private set; }

        protected override async Task<RunSummary> RunTestAsync()
        {
            var summary = new BenchmarkRunSummary
            {
                Test = DisplayName,
                Variation = TestCase.Variation,
                RunStarted = DateTime.UtcNow,
                MachineName = Environment.MachineName,
                Framework = GetFramework(),
                WarmupIterations = TestCase.WarmupIterations,
                Iterations = TestCase.Iterations
            };

            for (int i = 0; i < TestCase.WarmupIterations; i++)
            {
                var runner = CreateRunner(i + 1, TestCase.WarmupIterations, true, TestCase.Variation);
                summary.Aggregate(await runner.RunAsync());
            }

            for (int i = 0; i < TestCase.Iterations; i++)
            {
                var runner = CreateRunner(i + 1, TestCase.Iterations, false, TestCase.Variation);

                var iterationSummary = new BenchmarkIterationSummary();
                iterationSummary.Aggregate(await runner.RunAsync());
                iterationSummary.TimeEllapsed = TestCase.MetricCollector.TimeEllapsed;
                iterationSummary.MemoryDelta = TestCase.MetricCollector.MemoryDelta;
                summary.Aggregate(iterationSummary);
            }

            summary.PopulateMetrics();
            if (BenchmarkConfig.Instance.ResultsDatabase != null)
            {
                new SqlServerBenchmarkResultProcessor(BenchmarkConfig.Instance.ResultsDatabase).SaveSummary(summary);
            }

            return summary;
        }

        private XunitTestRunner CreateRunner(int iteration, int totalIterations, bool warmup, string variation)
        {
            var name = string.Format("{0} [Stage: {3}] [Iteration: {1}/{2}] [Variation: {4}]",
                DisplayName,
                iteration,
                totalIterations,
                warmup ? "Warmup" : "Collection",
                variation);

            return new XunitTestRunner(
                new XunitTest(TestCase, name),
                MessageBus,
                TestClass,
                ConstructorArguments,
                TestMethod,
                TestMethodArguments,
                SkipReason,
                BeforeAfterAttributes,
                Aggregator,
                CancellationTokenSource);
        }

        private static string GetFramework()
        {
#if DNX451 || DNXCORE50
            var services = Microsoft.Framework.Runtime.Infrastructure.CallContextServiceLocator.Locator.ServiceProvider; 
            var env = (Microsoft.Framework.Runtime.IRuntimeEnvironment)services.GetService(typeof(Microsoft.Framework.Runtime.IRuntimeEnvironment)); 
            return "DNX." + env.RuntimeType;
#else
            return ".NETFramework";
#endif
        }
    }
}
