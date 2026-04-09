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
	public partial class WheelComponentData :
		PartComponentData
	{
		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private CtrRef<WheelConfigData> _Config = new();

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private WheelPhysicsType _PhysicsType = new();

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _EffectClampVelocity;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Config));
			p_Writer.Write((int) PhysicsType);
			p_Writer.Write(EffectClampVelocity);
			p_Writer.WriteNullBytes(4);
		}
	}
}
