///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 48)]
	public class UITextDataBinding : 
		UIDataBinding
	{
		[ContainerField(8), LayoutImmutable]
		public string StaticText { get; set; } = string.Empty;

		[ContainerField(12)]
		public UIDataSourceInfo TextData { get; set; } = new();

		[ContainerField(28)]
		public UIDataSourceInfo Visibility { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool Refresh { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable]
		public bool OverrideDirectAccess { get; set; }

		public static void Deserialize(UITextDataBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.StaticText = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			fb.UIDataSourceInfo.Deserialize(p_Instance.TextData, p_Reader, p_Parser);
			fb.UIDataSourceInfo.Deserialize(p_Instance.Visibility, p_Reader, p_Parser);
			p_Instance.Refresh = p_Reader.ReadBool();
			p_Instance.OverrideDirectAccess = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
