using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTracePerformance
{
    public class Program
    {
	    public static void Main()
	    {
		    for (int i = 0; i < 10000; i++)
		    {
			    new StackTrace(true).GetFrames();
		    }
	    }
    }
}
