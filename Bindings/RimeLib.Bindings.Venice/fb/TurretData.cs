///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class TurretData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float PitchP { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float YawP { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float FakeShootSpaceMinDistance { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float FakeShootSpaceMaxDistance { get; set; } // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<AIAimingConstraintsData> AimingConstraints { get; set; } = new CtrRef<AIAimingConstraintsData>(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3380975443:
					PitchP = (float) p_Value;
					break;

				case 2089497178:
					YawP = (float) p_Value;
					break;

				case 4286661422:
					FakeShootSpaceMinDistance = (float) p_Value;
					break;

				case 1645003312:
					FakeShootSpaceMaxDistance = (float) p_Value;
					break;

				case 1523178198:
					AimingConstraints = (CtrRef<AIAimingConstraintsData>) p_Value;
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
				case 3380975443:
					return PitchP;

				case 2089497178:
					return YawP;

				case 4286661422:
					return FakeShootSpaceMinDistance;

				case 1645003312:
					return FakeShootSpaceMaxDistance;

				case 1523178198:
					return AimingConstraints;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3380975443:
					return typeof(TurretData).GetProperty(nameof(PitchP));

				case 2089497178:
					return typeof(TurretData).GetProperty(nameof(YawP));

				case 4286661422:
					return typeof(TurretData).GetProperty(nameof(FakeShootSpaceMinDistance));

				case 1645003312:
					return typeof(TurretData).GetProperty(nameof(FakeShootSpaceMaxDistance));

				case 1523178198:
					return typeof(TurretData).GetProperty(nameof(AimingConstraints));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
