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
	[ContainerType(16)]
	public class SimpleAnimationControlComponentData : 
		ComponentData
	{
		protected SimpleAnimationControlBinding m_Binding = new SimpleAnimationControlBinding();
		[ContainerField(96), ContainerFieldNameHash(2590060228)]
		public SimpleAnimationControlBinding Binding { get { return m_Binding; } set { if (OnPropertyChanging("SimpleAnimationControlComponentData." + nameof(Binding), this, m_Binding, value)) m_Binding = value; } } // 0x60 (96)
		
		protected int m_AnimationEntitySpacePriority = new int();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(4041607518)]
		public int AnimationEntitySpacePriority { get { return m_AnimationEntitySpacePriority; } set { if (OnPropertyChanging("SimpleAnimationControlComponentData." + nameof(AnimationEntitySpacePriority), this, m_AnimationEntitySpacePriority, value)) m_AnimationEntitySpacePriority = value; } } // 0x64 (100)
		
		protected bool m_Run = new bool();
		[ContainerField(104), LayoutImmutable, Blittable, ContainerFieldNameHash(193464460)]
		public bool Run { get { return m_Run; } set { if (OnPropertyChanging("SimpleAnimationControlComponentData." + nameof(Run), this, m_Run, value)) m_Run = value; } } // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2590060228:
					Binding = (SimpleAnimationControlBinding) p_Value;
					break;

				case 4041607518:
					AnimationEntitySpacePriority = (int) p_Value;
					break;

				case 193464460:
					Run = (bool) p_Value;
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
				case 2590060228:
					return Binding;

				case 4041607518:
					return AnimationEntitySpacePriority;

				case 193464460:
					return Run;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2590060228:
					return typeof(SimpleAnimationControlComponentData).GetProperty(nameof(Binding));

				case 4041607518:
					return typeof(SimpleAnimationControlComponentData).GetProperty(nameof(AnimationEntitySpacePriority));

				case 193464460:
					return typeof(SimpleAnimationControlComponentData).GetProperty(nameof(Run));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
