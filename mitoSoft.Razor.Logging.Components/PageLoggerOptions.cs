using System;

namespace mitoSoft.Razor.Logging.Components
{
    public  class PageLoggerOptions
    {
        public virtual DateTimeKind DateTimeKind { get; set; } = DateTimeKind.Local;

        public virtual int MaxRows { get; set; } = 100;
    }
}