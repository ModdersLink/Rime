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
	public class LookAtTriggerEntityData : 
		TriggerEventEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public float FOV { get; set; } // 0x70 (112)
		
		[ContainerField(116)]
		public CtrRef<SoldierWeaponBlueprint> Weapon { get; set; } = new CtrRef<SoldierWeaponBlueprint>(); // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public uint ZoomLevel { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float MinDistanceToObject { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float MaxDistanceToObject { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public bool StartTriggerLookingAt { get; set; } // 0x84 (132)
		
		[ContainerField(133), LayoutImmutable, Blittable]
		public bool CheckOcclusion { get; set; } // 0x85 (133)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193442778:
					FOV = (float) p_Value;
					break;

				case 3190562823:
					Weapon = (CtrRef<SoldierWeaponBlueprint>) p_Value;
					break;

				case 3650803780:
					ZoomLevel = (uint) p_Value;
					break;

				case 3463845186:
					MinDistanceToObject = (float) p_Value;
					break;

				case 954132188:
					MaxDistanceToObject = (float) p_Value;
					break;

				case 2703714543:
					StartTriggerLookingAt = (bool) p_Value;
					break;

				case 3588432334:
					CheckOcclusion = (bool) p_Value;
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
				case 193442778:
					return FOV;

				case 3190562823:
					return Weapon;

				case 3650803780:
					return ZoomLevel;

				case 3463845186:
					return MinDistanceToObject;

				case 954132188:
					return MaxDistanceToObject;

				case 2703714543:
					return StartTriggerLookingAt;

				case 3588432334:
					return CheckOcclusion;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193442778:
					return typeof(LookAtTriggerEntityData).GetProperty(nameof(FOV));

				case 3190562823:
					return typeof(LookAtTriggerEntityData).GetProperty(nameof(Weapon));

				case 3650803780:
					return typeof(LookAtTriggerEntityData).GetProperty(nameof(ZoomLevel));

				case 3463845186:
					return typeof(LookAtTriggerEntityData).GetProperty(nameof(MinDistanceToObject));

				case 954132188:
					return typeof(LookAtTriggerEntityData).GetProperty(nameof(MaxDistanceToObject));

				case 2703714543:
					return typeof(LookAtTriggerEntityData).GetProperty(nameof(StartTriggerLookingAt));

				case 3588432334:
					return typeof(LookAtTriggerEntityData).GetProperty(nameof(CheckOcclusion));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
