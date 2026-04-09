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
	[ContainerType(16, 96)]
	public partial class AnimatedCameraData :
		CameraData
	{
		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private CtrRef<SkeletonAsset> _Skeleton = new();

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, JsonProperty(Order = 84)]
		private string _CameraBone = string.Empty;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, JsonProperty(Order = 88)]
		private string _FovBone = string.Empty;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Skeleton));
			p_Writer.Write(p_EbxWriter.WriteString(CameraBone));
			p_Writer.Write(p_EbxWriter.WriteString(FovBone));
			p_Writer.WriteNullBytes(4);
		}
	}
}
