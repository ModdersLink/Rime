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
	[ContainerType(16, 176)]
	public partial class SocketData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private LinearTransform _BoneRigidTransform = new();

		[ObservableProperty]
		[property: ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private LinearTransform _Transform = new();

		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private CtrRef<UnlockAssetBase> _UnlockAsset = new();

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private int _BoneId;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, JsonProperty(Order = 152)]
		private string _BoneName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(156), JsonProperty(Order = 156)]
		private RefArray<SocketObjectDataBase> _AvailableObjects = new();

		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private GearSlot _GearSlot = new();

		[ObservableProperty]
		[property: ContainerField(164), JsonProperty(Order = 164)]
		private SocketType _SocketType = new();

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private bool _UsesDefaultObject;

		[ObservableProperty]
		[property: ContainerField(169), LayoutImmutable, Blittable, JsonProperty(Order = 169)]
		private bool _Excluded;

		[ObservableProperty]
		[property: ContainerField(170), LayoutImmutable, Blittable, JsonProperty(Order = 170)]
		private bool _DefaultEnableSocketEntities;

		[ObservableProperty]
		[property: ContainerField(171), LayoutImmutable, Blittable, JsonProperty(Order = 171)]
		private bool _ForceSocketEntitiesEnabled;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private bool _HideByZoomTransition;

		[ObservableProperty]
		[property: ContainerField(173), LayoutImmutable, Blittable, JsonProperty(Order = 173)]
		private bool _HideByLightToggle;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
			BoneRigidTransform.Serialize(p_Writer, p_EbxWriter);
			Transform.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(UnlockAsset));
			p_Writer.Write(BoneId);
			p_Writer.Write(p_EbxWriter.WriteString(BoneName));
			(RimeWriter Writer, uint ArrayIndex) s_AvailableObjects = p_EbxWriter.GetArrayWriter(AvailableObjects.GetType(), AvailableObjects.Count);
			p_Writer.Write(s_AvailableObjects.ArrayIndex);
			foreach (var s_Entry in AvailableObjects)
			{
				s_AvailableObjects.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write((int) GearSlot);
			p_Writer.Write((int) SocketType);
			p_Writer.Write(UsesDefaultObject);
			p_Writer.Write(Excluded);
			p_Writer.Write(DefaultEnableSocketEntities);
			p_Writer.Write(ForceSocketEntitiesEnabled);
			p_Writer.Write(HideByZoomTransition);
			p_Writer.Write(HideByLightToggle);
			p_Writer.WriteNullBytes(2);
		}
	}
}
