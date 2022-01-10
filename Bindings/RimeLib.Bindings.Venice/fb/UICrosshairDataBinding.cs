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
	public class UICrosshairDataBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo Dispersion { get; set; } = new();

		[ContainerField(24)]
		public UIDataSourceInfo Zoomed { get; set; } = new();

		[ContainerField(40)]
		public UIDataSourceInfo Visibility { get; set; } = new();

		[ContainerField(56), LayoutImmutable, Blittable]
		public float DispersionBaseOffset { get; set; }

		public static void Deserialize(UICrosshairDataBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.UIDataSourceInfo.Deserialize(p_Instance.Dispersion, p_Reader, p_Parser);
			fb.UIDataSourceInfo.Deserialize(p_Instance.Zoomed, p_Reader, p_Parser);
			fb.UIDataSourceInfo.Deserialize(p_Instance.Visibility, p_Reader, p_Parser);
			p_Instance.DispersionBaseOffset = p_Reader.ReadSingle();
		}

	}
}
