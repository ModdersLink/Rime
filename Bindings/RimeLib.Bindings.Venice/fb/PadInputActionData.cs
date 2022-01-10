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
	[ContainerType(4, 36)]
	public class PadInputActionData : 
		AxesInputActionData
	{
		[ContainerField(20)]
		public InputDevicePadButtons Button { get; set; } = new();

		[ContainerField(24)]
		public InputDevicePOVs Pov { get; set; } = new();

		[ContainerField(28)]
		public InputDevicePadButtons PS3AlternativeButton { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool UseSquareInput { get; set; }

		public static void Deserialize(PadInputActionData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Button = (InputDevicePadButtons) p_Reader.ReadInt32();
			p_Instance.Pov = (InputDevicePOVs) p_Reader.ReadInt32();
			p_Instance.PS3AlternativeButton = (InputDevicePadButtons) p_Reader.ReadInt32();
			p_Instance.UseSquareInput = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
