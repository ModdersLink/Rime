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
	[ContainerType(16, 32)]
	public class ConstantForceData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Value { get; set; } = new();
		
		[ContainerField(16)]
		public ForceCondition Condition { get; set; } = new();
		
		[ContainerField(20)]
		public ForceType TypeOfForce { get; set; } = new();
		
		[ContainerField(24)]
		public SpaceType Space { get; set; } = new();
		
		public static void Deserialize(ConstantForceData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.Value, p_Reader, p_Parser);
			p_Instance.Condition = (ForceCondition) p_Reader.ReadInt32();
			p_Instance.TypeOfForce = (ForceType) p_Reader.ReadInt32();
			p_Instance.Space = (SpaceType) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
		}
	}
}
