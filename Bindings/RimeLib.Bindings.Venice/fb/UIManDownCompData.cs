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
	public class UIManDownCompData : 
		UIComponentData
	{
		protected float m_DelayManDownTextTime = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3590261480)]
		public float DelayManDownTextTime { get { return m_DelayManDownTextTime; } set { if (OnPropertyChanging("UIManDownCompData." + nameof(DelayManDownTextTime), this, m_DelayManDownTextTime, value)) m_DelayManDownTextTime = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3590261480:
					DelayManDownTextTime = (float) p_Value;
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
				case 3590261480:
					return DelayManDownTextTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3590261480:
					return typeof(UIManDownCompData).GetProperty(nameof(DelayManDownTextTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
