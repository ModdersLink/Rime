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
	[ContainerType(16, 176)]
	public partial class VisualEnvironmentEffectEntityData :
		EffectEntityData
	{
		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private Vec4 _LifetimeCurve = new();

		[ObservableProperty]
		[property: ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private Vec4 _CullDistanceCurve = new();

		[ObservableProperty]
		[property: ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private Vec4 _CullAngleCurve = new();

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _Lifetime;

		[ObservableProperty]
		[property: ContainerField(164), JsonProperty(Order = 164)]
		private CtrRef<VisualEnvironmentBlueprint> _VisualEnvironment = new();

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private bool _SampleOnStartOnly;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			LifetimeCurve.Serialize(p_Writer, p_EbxWriter);
			CullDistanceCurve.Serialize(p_Writer, p_EbxWriter);
			CullAngleCurve.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Lifetime);
			p_Writer.Write(p_EbxWriter.WriteImport(VisualEnvironment));
			p_Writer.Write(SampleOnStartOnly);
			p_Writer.WriteNullBytes(7);
		}
	}
}
