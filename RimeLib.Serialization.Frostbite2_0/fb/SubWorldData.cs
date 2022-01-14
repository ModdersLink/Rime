///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 44)]
	public class SubWorldData :
		SpatialPrefabBlueprint
	{
		[ContainerField(36), JsonProperty(Order = 36)]
		public CtrRef<RegistryContainer> RegistryContainer { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public bool IsWin32SubLevel { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
		public bool IsXenonSubLevel { get; set; }

		[ContainerField(42), LayoutImmutable, Blittable, JsonProperty(Order = 42)]
		public bool IsPs3SubLevel { get; set; }

		[ContainerField(43), LayoutImmutable, Blittable, JsonProperty(Order = 43)]
		public bool RememberStateOnStreamOut { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(RegistryContainer));
			p_Writer.Write(IsWin32SubLevel);
			p_Writer.Write(IsXenonSubLevel);
			p_Writer.Write(IsPs3SubLevel);
			p_Writer.Write(RememberStateOnStreamOut);
		}
	}
}
