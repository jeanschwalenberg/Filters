using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Diagnostics;

namespace Filters.Infrastructure {
    public class ProFileResultAttribute : FilterAttribute, IResultFilter {
        private Stopwatch timer;

        public void OnResultExecuting(ResultExecutingContext filterContext) {
            timer = Stopwatch.StartNew();
        }

        public void OnResultExecuted(ResultExecutedContext filterContext) {
            timer.Stop();
            filterContext.HttpContext.Response.Write(
                    string.Format("<div>Result elapsed time: {0:F6}</div>",
                        timer.Elapsed.TotalSeconds));
        }
    }
}