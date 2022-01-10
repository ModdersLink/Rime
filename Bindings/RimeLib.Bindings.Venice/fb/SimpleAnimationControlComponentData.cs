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
	public class SimpleAnimationControlComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public SimpleAnimationControlBinding Binding { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public bool Run { get; set; }

		public static void Deserialize(SimpleAnimationControlComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.SimpleAnimationControlBinding.Deserialize(p_Instance.Binding, p_Reader, p_Parser);
			p_Instance.AnimationEntitySpacePriority = p_Reader.ReadInt32();
			p_Instance.Run = p_Reader.ReadBool();
			p_Reader.Seek(7, SeekOrigin.Current);
		}

	}
}
