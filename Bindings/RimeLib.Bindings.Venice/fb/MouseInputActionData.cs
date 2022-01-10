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
	[ContainerType(4, 28)]
	public class MouseInputActionData : 
		AxesInputActionData
	{
		[ContainerField(20)]
		public InputDeviceMouseButtons Button { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool SimulateJoystickAxis { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool RememberExcessInput { get; set; }

		[ContainerField(26), LayoutImmutable, Blittable]
		public bool ScaleScrollWheelAxisInput { get; set; }

		public static void Deserialize(MouseInputActionData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Button = (InputDeviceMouseButtons) p_Reader.ReadInt32();
			p_Instance.SimulateJoystickAxis = p_Reader.ReadBool();
			p_Instance.RememberExcessInput = p_Reader.ReadBool();
			p_Instance.ScaleScrollWheelAxisInput = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
