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
	public class SpringData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float Length { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float Stiffness { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Damping { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MaxSpringForce { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float ProgressiveStartRatio { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float ProgressiveExponent { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float VisualClipOffset { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float AttachOffsetY { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float DisabledStrenghModifier { get; set; }
		
		public static void Deserialize(SpringData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Length = p_Reader.ReadSingle();
			p_Instance.Stiffness = p_Reader.ReadSingle();
			p_Instance.Damping = p_Reader.ReadSingle();
			p_Instance.MaxSpringForce = p_Reader.ReadSingle();
			p_Instance.ProgressiveStartRatio = p_Reader.ReadSingle();
			p_Instance.ProgressiveExponent = p_Reader.ReadSingle();
			p_Instance.VisualClipOffset = p_Reader.ReadSingle();
			p_Instance.AttachOffsetY = p_Reader.ReadSingle();
			p_Instance.DisabledStrenghModifier = p_Reader.ReadSingle();
		}
	}
}
