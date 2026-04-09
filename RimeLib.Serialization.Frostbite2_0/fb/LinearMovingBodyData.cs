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
	[ContainerType(16, 80)]
	public partial class LinearMovingBodyData :
		MovingBodyData
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _Axis = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private EndPointData _Start = new();

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private EndPointData _End = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Axis.Serialize(p_Writer, p_EbxWriter);
			Start.Serialize(p_Writer, p_EbxWriter);
			End.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
		}
	}
}
