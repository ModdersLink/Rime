namespace RimeLib.Havok
{
    /// <summary>An engine's physics resources as objects of its Havok version, which Rime can write packfiles of.</summary>
    public interface IHavokObjectModel : IEngineInterface
    {
        /// <summary>
        /// The physics resource with both packfiles written again from their objects: what checks the
        /// object model against the game's own files.
        /// </summary>
        /// <exception cref="System.NotSupportedException">A packfile holds a class that is not modelled.</exception>
        byte[] Rewrite(byte[] p_Resource);
    }
}
