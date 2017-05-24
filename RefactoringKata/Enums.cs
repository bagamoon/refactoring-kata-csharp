using System.ComponentModel;

namespace RefactoringKata
{
    public enum ProductSize
    {
        [Description("Invalid Size")]
        InvalidSize = -1,

        [Description("XS")]
        XS = 1,

        [Description("S")]
        S = 2,

        [Description("M")]
        M = 3,

        [Description("L")]
        L = 4,

        [Description("XL")]
        XL = 5,

        [Description("XXL")]
        XXL = 6,
    }

    public enum ProductColor
    {
        [Description("no color")]
        NoColor = 0,

        [Description("blue")]
        Blue = 1,

        [Description("red")]
        Red = 2,

        [Description("yellow")]
        Yellow = 3,
    }
}