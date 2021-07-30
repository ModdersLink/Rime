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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class SpeedEventGateEntityData : 
		GameEntityData
	{
		protected float m_MinSpeed = new float();
		[ContainerField(Name: "MinSpeed", Offset: 96, NameHash: 3368183944, Flags: 49469), LayoutImmutable, Blittable]
		public float MinSpeed { get { return m_MinSpeed; } set { if (OnPropertyChanging("SpeedEventGateEntityData." + nameof(MinSpeed), this, m_MinSpeed, value)) m_MinSpeed = value; } } // 0x60 (96)
		
		protected float m_MaxSpeed = new float();
		[ContainerField(Name: "MaxSpeed", Offset: 100, NameHash: 396228950, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxSpeed { get { return m_MaxSpeed; } set { if (OnPropertyChanging("SpeedEventGateEntityData." + nameof(MaxSpeed), this, m_MaxSpeed, value)) m_MaxSpeed = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3368183944:
					MinSpeed = (float) p_Value;
					break;

				case 396228950:
					MaxSpeed = (float) p_Value;
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
				case 3368183944:
					return MinSpeed;

				case 396228950:
					return MaxSpeed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3368183944:
					return typeof(SpeedEventGateEntityData).GetProperty(nameof(MinSpeed));

				case 396228950:
					return typeof(SpeedEventGateEntityData).GetProperty(nameof(MaxSpeed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
