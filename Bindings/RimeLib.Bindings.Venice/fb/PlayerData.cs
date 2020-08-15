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
	[ContainerType(4)]
	public class PlayerData : 
		Asset
	{
		protected CtrRef<PlayerViewData> m_PlayerView = new CtrRef<PlayerViewData>();
		[ContainerField(12), ContainerFieldNameHash(774623483)]
		public CtrRef<PlayerViewData> PlayerView { get { return m_PlayerView; } set { if (OnPropertyChanging("PlayerData." + nameof(PlayerView), this, m_PlayerView, value)) m_PlayerView = value; } } // 0xC (12)
		
		protected CtrRef<EntryInputActionMapsData> m_InputConceptDefinition = new CtrRef<EntryInputActionMapsData>();
		[ContainerField(16), ContainerFieldNameHash(1770668454)]
		public CtrRef<EntryInputActionMapsData> InputConceptDefinition { get { return m_InputConceptDefinition; } set { if (OnPropertyChanging("PlayerData." + nameof(InputConceptDefinition), this, m_InputConceptDefinition, value)) m_InputConceptDefinition = value; } } // 0x10 (16)
		
		protected CtrRef<InputActionMappingsData> m_InputMapping = new CtrRef<InputActionMappingsData>();
		[ContainerField(20), ContainerFieldNameHash(1744270687)]
		public CtrRef<InputActionMappingsData> InputMapping { get { return m_InputMapping; } set { if (OnPropertyChanging("PlayerData." + nameof(InputMapping), this, m_InputMapping, value)) m_InputMapping = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 774623483:
					PlayerView = (CtrRef<PlayerViewData>) p_Value;
					break;

				case 1770668454:
					InputConceptDefinition = (CtrRef<EntryInputActionMapsData>) p_Value;
					break;

				case 1744270687:
					InputMapping = (CtrRef<InputActionMappingsData>) p_Value;
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
				case 774623483:
					return PlayerView;

				case 1770668454:
					return InputConceptDefinition;

				case 1744270687:
					return InputMapping;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 774623483:
					return typeof(PlayerData).GetProperty(nameof(PlayerView));

				case 1770668454:
					return typeof(PlayerData).GetProperty(nameof(InputConceptDefinition));

				case 1744270687:
					return typeof(PlayerData).GetProperty(nameof(InputMapping));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
