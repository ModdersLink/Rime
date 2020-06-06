///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class DeathEvent : 
		MetricEvent
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Position { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 KillerPosition { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public ulong KillerId { get; set; } // 0x30 (48)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float Time { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable]
		public string Weapon { get; set; } // 0x3C (60)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3402582524:
					Position = (Vec3) p_Value;
					break;

				case 1483294665:
					KillerPosition = (Vec3) p_Value;
					break;

				case 3035491517:
					KillerId = (ulong) p_Value;
					break;

				case 2089313744:
					Time = (float) p_Value;
					break;

				case 3190562823:
					Weapon = (string) p_Value;
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
				case 3402582524:
					return Position;

				case 1483294665:
					return KillerPosition;

				case 3035491517:
					return KillerId;

				case 2089313744:
					return Time;

				case 3190562823:
					return Weapon;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3402582524:
					return typeof(DeathEvent).GetProperty(nameof(Position));

				case 1483294665:
					return typeof(DeathEvent).GetProperty(nameof(KillerPosition));

				case 3035491517:
					return typeof(DeathEvent).GetProperty(nameof(KillerId));

				case 2089313744:
					return typeof(DeathEvent).GetProperty(nameof(Time));

				case 3190562823:
					return typeof(DeathEvent).GetProperty(nameof(Weapon));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
