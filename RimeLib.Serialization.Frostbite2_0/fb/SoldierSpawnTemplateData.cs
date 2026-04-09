///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 32)]
	public partial class SoldierSpawnTemplateData :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<CustomizeSoldierData> _CustomizeSoldierData = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<GameSensingTemplateData> _Sensing = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<GameBehaviourTemplateData> _Behaviour = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private CtrRef<AnimationSpawnTemplate> _AnimationTemplate = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private RefArray<VoiceOverLabel> _VoiceOverLabels = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(CustomizeSoldierData));
			p_Writer.Write(p_EbxWriter.WriteImport(Sensing));
			p_Writer.Write(p_EbxWriter.WriteImport(Behaviour));
			p_Writer.Write(p_EbxWriter.WriteImport(AnimationTemplate));
			(RimeWriter Writer, uint ArrayIndex) s_VoiceOverLabels = p_EbxWriter.GetArrayWriter(VoiceOverLabels.GetType(), VoiceOverLabels.Count);
			p_Writer.Write(s_VoiceOverLabels.ArrayIndex);
			foreach (var s_Entry in VoiceOverLabels)
			{
				s_VoiceOverLabels.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
