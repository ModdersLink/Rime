using RimeLib.Animation.EA.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RimeLib.Animation.EA.GenericData
{
    /// <summary>
    /// The values of a layout's fields: an object a data blob holds, one a field refers to, or a
    /// struct inside either. A value is a number of its field's basic type (a bool is its raw byte),
    /// a <see cref="Guid"/>, a string, an <see cref="Instance"/> for a struct or a data reference,
    /// or a list of those for an array. A null string or reference is a null pointer.
    /// </summary>
    public sealed class Instance
    {
        public LayoutHeader Layout { get; set; }

        /// <summary>The values by field, in the order of <see cref="LayoutHeader.Fields"/>.</summary>
        public object?[] Values { get; set; }

        /// <summary>The header of an object; null for a struct.</summary>
        public Data? Header { get; set; }

        public Instance(LayoutHeader p_Layout, Data? p_Header)
        {
            Layout = p_Layout;
            Header = p_Header;
            Values = new object?[p_Layout.Fields.Length];
        }

        /// <summary>A new object of a layout, its fields zero, null or empty.</summary>
        public static Instance Create(LayoutHeader p_Layout, bool p_Object = true)
        {
            var s_Instance = new Instance(p_Layout, p_Object ? new Data { LayoutHash = p_Layout.Hash } : null);

            for (var i = 0; i < p_Layout.Fields.Length; i++)
                s_Instance.Values[i] = Default(p_Layout.Fields[i]);

            return s_Instance;
        }

        /// <summary>A field's zero value.</summary>
        public static object? Default(EntryHeader p_Field)
        {
            if (p_Field.Count == 0 || p_Field.Layout == null)
                return null;

            if (p_Field.IsArray)
                return new List<object?>();

            if (p_Field.Count > 1)
                return Enumerable.Range(0, p_Field.Count).Select(_ => DefaultElement(p_Field)).ToList();

            return DefaultElement(p_Field);
        }

        private static object? DefaultElement(EntryHeader p_Field) => (LayoutType)p_Field.LayoutHash switch
        {
            LayoutType.Bool or LayoutType.UInt8 => (byte)0,
            LayoutType.Int8 => (sbyte)0,
            LayoutType.Int16 => (short)0,
            LayoutType.UInt16 => (ushort)0,
            LayoutType.Int32 => 0,
            LayoutType.UInt32 => 0u,
            LayoutType.Int64 => 0L,
            LayoutType.UInt64 => 0UL,
            LayoutType.Float => 0f,
            LayoutType.Double => 0d,
            LayoutType.Guid => Guid.Empty,
            LayoutType.String or LayoutType.DataRef => null,
            _ => Create(p_Field.Layout!, false),
        };

        public int IndexOf(string p_Name) => Array.FindIndex(Layout.Fields, p_Field => p_Field.Name == p_Name);

        public bool Has(string p_Name) => IndexOf(p_Name) >= 0;

        /// <summary>A field's value by name.</summary>
        public object? this[string p_Name]
        {
            get => Values[Index(p_Name)];
            set => Values[Index(p_Name)] = value;
        }

        private int Index(string p_Name)
        {
            var s_Index = IndexOf(p_Name);
            if (s_Index < 0)
                throw new KeyNotFoundException($"{Layout.Name} has no field {p_Name}");

            return s_Index;
        }

        public override string ToString() => $"{Layout.Name} {(Has("__name") ? this["__name"] : null)}";
    }
}
