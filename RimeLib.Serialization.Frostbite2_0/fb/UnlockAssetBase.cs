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
	[ContainerType(4, 40)]
	public partial class UnlockAssetBase :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _UnlockScore;

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<UnlockUserDataBase> _UnlockUserData = new();

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		private string _DebugUnlockId = string.Empty;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _Identifier;

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private UnlockAvailability _AvailableForPlayer = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private CtrRef<UnlockAssetBase> _NextLevelUnlockAsset = new();

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private bool _AutoAvailable;

		[ObservableProperty]
		[property: ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		private bool _HiddenInProgression;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(UnlockScore);
			p_Writer.Write(p_EbxWriter.WriteImport(UnlockUserData));
			p_Writer.Write(p_EbxWriter.WriteString(DebugUnlockId));
			p_Writer.Write(Identifier);
			p_Writer.Write((int) AvailableForPlayer);
			p_Writer.Write(p_EbxWriter.WriteImport(NextLevelUnlockAsset));
			p_Writer.Write(AutoAvailable);
			p_Writer.Write(HiddenInProgression);
			p_Writer.WriteNullBytes(2);
		}
	}
}
