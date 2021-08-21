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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 80)]
	public class CameraLeapData : FrostbiteContainer
	{
		[ContainerField(Name: "Transform", Offset: 0, NameHash: 2270319721, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get; set; } = new LinearTransform(); // 0x0 (0)
		
		[ContainerField(Name: "Time", Offset: 64, NameHash: 2089313744, Flags: 49469), LayoutImmutable, Blittable]
		public float Time { get; set; } // 0x40 (64)
		
		[ContainerField(Name: "FovModifier", Offset: 68, NameHash: 3245684845, Flags: 49469), LayoutImmutable, Blittable]
		public float FovModifier { get; set; } // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2270319721:
					Transform = (LinearTransform) p_Value;
					break;

				case 2089313744:
					Time = (float) p_Value;
					break;

				case 3245684845:
					FovModifier = (float) p_Value;
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
				case 2270319721:
					return Transform;

				case 2089313744:
					return Time;

				case 3245684845:
					return FovModifier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2270319721:
					return typeof(CameraLeapData).GetProperty(nameof(Transform));

				case 2089313744:
					return typeof(CameraLeapData).GetProperty(nameof(Time));

				case 3245684845:
					return typeof(CameraLeapData).GetProperty(nameof(FovModifier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
