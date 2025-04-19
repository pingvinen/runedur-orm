using System.Reflection;

namespace Runedur.Generator;

public static class GeneralGenerationHelper
{
    private static readonly AssemblyName AssemblyName = typeof(AssemblyMarker).Assembly.GetName();
    
    /// <summary>
    /// The contents of an attribute that helps tools realise
    /// that the code was written by a generator.
    /// </summary>
    public static readonly string GeneratedCodeAttribute = $"""global::System.CodeDom.Compiler.GeneratedCodeAttribute("{AssemblyName.Name}", "{AssemblyName.Version}")""";

}