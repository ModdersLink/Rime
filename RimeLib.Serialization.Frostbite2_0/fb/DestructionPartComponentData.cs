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
	[ContainerType(16, 112)]
	public class DestructionPartComponentData :
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public RefArray<GameObjectData> Objects { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public uint PartIndex { get; set; }

		[ContainerField(104), JsonProperty(Order = 104)]
		public DestructionConnectivityType ConnectivityType { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public bool Fixed { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		public bool Fragile { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Objects = p_EbxWriter.GetArrayWriter(Objects.GetType(), Objects.Count);
			p_Writer.Write(s_Objects.ArrayIndex);
			foreach (var s_Entry in Objects)
			{
				s_Objects.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(PartIndex);
			p_Writer.Write((int) ConnectivityType);
			p_Writer.Write(Fixed);
			p_Writer.Write(Fragile);
			p_Writer.WriteNullBytes(2);
		}
	}
}
