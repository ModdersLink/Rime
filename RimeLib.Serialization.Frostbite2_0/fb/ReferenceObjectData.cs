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
	[ContainerType(16, 96)]
	public partial class ReferenceObjectData :
		GameObjectData
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private LinearTransform _BlueprintTransform = new();

		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private CtrRef<Blueprint> _Blueprint = new();

		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private CtrRef<ObjectVariation> _ObjectVariation = new();

		[ObservableProperty]
		[property: ContainerField(88), JsonProperty(Order = 88)]
		private StreamRealm _StreamRealm = new();

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private bool _CastSunShadowEnable;

		[ObservableProperty]
		[property: ContainerField(93), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
		private bool _Excluded;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			BlueprintTransform.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Blueprint));
			p_Writer.Write(p_EbxWriter.WriteImport(ObjectVariation));
			p_Writer.Write((int) StreamRealm);
			p_Writer.Write(CastSunShadowEnable);
			p_Writer.Write(Excluded);
			p_Writer.WriteNullBytes(2);
		}
	}
}
