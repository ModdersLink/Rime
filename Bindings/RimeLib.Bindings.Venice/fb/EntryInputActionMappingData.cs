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
	[ContainerType(4, 16)]
	public class EntryInputActionMappingData : 
		InputActionMappingData
	{
		[ContainerField(8)]
		public EntryInputActionEnum ActionIdentifier { get; set; } = new();

		[ContainerField(12)]
		public InputConceptIdentifiers ConceptIdentifier { get; set; } = new();

		public static void Deserialize(EntryInputActionMappingData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ActionIdentifier = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Instance.ConceptIdentifier = (InputConceptIdentifiers) p_Reader.ReadInt32();
		}

	}
}
