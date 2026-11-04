using System.Collections.Generic;

namespace RimeLib.Mesh.Sets;

/// <summary>A MeshSet resource's payload and its meta.</summary>
public sealed record MeshSetPayload(byte[] Data, byte[] Meta);

/// <summary>
/// Reads an engine's MeshSet into a <see cref="MeshSetModel"/> and writes it back. A codec refuses
/// what the model cannot hold, so a payload written from a decoded one with that payload as the
/// template is the same bytes.
/// </summary>
public interface IMeshSetCodec : IEngineInterface
{
    /// <summary>The LODs this engine's MeshSet has room for.</summary>
    int MaxLodCount { get; }

    /// <summary>The vertex usages this engine names.</summary>
    IReadOnlyCollection<VertexUsage> Usages { get; }

    MeshSetModel Decode(MeshSetPayload p_Payload);

    /// <param name="p_Template">
    /// A payload of the same MeshSet whose fields the model does not hold are kept, LOD by LOD and
    /// subset by subset, where the engine has such fields. Without one they get the values most
    /// meshes have.
    /// </param>
    MeshSetPayload Encode(MeshSetModel p_Model, MeshSetPayload? p_Template = null);

    /// <summary>The hash a shader database names the vertex declaration the subset is written with by.</summary>
    uint DeclarationHash(MeshSubsetModel p_Subset);

    /// <summary>A vertex declaration as a shader database stores it, as a subset's elements and streams.</summary>
    (IReadOnlyList<VertexElement> Elements, IReadOnlyList<VertexStream> Streams) ReadDeclaration(byte[] p_Declaration);
}
