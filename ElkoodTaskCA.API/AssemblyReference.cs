using System.Reflection;

namespace ElkoodTaskCA.API;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}