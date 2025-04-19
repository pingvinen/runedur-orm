using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Testing;
using Microsoft.CodeAnalysis.Testing;

namespace unit_tests;

public static class CSharpIncrementalGeneratorVerifier<TGenerator>
where TGenerator : IIncrementalGenerator, new()
{
    public class Test : CSharpSourceGeneratorTest<TGenerator, DefaultVerifier>
    {
        public Test()
        {
        }
    }
}