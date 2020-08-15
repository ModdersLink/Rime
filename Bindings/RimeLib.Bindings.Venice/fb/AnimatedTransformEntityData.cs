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
	public class AnimatedTransformEntityData : 
		EntityData
	{
		protected AntRef m_Animatable = new AntRef();
		[ContainerField(12), ContainerFieldNameHash(3208693873)]
		public AntRef Animatable { get { return m_Animatable; } set { if (OnPropertyChanging("AnimatedTransformEntityData." + nameof(Animatable), this, m_Animatable, value)) m_Animatable = value; } } // 0xC (12)
		
		protected float m_ExternalTime = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(2162678253)]
		public float ExternalTime { get { return m_ExternalTime; } set { if (OnPropertyChanging("AnimatedTransformEntityData." + nameof(ExternalTime), this, m_ExternalTime, value)) m_ExternalTime = value; } } // 0x10 (16)
		
		protected AntRef m_Controller = new AntRef();
		[ContainerField(20), ContainerFieldNameHash(1870777401)]
		public AntRef Controller { get { return m_Controller; } set { if (OnPropertyChanging("AnimatedTransformEntityData." + nameof(Controller), this, m_Controller, value)) m_Controller = value; } } // 0x14 (20)
		
		protected string m_BoneName = new string();
		[ContainerField(24), LayoutImmutable, ContainerFieldNameHash(1590647844)]
		public string BoneName { get { return m_BoneName; } set { if (OnPropertyChanging("AnimatedTransformEntityData." + nameof(BoneName), this, m_BoneName, value)) m_BoneName = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3208693873:
					Animatable = (AntRef) p_Value;
					break;

				case 2162678253:
					ExternalTime = (float) p_Value;
					break;

				case 1870777401:
					Controller = (AntRef) p_Value;
					break;

				case 1590647844:
					BoneName = (string) p_Value;
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
				case 3208693873:
					return Animatable;

				case 2162678253:
					return ExternalTime;

				case 1870777401:
					return Controller;

				case 1590647844:
					return BoneName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3208693873:
					return typeof(AnimatedTransformEntityData).GetProperty(nameof(Animatable));

				case 2162678253:
					return typeof(AnimatedTransformEntityData).GetProperty(nameof(ExternalTime));

				case 1870777401:
					return typeof(AnimatedTransformEntityData).GetProperty(nameof(Controller));

				case 1590647844:
					return typeof(AnimatedTransformEntityData).GetProperty(nameof(BoneName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
