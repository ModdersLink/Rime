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
	[ContainerType(4)]
	public class VehicleParachuteData : 
		DataContainer
	{
		protected float m_TerminalVelocity = new float();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(1459893878)]
		public float TerminalVelocity { get { return m_TerminalVelocity; } set { if (OnPropertyChanging("VehicleParachuteData." + nameof(TerminalVelocity), this, m_TerminalVelocity, value)) m_TerminalVelocity = value; } } // 0x8 (8)
		
		protected float m_FreefallGravityMultiplier = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(35723995)]
		public float FreefallGravityMultiplier { get { return m_FreefallGravityMultiplier; } set { if (OnPropertyChanging("VehicleParachuteData." + nameof(FreefallGravityMultiplier), this, m_FreefallGravityMultiplier, value)) m_FreefallGravityMultiplier = value; } } // 0xC (12)
		
		protected float m_DragCoefficient = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(4054248384)]
		public float DragCoefficient { get { return m_DragCoefficient; } set { if (OnPropertyChanging("VehicleParachuteData." + nameof(DragCoefficient), this, m_DragCoefficient, value)) m_DragCoefficient = value; } } // 0x10 (16)
		
		protected float m_MaxRollVelocity = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(1947747259)]
		public float MaxRollVelocity { get { return m_MaxRollVelocity; } set { if (OnPropertyChanging("VehicleParachuteData." + nameof(MaxRollVelocity), this, m_MaxRollVelocity, value)) m_MaxRollVelocity = value; } } // 0x14 (20)
		
		protected float m_MaxPitchVelocity = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(2587272352)]
		public float MaxPitchVelocity { get { return m_MaxPitchVelocity; } set { if (OnPropertyChanging("VehicleParachuteData." + nameof(MaxPitchVelocity), this, m_MaxPitchVelocity, value)) m_MaxPitchVelocity = value; } } // 0x18 (24)
		
		protected float m_MaxYawVelocity = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(3921711241)]
		public float MaxYawVelocity { get { return m_MaxYawVelocity; } set { if (OnPropertyChanging("VehicleParachuteData." + nameof(MaxYawVelocity), this, m_MaxYawVelocity, value)) m_MaxYawVelocity = value; } } // 0x1C (28)
		
		protected float m_DeployTime = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(2275884507)]
		public float DeployTime { get { return m_DeployTime; } set { if (OnPropertyChanging("VehicleParachuteData." + nameof(DeployTime), this, m_DeployTime, value)) m_DeployTime = value; } } // 0x20 (32)
		
		protected float m_UndeployGroundHeight = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(2288289167)]
		public float UndeployGroundHeight { get { return m_UndeployGroundHeight; } set { if (OnPropertyChanging("VehicleParachuteData." + nameof(UndeployGroundHeight), this, m_UndeployGroundHeight, value)) m_UndeployGroundHeight = value; } } // 0x24 (36)
		
		protected float m_AngularDescentDamping = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(2231264209)]
		public float AngularDescentDamping { get { return m_AngularDescentDamping; } set { if (OnPropertyChanging("VehicleParachuteData." + nameof(AngularDescentDamping), this, m_AngularDescentDamping, value)) m_AngularDescentDamping = value; } } // 0x28 (40)
		
		protected float m_AngularDeployDamping = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(1488300372)]
		public float AngularDeployDamping { get { return m_AngularDeployDamping; } set { if (OnPropertyChanging("VehicleParachuteData." + nameof(AngularDeployDamping), this, m_AngularDeployDamping, value)) m_AngularDeployDamping = value; } } // 0x2C (44)
		
		protected float m_DeployPhysicsStart = new float();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(4034659173)]
		public float DeployPhysicsStart { get { return m_DeployPhysicsStart; } set { if (OnPropertyChanging("VehicleParachuteData." + nameof(DeployPhysicsStart), this, m_DeployPhysicsStart, value)) m_DeployPhysicsStart = value; } } // 0x30 (48)
		
		protected float m_DeployInitialDragStart = new float();
		[ContainerField(52), LayoutImmutable, Blittable, ContainerFieldNameHash(1770564768)]
		public float DeployInitialDragStart { get { return m_DeployInitialDragStart; } set { if (OnPropertyChanging("VehicleParachuteData." + nameof(DeployInitialDragStart), this, m_DeployInitialDragStart, value)) m_DeployInitialDragStart = value; } } // 0x34 (52)
		
		protected float m_InitialDragStartVelocityScale = new float();
		[ContainerField(56), LayoutImmutable, Blittable, ContainerFieldNameHash(2804502340)]
		public float InitialDragStartVelocityScale { get { return m_InitialDragStartVelocityScale; } set { if (OnPropertyChanging("VehicleParachuteData." + nameof(InitialDragStartVelocityScale), this, m_InitialDragStartVelocityScale, value)) m_InitialDragStartVelocityScale = value; } } // 0x38 (56)
		
		protected float m_InitialDragAngularVelocityPitch = new float();
		[ContainerField(60), LayoutImmutable, Blittable, ContainerFieldNameHash(2206516088)]
		public float InitialDragAngularVelocityPitch { get { return m_InitialDragAngularVelocityPitch; } set { if (OnPropertyChanging("VehicleParachuteData." + nameof(InitialDragAngularVelocityPitch), this, m_InitialDragAngularVelocityPitch, value)) m_InitialDragAngularVelocityPitch = value; } } // 0x3C (60)
		
		protected float m_InitialDragRandomAngularVelocityRollMax = new float();
		[ContainerField(64), LayoutImmutable, Blittable, ContainerFieldNameHash(2538749068)]
		public float InitialDragRandomAngularVelocityRollMax { get { return m_InitialDragRandomAngularVelocityRollMax; } set { if (OnPropertyChanging("VehicleParachuteData." + nameof(InitialDragRandomAngularVelocityRollMax), this, m_InitialDragRandomAngularVelocityRollMax, value)) m_InitialDragRandomAngularVelocityRollMax = value; } } // 0x40 (64)
		
		protected float m_RampLength = new float();
		[ContainerField(68), LayoutImmutable, Blittable, ContainerFieldNameHash(1007353783)]
		public float RampLength { get { return m_RampLength; } set { if (OnPropertyChanging("VehicleParachuteData." + nameof(RampLength), this, m_RampLength, value)) m_RampLength = value; } } // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1459893878:
					TerminalVelocity = (float) p_Value;
					break;

				case 35723995:
					FreefallGravityMultiplier = (float) p_Value;
					break;

				case 4054248384:
					DragCoefficient = (float) p_Value;
					break;

				case 1947747259:
					MaxRollVelocity = (float) p_Value;
					break;

				case 2587272352:
					MaxPitchVelocity = (float) p_Value;
					break;

				case 3921711241:
					MaxYawVelocity = (float) p_Value;
					break;

				case 2275884507:
					DeployTime = (float) p_Value;
					break;

				case 2288289167:
					UndeployGroundHeight = (float) p_Value;
					break;

				case 2231264209:
					AngularDescentDamping = (float) p_Value;
					break;

				case 1488300372:
					AngularDeployDamping = (float) p_Value;
					break;

				case 4034659173:
					DeployPhysicsStart = (float) p_Value;
					break;

				case 1770564768:
					DeployInitialDragStart = (float) p_Value;
					break;

				case 2804502340:
					InitialDragStartVelocityScale = (float) p_Value;
					break;

				case 2206516088:
					InitialDragAngularVelocityPitch = (float) p_Value;
					break;

				case 2538749068:
					InitialDragRandomAngularVelocityRollMax = (float) p_Value;
					break;

				case 1007353783:
					RampLength = (float) p_Value;
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
				case 1459893878:
					return TerminalVelocity;

				case 35723995:
					return FreefallGravityMultiplier;

				case 4054248384:
					return DragCoefficient;

				case 1947747259:
					return MaxRollVelocity;

				case 2587272352:
					return MaxPitchVelocity;

				case 3921711241:
					return MaxYawVelocity;

				case 2275884507:
					return DeployTime;

				case 2288289167:
					return UndeployGroundHeight;

				case 2231264209:
					return AngularDescentDamping;

				case 1488300372:
					return AngularDeployDamping;

				case 4034659173:
					return DeployPhysicsStart;

				case 1770564768:
					return DeployInitialDragStart;

				case 2804502340:
					return InitialDragStartVelocityScale;

				case 2206516088:
					return InitialDragAngularVelocityPitch;

				case 2538749068:
					return InitialDragRandomAngularVelocityRollMax;

				case 1007353783:
					return RampLength;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1459893878:
					return typeof(VehicleParachuteData).GetProperty(nameof(TerminalVelocity));

				case 35723995:
					return typeof(VehicleParachuteData).GetProperty(nameof(FreefallGravityMultiplier));

				case 4054248384:
					return typeof(VehicleParachuteData).GetProperty(nameof(DragCoefficient));

				case 1947747259:
					return typeof(VehicleParachuteData).GetProperty(nameof(MaxRollVelocity));

				case 2587272352:
					return typeof(VehicleParachuteData).GetProperty(nameof(MaxPitchVelocity));

				case 3921711241:
					return typeof(VehicleParachuteData).GetProperty(nameof(MaxYawVelocity));

				case 2275884507:
					return typeof(VehicleParachuteData).GetProperty(nameof(DeployTime));

				case 2288289167:
					return typeof(VehicleParachuteData).GetProperty(nameof(UndeployGroundHeight));

				case 2231264209:
					return typeof(VehicleParachuteData).GetProperty(nameof(AngularDescentDamping));

				case 1488300372:
					return typeof(VehicleParachuteData).GetProperty(nameof(AngularDeployDamping));

				case 4034659173:
					return typeof(VehicleParachuteData).GetProperty(nameof(DeployPhysicsStart));

				case 1770564768:
					return typeof(VehicleParachuteData).GetProperty(nameof(DeployInitialDragStart));

				case 2804502340:
					return typeof(VehicleParachuteData).GetProperty(nameof(InitialDragStartVelocityScale));

				case 2206516088:
					return typeof(VehicleParachuteData).GetProperty(nameof(InitialDragAngularVelocityPitch));

				case 2538749068:
					return typeof(VehicleParachuteData).GetProperty(nameof(InitialDragRandomAngularVelocityRollMax));

				case 1007353783:
					return typeof(VehicleParachuteData).GetProperty(nameof(RampLength));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
