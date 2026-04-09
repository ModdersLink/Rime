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
	[ContainerType(4, 24)]
	public partial class MaterialRelationEffectData :
		PhysicsMaterialRelationPropertyData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private RefArray<EffectBlueprint> _ImpactEffects = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<ObjectBlueprint> _ImpactDebris = new();

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _ImpactEffectMaxSpreadAngle;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private bool _MirrorImpactDirection;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_ImpactEffects = p_EbxWriter.GetArrayWriter(ImpactEffects.GetType(), ImpactEffects.Count);
			p_Writer.Write(s_ImpactEffects.ArrayIndex);
			foreach (var s_Entry in ImpactEffects)
			{
				s_ImpactEffects.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_ImpactDebris = p_EbxWriter.GetArrayWriter(ImpactDebris.GetType(), ImpactDebris.Count);
			p_Writer.Write(s_ImpactDebris.ArrayIndex);
			foreach (var s_Entry in ImpactDebris)
			{
				s_ImpactDebris.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(ImpactEffectMaxSpreadAngle);
			p_Writer.Write(MirrorImpactDirection);
			p_Writer.WriteNullBytes(3);
		}
	}
}
