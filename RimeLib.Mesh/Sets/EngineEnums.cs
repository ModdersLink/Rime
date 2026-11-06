using System;
using System.IO;

namespace RimeLib.Mesh.Sets;

/// <summary>
/// Maps an engine's enum value to the model's of the same name and back. Engine enums name their
/// values after the type (MeshType_Rigid); the model's drop that prefix (Rigid).
/// </summary>
public static class EngineEnums
{
    public static TModel ToModel<TModel>(Enum p_Value) where TModel : struct, Enum
    {
        var s_Name = p_Value.ToString();
        var s_Prefix = p_Value.GetType().Name + "_";
        if (s_Name.StartsWith(s_Prefix, StringComparison.Ordinal))
            s_Name = s_Name[s_Prefix.Length..];

        if (!Enum.TryParse<TModel>(s_Name, out var s_Model) || !Enum.IsDefined(s_Model))
            throw new InvalidDataException($"{p_Value.GetType().Name} {p_Value} has no {typeof(TModel).Name}.");
        return s_Model;
    }

    public static bool TryToEngine<TEngine>(Enum p_Value, out TEngine p_Engine) where TEngine : struct, Enum =>
        Enum.TryParse($"{typeof(TEngine).Name}_{p_Value}", out p_Engine) && Enum.IsDefined(p_Engine);

    public static TEngine ToEngine<TEngine>(Enum p_Value) where TEngine : struct, Enum =>
        TryToEngine<TEngine>(p_Value, out var s_Engine)
            ? s_Engine
            : throw new InvalidDataException($"{typeof(TEngine).Name} has no {p_Value}.");
}
