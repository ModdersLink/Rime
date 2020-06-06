///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class CompareEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new Realm(); // 0xC (12)
		
		[ContainerField(16)]
		public CompareOp Operator { get; set; } = new CompareOp(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float FloatIn0 { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float FloatIn1 { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public int IntIn0 { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public int IntIn1 { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2153507813:
					Operator = (CompareOp) Enum.ToObject(typeof(CompareOp), p_Value);
					break;

				case 1718513826:
					FloatIn0 = (float) p_Value;
					break;

				case 1718513827:
					FloatIn1 = (float) p_Value;
					break;

				case 2784473121:
					IntIn0 = (int) p_Value;
					break;

				case 2784473120:
					IntIn1 = (int) p_Value;
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
				case 229961746:
					return Realm;

				case 2153507813:
					return Operator;

				case 1718513826:
					return FloatIn0;

				case 1718513827:
					return FloatIn1;

				case 2784473121:
					return IntIn0;

				case 2784473120:
					return IntIn1;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(CompareEntityData).GetProperty(nameof(Realm));

				case 2153507813:
					return typeof(CompareEntityData).GetProperty(nameof(Operator));

				case 1718513826:
					return typeof(CompareEntityData).GetProperty(nameof(FloatIn0));

				case 1718513827:
					return typeof(CompareEntityData).GetProperty(nameof(FloatIn1));

				case 2784473121:
					return typeof(CompareEntityData).GetProperty(nameof(IntIn0));

				case 2784473120:
					return typeof(CompareEntityData).GetProperty(nameof(IntIn1));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
