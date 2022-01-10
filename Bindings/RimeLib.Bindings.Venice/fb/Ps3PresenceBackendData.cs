///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 32)]
	public class Ps3PresenceBackendData : 
		PresenceBackendData
	{
		[ContainerField(16), LayoutImmutable]
		public string CommunicationId { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable]
		public string CommunicationSignature { get; set; } = string.Empty;

		[ContainerField(24)]
		public List<Ps3SkuSettings> SkuSettings { get; set; } = new();

		[ContainerField(28)]
		public List<Ps3ParentalLockAgeSettings> ParentalLockAgeSettings { get; set; } = new();

		public static void Deserialize(Ps3PresenceBackendData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.CommunicationId = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.CommunicationSignature = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.SkuSettings.Clear();
			(RimeReader Reader, uint Count) s_SkuSettings = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_SkuSettings.Count; ++i)
			{
				var s_Value = new Ps3SkuSettings();
				fb.Ps3SkuSettings.Deserialize(s_Value, s_SkuSettings.Reader, p_Parser);
				p_Instance.SkuSettings.Add(s_Value);
			}
			
			s_SkuSettings.Reader.Dispose();
			p_Instance.ParentalLockAgeSettings.Clear();
			(RimeReader Reader, uint Count) s_ParentalLockAgeSettings = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ParentalLockAgeSettings.Count; ++i)
			{
				var s_Value = new Ps3ParentalLockAgeSettings();
				fb.Ps3ParentalLockAgeSettings.Deserialize(s_Value, s_ParentalLockAgeSettings.Reader, p_Parser);
				p_Instance.ParentalLockAgeSettings.Add(s_Value);
			}
			
			s_ParentalLockAgeSettings.Reader.Dispose();
		}

	}
}
