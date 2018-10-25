using System.Diagnostics;
using DLaB.Xrm.Test;

namespace Xyz.Xrm.Test
{
    /// <summary>
    /// Example DebugLogger
    /// </summary>
    public class DebugLogger: ITestLogger
    {
        public void WriteLine(string message)
        {
            Debug.WriteLine(message);
        }

        public void WriteLine(string format, params object[] args)
        {
            Debug.WriteLine(format, args);
        }
    }
}
