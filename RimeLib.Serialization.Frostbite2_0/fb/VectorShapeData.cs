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
	public partial class VectorShapeData :
		BaseShapeData
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<Vec3> _Points = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<Vec3> _Normals = new();

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _Tension;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private bool _IsClosed;

		[ObservableProperty]
		[property: ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		private bool _AllowRoll;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Points = p_EbxWriter.GetArrayWriter(Points.GetType(), Points.Count);
			p_Writer.Write(s_Points.ArrayIndex);
			foreach (var s_Entry in Points)
			{
				s_Entry.Serialize(s_Points.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_Normals = p_EbxWriter.GetArrayWriter(Normals.GetType(), Normals.Count);
			p_Writer.Write(s_Normals.ArrayIndex);
			foreach (var s_Entry in Normals)
			{
				s_Entry.Serialize(s_Normals.Writer, p_EbxWriter);
			}
			p_Writer.Write(Tension);
			p_Writer.Write(IsClosed);
			p_Writer.Write(AllowRoll);
			p_Writer.WriteNullBytes(2);
		}
	}
}
