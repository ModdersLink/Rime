using System.Collections.Generic;
using RimeLib.Cmd.Commands.Base;
using RimeLib.Content.Mounting;

namespace RimeLib.Cmd.Contexts
{
    public class BaseContext : ExecutionContext
    {
        private int m_LastMounterId;
        private readonly Dictionary<int, IEngineMounter> m_Mounters = new Dictionary<int, IEngineMounter>();

        public BaseContext()
        {
            RegisterCommand<MountGameCommand>();
            RegisterCommand<DismountGameCommand>();
            RegisterCommand<ListGamesCommand>();
            RegisterCommand<SelectGameCommand>();
            RegisterCommand<BuildSbCommand>();
        }

        public override string GetShortDescription()
        {
            return $"{m_Mounters.Count} game{(m_Mounters.Count == 1 ? "" : "s")} mounted";
        }

        public override string GetLongDescription()
        {
            return $"Rime - {m_Mounters.Count} game{(m_Mounters.Count == 1 ? "" : "s")} currently mounted";
        }

        internal IReadOnlyDictionary<int, IEngineMounter> GetMounters()
        {
            return m_Mounters;
        }

        internal int RegisterMounter(IEngineMounter p_Mounter)
        {
            var s_Id = ++m_LastMounterId;
            m_Mounters[s_Id] = p_Mounter;
            return s_Id;
        }

        internal void DeregisterMounter(int p_Id)
        {
            m_Mounters.Remove(p_Id);
        }

        internal bool TryGetMounterById(int p_Id, out IEngineMounter? p_Mounter)
        {
            return m_Mounters.TryGetValue(p_Id, out p_Mounter);
        }
    }
}
