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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class SoldierSpawnTemplateData : 
		Asset
	{
		protected CtrRef<CustomizeSoldierData> m_CustomizeSoldierData = new CtrRef<CustomizeSoldierData>();
		[ContainerField(Name: "CustomizeSoldierData", Offset: 12, NameHash: 2875154650, Flags: 53)]
		public CtrRef<CustomizeSoldierData> CustomizeSoldierData { get { return m_CustomizeSoldierData; } set { if (OnPropertyChanging("SoldierSpawnTemplateData." + nameof(CustomizeSoldierData), this, m_CustomizeSoldierData, value)) m_CustomizeSoldierData = value; } } // 0xC (12)
		
		protected CtrRef<GameSensingTemplateData> m_Sensing = new CtrRef<GameSensingTemplateData>();
		[ContainerField(Name: "Sensing", Offset: 16, NameHash: 2773286638, Flags: 53)]
		public CtrRef<GameSensingTemplateData> Sensing { get { return m_Sensing; } set { if (OnPropertyChanging("SoldierSpawnTemplateData." + nameof(Sensing), this, m_Sensing, value)) m_Sensing = value; } } // 0x10 (16)
		
		protected CtrRef<GameBehaviourTemplateData> m_Behaviour = new CtrRef<GameBehaviourTemplateData>();
		[ContainerField(Name: "Behaviour", Offset: 20, NameHash: 513159228, Flags: 53)]
		public CtrRef<GameBehaviourTemplateData> Behaviour { get { return m_Behaviour; } set { if (OnPropertyChanging("SoldierSpawnTemplateData." + nameof(Behaviour), this, m_Behaviour, value)) m_Behaviour = value; } } // 0x14 (20)
		
		protected CtrRef<AnimationSpawnTemplate> m_AnimationTemplate = new CtrRef<AnimationSpawnTemplate>();
		[ContainerField(Name: "AnimationTemplate", Offset: 24, NameHash: 4294916323, Flags: 53)]
		public CtrRef<AnimationSpawnTemplate> AnimationTemplate { get { return m_AnimationTemplate; } set { if (OnPropertyChanging("SoldierSpawnTemplateData." + nameof(AnimationTemplate), this, m_AnimationTemplate, value)) m_AnimationTemplate = value; } } // 0x18 (24)
		
		protected RefArray<VoiceOverLabel> m_VoiceOverLabels = new RefArray<VoiceOverLabel>();
		[ContainerField(Name: "VoiceOverLabels", Offset: 28, NameHash: 2741340584, Flags: 65)]
		public RefArray<VoiceOverLabel> VoiceOverLabels { get { return m_VoiceOverLabels; } set { if (OnPropertyChanging("SoldierSpawnTemplateData." + nameof(VoiceOverLabels), this, m_VoiceOverLabels, value)) m_VoiceOverLabels = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2875154650:
					CustomizeSoldierData = (CtrRef<CustomizeSoldierData>) p_Value;
					break;

				case 2773286638:
					Sensing = (CtrRef<GameSensingTemplateData>) p_Value;
					break;

				case 513159228:
					Behaviour = (CtrRef<GameBehaviourTemplateData>) p_Value;
					break;

				case 4294916323:
					AnimationTemplate = (CtrRef<AnimationSpawnTemplate>) p_Value;
					break;

				case 2741340584:
					VoiceOverLabels = (RefArray<VoiceOverLabel>) p_Value;
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
				case 2875154650:
					return CustomizeSoldierData;

				case 2773286638:
					return Sensing;

				case 513159228:
					return Behaviour;

				case 4294916323:
					return AnimationTemplate;

				case 2741340584:
					return VoiceOverLabels;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2875154650:
					return typeof(SoldierSpawnTemplateData).GetProperty(nameof(CustomizeSoldierData));

				case 2773286638:
					return typeof(SoldierSpawnTemplateData).GetProperty(nameof(Sensing));

				case 513159228:
					return typeof(SoldierSpawnTemplateData).GetProperty(nameof(Behaviour));

				case 4294916323:
					return typeof(SoldierSpawnTemplateData).GetProperty(nameof(AnimationTemplate));

				case 2741340584:
					return typeof(SoldierSpawnTemplateData).GetProperty(nameof(VoiceOverLabels));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
