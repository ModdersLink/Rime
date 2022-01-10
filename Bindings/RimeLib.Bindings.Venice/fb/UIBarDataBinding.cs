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
	[ContainerType(4, 60)]
	public class UIBarDataBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo Visibility { get; set; } = new();

		[ContainerField(24)]
		public UIDataSourceInfo Value { get; set; } = new();

		[ContainerField(40)]
		public UIDataSourceInfo Color { get; set; } = new();

		[ContainerField(56), LayoutImmutable, Blittable]
		public bool Refresh { get; set; }

		public static void Deserialize(UIBarDataBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.UIDataSourceInfo.Deserialize(p_Instance.Visibility, p_Reader, p_Parser);
			fb.UIDataSourceInfo.Deserialize(p_Instance.Value, p_Reader, p_Parser);
			fb.UIDataSourceInfo.Deserialize(p_Instance.Color, p_Reader, p_Parser);
			p_Instance.Refresh = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
