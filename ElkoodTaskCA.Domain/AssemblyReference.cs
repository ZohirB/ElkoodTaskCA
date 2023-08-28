using System.Reflection;

namespace ElkoodTaskCA.Domain;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}