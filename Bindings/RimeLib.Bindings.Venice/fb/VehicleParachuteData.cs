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
	public class VehicleParachuteData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float TerminalVelocity { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float FreefallGravityMultiplier { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float DragCoefficient { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float MaxRollVelocity { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxPitchVelocity { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxYawVelocity { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float DeployTime { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float UndeployGroundHeight { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float AngularDescentDamping { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float AngularDeployDamping { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float DeployPhysicsStart { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float DeployInitialDragStart { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float InitialDragStartVelocityScale { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float InitialDragAngularVelocityPitch { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float InitialDragRandomAngularVelocityRollMax { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float RampLength { get; set; } // 0x44 (68)
		
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
