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
	[ContainerType(16, 96)]
	public class GameEntityData :
		SpatialEntityData
	{
		[ContainerField(80), JsonProperty(Order = 80)]
		public RefArray<GameObjectData> Components { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public bool Enabled { get; set; }

		[ContainerField(85), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
		public sbyte RuntimeComponentCount { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Components = p_EbxWriter.GetArrayWriter(Components.GetType(), Components.Count);
			p_Writer.Write(s_Components.ArrayIndex);
			foreach (var s_Entry in Components)
			{
				s_Components.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(Enabled);
			p_Writer.Write(RuntimeComponentCount);
			p_Writer.WriteNullBytes(10);
		}
	}
}
