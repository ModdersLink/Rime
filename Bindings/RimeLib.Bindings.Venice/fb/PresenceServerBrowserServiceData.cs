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
	[ContainerType(4, 48)]
	public class PresenceServerBrowserServiceData : 
		PresenceServiceData
	{
		[ContainerField(12)]
		public MatchmakingCriteria FilterCriterias { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable]
		public uint ListCapacity { get; set; }

		public static void Deserialize(PresenceServerBrowserServiceData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.MatchmakingCriteria.Deserialize(p_Instance.FilterCriterias, p_Reader, p_Parser);
			p_Instance.ListCapacity = p_Reader.ReadUInt32();
		}

	}
}
