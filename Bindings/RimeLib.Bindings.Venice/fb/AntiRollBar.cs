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
	public class AntiRollBar : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Stiffness { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float TorqueActivationLimit { get; set; }

		public static void Deserialize(AntiRollBar p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Stiffness = p_Reader.ReadSingle();
			p_Instance.TorqueActivationLimit = p_Reader.ReadSingle();
		}

	}
}
