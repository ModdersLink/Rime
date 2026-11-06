using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Conversion;

namespace RimeLib.Serialization.Frostbite2_0;

/// <summary>Frostbite 2 emitter systems: an EmitterSystemAsset whose atlas infos name areas of its two atlases.</summary>
public class EmitterSystemRules : IEmitterSystemRules
{
    public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

    public EmitterSystemModel? ReadSystem(DataContainerBase p_Instance)
    {
        if (p_Instance is not fb.EmitterSystemAsset s_System)
            return null;

        var s_Model = new EmitterSystemModel { BaseAtlas = s_System.BaseAtlasTexture, NormalAtlas = s_System.NormalAtlasTexture };
        s_Model.Entries.AddRange(s_System.TextureInfos.Select(p_I =>
            new EmitterAtlasEntry(p_I.TextureName, new Vector2(p_I.MinUv.x, p_I.MinUv.y), new Vector2(p_I.MaxUv.x, p_I.MaxUv.y))));
        return s_Model;
    }

    public DataContainerBase CreateSystem(string p_Name, GUID p_InstanceGuid, EmitterSystemModel p_System)
    {
        var s_System = new fb.EmitterSystemAsset
        {
            Name = p_Name,
            InstanceId = new DataContainerId.Guid(p_InstanceGuid),
            BaseAtlasTexture = new CtrRef<fb.TextureAsset>(p_System.BaseAtlas.PartitionGuid, p_System.BaseAtlas.InstanceId),
            NormalAtlasTexture = new CtrRef<fb.TextureAsset>(p_System.NormalAtlas.PartitionGuid, p_System.NormalAtlas.InstanceId),
        };

        foreach (var s_Entry in p_System.Entries)
        {
            s_System.TextureInfos.Add(new fb.EmitterTextureAtlasInfo
            {
                TextureName = s_Entry.TextureName,
                MinUv = new fb.Vec2 { x = s_Entry.MinUv.X, y = s_Entry.MinUv.Y },
                MaxUv = new fb.Vec2 { x = s_Entry.MaxUv.X, y = s_Entry.MaxUv.Y },
            });
        }

        return s_System;
    }

    public string? GetTextureAssetName(DataContainerBase p_Instance) => (p_Instance as fb.TextureAsset)?.Name;

    public DataContainerBase CreateTextureAsset(string p_Name, GUID p_InstanceGuid) =>
        new fb.TextureAsset { Name = p_Name, InstanceId = new DataContainerId.Guid(p_InstanceGuid) };

    public IEnumerable<string> GetEmitterTextureNames(DataContainerBase p_Instance)
    {
        if (p_Instance is fb.UpdateTextureCoordsData s_Coords)
            yield return s_Coords.TextureInfo1.TextureName;
    }
}
