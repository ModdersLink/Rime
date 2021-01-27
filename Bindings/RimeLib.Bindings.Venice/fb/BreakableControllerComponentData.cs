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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class BreakableControllerComponentData : 
		DestructionControllerComponentData
	{
		protected uint m_BreakablePartCount = new uint();
		[ContainerField(Name: "BreakablePartCount", Offset: 112, NameHash: 3849422468, Flags: 49421), LayoutImmutable, Blittable]
		public uint BreakablePartCount { get { return m_BreakablePartCount; } set { if (OnPropertyChanging("BreakableControllerComponentData." + nameof(BreakablePartCount), this, m_BreakablePartCount, value)) m_BreakablePartCount = value; } } // 0x70 (112)
		
		protected uint m_NetworkIdCount = new uint();
		[ContainerField(Name: "NetworkIdCount", Offset: 116, NameHash: 1234693717, Flags: 49421), LayoutImmutable, Blittable]
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
