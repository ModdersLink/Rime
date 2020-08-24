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
	public class UIScoreboardCompData : 
		UIComponentData
	{
		protected float m_MaxUpdateInterval = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2164988415)]
		public float MaxUpdateInterval { get { return m_MaxUpdateInterval; } set { if (OnPropertyChanging("UIScoreboardCompData." + nameof(MaxUpdateInterval), this, m_MaxUpdateInterval, value)) m_MaxUpdateInterval = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2164988415:
					MaxUpdateInterval = (float) p_Value;
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
				case 2164988415:
					return MaxUpdateInterval;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2164988415:
					return typeof(UIScoreboardCompData).GetProperty(nameof(MaxUpdateInterval));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
