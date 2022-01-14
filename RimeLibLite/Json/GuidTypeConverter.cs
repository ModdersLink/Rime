using System;
using System.ComponentModel;
using System.Globalization;
using RimeLib.Frostbite.Core;

namespace RimeLib.Json
{
    public class GuidTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext? p_Context, Type p_SourceType)
        {
            if (p_SourceType == typeof(string))
                return true;

            return base.CanConvertFrom(p_Context, p_SourceType);
        }

        public override object? ConvertFrom(ITypeDescriptorContext? p_Context, CultureInfo? p_Culture, object p_Value)
        {
            if (p_Value is string s_Value)
                return new GUID(s_Value);

            return base.ConvertFrom(p_Context, p_Culture, p_Value);
        }
    }
}
