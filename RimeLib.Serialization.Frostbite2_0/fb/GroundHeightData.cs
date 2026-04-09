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
	[ContainerType(4, 16)]
	public partial class GroundHeightData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private Vec2 _HeightSpan = new();
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _WorldSize;
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<ushort> _Data = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			HeightSpan.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(WorldSize);
			(RimeWriter Writer, uint ArrayIndex) s_Data = p_EbxWriter.GetArrayWriter(Data.GetType(), Data.Count);
			p_Writer.Write(s_Data.ArrayIndex);
			foreach (var s_Entry in Data)
			{
				s_Data.Writer.Write(s_Entry);
			}
		}
	}
}
