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
	public partial class Crossfader2NodeData :
		AudioGraphNodeData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AudioGraphNodePort _Ctrl = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AudioGraphNodePort _CtrlOut1 = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AudioGraphNodePort _CtrlOut2 = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Ctrl.Serialize(p_Writer, p_EbxWriter);
			CtrlOut1.Serialize(p_Writer, p_EbxWriter);
			CtrlOut2.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
