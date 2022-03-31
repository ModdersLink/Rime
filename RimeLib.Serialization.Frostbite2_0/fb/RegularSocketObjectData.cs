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

namespace fb
{
	[ContainerType(16, 160)]
	public class RegularSocketObjectData :
		SocketObjectData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public LinearTransform Transform { get; set; } = new();

		[ContainerField(144), JsonProperty(Order = 144)]
		public List<LinearTransform> Mesh3pTransforms { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			Transform.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Mesh3pTransforms = p_EbxWriter.GetArrayWriter(Mesh3pTransforms.GetType(), Mesh3pTransforms.Count);
			p_Writer.Write(s_Mesh3pTransforms.ArrayIndex);
			foreach (var s_Entry in Mesh3pTransforms)
			{
				s_Entry.Serialize(s_Mesh3pTransforms.Writer, p_EbxWriter);
			}
			p_Writer.WriteNullBytes(12);
		}
	}
}
