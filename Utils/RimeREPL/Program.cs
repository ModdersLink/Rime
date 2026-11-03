using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
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
            // EngineInterfaceRegistry finds the support assemblies by scanning the AppDomain, but
            // nothing references them, so without loading them here they never appear and their
            // commands go missing.
            foreach (var s_Dll in Directory.GetFiles(AppContext.BaseDirectory, "RimeLib.*.dll"))
            {
                try
                {
                    Assembly.LoadFrom(s_Dll);
                }
                catch (Exception s_Exception)
                {
                    Console.Error.WriteLine($"Could not load {Path.GetFileName(s_Dll)}: {s_Exception.Message}");
                }
            }

            Parser.Default.ParseArguments<Options>(p_Args).WithParsed(p_Options =>
            {
                Quiet = p_Options.Quiet;

                if (p_Options.CommandsFile != null)
                {
                    ProcessCommandsFromFile(p_Options.CommandsFile);
                    return;
                }

                // Piped stdin (scripts, tools, a FIFO for a long-lived session): the interactive
                // REPL needs a real console for ReadKey, so read plain lines instead.
                if (Console.IsInputRedirected)
                {
                    ProcessCommandsFromStdin();
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

        private static IEnumerable<string> ReadStdinLines()
        {
            string? s_Line;
            while ((s_Line = Console.In.ReadLine()) != null)
                yield return s_Line;
        }

        private static void ProcessCommandsFromStdin()
        {
            var s_Output = Quiet ? TextWriter.Null : Console.Out;
            ExecutionContext? s_Context = new BaseContext();

            foreach (var s_RawLine in ReadStdinLines())
            {
                var s_Line = s_RawLine.Trim();

                if (s_Line.Length == 0 || s_Line.StartsWith('#'))
                    continue;

                // Echo the command and mark where its output ends, so a caller reading the
                // output stream can tell which output belongs to which command.
                s_Output.WriteLine($"> {s_Line}");

                try
                {
                    s_Context!.ProcessCommand(s_Line, s_Output, out s_Context);
                }
                catch (Exception s_Exception)
                {
                    s_Output.WriteLine($"[error] {s_Exception}");
                }

                s_Output.WriteLine("<<< done");
                s_Output.Flush();

                // A null context means the base context was asked to exit.
                if (s_Context == null)
                    return;
            }
        }
    }
}
