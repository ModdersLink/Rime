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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(112), ContainerClass]
	public class KillAllEntityData : 
		GameEntityData
	{
		protected bool m_KillAllHumanSoldiers = new bool();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2202794880)]
		public bool KillAllHumanSoldiers { get { return m_KillAllHumanSoldiers; } set { if (OnPropertyChanging("KillAllEntityData." + nameof(KillAllHumanSoldiers), this, m_KillAllHumanSoldiers, value)) m_KillAllHumanSoldiers = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2202794880:
					KillAllHumanSoldiers = (bool) p_Value;
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
				case 2202794880:
					return KillAllHumanSoldiers;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2202794880:
					return typeof(KillAllEntityData).GetProperty(nameof(KillAllHumanSoldiers));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
