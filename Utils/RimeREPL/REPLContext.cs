using System.Collections.Generic;

namespace Rime.Utils.RimeREPL
{
    internal abstract class REPLContext
    {
        public abstract bool TryGetParent(out REPLContext? p_Parent);
        public abstract bool ProcessCommand(string p_Input, out REPLContext p_NewContext);
        public abstract List<string> GetSuggestions(string p_Input);
        public abstract void PrintHelp();
        public abstract string GetDescription();
    }
}
