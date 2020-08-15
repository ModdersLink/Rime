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
	public class JumpStateData : 
		CharacterStateData
	{
		protected float m_JumpHeight = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(1265809368)]
		public float JumpHeight { get { return m_JumpHeight; } set { if (OnPropertyChanging("JumpStateData." + nameof(JumpHeight), this, m_JumpHeight, value)) m_JumpHeight = value; } } // 0xC (12)
		
		protected float m_JumpEffectSize = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(2845964789)]
		public float JumpEffectSize { get { return m_JumpEffectSize; } set { if (OnPropertyChanging("JumpStateData." + nameof(JumpEffectSize), this, m_JumpEffectSize, value)) m_JumpEffectSize = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1265809368:
					JumpHeight = (float) p_Value;
					break;

				case 2845964789:
					JumpEffectSize = (float) p_Value;
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
				case 1265809368:
					return JumpHeight;

				case 2845964789:
					return JumpEffectSize;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1265809368:
					return typeof(JumpStateData).GetProperty(nameof(JumpHeight));

				case 2845964789:
					return typeof(JumpStateData).GetProperty(nameof(JumpEffectSize));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
