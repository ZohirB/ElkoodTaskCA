using System.Reflection;

namespace ElkoodTaskCA.Presistence;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}