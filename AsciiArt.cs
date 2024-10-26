
using System;
using System.Linq;
using System.Reflection;

public static class AsciiArt
{
    public static string[] GetAvailableFonts()
    {
        var fontProperties = typeof(FiggleFonts)
            .GetProperties(BindingFlags.Public | BindingFlags.Static)
            .Select(prop => prop.Name)
            .ToArray();

        return fontProperties;
    }
}
