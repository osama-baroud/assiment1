using System;
using System.Linq;
using System.Reflection;

namespace HelloDotNet
{
    public static class AsciiArt
    {
        public static void Write(Options o)
        {
            FiggleFont? font = null;

            if (!string.IsNullOrWhiteSpace(o.Font))
            {
                font = typeof(FiggleFonts)
                    .GetProperty(o.Font, BindingFlags.Static | BindingFlags.Public)
                    ?.GetValue(null) as FiggleFont;

                if (font == null)
                {
                    Console.WriteLine($"Could not find font '{o.Font}'");
                }
            }

            font ??= FiggleFonts.Standard;

            if (o?.Text != null)
            {
                Console.WriteLine(font.Render(o.Text));
                Console.WriteLine($"Brought to you by {typeof(AsciiArt).FullName}");
            }

            // Display available fonts
            DisplayAvailableFonts();
        }

        private static void DisplayAvailableFonts()
        {
            var fontNames = typeof(FiggleFonts)
                .GetProperties(BindingFlags.Static | BindingFlags.Public)
                .Select(p => p.Name)
                .ToArray();

            Console.WriteLine("Available fonts:");
            foreach (var fontName in fontNames)
            {
                Console.WriteLine($"- {fontName}");
            }
        }
    }
}
