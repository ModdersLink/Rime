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
	public class PhysicsDebugSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint TimingRecursionDepth { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public bool UsePhysicsCpuTimers { get; set; }

		[ContainerField(13), LayoutImmutable, Blittable]
		public bool DebugHingeConstraints { get; set; }

		public static void Deserialize(PhysicsDebugSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TimingRecursionDepth = p_Reader.ReadUInt32();
			p_Instance.UsePhysicsCpuTimers = p_Reader.ReadBool();
			p_Instance.DebugHingeConstraints = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
