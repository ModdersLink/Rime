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
	public partial class WarpAnimationBinding :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private AntRef _ConnectJointGroup = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private AntRef _ConnectJointWeight = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AntRef _EnableAlign = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private AntRef _DisableCulling = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AntRef _TranslationYWarpTolerance = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ConnectJointGroup.Serialize(p_Writer, p_EbxWriter);
			ConnectJointWeight.Serialize(p_Writer, p_EbxWriter);
			EnableAlign.Serialize(p_Writer, p_EbxWriter);
			DisableCulling.Serialize(p_Writer, p_EbxWriter);
			TranslationYWarpTolerance.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
