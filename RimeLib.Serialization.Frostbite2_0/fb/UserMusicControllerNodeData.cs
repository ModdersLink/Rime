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
	[ContainerType(4, 28)]
	public partial class UserMusicControllerNodeData :
		AudioGraphNodeData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AudioGraphNodePort _Override = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AudioGraphNodePort _Restore = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private bool _RestoreOnDeactivated;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Override.Serialize(p_Writer, p_EbxWriter);
			Restore.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(RestoreOnDeactivated);
			p_Writer.WriteNullBytes(3);
		}
	}
}
