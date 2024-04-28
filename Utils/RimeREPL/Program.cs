using System;
using System.IO;
using CommandLine;
using RimeLib.Cmd;
using RimeLib.Cmd.Contexts;

namespace Rime.Utils.RimeREPL
{
    class Program
    {
        public class Options
        {
            [Option('q', "quiet", Required = false, Default = false, HelpText = "Suppress console output.")]
            public bool Quiet { get; set; } = false;

            [Value(0, MetaName = "commands file", Required = false, HelpText = "A text file containing commands to be executed, one in each line.")]
            public string? CommandsFile { get; set; }
        }

        public static bool Quiet { get; private set; }

        static void Main(string[] p_Args)
        {
            Parser.Default.ParseArguments<Options>(p_Args).WithParsed(p_Options =>
            {
                Quiet = p_Options.Quiet;

                if (p_Options.CommandsFile != null)
                {
                    ProcessCommandsFromFile(p_Options.CommandsFile);
                    return;
                }
                
                var s_REPL = new REPL();
                s_REPL.Process();
            }).WithNotParsed(p_Err => { Environment.Exit(1); });
        }

        private static void ProcessCommandsFromFile(string p_CommandsFile)
        {
            if (!File.Exists(p_CommandsFile))
            {
                Console.WriteLine("The specified file could not be found.");
                Environment.Exit(1);
                return;
            }

            var s_Output = Console.Out;
                    
            if (Quiet)
                s_Output = TextWriter.Null;

            ExecutionContext s_Context = new BaseContext();
            ExecutionContext s_StartingContext = s_Context;

            bool s_DropToRepl = false;
            foreach (var s_Line in File.ReadLines(p_CommandsFile))
            {
                if (s_Line == "DROP")
                {
                    s_DropToRepl = true;
                    continue;
                }
                
                s_Context.ProcessCommand(s_Line, s_Output, out s_Context);
            }

            if (s_DropToRepl)
            {
                var s_REPL = new REPL((BaseContext?)s_StartingContext);
                s_REPL.Process();
            }
        }
    }
}
