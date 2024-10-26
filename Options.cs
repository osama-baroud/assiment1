using CommandLine;
using System.Collections.Generic;

public class Options
{
    [Value(0, MetaName = "text", HelpText = "Text to write in ASCII art.", Required = true)]
    public required IEnumerable<string> Texts { get; set; }
}
