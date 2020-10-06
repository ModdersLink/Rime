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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(16), ContainerClass]
	public class EnlightenRuntimeConfig : 
		Asset
	{
		protected uint m_JobCount = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(4166996065)]
		public uint JobCount { get { return m_JobCount; } set { if (OnPropertyChanging("EnlightenRuntimeConfig." + nameof(JobCount), this, m_JobCount, value)) m_JobCount = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4166996065:
					JobCount = (uint) p_Value;
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
				case 4166996065:
					return JobCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4166996065:
					return typeof(EnlightenRuntimeConfig).GetProperty(nameof(JobCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
