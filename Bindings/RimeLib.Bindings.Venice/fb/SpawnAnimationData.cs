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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(64), ContainerClass]
	public class SpawnAnimationData : 
		ProcessorData
	{
		protected float m_AnimationSpeed = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3065159348)]
		public float AnimationSpeed { get { return m_AnimationSpeed; } set { if (OnPropertyChanging("SpawnAnimationData." + nameof(AnimationSpeed), this, m_AnimationSpeed, value)) m_AnimationSpeed = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3065159348:
					AnimationSpeed = (float) p_Value;
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
				case 3065159348:
					return AnimationSpeed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3065159348:
					return typeof(SpawnAnimationData).GetProperty(nameof(AnimationSpeed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
