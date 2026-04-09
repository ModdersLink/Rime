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
	[ContainerType(4, 28)]
	public partial class OnGroundStateData :
		CharacterStateData
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _JumpDelay;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _JumpStaminaPenalty;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _AllowedDistanceFromGround;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private bool _GroundHugging;

		[ObservableProperty]
		[property: ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		private bool _LimitDownwardVelocity;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(JumpDelay);
			p_Writer.Write(JumpStaminaPenalty);
			p_Writer.Write(AllowedDistanceFromGround);
			p_Writer.Write(GroundHugging);
			p_Writer.Write(LimitDownwardVelocity);
			p_Writer.WriteNullBytes(2);
		}
	}
}
