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
	public class VehicleInputTweakData : 
		DataContainer
	{
		protected VehicleInputTweakType m_InputTweakType = new VehicleInputTweakType();
		[ContainerField(8), ContainerFieldNameHash(3111564359)]
		public VehicleInputTweakType InputTweakType { get { return m_InputTweakType; } set { if (OnPropertyChanging("VehicleInputTweakData." + nameof(InputTweakType), this, m_InputTweakType, value)) m_InputTweakType = value; } } // 0x8 (8)
		
		protected float m_MinSpeed = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(3368183944)]
		public float MinSpeed { get { return m_MinSpeed; } set { if (OnPropertyChanging("VehicleInputTweakData." + nameof(MinSpeed), this, m_MinSpeed, value)) m_MinSpeed = value; } } // 0xC (12)
		
		protected float m_MaxSpeed = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(396228950)]
		public float MaxSpeed { get { return m_MaxSpeed; } set { if (OnPropertyChanging("VehicleInputTweakData." + nameof(MaxSpeed), this, m_MaxSpeed, value)) m_MaxSpeed = value; } } // 0x10 (16)
		
		protected float m_MinSpeedScale = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(1840139696)]
		public float MinSpeedScale { get { return m_MinSpeedScale; } set { if (OnPropertyChanging("VehicleInputTweakData." + nameof(MinSpeedScale), this, m_MinSpeedScale, value)) m_MinSpeedScale = value; } } // 0x14 (20)
		
		protected float m_MaxSpeedScale = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(33238958)]
		public float MaxSpeedScale { get { return m_MaxSpeedScale; } set { if (OnPropertyChanging("VehicleInputTweakData." + nameof(MaxSpeedScale), this, m_MaxSpeedScale, value)) m_MaxSpeedScale = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3111564359:
					InputTweakType = (VehicleInputTweakType) Enum.ToObject(typeof(VehicleInputTweakType), p_Value);
					break;

				case 3368183944:
					MinSpeed = (float) p_Value;
					break;

				case 396228950:
					MaxSpeed = (float) p_Value;
					break;

				case 1840139696:
					MinSpeedScale = (float) p_Value;
					break;

				case 33238958:
					MaxSpeedScale = (float) p_Value;
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
				case 3111564359:
					return InputTweakType;

				case 3368183944:
					return MinSpeed;

				case 396228950:
					return MaxSpeed;

				case 1840139696:
					return MinSpeedScale;

				case 33238958:
					return MaxSpeedScale;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3111564359:
					return typeof(VehicleInputTweakData).GetProperty(nameof(InputTweakType));

				case 3368183944:
					return typeof(VehicleInputTweakData).GetProperty(nameof(MinSpeed));

				case 396228950:
					return typeof(VehicleInputTweakData).GetProperty(nameof(MaxSpeed));

				case 1840139696:
					return typeof(VehicleInputTweakData).GetProperty(nameof(MinSpeedScale));

				case 33238958:
					return typeof(VehicleInputTweakData).GetProperty(nameof(MaxSpeedScale));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
