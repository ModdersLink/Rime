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
	[ContainerType(4, 16)]
	public class UnlockableTextureSliceCollection :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public int DefaultValue { get; set; }

		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<TextureSliceUnlockPartData> PossibleValues { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DefaultValue);
			(RimeWriter Writer, uint ArrayIndex) s_PossibleValues = p_EbxWriter.GetArrayWriter(PossibleValues.GetType(), PossibleValues.Count);
			p_Writer.Write(s_PossibleValues.ArrayIndex);
			foreach (var s_Entry in PossibleValues)
			{
				s_PossibleValues.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
