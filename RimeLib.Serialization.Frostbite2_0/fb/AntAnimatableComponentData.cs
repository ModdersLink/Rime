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
	[ContainerType(16, 160)]
	public partial class AntAnimatableComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(100), JsonProperty(Order = 100)]
		private SubRealm _SubRealm = new();

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private AntAnimationHandlerData _AnimationData = new();

		[ObservableProperty]
		[property: ContainerField(152), JsonProperty(Order = 152)]
		private CtrRef<SkinnedMeshAsset> _Mesh = new();

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private bool _AutoActivate;

		[ObservableProperty]
		[property: ContainerField(157), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
		private bool _AnimationControlledFromStart;

		[ObservableProperty]
		[property: ContainerField(158), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
		private bool _ForceDisableCulling;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Realm);
			p_Writer.Write((int) SubRealm);
			AnimationData.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(AutoActivate);
			p_Writer.Write(AnimationControlledFromStart);
			p_Writer.Write(ForceDisableCulling);
			p_Writer.WriteNullBytes(1);
		}
	}
}
