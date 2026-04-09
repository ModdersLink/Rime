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
	[ContainerType(16, 144)]
	public partial class ClimbLadderComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private int _ClimbPhase;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private int _ConnectPhase;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _ConnectJointDisplacement;

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private ClimbLadderBinding _Binding = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ClimbPhase);
			p_Writer.Write(ConnectPhase);
			p_Writer.Write(ConnectJointDisplacement);
			Binding.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(12);
		}
	}
}
