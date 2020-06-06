///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SoldierEmoteNetworkedMessageMapping : 
		DataContainer
	{
		[ContainerField(8)]
		public SoldierEmote Emote { get; set; } = new SoldierEmote(); // 0x8 (8)
		
		[ContainerField(12)]
		public List<UIMessageType> Messages { get; set; } = new List<UIMessageType>(); // 0xC (12)
		
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
