using CommandLine;
using Environment = System.Environment;

namespace Rime.Utils.RimeREPL
{
    class Program
    {
        public class Options
        {
            [Option('q', "quiet", Required = false, Default = false, HelpText = "Suppress console output.")]
            public bool Quiet { get; set; } = false;
        }

        public static bool Quiet { get; private set; }

        static void Main(string[] p_Args)
        {
            Parser.Default.ParseArguments<Options>(p_Args).WithParsed(p_Options =>
            {
                Quiet = p_Options.Quiet;
                
                var s_REPL = new REPL();
                s_REPL.Process();

            }).WithNotParsed(p_Err => { Environment.Exit(1); });
        }
    }
}
