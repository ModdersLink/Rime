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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class VoiceOverDialogClipEvents : 
		DataContainer
	{
		protected uint m_StartedNameHash = new uint();
		[ContainerField(Name: "StartedNameHash", Offset: 8, NameHash: 2297623121, Flags: 49421), LayoutImmutable, Blittable]
		public uint StartedNameHash { get { return m_StartedNameHash; } set { if (OnPropertyChanging("VoiceOverDialogClipEvents." + nameof(StartedNameHash), this, m_StartedNameHash, value)) m_StartedNameHash = value; } } // 0x8 (8)
		
		protected uint m_FinishedNameHash = new uint();
		[ContainerField(Name: "FinishedNameHash", Offset: 12, NameHash: 651465762, Flags: 49421), LayoutImmutable, Blittable]
		public uint FinishedNameHash { get { return m_FinishedNameHash; } set { if (OnPropertyChanging("VoiceOverDialogClipEvents." + nameof(FinishedNameHash), this, m_FinishedNameHash, value)) m_FinishedNameHash = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2297623121:
					StartedNameHash = (uint) p_Value;
					break;

				case 651465762:
					FinishedNameHash = (uint) p_Value;
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
				case 2297623121:
					return StartedNameHash;

				case 651465762:
					return FinishedNameHash;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2297623121:
					return typeof(VoiceOverDialogClipEvents).GetProperty(nameof(StartedNameHash));

				case 651465762:
					return typeof(VoiceOverDialogClipEvents).GetProperty(nameof(FinishedNameHash));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
