using Microsoft.Extensions.Logging;
using mitoSoft.Razor.Logging.Dictionary;
using System;

namespace mitoSoft.Razor.Logging.Components.Extensions
{
    public static class ILoggingBuilderExtensions
    {
        public static ILoggingBuilder AddPage(this ILoggingBuilder builder)
        {
            var provider = new DictionaryLoggerProvider();
            var options = new PageLoggerOptions();
            provider.Options.RegisterCallback = Trunk.RegisterLogger;
            provider.Options.DateTimeKind = options.DateTimeKind;
            provider.Options.MaxRows = options.MaxRows; ;
            Trunk.MaxRows = options.MaxRows;
            Trunk.OutputFormat = options.OutputFormat;
            Trunk.IsConfigured = true;

            builder.AddProvider(provider);
            return builder;
        }

        public static ILoggingBuilder AddPage(this ILoggingBuilder builder, Action<PageLoggerOptions> configure)
        {
            var options = new PageLoggerOptions();
            configure?.Invoke(options);

            var provider = new DictionaryLoggerProvider();
            provider.Options.RegisterCallback = Trunk.RegisterLogger;
            provider.Options.DateTimeKind = options.DateTimeKind;
            provider.Options.MaxRows = options.MaxRows;
            Trunk.MaxRows = options.MaxRows;
            Trunk.OutputFormat = options.OutputFormat;
            Trunk.IsConfigured = true;

            builder.AddProvider(provider);
            return builder;
        }
    }
}