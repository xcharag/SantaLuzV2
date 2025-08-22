namespace SantaLuzV2.Theme;

public enum ThemeColor
{
    Navy900,
    Navy700,
    Navy400,
    Olive200,
    Lime500,
    Sky50,
    Teal200,
    Sand200,
    Green500,
    Amber400,
    Gray300,
    Red600,
    White,
    BlurCeleste,
    BlurCeleste30,

    // Semantic / dark theme tokens (scoped under .theme-dark)
    TextPrimary,
    TextSecondary,
    TextAccent,
    SurfacePanel,
    SurfacePanelAlt,
    SurfacePanelMuted
}

public static class ThemeColorExtensions
{
    public static string ToCssVar(this ThemeColor color)
        => $"var({GetVarName(color)})";

    public static string ToStyleColor(this ThemeColor color)
        => $"color: {color.ToCssVar()};";

    public static string ToBackGround(this ThemeColor color)
        => $"background: {color.ToCssVar()};";

    public static string GetVarName(this ThemeColor color) => color switch
    {
        ThemeColor.Navy900 => "--color-navy-900",
        ThemeColor.Navy700 => "--color-navy-700",
        ThemeColor.Navy400 => "--color-navy-400",
        ThemeColor.Olive200 => "--color-olive-200",
        ThemeColor.Lime500 => "--color-lime-500",
        ThemeColor.Sky50 => "--color-sky-50",
        ThemeColor.Teal200 => "--color-teal-200",
        ThemeColor.Sand200 => "--color-sand-200",
        ThemeColor.Green500 => "--color-green-500",
        ThemeColor.Amber400 => "--color-amber-400",
        ThemeColor.Gray300 => "--color-gray-300",
        ThemeColor.Red600 => "--color-red-600",
        ThemeColor.White => "--color-white",
        ThemeColor.BlurCeleste => "--color-blur-celeste",
        ThemeColor.TextPrimary => "--text-primary",
        ThemeColor.TextSecondary => "--text-secondary",
        ThemeColor.TextAccent => "--text-accent",
        ThemeColor.SurfacePanel => "--surface-panel",
        ThemeColor.SurfacePanelAlt => "--surface-panel-alt",
        ThemeColor.SurfacePanelMuted => "--surface-panel-muted",
        _ => "--color-lime-500"
    };

    // Literal resolved values from theme.css (uppercase for consistency)
    public static string ToHex(this ThemeColor color) => color switch
    {
        ThemeColor.Navy900 => "#1A5276",
        ThemeColor.Navy700 => "#2980B9",
        ThemeColor.Navy400 => "#85C1E9",
        ThemeColor.Olive200 => "#E6E49F",
        ThemeColor.Lime500 => "#8FC440",
        ThemeColor.Sky50 => "#E1F8FF",
        ThemeColor.Teal200 => "#A7E0DA",
        ThemeColor.Sand200 => "#FBE8B8",
        ThemeColor.Green500 => "#22C55E",
        ThemeColor.Amber400 => "#FBBF24",
        ThemeColor.Gray300 => "#BCC4D0",
        ThemeColor.Red600 => "#DC2626",
        ThemeColor.White => "#FFFFF0",
        ThemeColor.BlurCeleste => "rgba(133, 193, 233, 0.15)",
        ThemeColor.BlurCeleste30 => "rgba(133, 193, 233, 0.30)",
        // Dark theme semantic tokens
        ThemeColor.TextPrimary => "#F5F7FA",
        ThemeColor.TextSecondary => "#D5DDE5",
        ThemeColor.TextAccent => "#8FC440",      // var(--color-lime-500)
        ThemeColor.SurfacePanel => "#1A5276",    // var(--color-navy-900)
        ThemeColor.SurfacePanelAlt => "#2980B9", // var(--color-navy-700)
        ThemeColor.SurfacePanelMuted => "#FFFFFF0A", // rgba(255,255,255,0.04)
        _ => "#8FC440"
    };
}