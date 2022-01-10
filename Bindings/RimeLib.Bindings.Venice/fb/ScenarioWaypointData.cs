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
	[ContainerType(16, 144)]
	public class ScenarioWaypointData : 
		AbstractLocoWaypointData
	{
		[ContainerField(48)]
		public AntRef ScenarioAntRef { get; set; } = new();

		[ContainerField(64)]
		public ScenarioTaskData ScenarioTask { get; set; } = new();

		public static void Deserialize(ScenarioWaypointData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.ScenarioAntRef, p_Reader, p_Parser);
			p_Reader.Seek(12, SeekOrigin.Current);
			fb.ScenarioTaskData.Deserialize(p_Instance.ScenarioTask, p_Reader, p_Parser);
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
