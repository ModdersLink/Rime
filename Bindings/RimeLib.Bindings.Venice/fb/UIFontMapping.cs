///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class UIFontMapping : FrostbiteContainer
	{
		[ContainerField(Name: "ScaleformFontName", Offset: 0, NameHash: 842040767, Flags: 65)]
		public List<string> ScaleformFontName { get; set; } = new List<string>(); // 0x0 (0)
		
		[ContainerField(Name: "FontLongName", Offset: 4, NameHash: 1625526299, Flags: 16509), LayoutImmutable]
		public string FontLongName { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 842040767:
					ScaleformFontName = (List<string>) p_Value;
					break;

				case 1625526299:
					FontLongName = (string) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 842040767:
					return ScaleformFontName;

				case 1625526299:
					return FontLongName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 842040767:
					return typeof(UIFontMapping).GetProperty(nameof(ScaleformFontName));

				case 1625526299:
					return typeof(UIFontMapping).GetProperty(nameof(FontLongName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
