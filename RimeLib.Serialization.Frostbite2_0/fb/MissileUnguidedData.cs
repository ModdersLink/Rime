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
	[ContainerType(4, 20)]
	public partial class MissileUnguidedData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private Vec2 _StaticPosition = new();
		
		[ObservableProperty]
		[property: ContainerField(8), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private Vec2 _TargetPositionOffset = new();
		
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private bool _UseTargetPosition;
		
		[ObservableProperty]
		[property: ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		private bool _UseStaticPosition;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			StaticPosition.Serialize(p_Writer, p_EbxWriter);
			TargetPositionOffset.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(UseTargetPosition);
			p_Writer.Write(UseStaticPosition);
			p_Writer.WriteNullBytes(2);
		}
	}
}
