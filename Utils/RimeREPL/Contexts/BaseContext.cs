using System;
using System.Reflection;
using RimeLib.Frostbite;

namespace Rime.Utils.RimeREPL.Contexts
{
    class BaseContext : REPLContext
    {
        public override bool TryGetParent(out REPLContext? p_Parent)
        {
            p_Parent = null;
            return false;
        }

        public override bool ProcessCommand(string p_Input, out REPLContext p_NewContext)
        {
            p_NewContext = this;
            return false;
        }

        public override void PrintHelp()
        {
            Console.WriteLine("Help me!");
        }

        public override string GetDescription()
        {
            return "";
        }

        private void LoadContentAssembly(EngineType p_Engine)
        {
            var s_AssemblyName = "RimeLib.Content." + p_Engine;

            try
            {
                if (!Program.Quiet)
                    Console.WriteLine($"Loading engine content support assembly for '{p_Engine}'.");

                Assembly.Load(s_AssemblyName);
            }
            catch
            {
                if (!Program.Quiet)
                    Console.WriteLine($"Failed to load supporting engine assembly ({s_AssemblyName}.dll). This means that the engine is not supported or that you are missing required files.");
            }
        }
    }
}
