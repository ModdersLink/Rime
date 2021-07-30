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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 24)]
	public class NormalizeSettings : FrostbiteContainer
	{
		[ContainerField(Name: "Maximum", Offset: 0, NameHash: 1313344397, Flags: 49469), LayoutImmutable, Blittable]
		public float Maximum { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Minimum", Offset: 4, NameHash: 1011407507, Flags: 49469), LayoutImmutable, Blittable]
		public float Minimum { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "Velocity", Offset: 8, NameHash: 3860766482, Flags: 49469), LayoutImmutable, Blittable]
		public float Velocity { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "Lower", Offset: 12, NameHash: 218180838, Flags: 49469), LayoutImmutable, Blittable]
		public float Lower { get; set; } // 0xC (12)
		
		[ContainerField(Name: "Upper", Offset: 16, NameHash: 219190343, Flags: 49469), LayoutImmutable, Blittable]
		public float Upper { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "Normalize", Offset: 20, NameHash: 3221786848, Flags: 49325), LayoutImmutable, Blittable]
		public bool Normalize { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1313344397:
					Maximum = (float) p_Value;
					break;

				case 1011407507:
					Minimum = (float) p_Value;
					break;

				case 3860766482:
					Velocity = (float) p_Value;
					break;

				case 218180838:
					Lower = (float) p_Value;
					break;

				case 219190343:
					Upper = (float) p_Value;
					break;

				case 3221786848:
					Normalize = (bool) p_Value;
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
				case 1313344397:
					return Maximum;

				case 1011407507:
					return Minimum;

				case 3860766482:
					return Velocity;

				case 218180838:
					return Lower;

				case 219190343:
					return Upper;

				case 3221786848:
					return Normalize;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1313344397:
					return typeof(NormalizeSettings).GetProperty(nameof(Maximum));

				case 1011407507:
					return typeof(NormalizeSettings).GetProperty(nameof(Minimum));

				case 3860766482:
					return typeof(NormalizeSettings).GetProperty(nameof(Velocity));

				case 218180838:
					return typeof(NormalizeSettings).GetProperty(nameof(Lower));

				case 219190343:
					return typeof(NormalizeSettings).GetProperty(nameof(Upper));

				case 3221786848:
					return typeof(NormalizeSettings).GetProperty(nameof(Normalize));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
