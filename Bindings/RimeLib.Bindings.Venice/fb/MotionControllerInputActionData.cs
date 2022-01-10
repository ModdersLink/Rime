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
	[ContainerType(4, 24)]
	public class MotionControllerInputActionData : 
		AxesInputActionData
	{
		[ContainerField(20)]
		public InputDeviceMotionControllerButtons Button { get; set; } = new();

		public static void Deserialize(MotionControllerInputActionData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Button = (InputDeviceMotionControllerButtons) p_Reader.ReadInt32();
		}

	}
}
