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
	[ContainerType(4, 20)]
	public partial class AwardStatus :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		private string _Code = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		private uint _CurrentValue;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private uint _OriginalValue;
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<CounterStatus> _Counters = new();
		
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private bool _IsCounting;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Code));
			p_Writer.Write(CurrentValue);
			p_Writer.Write(OriginalValue);
			(RimeWriter Writer, uint ArrayIndex) s_Counters = p_EbxWriter.GetArrayWriter(Counters.GetType(), Counters.Count);
			p_Writer.Write(s_Counters.ArrayIndex);
			foreach (var s_Entry in Counters)
			{
				s_Entry.Serialize(s_Counters.Writer, p_EbxWriter);
			}
			p_Writer.Write(IsCounting);
			p_Writer.WriteNullBytes(3);
		}
	}
}
