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
	[ContainerType(16, 128)]
	public partial class MobileSpawnComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _ParachuteSpawnRadiusMin;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _ParachuteSpawnDistance;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, JsonProperty(Order = 104)]
		private string _NameSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _ParachuteSpawnRadiusMax;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private bool _EnterMobileSpawnPoint;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ParachuteSpawnRadiusMin);
			p_Writer.Write(ParachuteSpawnDistance);
			p_Writer.Write(p_EbxWriter.WriteString(NameSid));
			p_Writer.Write(ParachuteSpawnRadiusMax);
			p_Writer.Write(EnterMobileSpawnPoint);
			p_Writer.WriteNullBytes(15);
		}
	}
}
