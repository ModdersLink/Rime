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
	[ContainerType(4, 48)]
	public partial class AntAnimationHandlerData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private AntAnimatableData _Animatable = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private AntRef _RootController = new();
		
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private LodBinding _LodBinding = new();
		
		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private RefArray<AntPackageAsset> _AntPackageData = new();
		
		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private List<GameplayBone> _BonesToMirror = new();
		
		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private bool _ReportBackFromAnt;
		
		[ObservableProperty]
		[property: ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		private bool _EnableMasterSlaveCopy;
		
		[ObservableProperty]
		[property: ContainerField(46), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
		private bool _IsProp;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Animatable.Serialize(p_Writer, p_EbxWriter);
			RootController.Serialize(p_Writer, p_EbxWriter);
			LodBinding.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_AntPackageData = p_EbxWriter.GetArrayWriter(AntPackageData.GetType(), AntPackageData.Count);
			p_Writer.Write(s_AntPackageData.ArrayIndex);
			foreach (var s_Entry in AntPackageData)
			{
				s_AntPackageData.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_BonesToMirror = p_EbxWriter.GetArrayWriter(BonesToMirror.GetType(), BonesToMirror.Count);
			p_Writer.Write(s_BonesToMirror.ArrayIndex);
			foreach (var s_Entry in BonesToMirror)
			{
				s_Entry.Serialize(s_BonesToMirror.Writer, p_EbxWriter);
			}
			p_Writer.Write(ReportBackFromAnt);
			p_Writer.Write(EnableMasterSlaveCopy);
			p_Writer.Write(IsProp);
			p_Writer.WriteNullBytes(1);
		}
	}
}
