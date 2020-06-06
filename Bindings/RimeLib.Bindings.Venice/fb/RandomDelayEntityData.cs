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
	public class RandomDelayEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MinDelay { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float MaxDelay { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public Realm Realm { get; set; } = new Realm(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool AutoStart { get; set; } // 0x18 (24)
		
		[ContainerField(25), LayoutImmutable, Blittable]
		public bool RunOnce { get; set; } // 0x19 (25)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3350783098:
					MinDelay = (float) p_Value;
					break;

				case 420379940:
					MaxDelay = (float) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 792615882:
					AutoStart = (bool) p_Value;
					break;

				case 709901739:
					RunOnce = (bool) p_Value;
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
				case 3350783098:
					return MinDelay;

				case 420379940:
					return MaxDelay;

				case 229961746:
					return Realm;

				case 792615882:
					return AutoStart;

				case 709901739:
					return RunOnce;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3350783098:
					return typeof(RandomDelayEntityData).GetProperty(nameof(MinDelay));

				case 420379940:
					return typeof(RandomDelayEntityData).GetProperty(nameof(MaxDelay));

				case 229961746:
					return typeof(RandomDelayEntityData).GetProperty(nameof(Realm));

				case 792615882:
					return typeof(RandomDelayEntityData).GetProperty(nameof(AutoStart));

				case 709901739:
					return typeof(RandomDelayEntityData).GetProperty(nameof(RunOnce));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
