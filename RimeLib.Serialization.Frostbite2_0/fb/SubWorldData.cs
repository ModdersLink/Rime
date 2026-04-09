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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 44)]
	public partial class SubWorldData :
		SpatialPrefabBlueprint
	{
		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private CtrRef<RegistryContainer> _RegistryContainer = new();

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private bool _IsWin32SubLevel;

		[ObservableProperty]
		[property: ContainerField(41), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
		private bool _IsXenonSubLevel;

		[ObservableProperty]
		[property: ContainerField(42), LayoutImmutable, Blittable, JsonProperty(Order = 42)]
		private bool _IsPs3SubLevel;

		[ObservableProperty]
		[property: ContainerField(43), LayoutImmutable, Blittable, JsonProperty(Order = 43)]
		private bool _RememberStateOnStreamOut;

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
