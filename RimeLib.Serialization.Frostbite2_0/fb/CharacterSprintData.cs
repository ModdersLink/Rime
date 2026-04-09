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
	public partial class CharacterSprintData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _SprintPowerDecreasePerSecond;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _SprintPowerIncreasePerSecond;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _SprintMinimumPower;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private bool _AllowContinousSprinting;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(SprintPowerDecreasePerSecond);
			p_Writer.Write(SprintPowerIncreasePerSecond);
			p_Writer.Write(SprintMinimumPower);
			p_Writer.Write(AllowContinousSprinting);
			p_Writer.WriteNullBytes(3);
		}
	}
}
