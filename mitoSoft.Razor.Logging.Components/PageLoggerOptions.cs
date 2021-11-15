using System;

namespace mitoSoft.Razor.Logging.Components
{
    public  class PageLoggerOptions
    {
        public virtual DateTimeKind DateTimeKind { get; set; }

        public virtual int MaxRows { get; set; }

        public virtual string OutputFormat { get; set; }
    }
}