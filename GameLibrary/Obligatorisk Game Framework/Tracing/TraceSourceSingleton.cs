using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Obligatorisk_Game_Framework.Tracing
{
    public static class TraceSourceSingleton
    {
        private static TraceSource _ts;
        private static readonly object _lockObject = new object();

        /// <summary>
        /// Keeps track of the TraceSource. First time it is being called is the only time it can be injected.
        /// </summary>
        /// <param name="traceSource">The TraceSource the program is going to use, if null the program will default to the base TraceSource class.</param>
        /// <returns>Returns the TraceSource being used.</returns>
        public static TraceSource Ts(TraceSource traceSource = null)
        {
            lock (_lockObject)
            {
                if (_ts == null && traceSource == null)
                {
                    _ts = new TraceSource("Game Framework Trace");
                    _ts.Switch = new SourceSwitch("Default Switch", "All");
                    return _ts;
                }

                if (_ts == null && traceSource != null)
                {
                    _ts = traceSource;
                    return _ts;
                }

                return _ts;
            }
        }
    }
}
