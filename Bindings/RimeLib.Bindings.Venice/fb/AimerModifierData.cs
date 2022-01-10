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
	public class AimerModifierData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float LookSpeedMultiplier { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public bool OnlyInSupportedShooting { get; set; }

		public static void Deserialize(AimerModifierData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.LookSpeedMultiplier = p_Reader.ReadSingle();
			p_Instance.OnlyInSupportedShooting = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
