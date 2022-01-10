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
	public class TransformModifierEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In { get; set; } = new();

		[ContainerField(80)]
		public Realm Realm { get; set; } = new();

		[ContainerField(84)]
		public ModifierAxis Left { get; set; } = new();

		[ContainerField(88)]
		public ModifierAxis Up { get; set; } = new();

		[ContainerField(92)]
		public ModifierAxis Forward { get; set; } = new();

		[ContainerField(96), LayoutImmutable, Blittable]
		public bool InvertLeft { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable]
		public bool InvertUp { get; set; }

		[ContainerField(98), LayoutImmutable, Blittable]
		public bool InvertForward { get; set; }

		public static void Deserialize(TransformModifierEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.In, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Left = (ModifierAxis) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Up = (ModifierAxis) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Forward = (ModifierAxis) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.InvertLeft = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.InvertUp = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.InvertForward = p_Reader.ReadBool();
			p_Reader.Seek(17, SeekOrigin.Current);
		}

	}
}
