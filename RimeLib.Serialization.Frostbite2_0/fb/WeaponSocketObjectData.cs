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
	public partial class WeaponSocketObjectData :
		SocketObjectDataBase
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private List<uint> _ReferencedAssetHashes = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<Asset> _Asset1p = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<Asset> _Asset1pzoom = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<Asset> _Asset3p = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_ReferencedAssetHashes = p_EbxWriter.GetArrayWriter(ReferencedAssetHashes.GetType(), ReferencedAssetHashes.Count);
			p_Writer.Write(s_ReferencedAssetHashes.ArrayIndex);
			foreach (var s_Entry in ReferencedAssetHashes)
			{
				s_ReferencedAssetHashes.Writer.Write(s_Entry);
			}
			p_Writer.Write(p_EbxWriter.WriteImport(Asset1p));
			p_Writer.Write(p_EbxWriter.WriteImport(Asset1pzoom));
			p_Writer.Write(p_EbxWriter.WriteImport(Asset3p));
		}
	}
}
