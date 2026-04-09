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
	[ContainerType(16, 112)]
	public partial class ChildMovingBodyData :
		LinearMovingBodyData
	{
		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _InputDelay;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _Speed;

		[ObservableProperty]
		[property: ContainerField(88), JsonProperty(Order = 88)]
		private EntryInputActionEnum _InputAction = new();

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _TriggerImpulse;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private bool _IsOneShotInput;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(InputDelay);
			p_Writer.Write(Speed);
			p_Writer.Write((int) InputAction);
			p_Writer.Write(TriggerImpulse);
			p_Writer.Write(IsOneShotInput);
			p_Writer.WriteNullBytes(15);
		}
	}
}
