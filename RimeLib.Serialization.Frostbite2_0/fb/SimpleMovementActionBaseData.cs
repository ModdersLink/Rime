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
	[ContainerType(4, 24)]
	public partial class SimpleMovementActionBaseData :
		MovementActionData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private SimpleMovementActionTimeData _StartTimeInfo = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private SimpleMovementActionTimeData _RunTimeInfo = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			StartTimeInfo.Serialize(p_Writer, p_EbxWriter);
			RunTimeInfo.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
