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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(24), ContainerClass]
	public class CharacterSocketListAsset : 
		Asset
	{
		protected RefArray<SocketData> m_GameplaySockets = new RefArray<SocketData>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(790257145), ContainerRefArray]
		public RefArray<SocketData> GameplaySockets { get { return m_GameplaySockets; } set { if (OnPropertyChanging("CharacterSocketListAsset." + nameof(GameplaySockets), this, m_GameplaySockets, value)) m_GameplaySockets = value; } } // 0xC (12)
		
		protected RefArray<SocketData> m_RigidVisualSockets = new RefArray<SocketData>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(2894846550), ContainerRefArray]
		public RefArray<SocketData> RigidVisualSockets { get { return m_RigidVisualSockets; } set { if (OnPropertyChanging("CharacterSocketListAsset." + nameof(RigidVisualSockets), this, m_RigidVisualSockets, value)) m_RigidVisualSockets = value; } } // 0x10 (16)
		
		protected RefArray<SocketData> m_SkinnedVisualSockets = new RefArray<SocketData>();
		[ContainerField(20), MemberInfoFlag(65), ContainerFieldNameHash(2310136503), ContainerRefArray]
		public RefArray<SocketData> SkinnedVisualSockets { get { return m_SkinnedVisualSockets; } set { if (OnPropertyChanging("CharacterSocketListAsset." + nameof(SkinnedVisualSockets), this, m_SkinnedVisualSockets, value)) m_SkinnedVisualSockets = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 790257145:
					GameplaySockets = (RefArray<SocketData>) p_Value;
					break;

				case 2894846550:
					RigidVisualSockets = (RefArray<SocketData>) p_Value;
					break;

				case 2310136503:
					SkinnedVisualSockets = (RefArray<SocketData>) p_Value;
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
				case 790257145:
					return GameplaySockets;

				case 2894846550:
					return RigidVisualSockets;

				case 2310136503:
					return SkinnedVisualSockets;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 790257145:
					return typeof(CharacterSocketListAsset).GetProperty(nameof(GameplaySockets));

				case 2894846550:
					return typeof(CharacterSocketListAsset).GetProperty(nameof(RigidVisualSockets));

				case 2310136503:
					return typeof(CharacterSocketListAsset).GetProperty(nameof(SkinnedVisualSockets));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
