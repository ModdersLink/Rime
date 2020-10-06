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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(20), ContainerStruct]
	public class EndPointData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Pos { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float EndDamping { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float SpringLength { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float SpringAcceleration { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float SpringDamping { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193467465:
					Pos = (float) p_Value;
					break;

				case 2868914898:
					EndDamping = (float) p_Value;
					break;

				case 116753576:
					SpringLength = (float) p_Value;
					break;

				case 820551190:
					SpringAcceleration = (float) p_Value;
					break;

				case 1976598700:
					SpringDamping = (float) p_Value;
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
				case 193467465:
					return Pos;

				case 2868914898:
					return EndDamping;

				case 116753576:
					return SpringLength;

				case 820551190:
					return SpringAcceleration;

				case 1976598700:
					return SpringDamping;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193467465:
					return typeof(EndPointData).GetProperty(nameof(Pos));

				case 2868914898:
					return typeof(EndPointData).GetProperty(nameof(EndDamping));

				case 116753576:
					return typeof(EndPointData).GetProperty(nameof(SpringLength));

				case 820551190:
					return typeof(EndPointData).GetProperty(nameof(SpringAcceleration));

				case 1976598700:
					return typeof(EndPointData).GetProperty(nameof(SpringDamping));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
