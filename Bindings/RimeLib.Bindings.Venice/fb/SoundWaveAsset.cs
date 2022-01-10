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
	[ContainerType(4, 48)]
	public class SoundWaveAsset : 
		SoundDataAsset
	{
		[ContainerField(20)]
		public List<CtrRef<SoundWaveVariation>> Variations { get; set; } = new();

		[ContainerField(24)]
		public List<SoundWaveLocalizationInfo> Localization { get; set; } = new();

		[ContainerField(28)]
		public List<string> SubtitleStringIds { get; set; } = new();

		[ContainerField(32)]
		public SoundWaveVariationSelection Selection { get; set; } = new();

		[ContainerField(36)]
		public CtrRef<StreamPoolAsset> StreamPool { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable]
		public bool Seekable { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable]
		public bool PreferAvailableVariations { get; set; }

		[ContainerField(42), LayoutImmutable, Blittable]
		public sbyte PersistentVariationCount { get; set; }

		[ContainerField(43), LayoutImmutable, Blittable]
		public sbyte ChannelCount { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public sbyte VoicePriority { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable]
		public sbyte PrimePriority { get; set; }

		[ContainerField(46), LayoutImmutable, Blittable]
		public sbyte RequestPriority { get; set; }

		public static void Deserialize(SoundWaveAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Variations.Clear();
			(RimeReader Reader, uint Count) s_Variations = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Variations.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SoundWaveVariation>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Variations.Reader.ReadUInt32()));
				p_Instance.Variations.Add(s_CtrRef);
			}
			
			s_Variations.Reader.Dispose();
			p_Instance.Localization.Clear();
			(RimeReader Reader, uint Count) s_Localization = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Localization.Count; ++i)
			{
				var s_Value = new SoundWaveLocalizationInfo();
				fb.SoundWaveLocalizationInfo.Deserialize(s_Value, s_Localization.Reader, p_Parser);
				p_Instance.Localization.Add(s_Value);
			}
			
			s_Localization.Reader.Dispose();
			p_Instance.SubtitleStringIds.Clear();
			(RimeReader Reader, uint Count) s_SubtitleStringIds = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_SubtitleStringIds.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_SubtitleStringIds.Reader.ReadUInt32());
				p_Instance.SubtitleStringIds.Add(s_Value);
			}
			
			s_SubtitleStringIds.Reader.Dispose();
			p_Instance.Selection = (SoundWaveVariationSelection) p_Reader.ReadInt32();
			p_Instance.StreamPool.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Seekable = p_Reader.ReadBool();
			p_Instance.PreferAvailableVariations = p_Reader.ReadBool();
			p_Instance.PersistentVariationCount = p_Reader.ReadSByte();
			p_Instance.ChannelCount = p_Reader.ReadSByte();
			p_Instance.VoicePriority = p_Reader.ReadSByte();
			p_Instance.PrimePriority = p_Reader.ReadSByte();
			p_Instance.RequestPriority = p_Reader.ReadSByte();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
