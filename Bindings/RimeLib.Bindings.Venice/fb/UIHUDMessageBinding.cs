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
	[ContainerType(4, 44)]
	public class UIHUDMessageBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo MessageQuery { get; set; } = new();

		[ContainerField(24)]
		public UIDataSourceInfo VisibilityQuery { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable]
		public int NumberOfRows { get; set; }

		public static void Deserialize(UIHUDMessageBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.UIDataSourceInfo.Deserialize(p_Instance.MessageQuery, p_Reader, p_Parser);
			fb.UIDataSourceInfo.Deserialize(p_Instance.VisibilityQuery, p_Reader, p_Parser);
			p_Instance.NumberOfRows = p_Reader.ReadInt32();
		}

	}
}
