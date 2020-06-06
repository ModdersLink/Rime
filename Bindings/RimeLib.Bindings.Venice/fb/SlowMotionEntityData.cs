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
	public class SlowMotionEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new Realm(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float TimeScale { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float ScaleDownTransitionTime { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float ScaleUpTransitionTime { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 169511528:
					TimeScale = (float) p_Value;
					break;

				case 3146782549:
					ScaleDownTransitionTime = (float) p_Value;
					break;

				case 877920322:
					ScaleUpTransitionTime = (float) p_Value;
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

				case 169511528:
					return TimeScale;

				case 3146782549:
					return ScaleDownTransitionTime;

				case 877920322:
					return ScaleUpTransitionTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(SlowMotionEntityData).GetProperty(nameof(Realm));

				case 169511528:
					return typeof(SlowMotionEntityData).GetProperty(nameof(TimeScale));

				case 3146782549:
					return typeof(SlowMotionEntityData).GetProperty(nameof(ScaleDownTransitionTime));

				case 877920322:
					return typeof(SlowMotionEntityData).GetProperty(nameof(ScaleUpTransitionTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
