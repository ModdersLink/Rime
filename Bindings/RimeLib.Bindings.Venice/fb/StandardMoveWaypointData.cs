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
	[ContainerType(16, 96)]
	public class StandardMoveWaypointData : 
		AbstractLocoWaypointData
	{
		[ContainerField(48)]
		public AILocoMoveTaskData MoveTask { get; set; } = new();

		public static void Deserialize(StandardMoveWaypointData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AILocoMoveTaskData.Deserialize(p_Instance.MoveTask, p_Reader, p_Parser);
		}

	}
}
