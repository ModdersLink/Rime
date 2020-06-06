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
	public class Or4EntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new Realm(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool In1 { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool In2 { get; set; } // 0x11 (17)
		
		[ContainerField(18), LayoutImmutable, Blittable]
		public bool In3 { get; set; } // 0x12 (18)
		
		[ContainerField(19), LayoutImmutable, Blittable]
		public bool In4 { get; set; } // 0x13 (19)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 193450867:
					In1 = (bool) p_Value;
					break;

				case 193450864:
					In2 = (bool) p_Value;
					break;

				case 193450865:
					In3 = (bool) p_Value;
					break;

				case 193450870:
					In4 = (bool) p_Value;
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

				case 193450867:
					return In1;

				case 193450864:
					return In2;

				case 193450865:
					return In3;

				case 193450870:
					return In4;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(Or4EntityData).GetProperty(nameof(Realm));

				case 193450867:
					return typeof(Or4EntityData).GetProperty(nameof(In1));

				case 193450864:
					return typeof(Or4EntityData).GetProperty(nameof(In2));

				case 193450865:
					return typeof(Or4EntityData).GetProperty(nameof(In3));

				case 193450870:
					return typeof(Or4EntityData).GetProperty(nameof(In4));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
