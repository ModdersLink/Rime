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
	[ContainerType(16, 112)]
	public class RigidBodyConeConstraintData : 
		RigidBodyConstraintData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float MinAngle { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float AngularFriction { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float MaxAngle { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool HasLimits { get; set; }

		public static void Deserialize(RigidBodyConeConstraintData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MinAngle = p_Reader.ReadSingle();
			p_Instance.AngularFriction = p_Reader.ReadSingle();
			p_Instance.MaxAngle = p_Reader.ReadSingle();
			p_Instance.HasLimits = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
