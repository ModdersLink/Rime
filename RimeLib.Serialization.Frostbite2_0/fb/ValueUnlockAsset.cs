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

namespace fb
{
	[ContainerType(4, 44)]
	public class ValueUnlockAsset :
		UnlockAssetBase
	{
		[ContainerField(40), JsonProperty(Order = 40)]
		public RefArray<UnlockValuePair> UnlockValues { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_UnlockValues = p_EbxWriter.GetArrayWriter(UnlockValues.GetType(), UnlockValues.Count);
			p_Writer.Write(s_UnlockValues.ArrayIndex);
			foreach (var s_Entry in UnlockValues)
			{
				s_UnlockValues.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
