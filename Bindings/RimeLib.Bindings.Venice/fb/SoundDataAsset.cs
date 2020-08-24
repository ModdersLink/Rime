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
	public class SoundDataAsset : 
		Asset
	{
		protected uint m_NameHash = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(994057744)]
		public uint NameHash { get { return m_NameHash; } set { if (OnPropertyChanging("SoundDataAsset." + nameof(NameHash), this, m_NameHash, value)) m_NameHash = value; } } // 0xC (12)
		
		protected List<SoundDataChunk> m_Chunks = new List<SoundDataChunk>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(2727168525), ContainerArray]
		public List<SoundDataChunk> Chunks { get { return m_Chunks; } set { if (OnPropertyChanging("SoundDataAsset." + nameof(Chunks), this, m_Chunks, value)) m_Chunks = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 994057744:
					NameHash = (uint) p_Value;
					break;

				case 2727168525:
					Chunks = (List<SoundDataChunk>) p_Value;
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
				case 994057744:
					return NameHash;

				case 2727168525:
					return Chunks;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 994057744:
					return typeof(SoundDataAsset).GetProperty(nameof(NameHash));

				case 2727168525:
					return typeof(SoundDataAsset).GetProperty(nameof(Chunks));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
