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
	public class CompareFloatEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new Realm(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float A { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float B { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool TriggerOnPropertyChange { get; set; } // 0x18 (24)
		
		[ContainerField(25), LayoutImmutable, Blittable]
		public bool TriggerOnStart { get; set; } // 0x19 (25)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 177636:
					A = (float) p_Value;
					break;

				case 177639:
					B = (float) p_Value;
					break;

				case 3134109917:
					TriggerOnPropertyChange = (bool) p_Value;
					break;

				case 3859836348:
					TriggerOnStart = (bool) p_Value;
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

				case 177636:
					return A;

				case 177639:
					return B;

				case 3134109917:
					return TriggerOnPropertyChange;

				case 3859836348:
					return TriggerOnStart;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(CompareFloatEntityData).GetProperty(nameof(Realm));

				case 177636:
					return typeof(CompareFloatEntityData).GetProperty(nameof(A));

				case 177639:
					return typeof(CompareFloatEntityData).GetProperty(nameof(B));

				case 3134109917:
					return typeof(CompareFloatEntityData).GetProperty(nameof(TriggerOnPropertyChange));

				case 3859836348:
					return typeof(CompareFloatEntityData).GetProperty(nameof(TriggerOnStart));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
