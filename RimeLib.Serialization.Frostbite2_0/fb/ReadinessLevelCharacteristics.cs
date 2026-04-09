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
	[ContainerType(4, 12)]
	public partial class ReadinessLevelCharacteristics :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private float _MinReactionTime;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		private float _MaxReactionTime;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _ReductionTime;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MinReactionTime);
			p_Writer.Write(MaxReactionTime);
			p_Writer.Write(ReductionTime);
		}
	}
}
