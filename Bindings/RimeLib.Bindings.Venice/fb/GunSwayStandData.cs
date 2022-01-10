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
	[ContainerType(4, 280)]
	public class GunSwayStandData
	{
		[ContainerField(0)]
		public GunSwayBaseMoveJumpData NoZoom { get; set; } = new();
		
		[ContainerField(140)]
		public GunSwayBaseMoveJumpData Zoom { get; set; } = new();
		
		public static void Deserialize(GunSwayStandData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.GunSwayBaseMoveJumpData.Deserialize(p_Instance.NoZoom, p_Reader, p_Parser);
			fb.GunSwayBaseMoveJumpData.Deserialize(p_Instance.Zoom, p_Reader, p_Parser);
		}
	}
}
