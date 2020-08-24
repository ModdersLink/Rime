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
	public class SoldierEmoteNetworkedMessageMapping : 
		DataContainer
	{
		protected SoldierEmote m_Emote = new SoldierEmote();
		[ContainerField(8), MemberInfoFlag(137), ContainerFieldNameHash(201165523)]
		public SoldierEmote Emote { get { return m_Emote; } set { if (OnPropertyChanging("SoldierEmoteNetworkedMessageMapping." + nameof(Emote), this, m_Emote, value)) m_Emote = value; } } // 0x8 (8)
		
		protected List<UIMessageType> m_Messages = new List<UIMessageType>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(1812934205), ContainerArray]
		public List<UIMessageType> Messages { get { return m_Messages; } set { if (OnPropertyChanging("SoldierEmoteNetworkedMessageMapping." + nameof(Messages), this, m_Messages, value)) m_Messages = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 201165523:
					Emote = (SoldierEmote) Enum.ToObject(typeof(SoldierEmote), p_Value);
					break;

				case 1812934205:
					if (p_Value.GetType() == typeof (List<uint>))
						Messages = ((List<uint>) p_Value).Select(x => (UIMessageType) Enum.ToObject(typeof(UIMessageType), x)).ToList();
					else
						Messages = (List<UIMessageType>) p_Value;
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
				case 201165523:
					return Emote;

				case 1812934205:
					return Messages;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 201165523:
					return typeof(SoldierEmoteNetworkedMessageMapping).GetProperty(nameof(Emote));

				case 1812934205:
					return typeof(SoldierEmoteNetworkedMessageMapping).GetProperty(nameof(Messages));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
