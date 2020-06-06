///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class AnimationTurretRotationComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public List<TurretRotationInfo> Rotations { get; set; } = new List<TurretRotationInfo>(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public int SoldierBaseIndex { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public bool UseVehicleWorldTransform { get; set; } // 0x68 (104)
		
		[ContainerField(105), LayoutImmutable, Blittable]
		public bool OutputWorldTransform { get; set; } // 0x69 (105)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1606233474:
					Rotations = (List<TurretRotationInfo>) p_Value;
					break;

				case 3732427844:
					SoldierBaseIndex = (int) p_Value;
					break;

				case 4119091248:
					UseVehicleWorldTransform = (bool) p_Value;
					break;

				case 1849681172:
					OutputWorldTransform = (bool) p_Value;
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
				case 1606233474:
					return Rotations;

				case 3732427844:
					return SoldierBaseIndex;

				case 4119091248:
					return UseVehicleWorldTransform;

				case 1849681172:
					return OutputWorldTransform;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1606233474:
					return typeof(AnimationTurretRotationComponentData).GetProperty(nameof(Rotations));

				case 3732427844:
					return typeof(AnimationTurretRotationComponentData).GetProperty(nameof(SoldierBaseIndex));

				case 4119091248:
					return typeof(AnimationTurretRotationComponentData).GetProperty(nameof(UseVehicleWorldTransform));

				case 1849681172:
					return typeof(AnimationTurretRotationComponentData).GetProperty(nameof(OutputWorldTransform));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
