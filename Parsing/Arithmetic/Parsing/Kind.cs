namespace Parsing.Arithmetic.Parsing
{
    public enum Kind
    {
        Eof,
        Number,
        Identifier,
        Boolean,

        // Symbols
        ParenLeft,
        ParenRight,
        Comma,

        // Operators
        OpPlus,
        OpMinus,
        OpMultiply,
        OpDivide,
        OpModulo,
        OpPower,
        OpBinaryNot,
        OpLogicalNot,
    }
}