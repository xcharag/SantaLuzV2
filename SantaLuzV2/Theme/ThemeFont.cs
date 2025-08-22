namespace SantaLuzV2.Theme;

public enum ThemeFont
{
    Title,
    Subtitle,
    Content
}

public static class ThemeFontExtensions
{
    public static string ToCssVar(this ThemeFont font)
        => $"var({GetVarName(font)})";

    public static string ToStyleFont(this ThemeFont font)
        => $"font-family: {font.ToCssVar()};";

    public static string GetVarName(this ThemeFont font) => font switch
    {
        ThemeFont.Title => "--font-title",
        ThemeFont.Subtitle => "--font-subtitle",
        ThemeFont.Content => "--font-content",
        _ => "--font-content"
    };
}