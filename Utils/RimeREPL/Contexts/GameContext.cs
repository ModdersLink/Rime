using System;
using System.Collections.Generic;
using System.Text;
using RimeLib.Content.Mounting;

namespace Rime.Utils.RimeREPL.Contexts
{
    class GameContext : REPLContext
    {
        protected BaseContext m_Parent;
        protected IEngineMounter m_Mounter;
        protected int m_Id;

        public GameContext(BaseContext p_Parent, IEngineMounter p_Mounter, int p_Id)
        {
            m_Parent = p_Parent;
            m_Mounter = p_Mounter;
            m_Id = p_Id;
        }

        public override bool TryGetParent(out REPLContext p_Parent)
        {
            p_Parent = m_Parent;
            return true;
        }

        public override bool ProcessCommand(string p_Input, out REPLContext p_NewContext)
        {
            throw new NotImplementedException();
        }

        public override List<string> GetSuggestions(string p_Input)
        {
            throw new NotImplementedException();
        }

        public override void PrintHelp()
        {
            throw new NotImplementedException();
        }

        public override string GetDescription()
        {
            return $"{m_Id} - {m_Mounter.GetGamePath()} - {m_Mounter.GetEngineType()}";
        }
    }
}
