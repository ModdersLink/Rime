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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 64)]
	public class SpawnRotationSpeedData : 
		ProcessorData
	{
		protected float m_RotationSpeed = new float();
		[ContainerField(Name: "RotationSpeed", Offset: 48, NameHash: 802351446, Flags: 49469), LayoutImmutable, Blittable]
		public float RotationSpeed { get { return m_RotationSpeed; } set { if (OnPropertyChanging("SpawnRotationSpeedData." + nameof(RotationSpeed), this, m_RotationSpeed, value)) m_RotationSpeed = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 802351446:
					RotationSpeed = (float) p_Value;
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
				case 802351446:
					return RotationSpeed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 802351446:
					return typeof(SpawnRotationSpeedData).GetProperty(nameof(RotationSpeed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
