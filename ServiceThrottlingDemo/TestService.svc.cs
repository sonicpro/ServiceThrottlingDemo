using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace ServiceThrottlingDemo
{
    /// <summary>
    /// TestService
    /// Implements the ITestService Interface
    /// A simple test service that simulates a long running process
    /// Average time in method will be 5 seconds but
    /// depending on the service configuration, the average
    /// total client call time (including time spent in service)
    /// varies based on the configuration.
    /// Test Modes
    /// Concurrency: Multiple | Instance: PerCall  
    /// Concurrency: Multiple | Instance: Single   
    /// Concurrency: Single   | Instance: PerCall  
    /// Concurrency: Single   | Instance: Single   
    /// </summary>
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public class TestService : ITestService
    {
        /// <summary>
        /// TestMethod
        /// Simulates a long running process on a service
        /// </summary>
        /// <returns>the TotalMilliseconds (int) spent in the service method</returns>
        public void TestMethod()
        {
            Thread.Sleep(5000);
        }
    } // end of class
} // end of namespace
