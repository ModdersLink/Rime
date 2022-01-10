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
	public class ProceduralAwarenessAntRefs : 
		DataContainer
	{
		[ContainerField(8)]
		public AntRef ProceduralAwarenessActive { get; set; } = new();

		[ContainerField(12)]
		public AntRef ProceduralAwarenessHumanIKActive { get; set; } = new();

		[ContainerField(16)]
		public AntRef ProceduralAwarenessData { get; set; } = new();

		public static void Deserialize(ProceduralAwarenessAntRefs p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.ProceduralAwarenessActive, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.ProceduralAwarenessHumanIKActive, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.ProceduralAwarenessData, p_Reader, p_Parser);
		}

	}
}
