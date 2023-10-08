using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_async_await.book_practise.chap_04
{
    public static class LoggingApi
    {
        public static void TraceDebugLog()
        {
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("D:/log.txt")));
            Trace.AutoFlush = true;

            Debug.WriteLine("os it");
            Trace.WriteLine("Tracing ? ohh yeadoes it");
        }
    }
}
