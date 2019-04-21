namespace RimeLib.Frostbite.Content.Mesh
{
    /// <summary>
    /// Model mesh type
    /// </summary>
    public enum MeshType : uint
    {
        /// <summary>
        /// Rigid mesh
        /// </summary>
        MeshType_Rigid = 0x0,

        /// <summary>
        /// Skinned mesh
        /// </summary>
        MeshType_Skinned = 0x1,

        /// <summary>
        /// Composite mesh
        /// </summary>
        MeshType_Composite = 0x2,
    }
}
