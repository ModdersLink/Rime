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
	public class VisualEnvironmentEntityData : 
		GameEntityData
	{
		protected float m_Visibility = new float();
		[ContainerField(Name: "Visibility", Offset: 96, NameHash: 1708270083, Flags: 49469), LayoutImmutable, Blittable]
		public float Visibility { get { return m_Visibility; } set { if (OnPropertyChanging("VisualEnvironmentEntityData." + nameof(Visibility), this, m_Visibility, value)) m_Visibility = value; } } // 0x60 (96)
		
		protected int m_Priority = new int();
		[ContainerField(Name: "Priority", Offset: 100, NameHash: 3062102871, Flags: 49405), LayoutImmutable, Blittable]
		public int Priority { get { return m_Priority; } set { if (OnPropertyChanging("VisualEnvironmentEntityData." + nameof(Priority), this, m_Priority, value)) m_Priority = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1708270083:
					Visibility = (float) p_Value;
					break;

				case 3062102871:
					Priority = (int) p_Value;
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
				case 1708270083:
					return Visibility;

				case 3062102871:
					return Priority;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1708270083:
					return typeof(VisualEnvironmentEntityData).GetProperty(nameof(Visibility));

				case 3062102871:
					return typeof(VisualEnvironmentEntityData).GetProperty(nameof(Priority));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
