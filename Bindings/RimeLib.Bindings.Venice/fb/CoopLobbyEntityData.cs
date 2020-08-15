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
	[ContainerType(16)]
	public class CoopLobbyEntityData : 
		GameEntityData
	{
		protected float m_ClientConnectionTimeout = new float();
		[ContainerField(96), LayoutImmutable, Blittable, ContainerFieldNameHash(2916205073)]
		public float ClientConnectionTimeout { get { return m_ClientConnectionTimeout; } set { if (OnPropertyChanging("CoopLobbyEntityData." + nameof(ClientConnectionTimeout), this, m_ClientConnectionTimeout, value)) m_ClientConnectionTimeout = value; } } // 0x60 (96)
		
		protected bool m_IsInGame = new bool();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(703264438)]
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
