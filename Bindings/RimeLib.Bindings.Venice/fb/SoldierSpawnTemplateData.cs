///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SoldierSpawnTemplateData : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<CustomizeSoldierData> CustomizeSoldierData { get; set; } = new CtrRef<CustomizeSoldierData>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<GameSensingTemplateData> Sensing { get; set; } = new CtrRef<GameSensingTemplateData>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<GameBehaviourTemplateData> Behaviour { get; set; } = new CtrRef<GameBehaviourTemplateData>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<AnimationSpawnTemplate> AnimationTemplate { get; set; } = new CtrRef<AnimationSpawnTemplate>(); // 0x18 (24)
		
		[ContainerField(28)]
		public RefArray<VoiceOverLabel> VoiceOverLabels { get; set; } = new RefArray<VoiceOverLabel>(); // 0x1C (28)
		
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
