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
	public class SoldierAutoAimData : 
		DataContainer
	{
		protected List<AutoAimData> m_Poses = new List<AutoAimData>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(232668927), ContainerArray]
		public List<AutoAimData> Poses { get { return m_Poses; } set { if (OnPropertyChanging("SoldierAutoAimData." + nameof(Poses), this, m_Poses, value)) m_Poses = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 232668927:
					Poses = (List<AutoAimData>) p_Value;
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
				case 232668927:
					return Poses;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 232668927:
					return typeof(SoldierAutoAimData).GetProperty(nameof(Poses));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
