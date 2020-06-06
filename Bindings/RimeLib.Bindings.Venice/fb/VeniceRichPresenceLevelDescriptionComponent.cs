///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VeniceRichPresenceLevelDescriptionComponent : 
		LevelDescriptionComponent
	{
		[ContainerField(8)]
		public CtrRef<RichPresencePresenceString> PresenceMode { get; set; } = new CtrRef<RichPresencePresenceString>(); // 0x8 (8)
		
		[ContainerField(12)]
		public List<RichPresenceContextSetting> ContextValues { get; set; } = new List<RichPresenceContextSetting>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2266879327:
					PresenceMode = (CtrRef<RichPresencePresenceString>) p_Value;
					break;

				case 3085702594:
					ContextValues = (List<RichPresenceContextSetting>) p_Value;
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
				case 2266879327:
					return PresenceMode;

				case 3085702594:
					return ContextValues;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2266879327:
					return typeof(VeniceRichPresenceLevelDescriptionComponent).GetProperty(nameof(PresenceMode));

				case 3085702594:
					return typeof(VeniceRichPresenceLevelDescriptionComponent).GetProperty(nameof(ContextValues));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
