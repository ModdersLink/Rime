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
	[ContainerType(4, 44)]
	public class InterludeOrderEntityData : 
		BFOrderEntityData
	{
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool IsCutscene { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable]
		public bool Crouch { get; set; }

		public static void Deserialize(InterludeOrderEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.IsCutscene = p_Reader.ReadBool();
			p_Instance.Crouch = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
