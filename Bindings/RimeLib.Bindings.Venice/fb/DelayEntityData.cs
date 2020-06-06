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
	public class DelayEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Delay { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public Realm Realm { get; set; } = new Realm(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool AutoStart { get; set; } // 0x14 (20)
		
		[ContainerField(21), LayoutImmutable, Blittable]
		public bool RunOnce { get; set; } // 0x15 (21)
		
		[ContainerField(22), LayoutImmutable, Blittable]
		public bool RemoveDuplicateEvents { get; set; } // 0x16 (22)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 208768368:
					Delay = (float) p_Value;
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

				case 2871488843:
					RemoveDuplicateEvents = (bool) p_Value;
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
				case 208768368:
					return Delay;

				case 229961746:
					return Realm;

				case 792615882:
					return AutoStart;

				case 709901739:
					return RunOnce;

				case 2871488843:
					return RemoveDuplicateEvents;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 208768368:
					return typeof(DelayEntityData).GetProperty(nameof(Delay));

				case 229961746:
					return typeof(DelayEntityData).GetProperty(nameof(Realm));

				case 792615882:
					return typeof(DelayEntityData).GetProperty(nameof(AutoStart));

				case 709901739:
					return typeof(DelayEntityData).GetProperty(nameof(RunOnce));

				case 2871488843:
					return typeof(DelayEntityData).GetProperty(nameof(RemoveDuplicateEvents));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
