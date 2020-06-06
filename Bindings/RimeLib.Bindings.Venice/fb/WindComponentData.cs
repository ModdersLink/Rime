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
    [ContainerType(16)]
	public class WindComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public Realm Realm { get; set; } = new Realm(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float WindDirection { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float WindStrength { get; set; } // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 3147800788:
					WindDirection = (float) p_Value;
					break;

				case 3768589012:
					WindStrength = (float) p_Value;
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

				case 3147800788:
					return WindDirection;

				case 3768589012:
					return WindStrength;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(WindComponentData).GetProperty(nameof(Realm));

				case 3147800788:
					return typeof(WindComponentData).GetProperty(nameof(WindDirection));

				case 3768589012:
					return typeof(WindComponentData).GetProperty(nameof(WindStrength));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
