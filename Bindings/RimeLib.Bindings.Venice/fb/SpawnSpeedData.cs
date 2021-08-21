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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 64)]
	public class SpawnSpeedData : 
		ProcessorData
	{
		protected float m_Speed = new float();
		[ContainerField(Name: "Speed", Offset: 48, NameHash: 230887042, Flags: 49469), LayoutImmutable, Blittable]
		public float Speed { get { return m_Speed; } set { if (OnPropertyChanging("SpawnSpeedData." + nameof(Speed), this, m_Speed, value)) m_Speed = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 230887042:
					Speed = (float) p_Value;
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
				case 230887042:
					return Speed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230887042:
					return typeof(SpawnSpeedData).GetProperty(nameof(Speed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
