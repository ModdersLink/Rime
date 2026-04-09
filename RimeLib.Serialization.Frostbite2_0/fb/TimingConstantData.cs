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
	[ContainerType(4, 44)]
	public partial class TimingConstantData :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _UpdateTimePerFrame;

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private SubsystemTimingConfigData _SubsystemTimeParts = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private RefArray<BotPriorityConfigData> _PriorityClasses = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(UpdateTimePerFrame);
			SubsystemTimeParts.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_PriorityClasses = p_EbxWriter.GetArrayWriter(PriorityClasses.GetType(), PriorityClasses.Count);
			p_Writer.Write(s_PriorityClasses.ArrayIndex);
			foreach (var s_Entry in PriorityClasses)
			{
				s_PriorityClasses.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
