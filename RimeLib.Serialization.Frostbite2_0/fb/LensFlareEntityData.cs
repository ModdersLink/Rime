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
	[ContainerType(16, 96)]
	public partial class LensFlareEntityData :
		SpatialEntityData
	{
		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private List<LensFlareElement> _Elements = new();

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _OccluderSize;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private bool _Visible;

		[ObservableProperty]
		[property: ContainerField(89), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
		private bool _HalfRes;

		[ObservableProperty]
		[property: ContainerField(90), LayoutImmutable, Blittable, JsonProperty(Order = 90)]
		private bool _DebugDrawOccluder;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Elements = p_EbxWriter.GetArrayWriter(Elements.GetType(), Elements.Count);
			p_Writer.Write(s_Elements.ArrayIndex);
			foreach (var s_Entry in Elements)
			{
				s_Entry.Serialize(s_Elements.Writer, p_EbxWriter);
			}
			p_Writer.Write(OccluderSize);
			p_Writer.Write(Visible);
			p_Writer.Write(HalfRes);
			p_Writer.Write(DebugDrawOccluder);
			p_Writer.WriteNullBytes(5);
		}
	}
}
