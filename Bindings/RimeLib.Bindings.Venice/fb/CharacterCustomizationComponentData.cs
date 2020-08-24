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
	public class CharacterCustomizationComponentData : 
		ComponentData
	{
		protected CtrRef<CharacterSocketListAsset> m_SocketList = new CtrRef<CharacterSocketListAsset>();
		[ContainerField(96), MemberInfoFlag(53), ContainerFieldNameHash(648025282), ContainerCtrRef]
		public CtrRef<CharacterSocketListAsset> SocketList { get { return m_SocketList; } set { if (OnPropertyChanging("CharacterCustomizationComponentData." + nameof(SocketList), this, m_SocketList, value)) m_SocketList = value; } } // 0x60 (96)
		
		protected CtrRef<MeshLodGroup> m_SharedLodGroup = new CtrRef<MeshLodGroup>();
		[ContainerField(100), MemberInfoFlag(53), ContainerFieldNameHash(1815069620), ContainerCtrRef]
		public CtrRef<MeshLodGroup> SharedLodGroup { get { return m_SharedLodGroup; } set { if (OnPropertyChanging("CharacterCustomizationComponentData." + nameof(SharedLodGroup), this, m_SharedLodGroup, value)) m_SharedLodGroup = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 648025282:
					SocketList = (CtrRef<CharacterSocketListAsset>) p_Value;
					break;

				case 1815069620:
					SharedLodGroup = (CtrRef<MeshLodGroup>) p_Value;
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
				case 648025282:
					return SocketList;

				case 1815069620:
					return SharedLodGroup;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 648025282:
					return typeof(CharacterCustomizationComponentData).GetProperty(nameof(SocketList));

				case 1815069620:
					return typeof(CharacterCustomizationComponentData).GetProperty(nameof(SharedLodGroup));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
