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
	[ContainerType(4, 40)]
	public class UIWidgetPathBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo WidgetPathQuery { get; set; } = new();

		[ContainerField(24)]
		public UIDataSourceInfo Visibility { get; set; } = new();

		public static void Deserialize(UIWidgetPathBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.UIDataSourceInfo.Deserialize(p_Instance.WidgetPathQuery, p_Reader, p_Parser);
			fb.UIDataSourceInfo.Deserialize(p_Instance.Visibility, p_Reader, p_Parser);
		}

	}
}
