using Microsoft.CodeAnalysis;

namespace RimeLib.CodeGen
{
    [Generator]
    public class CodeGen : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext p_Context)
        {
        }

        public void Execute(GeneratorExecutionContext p_Context)
        {
            p_Context.AddSource(
                "test.g.cs",
                "using System; namespace RimeTestShit { public static class Wow { public static void Wow2() { Console.WriteLine(\"Amazing\"); } } }"
            );
        }
    }
}
