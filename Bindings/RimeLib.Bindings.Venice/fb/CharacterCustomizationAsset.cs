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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(32), ContainerClass]
	public class CharacterCustomizationAsset : 
		Asset
	{
		protected string m_LabelSid = string.Empty;
		[ContainerField(12), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(4044105085)]
		public string LabelSid { get { return m_LabelSid; } set { if (OnPropertyChanging("CharacterCustomizationAsset." + nameof(LabelSid), this, m_LabelSid, value)) m_LabelSid = value; } } // 0xC (12)
		
		protected UIHudIcon m_UIHudIcon = new UIHudIcon();
		[ContainerField(16), MemberInfoFlag(137), ContainerFieldNameHash(3556510859)]
		public UIHudIcon UIHudIcon { get { return m_UIHudIcon; } set { if (OnPropertyChanging("CharacterCustomizationAsset." + nameof(UIHudIcon), this, m_UIHudIcon, value)) m_UIHudIcon = value; } } // 0x10 (16)
		
		protected RefArray<VoiceOverLabel> m_VoiceOverLabels = new RefArray<VoiceOverLabel>();
		[ContainerField(20), MemberInfoFlag(65), ContainerFieldNameHash(2741340584), ContainerRefArray]
		public RefArray<VoiceOverLabel> VoiceOverLabels { get { return m_VoiceOverLabels; } set { if (OnPropertyChanging("CharacterCustomizationAsset." + nameof(VoiceOverLabels), this, m_VoiceOverLabels, value)) m_VoiceOverLabels = value; } } // 0x14 (20)
		
		protected CtrRef<CustomizationTable> m_VisualTable = new CtrRef<CustomizationTable>();
		[ContainerField(24), MemberInfoFlag(53), ContainerFieldNameHash(277951407), ContainerCtrRef]
		public CtrRef<CustomizationTable> VisualTable { get { return m_VisualTable; } set { if (OnPropertyChanging("CharacterCustomizationAsset." + nameof(VisualTable), this, m_VisualTable, value)) m_VisualTable = value; } } // 0x18 (24)
		
		protected CtrRef<CustomizationTable> m_SpecializationTable = new CtrRef<CustomizationTable>();
		[ContainerField(28), MemberInfoFlag(53), ContainerFieldNameHash(1559267348), ContainerCtrRef]
		public CtrRef<CustomizationTable> SpecializationTable { get { return m_SpecializationTable; } set { if (OnPropertyChanging("CharacterCustomizationAsset." + nameof(SpecializationTable), this, m_SpecializationTable, value)) m_SpecializationTable = value; } } // 0x1C (28)
		
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
