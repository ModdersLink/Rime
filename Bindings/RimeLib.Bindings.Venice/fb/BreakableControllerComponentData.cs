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
	[ContainerType(16, 128)]
	public class BreakableControllerComponentData : 
		DestructionControllerComponentData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public uint BreakablePartCount { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public uint NetworkIdCount { get; set; }

		public static void Deserialize(BreakableControllerComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.BreakablePartCount = p_Reader.ReadUInt32();
			p_Instance.NetworkIdCount = p_Reader.ReadUInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
