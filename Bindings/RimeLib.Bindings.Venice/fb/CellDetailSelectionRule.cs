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
	public class CellDetailSelectionRule : 
		PackagingRule
	{
		protected PackagingDetailLevel m_Detail = new PackagingDetailLevel();
		[ContainerField(48), MemberInfoFlag(137), ContainerFieldNameHash(2594676244)]
		public PackagingDetailLevel Detail { get { return m_Detail; } set { if (OnPropertyChanging("CellDetailSelectionRule." + nameof(Detail), this, m_Detail, value)) m_Detail = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2594676244:
					Detail = (PackagingDetailLevel) Enum.ToObject(typeof(PackagingDetailLevel), p_Value);
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
				case 2594676244:
					return Detail;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2594676244:
					return typeof(CellDetailSelectionRule).GetProperty(nameof(Detail));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
