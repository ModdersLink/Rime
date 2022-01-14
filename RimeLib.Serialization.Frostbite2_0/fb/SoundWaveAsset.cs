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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 48)]
	public class SoundWaveAsset :
		SoundDataAsset
	{
		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<SoundWaveVariation> Variations { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public List<SoundWaveLocalizationInfo> Localization { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public List<string> SubtitleStringIds { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public SoundWaveVariationSelection Selection { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public CtrRef<StreamPoolAsset> StreamPool { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public bool Seekable { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
		public bool PreferAvailableVariations { get; set; }

		[ContainerField(42), LayoutImmutable, Blittable, JsonProperty(Order = 42)]
		public sbyte PersistentVariationCount { get; set; }

		[ContainerField(43), LayoutImmutable, Blittable, JsonProperty(Order = 43)]
		public sbyte ChannelCount { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public sbyte VoicePriority { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		public sbyte PrimePriority { get; set; }

		[ContainerField(46), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
		public sbyte RequestPriority { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Variations = p_EbxWriter.GetArrayWriter(Variations.GetType(), Variations.Count);
			p_Writer.Write(s_Variations.ArrayIndex);
			foreach (var s_Entry in Variations)
			{
				s_Variations.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Localization = p_EbxWriter.GetArrayWriter(Localization.GetType(), Localization.Count);
			p_Writer.Write(s_Localization.ArrayIndex);
			foreach (var s_Entry in Localization)
			{
				s_Entry.Serialize(s_Localization.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_SubtitleStringIds = p_EbxWriter.GetArrayWriter(SubtitleStringIds.GetType(), SubtitleStringIds.Count);
			p_Writer.Write(s_SubtitleStringIds.ArrayIndex);
			foreach (var s_Entry in SubtitleStringIds)
			{
				s_SubtitleStringIds.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.Write((int) Selection);
			p_Writer.Write(p_EbxWriter.WriteImport(StreamPool));
			p_Writer.Write(Seekable);
			p_Writer.Write(PreferAvailableVariations);
			p_Writer.Write(PersistentVariationCount);
			p_Writer.Write(ChannelCount);
			p_Writer.Write(VoicePriority);
			p_Writer.Write(PrimePriority);
			p_Writer.Write(RequestPriority);
			p_Writer.WriteNullBytes(1);
		}
	}
}
