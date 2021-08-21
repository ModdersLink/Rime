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
	public class SimpleAnimationControlComponentData : 
		ComponentData
	{
		protected SimpleAnimationControlBinding m_Binding = new SimpleAnimationControlBinding();
		[ContainerField(Name: "Binding", Offset: 96, NameHash: 2590060228, Flags: 41)]
		public SimpleAnimationControlBinding Binding { get { return m_Binding; } set { if (OnPropertyChanging("SimpleAnimationControlComponentData." + nameof(Binding), this, m_Binding, value)) m_Binding = value; } } // 0x60 (96)
		
		protected int m_AnimationEntitySpacePriority = new int();
		[ContainerField(Name: "AnimationEntitySpacePriority", Offset: 100, NameHash: 4041607518, Flags: 49405), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get { return m_AnimationEntitySpacePriority; } set { if (OnPropertyChanging("SimpleAnimationControlComponentData." + nameof(AnimationEntitySpacePriority), this, m_AnimationEntitySpacePriority, value)) m_AnimationEntitySpacePriority = value; } } // 0x64 (100)
		
		protected bool m_Run = new bool();
		[ContainerField(Name: "Run", Offset: 104, NameHash: 193464460, Flags: 49325), LayoutImmutable, Blittable]
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
