using System.Collections.Generic;

namespace Example.Services.TestService
{
    public class TestService : ITestService
    {
        public IEnumerable<string> GetTestValues()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
