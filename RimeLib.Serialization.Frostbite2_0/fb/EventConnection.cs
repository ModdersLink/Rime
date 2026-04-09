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
	public partial class EventConnection :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private CtrRef<DataContainer> _Source = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private CtrRef<DataContainer> _Target = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private EventSpec _SourceEvent = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private EventSpec _TargetEvent = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private EventConnectionTargetType _TargetType = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Source));
			p_Writer.Write(p_EbxWriter.WriteImport(Target));
			SourceEvent.Serialize(p_Writer, p_EbxWriter);
			TargetEvent.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) TargetType);
		}
	}
}
