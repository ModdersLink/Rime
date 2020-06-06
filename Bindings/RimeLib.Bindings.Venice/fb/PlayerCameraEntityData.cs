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
	public class PlayerCameraEntityData : 
		CameraEntityBaseData
	{
		[ContainerField(96)]
		public TargetMode SoldierTargetMode { get; set; } = new TargetMode(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public uint SoldierCameraIndex { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public TargetMode VehicleTargetMode { get; set; } = new TargetMode(); // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public uint VehicleCameraIndex { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public bool ReleaseControlIfTargetLost { get; set; } // 0x70 (112)
		
		[ContainerField(113), LayoutImmutable, Blittable]
		public bool ShouldTargetControllable { get; set; } // 0x71 (113)
		
		[ContainerField(114), LayoutImmutable, Blittable]
		public bool ShouldTargetVehicleDriverEntry { get; set; } // 0x72 (114)
		
		[ContainerField(115), LayoutImmutable, Blittable]
		public bool ShouldTargetExtraPlayerInDoublePlayerEvent { get; set; } // 0x73 (115)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2742914237:
					SoldierTargetMode = (TargetMode) Enum.ToObject(typeof(TargetMode), p_Value);
					break;

				case 61768104:
					SoldierCameraIndex = (uint) p_Value;
					break;

				case 3963983535:
					VehicleTargetMode = (TargetMode) Enum.ToObject(typeof(TargetMode), p_Value);
					break;

				case 1896906746:
					VehicleCameraIndex = (uint) p_Value;
					break;

				case 3292924305:
					ReleaseControlIfTargetLost = (bool) p_Value;
					break;

				case 341097948:
					ShouldTargetControllable = (bool) p_Value;
					break;

				case 1821967951:
					ShouldTargetVehicleDriverEntry = (bool) p_Value;
					break;

				case 1876542201:
					ShouldTargetExtraPlayerInDoublePlayerEvent = (bool) p_Value;
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
				case 2742914237:
					return SoldierTargetMode;

				case 61768104:
					return SoldierCameraIndex;

				case 3963983535:
					return VehicleTargetMode;

				case 1896906746:
					return VehicleCameraIndex;

				case 3292924305:
					return ReleaseControlIfTargetLost;

				case 341097948:
					return ShouldTargetControllable;

				case 1821967951:
					return ShouldTargetVehicleDriverEntry;

				case 1876542201:
					return ShouldTargetExtraPlayerInDoublePlayerEvent;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2742914237:
					return typeof(PlayerCameraEntityData).GetProperty(nameof(SoldierTargetMode));

				case 61768104:
					return typeof(PlayerCameraEntityData).GetProperty(nameof(SoldierCameraIndex));

				case 3963983535:
					return typeof(PlayerCameraEntityData).GetProperty(nameof(VehicleTargetMode));

				case 1896906746:
					return typeof(PlayerCameraEntityData).GetProperty(nameof(VehicleCameraIndex));

				case 3292924305:
					return typeof(PlayerCameraEntityData).GetProperty(nameof(ReleaseControlIfTargetLost));

				case 341097948:
					return typeof(PlayerCameraEntityData).GetProperty(nameof(ShouldTargetControllable));

				case 1821967951:
					return typeof(PlayerCameraEntityData).GetProperty(nameof(ShouldTargetVehicleDriverEntry));

				case 1876542201:
					return typeof(PlayerCameraEntityData).GetProperty(nameof(ShouldTargetExtraPlayerInDoublePlayerEvent));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
