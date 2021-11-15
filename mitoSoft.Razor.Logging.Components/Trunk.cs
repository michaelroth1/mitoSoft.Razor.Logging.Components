using mitoSoft.Razor.Logging.Dictionary;
using System.Collections.Generic;

namespace mitoSoft.Razor.Logging.Components
{
    internal static class Trunk
    {
        public static bool IsConfigured { get; set; }

        public static Dictionary<string, DictionaryLogger> Loggers { get; private set; } = new();
        
        public static int MaxRows { get; set; }

        public static void RegisterLogger(object sender, LoggerRegisterEventArgs<DictionaryLogger> e)
        {
            Trunk.Loggers.Add(e.Category, e.Logger);
        }
    }
}