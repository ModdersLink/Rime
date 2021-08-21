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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class CoopLobbyEntityData : 
		GameEntityData
	{
		protected float m_ClientConnectionTimeout = new float();
		[ContainerField(Name: "ClientConnectionTimeout", Offset: 96, NameHash: 2916205073, Flags: 49469), LayoutImmutable, Blittable]
		public float ClientConnectionTimeout { get { return m_ClientConnectionTimeout; } set { if (OnPropertyChanging("CoopLobbyEntityData." + nameof(ClientConnectionTimeout), this, m_ClientConnectionTimeout, value)) m_ClientConnectionTimeout = value; } } // 0x60 (96)
		
		protected bool m_IsInGame = new bool();
		[ContainerField(Name: "IsInGame", Offset: 100, NameHash: 703264438, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsInGame { get { return m_IsInGame; } set { if (OnPropertyChanging("CoopLobbyEntityData." + nameof(IsInGame), this, m_IsInGame, value)) m_IsInGame = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2916205073:
					ClientConnectionTimeout = (float) p_Value;
					break;

				case 703264438:
					IsInGame = (bool) p_Value;
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
				case 2916205073:
					return ClientConnectionTimeout;

				case 703264438:
					return IsInGame;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2916205073:
					return typeof(CoopLobbyEntityData).GetProperty(nameof(ClientConnectionTimeout));

				case 703264438:
					return typeof(CoopLobbyEntityData).GetProperty(nameof(IsInGame));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
