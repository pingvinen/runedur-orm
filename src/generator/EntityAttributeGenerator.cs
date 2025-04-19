using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Runedur.Generator;

[Generator]
public class EntityAttributeGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        context.RegisterPostInitializationOutput(ctx => ctx.AddSource(
    "RunedurEntityAttribute.g.cs", 
            SourceText.From(EntityAttributeGenerationHelper.Attribute, Encoding.UTF8)
        ));
    }
}