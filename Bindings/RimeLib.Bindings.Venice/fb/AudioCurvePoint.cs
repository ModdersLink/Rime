///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class AudioCurvePoint : FrostbiteContainer
	{
		[ContainerField(Name: "X", Offset: 0, NameHash: 177661, Flags: 49469), LayoutImmutable, Blittable]
		public float X { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Y", Offset: 4, NameHash: 177660, Flags: 49469), LayoutImmutable, Blittable]
		public float Y { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "K", Offset: 8, NameHash: 177646, Flags: 49469), LayoutImmutable, Blittable]
		public float K { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 177661:
					X = (float) p_Value;
					break;

				case 177660:
					Y = (float) p_Value;
					break;

				case 177646:
					K = (float) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 177661:
					return X;

				case 177660:
					return Y;

				case 177646:
					return K;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 177661:
					return typeof(AudioCurvePoint).GetProperty(nameof(X));

				case 177660:
					return typeof(AudioCurvePoint).GetProperty(nameof(Y));

				case 177646:
					return typeof(AudioCurvePoint).GetProperty(nameof(K));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
