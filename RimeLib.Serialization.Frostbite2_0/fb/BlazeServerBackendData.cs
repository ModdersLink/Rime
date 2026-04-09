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
	[ContainerType(4, 52)]
	public partial class BlazeServerBackendData :
		ServerBackendData
	{
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private BlazeCreateGameParameters _CreateParameters = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private OnlineEnvironmentConsoleUrl _ConfigUrl = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			CreateParameters.Serialize(p_Writer, p_EbxWriter);
			ConfigUrl.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
