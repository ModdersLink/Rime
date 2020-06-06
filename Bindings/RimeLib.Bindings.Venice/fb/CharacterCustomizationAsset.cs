///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class CharacterCustomizationAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string LabelSid { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public UIHudIcon UIHudIcon { get; set; } = new UIHudIcon(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<VoiceOverLabel> VoiceOverLabels { get; set; } = new RefArray<VoiceOverLabel>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<CustomizationTable> VisualTable { get; set; } = new CtrRef<CustomizationTable>(); // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<CustomizationTable> SpecializationTable { get; set; } = new CtrRef<CustomizationTable>(); // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4044105085:
					LabelSid = (string) p_Value;
					break;

				case 3556510859:
					UIHudIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 2741340584:
					VoiceOverLabels = (RefArray<VoiceOverLabel>) p_Value;
					break;

				case 277951407:
					VisualTable = (CtrRef<CustomizationTable>) p_Value;
					break;

				case 1559267348:
					SpecializationTable = (CtrRef<CustomizationTable>) p_Value;
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
				case 4044105085:
					return LabelSid;

				case 3556510859:
					return UIHudIcon;

				case 2741340584:
					return VoiceOverLabels;

				case 277951407:
					return VisualTable;

				case 1559267348:
					return SpecializationTable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4044105085:
					return typeof(CharacterCustomizationAsset).GetProperty(nameof(LabelSid));

				case 3556510859:
					return typeof(CharacterCustomizationAsset).GetProperty(nameof(UIHudIcon));

				case 2741340584:
					return typeof(CharacterCustomizationAsset).GetProperty(nameof(VoiceOverLabels));

				case 277951407:
					return typeof(CharacterCustomizationAsset).GetProperty(nameof(VisualTable));

				case 1559267348:
					return typeof(CharacterCustomizationAsset).GetProperty(nameof(SpecializationTable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
