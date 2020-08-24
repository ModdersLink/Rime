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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class AnimationControlledStateData : 
		CharacterStateData
	{
		protected float m_UpNormalTolerance = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4245736634)]
		public float UpNormalTolerance { get { return m_UpNormalTolerance; } set { if (OnPropertyChanging("AnimationControlledStateData." + nameof(UpNormalTolerance), this, m_UpNormalTolerance, value)) m_UpNormalTolerance = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4245736634:
					UpNormalTolerance = (float) p_Value;
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
				case 4245736634:
					return UpNormalTolerance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4245736634:
					return typeof(AnimationControlledStateData).GetProperty(nameof(UpNormalTolerance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
