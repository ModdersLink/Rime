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
	public partial class RandomDelayEntityData :
		EntityData
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _MinDelay;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _MaxDelay;

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private bool _AutoStart;

		[ObservableProperty]
		[property: ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		private bool _RunOnce;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MinDelay);
			p_Writer.Write(MaxDelay);
			p_Writer.Write((int) Realm);
			p_Writer.Write(AutoStart);
			p_Writer.Write(RunOnce);
			p_Writer.WriteNullBytes(2);
		}
	}
}
