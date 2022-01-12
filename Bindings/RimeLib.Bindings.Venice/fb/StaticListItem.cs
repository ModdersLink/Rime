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
	public class StaticListItem
	{
		[ContainerField(0), LayoutImmutable]
		public string ItemName { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public UIDataSourceInfo DynamicDisable { get; set; } = new();
		
		[ContainerField(20)]
		public UIDataSourceInfo DynamicNewContent { get; set; } = new();
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool AppendPlatformToSID { get; set; }
		
		[ContainerField(37), LayoutImmutable, Blittable]
		public bool ExcludeInRetail { get; set; }
		
	}
}
