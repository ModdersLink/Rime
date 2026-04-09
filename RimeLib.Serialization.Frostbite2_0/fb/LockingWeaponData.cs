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
	public partial class LockingWeaponData :
		WeaponData
	{
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<LockingControllerData> _LockingController = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<LockingControllerData> _SecondaryLockingController = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private WarnTarget _WarnLock = new();

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private bool _IsHoming;

		[ObservableProperty]
		[property: ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		private bool _IsGuidedWhenZoomed;

		[ObservableProperty]
		[property: ContainerField(30), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
		private bool _FireOnlyWhenLockedOn;

		[ObservableProperty]
		[property: ContainerField(31), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
		private bool _IsGuided;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(LockingController));
			p_Writer.Write(p_EbxWriter.WriteImport(SecondaryLockingController));
			p_Writer.Write((int) WarnLock);
			p_Writer.Write(IsHoming);
			p_Writer.Write(IsGuidedWhenZoomed);
			p_Writer.Write(FireOnlyWhenLockedOn);
			p_Writer.Write(IsGuided);
		}
	}
}
