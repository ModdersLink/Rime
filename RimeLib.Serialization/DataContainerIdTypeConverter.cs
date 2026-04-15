using System;
using System.ComponentModel;
using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization;

/// <summary>
/// TypeConverter for DataContainerId to support dictionary key deserialization from JSON.
/// Attempts to parse the string as a GUID first, then as a long index.
/// </summary>
public class DataContainerIdTypeConverter : TypeConverter
{
    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
    {
        return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
    }

    public override object? ConvertFrom(ITypeDescriptorContext? context, System.Globalization.CultureInfo? culture, object value)
    {
        return value switch
        {
            string s when Guid.TryParse(s, out var guid) => new DataContainerId.Guid(new GUID(guid)),
            string s when long.TryParse(s, out var index) => new DataContainerId.Index(index),
            _ => base.ConvertFrom(context, culture, value)
        };
    }

    public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
    {
        return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
    }

    public override object? ConvertTo(ITypeDescriptorContext? context, System.Globalization.CultureInfo? culture, object? value, Type destinationType)
    {
        if (destinationType == typeof(string) && value is DataContainerId containerId)
        {
            return containerId.ToString();
        }

        return base.ConvertTo(context, culture, value, destinationType);
    }
}
