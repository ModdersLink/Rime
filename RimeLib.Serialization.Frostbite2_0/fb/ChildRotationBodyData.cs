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
	[ContainerType(4, 80)]
	public partial class ChildRotationBodyData :
		RotationBodyData
	{
		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _ForceModifier;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _ResetForceModifier;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _ResetForceInputThreshold;

		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private EntryInputActionEnum _RotationInput = new();

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _WorldSpaceLockEfficiency;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private bool _UseLinearInput;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ForceModifier);
			p_Writer.Write(ResetForceModifier);
			p_Writer.Write(ResetForceInputThreshold);
			p_Writer.Write((int) RotationInput);
			p_Writer.Write(WorldSpaceLockEfficiency);
			p_Writer.Write(UseLinearInput);
			p_Writer.WriteNullBytes(3);
		}
	}
}
