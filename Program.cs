using CommandLine;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed(opts =>
            {
                WriteAsciiArt(opts.Texts);
            })
            .WithNotParsed(errs => ShowHelp());
    }

    static void ShowHelp()
    {
        Console.WriteLine("Available Fonts:");
        var fonts = AsciiArt.GetAvailableFonts();
        foreach (var font in fonts)
        {
            Console.WriteLine($"- {font}");
        }
    }

    static void WriteAsciiArt(IEnumerable<string> texts)
    {
        foreach (var text in texts)
        {
            Console.WriteLine($"ASCII Art for: {text}");
           
        }
    }
}
