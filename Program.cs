using CommandLine;
using Figgle;
using HelloDotNet;

namespace HelloDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(AsciiArt.Write)
                .WithNotParsed(errors =>
                    Console.WriteLine("Usage: HelloDotNet <Text> --font <FontName>"));
        }
    }
}
