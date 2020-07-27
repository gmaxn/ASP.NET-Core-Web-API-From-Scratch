using System.Collections.Generic;

namespace Example.Services.TestService
{
    public interface ITestService
    {
        IEnumerable<string> GetTestValues();
    }
}
