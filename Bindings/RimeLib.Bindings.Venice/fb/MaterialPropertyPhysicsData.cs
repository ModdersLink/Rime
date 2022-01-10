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
	public class MaterialPropertyPhysicsData : 
		PhysicsMaterialRelationPropertyData
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float DynamicFrictionModifier { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float StaticFrictionModifier { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float RestitutionModifier { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float Resistance { get; set; }

		public static void Deserialize(MaterialPropertyPhysicsData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DynamicFrictionModifier = p_Reader.ReadSingle();
			p_Instance.StaticFrictionModifier = p_Reader.ReadSingle();
			p_Instance.RestitutionModifier = p_Reader.ReadSingle();
			p_Instance.Resistance = p_Reader.ReadSingle();
		}

	}
}
