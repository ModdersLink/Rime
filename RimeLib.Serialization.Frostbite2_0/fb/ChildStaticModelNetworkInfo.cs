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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 20)]
	public class ChildStaticModelNetworkInfo :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public IndexRange NetworkRange { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint ParentPartComponentIndex { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint ParentHealthStateIndex { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint InstanceIndex { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			NetworkRange.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ParentPartComponentIndex);
			p_Writer.Write(ParentHealthStateIndex);
			p_Writer.Write(InstanceIndex);
		}
	}
}
