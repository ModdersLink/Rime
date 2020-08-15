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
	public class StaticUnlockList : 
		Asset
	{
		protected List<BasicUnlockInfo> m_UnlockInfos = new List<BasicUnlockInfo>();
		[ContainerField(12), ContainerFieldNameHash(4145033000)]
		public List<BasicUnlockInfo> UnlockInfos { get { return m_UnlockInfos; } set { if (OnPropertyChanging("StaticUnlockList." + nameof(UnlockInfos), this, m_UnlockInfos, value)) m_UnlockInfos = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4145033000:
					UnlockInfos = (List<BasicUnlockInfo>) p_Value;
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
				case 4145033000:
					return UnlockInfos;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4145033000:
					return typeof(StaticUnlockList).GetProperty(nameof(UnlockInfos));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
