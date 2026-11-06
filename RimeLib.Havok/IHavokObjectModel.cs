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

        /// <summary>
        /// The physics resource with both packfiles built in this engine's Havok from the shapes, its
        /// Frostbite header kept: how another engine's physics is carried over.
        /// </summary>
        /// <exception cref="System.NotSupportedException">A shape has no counterpart in this engine's Havok.</exception>
        byte[] Rewrite(byte[] p_Resource, System.Collections.Generic.IReadOnlyList<hkpCollisionShape> p_Shapes);

        /// <summary>
        /// Queries each MOPP in the resource with the bounds of each child or triangle it is over, and
        /// a MOPP Rime builds over the same ones: each query has to find its key. What it could not
        /// find, and how many trees it queried.
        /// </summary>
        System.Collections.Generic.IReadOnlyList<string> CheckMopps(byte[] p_Resource, out int p_Trees);
    }
}
