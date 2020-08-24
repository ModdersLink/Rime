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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class BreakableControllerComponentData : 
		DestructionControllerComponentData
	{
		protected uint m_BreakablePartCount = new uint();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3849422468)]
		public uint BreakablePartCount { get { return m_BreakablePartCount; } set { if (OnPropertyChanging("BreakableControllerComponentData." + nameof(BreakablePartCount), this, m_BreakablePartCount, value)) m_BreakablePartCount = value; } } // 0x70 (112)
		
		protected uint m_NetworkIdCount = new uint();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1234693717)]
		public uint NetworkIdCount { get { return m_NetworkIdCount; } set { if (OnPropertyChanging("BreakableControllerComponentData." + nameof(NetworkIdCount), this, m_NetworkIdCount, value)) m_NetworkIdCount = value; } } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3849422468:
					BreakablePartCount = (uint) p_Value;
					break;

				case 1234693717:
					NetworkIdCount = (uint) p_Value;
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
				case 3849422468:
					return BreakablePartCount;

				case 1234693717:
					return NetworkIdCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3849422468:
					return typeof(BreakableControllerComponentData).GetProperty(nameof(BreakablePartCount));

				case 1234693717:
					return typeof(BreakableControllerComponentData).GetProperty(nameof(NetworkIdCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
