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
	public class SpawnRotationData : 
		ProcessorData
	{
		protected float m_Rotation = new float();
		[ContainerField(Name: "Rotation", Offset: 48, NameHash: 48673745, Flags: 49469), LayoutImmutable, Blittable]
		public float Rotation { get { return m_Rotation; } set { if (OnPropertyChanging("SpawnRotationData." + nameof(Rotation), this, m_Rotation, value)) m_Rotation = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 48673745:
					Rotation = (float) p_Value;
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
				case 48673745:
					return Rotation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 48673745:
					return typeof(SpawnRotationData).GetProperty(nameof(Rotation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
