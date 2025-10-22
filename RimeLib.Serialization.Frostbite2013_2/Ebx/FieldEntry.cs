using System;

namespace RimeLib.Serialization.Frostbite2013_2.Ebx;

public class FieldEntry
{
    /// <summary>
    /// C# type of this field
    /// </summary>
    public Type? FieldType { get; set; }

    /// <summary>
    /// Name of field
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Offset in payload
    /// </summary>
    public uint Offset { get; set; }


    /// <summary>
    /// Parent who this field is apart of
    /// </summary>
    public TypeEntry? Parent { get; set; }

    /// <summary>
    /// Frostbite MemberInfoFlags
    /// </summary>
    public ushort Flags { get; set; }

    public override string ToString()

    {
        return $"{FieldType?.Name} {Name}";
    }
}