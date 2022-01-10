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
	[ContainerType(16, 96)]
	public class PhysicsConstraintData : 
		GameObjectData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get; set; } = new();

		[ContainerField(80)]
		public CtrRef<ReferenceObjectData> ConstrainedObject { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable]
		public float BreakThreshold { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public bool IsBreakable { get; set; }

		public static void Deserialize(PhysicsConstraintData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.Transform, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ConstrainedObject.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.BreakThreshold = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.IsBreakable = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
