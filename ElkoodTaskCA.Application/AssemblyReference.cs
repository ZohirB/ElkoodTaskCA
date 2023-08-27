using System.Reflection;

namespace ElkoodTaskCA.Application;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}