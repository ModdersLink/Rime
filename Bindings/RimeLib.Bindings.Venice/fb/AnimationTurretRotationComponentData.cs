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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class AnimationTurretRotationComponentData : 
		ComponentData
	{
		protected List<TurretRotationInfo> m_Rotations = new List<TurretRotationInfo>();
		[ContainerField(Name: "Rotations", Offset: 96, NameHash: 1606233474, Flags: 65)]
		public List<TurretRotationInfo> Rotations { get { return m_Rotations; } set { if (OnPropertyChanging("AnimationTurretRotationComponentData." + nameof(Rotations), this, m_Rotations, value)) m_Rotations = value; } } // 0x60 (96)
		
		protected int m_SoldierBaseIndex = new int();
		[ContainerField(Name: "SoldierBaseIndex", Offset: 100, NameHash: 3732427844, Flags: 49405), LayoutImmutable, Blittable]
		public int SoldierBaseIndex { get { return m_SoldierBaseIndex; } set { if (OnPropertyChanging("AnimationTurretRotationComponentData." + nameof(SoldierBaseIndex), this, m_SoldierBaseIndex, value)) m_SoldierBaseIndex = value; } } // 0x64 (100)
		
		protected bool m_UseVehicleWorldTransform = new bool();
		[ContainerField(Name: "UseVehicleWorldTransform", Offset: 104, NameHash: 4119091248, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseVehicleWorldTransform { get { return m_UseVehicleWorldTransform; } set { if (OnPropertyChanging("AnimationTurretRotationComponentData." + nameof(UseVehicleWorldTransform), this, m_UseVehicleWorldTransform, value)) m_UseVehicleWorldTransform = value; } } // 0x68 (104)
		
		protected bool m_OutputWorldTransform = new bool();
		[ContainerField(Name: "OutputWorldTransform", Offset: 105, NameHash: 1849681172, Flags: 49325), LayoutImmutable, Blittable]
		public bool OutputWorldTransform { get { return m_OutputWorldTransform; } set { if (OnPropertyChanging("AnimationTurretRotationComponentData." + nameof(OutputWorldTransform), this, m_OutputWorldTransform, value)) m_OutputWorldTransform = value; } } // 0x69 (105)
		
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
