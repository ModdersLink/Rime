///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 20)]
	public class AwardHeaderData : 
		AbstractAwardData
	{
		[ContainerField(12)]
		public AwardGroup Group { get; set; } = new();

		[ContainerField(16)]
		public StatsMultiplicity Multiplicity { get; set; } = new();

		public static void Deserialize(AwardHeaderData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Group = (AwardGroup) p_Reader.ReadInt32();
			p_Instance.Multiplicity = (StatsMultiplicity) p_Reader.ReadInt32();
		}

	}
}
