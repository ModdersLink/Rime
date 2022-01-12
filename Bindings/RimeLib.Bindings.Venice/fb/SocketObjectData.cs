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
	[ContainerType(4, 72)]
	public class SocketObjectData : 
		SocketObjectDataBase
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public GUID Asset1pGuid { get; set; }

		[ContainerField(24)]
		public List<GUID> Variation1pGuids { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public GUID Asset1pZoomGuid { get; set; }

		[ContainerField(44)]
		public List<GUID> Variation1pZoomGuids { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public GUID Asset3pGuid { get; set; }

		[ContainerField(64)]
		public List<GUID> Variation3pGuids { get; set; } = new();

		[ContainerField(68)]
		public RefArray<CustomizedMaterialData> CustomizedMaterials { get; set; } = new();

	}
}
