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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 272)]
	public class AnimatedDriverEntityData : 
		GameEntityData
	{
		protected LinearTransform m_InputTransform = new LinearTransform();
		[ContainerField(Name: "InputTransform", Offset: 96, NameHash: 674191935, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform InputTransform { get { return m_InputTransform; } set { if (OnPropertyChanging("AnimatedDriverEntityData." + nameof(InputTransform), this, m_InputTransform, value)) m_InputTransform = value; } } // 0x60 (96)
		
		protected AntRef m_VehicleBoost = new AntRef();
		[ContainerField(Name: "VehicleBoost", Offset: 160, NameHash: 519733784, Flags: 41)]
		public AntRef VehicleBoost { get { return m_VehicleBoost; } set { if (OnPropertyChanging("AnimatedDriverEntityData." + nameof(VehicleBoost), this, m_VehicleBoost, value)) m_VehicleBoost = value; } } // 0xA0 (160)
		
		protected AntRef m_VehicleSpeed = new AntRef();
		[ContainerField(Name: "VehicleSpeed", Offset: 164, NameHash: 503036026, Flags: 41)]
		public AntRef VehicleSpeed { get { return m_VehicleSpeed; } set { if (OnPropertyChanging("AnimatedDriverEntityData." + nameof(VehicleSpeed), this, m_VehicleSpeed, value)) m_VehicleSpeed = value; } } // 0xA4 (164)
		
		protected AntRef m_VehicleMovementState = new AntRef();
		[ContainerField(Name: "VehicleMovementState", Offset: 168, NameHash: 2105315721, Flags: 41)]
		public AntRef VehicleMovementState { get { return m_VehicleMovementState; } set { if (OnPropertyChanging("AnimatedDriverEntityData." + nameof(VehicleMovementState), this, m_VehicleMovementState, value)) m_VehicleMovementState = value; } } // 0xA8 (168)
		
		protected AntRef m_VehicleClutch = new AntRef();
		[ContainerField(Name: "VehicleClutch", Offset: 172, NameHash: 13000376, Flags: 41)]
		public AntRef VehicleClutch { get { return m_VehicleClutch; } set { if (OnPropertyChanging("AnimatedDriverEntityData." + nameof(VehicleClutch), this, m_VehicleClutch, value)) m_VehicleClutch = value; } } // 0xAC (172)
		
		protected AntRef m_VehicleBrake = new AntRef();
		[ContainerField(Name: "VehicleBrake", Offset: 176, NameHash: 519539362, Flags: 41)]
		public AntRef VehicleBrake { get { return m_VehicleBrake; } set { if (OnPropertyChanging("AnimatedDriverEntityData." + nameof(VehicleBrake), this, m_VehicleBrake, value)) m_VehicleBrake = value; } } // 0xB0 (176)
		
		protected float m_MovementStateStandThreshold = new float();
		[ContainerField(Name: "MovementStateStandThreshold", Offset: 180, NameHash: 1916267914, Flags: 49469), LayoutImmutable, Blittable]
		public float MovementStateStandThreshold { get { return m_MovementStateStandThreshold; } set { if (OnPropertyChanging("AnimatedDriverEntityData." + nameof(MovementStateStandThreshold), this, m_MovementStateStandThreshold, value)) m_MovementStateStandThreshold = value; } } // 0xB4 (180)
		
		protected NormalizeSettings m_Yaw = new NormalizeSettings();
		[ContainerField(Name: "Yaw", Offset: 184, NameHash: 193468618, Flags: 41)]
		public NormalizeSettings Yaw { get { return m_Yaw; } set { if (OnPropertyChanging("AnimatedDriverEntityData." + nameof(Yaw), this, m_Yaw, value)) m_Yaw = value; } } // 0xB8 (184)
		
		protected NormalizeSettings m_Roll = new NormalizeSettings();
		[ContainerField(Name: "Roll", Offset: 208, NameHash: 2089387576, Flags: 41)]
		public NormalizeSettings Roll { get { return m_Roll; } set { if (OnPropertyChanging("AnimatedDriverEntityData." + nameof(Roll), this, m_Roll, value)) m_Roll = value; } } // 0xD0 (208)
		
		protected NormalizeSettings m_Pitch = new NormalizeSettings();
		[ContainerField(Name: "Pitch", Offset: 232, NameHash: 232604323, Flags: 41)]
		public NormalizeSettings Pitch { get { return m_Pitch; } set { if (OnPropertyChanging("AnimatedDriverEntityData." + nameof(Pitch), this, m_Pitch, value)) m_Pitch = value; } } // 0xE8 (232)
		
		protected bool m_DelayAnimationWheelTransform = new bool();
		[ContainerField(Name: "DelayAnimationWheelTransform", Offset: 256, NameHash: 1883575417, Flags: 49325), LayoutImmutable, Blittable]
		public bool DelayAnimationWheelTransform { get { return m_DelayAnimationWheelTransform; } set { if (OnPropertyChanging("AnimatedDriverEntityData." + nameof(DelayAnimationWheelTransform), this, m_DelayAnimationWheelTransform, value)) m_DelayAnimationWheelTransform = value; } } // 0x100 (256)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 674191935:
					InputTransform = (LinearTransform) p_Value;
					break;

				case 519733784:
					VehicleBoost = (AntRef) p_Value;
					break;

				case 503036026:
					VehicleSpeed = (AntRef) p_Value;
					break;

				case 2105315721:
					VehicleMovementState = (AntRef) p_Value;
					break;

				case 13000376:
					VehicleClutch = (AntRef) p_Value;
					break;

				case 519539362:
					VehicleBrake = (AntRef) p_Value;
					break;

				case 1916267914:
					MovementStateStandThreshold = (float) p_Value;
					break;

				case 193468618:
					Yaw = (NormalizeSettings) p_Value;
					break;

				case 2089387576:
					Roll = (NormalizeSettings) p_Value;
					break;

				case 232604323:
					Pitch = (NormalizeSettings) p_Value;
					break;

				case 1883575417:
					DelayAnimationWheelTransform = (bool) p_Value;
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
				case 674191935:
					return InputTransform;

				case 519733784:
					return VehicleBoost;

				case 503036026:
					return VehicleSpeed;

				case 2105315721:
					return VehicleMovementState;

				case 13000376:
					return VehicleClutch;

				case 519539362:
					return VehicleBrake;

				case 1916267914:
					return MovementStateStandThreshold;

				case 193468618:
					return Yaw;

				case 2089387576:
					return Roll;

				case 232604323:
					return Pitch;

				case 1883575417:
					return DelayAnimationWheelTransform;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 674191935:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(InputTransform));

				case 519733784:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(VehicleBoost));

				case 503036026:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(VehicleSpeed));

				case 2105315721:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(VehicleMovementState));

				case 13000376:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(VehicleClutch));

				case 519539362:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(VehicleBrake));

				case 1916267914:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(MovementStateStandThreshold));

				case 193468618:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(Yaw));

				case 2089387576:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(Roll));

				case 232604323:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(Pitch));

				case 1883575417:
					return typeof(AnimatedDriverEntityData).GetProperty(nameof(DelayAnimationWheelTransform));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
