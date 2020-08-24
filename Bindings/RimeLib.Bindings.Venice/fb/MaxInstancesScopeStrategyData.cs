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
	public class MaxInstancesScopeStrategyData : 
		SoundScopeStrategyData
	{
		protected uint m_Count = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(212413894)]
		public uint Count { get { return m_Count; } set { if (OnPropertyChanging("MaxInstancesScopeStrategyData." + nameof(Count), this, m_Count, value)) m_Count = value; } } // 0xC (12)
		
		protected bool m_KeepOldest = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(135411227)]
		public bool KeepOldest { get { return m_KeepOldest; } set { if (OnPropertyChanging("MaxInstancesScopeStrategyData." + nameof(KeepOldest), this, m_KeepOldest, value)) m_KeepOldest = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 212413894:
					Count = (uint) p_Value;
					break;

				case 135411227:
					KeepOldest = (bool) p_Value;
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
				case 212413894:
					return Count;

				case 135411227:
					return KeepOldest;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 212413894:
					return typeof(MaxInstancesScopeStrategyData).GetProperty(nameof(Count));

				case 135411227:
					return typeof(MaxInstancesScopeStrategyData).GetProperty(nameof(KeepOldest));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
