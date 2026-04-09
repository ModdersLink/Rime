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
	public partial class BreakablePartComponentData :
		DestructionPartComponentData
	{
		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private uint _HealthPercentage;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private bool _Collapsable;

		[ObservableProperty]
		[property: ContainerField(117), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
		private bool _DestroyNearbyStaticEntities;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(HealthPercentage);
			p_Writer.Write(Collapsable);
			p_Writer.Write(DestroyNearbyStaticEntities);
			p_Writer.WriteNullBytes(10);
		}
	}
}
