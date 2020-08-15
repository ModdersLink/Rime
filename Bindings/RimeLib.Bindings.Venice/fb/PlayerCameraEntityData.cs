///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16)]
	public class PlayerCameraEntityData : 
		CameraEntityBaseData
	{
		protected TargetMode m_SoldierTargetMode = new TargetMode();
		[ContainerField(96), ContainerFieldNameHash(2742914237)]
		public TargetMode SoldierTargetMode { get { return m_SoldierTargetMode; } set { if (OnPropertyChanging("PlayerCameraEntityData." + nameof(SoldierTargetMode), this, m_SoldierTargetMode, value)) m_SoldierTargetMode = value; } } // 0x60 (96)
		
		protected uint m_SoldierCameraIndex = new uint();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(61768104)]
		public uint SoldierCameraIndex { get { return m_SoldierCameraIndex; } set { if (OnPropertyChanging("PlayerCameraEntityData." + nameof(SoldierCameraIndex), this, m_SoldierCameraIndex, value)) m_SoldierCameraIndex = value; } } // 0x64 (100)
		
		protected TargetMode m_VehicleTargetMode = new TargetMode();
		[ContainerField(104), ContainerFieldNameHash(3963983535)]
		public TargetMode VehicleTargetMode { get { return m_VehicleTargetMode; } set { if (OnPropertyChanging("PlayerCameraEntityData." + nameof(VehicleTargetMode), this, m_VehicleTargetMode, value)) m_VehicleTargetMode = value; } } // 0x68 (104)
		
		protected uint m_VehicleCameraIndex = new uint();
		[ContainerField(108), LayoutImmutable, Blittable, ContainerFieldNameHash(1896906746)]
		public uint VehicleCameraIndex { get { return m_VehicleCameraIndex; } set { if (OnPropertyChanging("PlayerCameraEntityData." + nameof(VehicleCameraIndex), this, m_VehicleCameraIndex, value)) m_VehicleCameraIndex = value; } } // 0x6C (108)
		
		protected bool m_ReleaseControlIfTargetLost = new bool();
		[ContainerField(112), LayoutImmutable, Blittable, ContainerFieldNameHash(3292924305)]
		public bool ReleaseControlIfTargetLost { get { return m_ReleaseControlIfTargetLost; } set { if (OnPropertyChanging("PlayerCameraEntityData." + nameof(ReleaseControlIfTargetLost), this, m_ReleaseControlIfTargetLost, value)) m_ReleaseControlIfTargetLost = value; } } // 0x70 (112)
		
		protected bool m_ShouldTargetControllable = new bool();
		[ContainerField(113), LayoutImmutable, Blittable, ContainerFieldNameHash(341097948)]
		public bool ShouldTargetControllable { get { return m_ShouldTargetControllable; } set { if (OnPropertyChanging("PlayerCameraEntityData." + nameof(ShouldTargetControllable), this, m_ShouldTargetControllable, value)) m_ShouldTargetControllable = value; } } // 0x71 (113)
		
		protected bool m_ShouldTargetVehicleDriverEntry = new bool();
		[ContainerField(114), LayoutImmutable, Blittable, ContainerFieldNameHash(1821967951)]
		public bool ShouldTargetVehicleDriverEntry { get { return m_ShouldTargetVehicleDriverEntry; } set { if (OnPropertyChanging("PlayerCameraEntityData." + nameof(ShouldTargetVehicleDriverEntry), this, m_ShouldTargetVehicleDriverEntry, value)) m_ShouldTargetVehicleDriverEntry = value; } } // 0x72 (114)
		
		protected bool m_ShouldTargetExtraPlayerInDoublePlayerEvent = new bool();
		[ContainerField(115), LayoutImmutable, Blittable, ContainerFieldNameHash(1876542201)]
		public bool ShouldTargetExtraPlayerInDoublePlayerEvent { get { return m_ShouldTargetExtraPlayerInDoublePlayerEvent; } set { if (OnPropertyChanging("PlayerCameraEntityData." + nameof(ShouldTargetExtraPlayerInDoublePlayerEvent), this, m_ShouldTargetExtraPlayerInDoublePlayerEvent, value)) m_ShouldTargetExtraPlayerInDoublePlayerEvent = value; } } // 0x73 (115)
		
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
