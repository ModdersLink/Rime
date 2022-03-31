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
	[ContainerType(16, 224)]
	public class SoldierEntryComponentData :
		EntryComponentData
	{
		[ContainerField(192), JsonProperty(Order = 192)]
		public AimingConstraintsData AimingConstraints { get; set; } = new();

		[ContainerField(208), JsonProperty(Order = 208)]
		public CtrRef<AntEnumeration> AntEntryEnumeration { get; set; } = new();

		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public bool AlignConstraintsToEntity { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			AimingConstraints.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(AntEntryEnumeration));
			p_Writer.Write(AlignConstraintsToEntity);
			p_Writer.WriteNullBytes(11);
		}
	}
}
