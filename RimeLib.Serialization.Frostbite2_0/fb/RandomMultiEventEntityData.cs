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
	public partial class RandomMultiEventEntityData :
		EntityData
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<float> _RandomEventWeight = new();

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private bool _UniformDistribution;

		[ObservableProperty]
		[property: ContainerField(21), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
		private bool _ResetOutputsWhenAllHasTriggered;

		[ObservableProperty]
		[property: ContainerField(22), LayoutImmutable, Blittable, JsonProperty(Order = 22)]
		private bool _DisableOutputOnTrigger;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Realm);
			(RimeWriter Writer, uint ArrayIndex) s_RandomEventWeight = p_EbxWriter.GetArrayWriter(RandomEventWeight.GetType(), RandomEventWeight.Count);
			p_Writer.Write(s_RandomEventWeight.ArrayIndex);
			foreach (var s_Entry in RandomEventWeight)
			{
				s_RandomEventWeight.Writer.Write(s_Entry);
			}
			p_Writer.Write(UniformDistribution);
			p_Writer.Write(ResetOutputsWhenAllHasTriggered);
			p_Writer.Write(DisableOutputOnTrigger);
			p_Writer.WriteNullBytes(1);
		}
	}
}
