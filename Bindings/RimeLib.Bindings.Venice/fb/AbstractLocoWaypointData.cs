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
	public class AbstractLocoWaypointData : 
		WaypointData
	{
		[ContainerField(16)]
		public AILocoBaseTaskData BaseTask { get; set; } = new();

		public static void Deserialize(AbstractLocoWaypointData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AILocoBaseTaskData.Deserialize(p_Instance.BaseTask, p_Reader, p_Parser);
		}

	}
}
