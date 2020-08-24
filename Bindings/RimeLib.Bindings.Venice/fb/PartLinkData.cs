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
	public class PartLinkData : 
		DataContainer
	{
		protected uint m_PartComponentIndex1 = new uint();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(830683346)]
		public uint PartComponentIndex1 { get { return m_PartComponentIndex1; } set { if (OnPropertyChanging("PartLinkData." + nameof(PartComponentIndex1), this, m_PartComponentIndex1, value)) m_PartComponentIndex1 = value; } } // 0x8 (8)
		
		protected uint m_PartComponentIndex2 = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(830683345)]
		public uint PartComponentIndex2 { get { return m_PartComponentIndex2; } set { if (OnPropertyChanging("PartLinkData." + nameof(PartComponentIndex2), this, m_PartComponentIndex2, value)) m_PartComponentIndex2 = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 830683346:
					PartComponentIndex1 = (uint) p_Value;
					break;

				case 830683345:
					PartComponentIndex2 = (uint) p_Value;
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
				case 830683346:
					return PartComponentIndex1;

				case 830683345:
					return PartComponentIndex2;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 830683346:
					return typeof(PartLinkData).GetProperty(nameof(PartComponentIndex1));

				case 830683345:
					return typeof(PartLinkData).GetProperty(nameof(PartComponentIndex2));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
