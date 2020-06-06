///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SoundWaveAsset : 
		SoundDataAsset
	{
		[ContainerField(20)]
		public RefArray<SoundWaveVariation> Variations { get; set; } = new RefArray<SoundWaveVariation>(); // 0x14 (20)
		
		[ContainerField(24)]
		public List<SoundWaveLocalizationInfo> Localization { get; set; } = new List<SoundWaveLocalizationInfo>(); // 0x18 (24)
		
		[ContainerField(28)]
		public List<string> SubtitleStringIds { get; set; } = new List<string>(); // 0x1C (28)
		
		[ContainerField(32)]
		public SoundWaveVariationSelection Selection { get; set; } = new SoundWaveVariationSelection(); // 0x20 (32)
		
		[ContainerField(36)]
		public CtrRef<StreamPoolAsset> StreamPool { get; set; } = new CtrRef<StreamPoolAsset>(); // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool Seekable { get; set; } // 0x28 (40)
		
		[ContainerField(41), LayoutImmutable, Blittable]
		public bool PreferAvailableVariations { get; set; } // 0x29 (41)
		
		[ContainerField(42), LayoutImmutable, Blittable]
		public sbyte PersistentVariationCount { get; set; } // 0x2A (42)
		
		[ContainerField(43), LayoutImmutable, Blittable]
		public sbyte ChannelCount { get; set; } // 0x2B (43)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public sbyte VoicePriority { get; set; } // 0x2C (44)
		
		[ContainerField(45), LayoutImmutable, Blittable]
		public sbyte PrimePriority { get; set; } // 0x2D (45)
		
		[ContainerField(46), LayoutImmutable, Blittable]
		public sbyte RequestPriority { get; set; } // 0x2E (46)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2728063271:
					Variations = (RefArray<SoundWaveVariation>) p_Value;
					break;

				case 13208870:
					Localization = (List<SoundWaveLocalizationInfo>) p_Value;
					break;

				case 2609603178:
					SubtitleStringIds = (List<string>) p_Value;
					break;

				case 299217285:
					Selection = (SoundWaveVariationSelection) Enum.ToObject(typeof(SoundWaveVariationSelection), p_Value);
					break;

				case 1617753829:
					StreamPool = (CtrRef<StreamPoolAsset>) p_Value;
					break;

				case 1308586775:
					Seekable = (bool) p_Value;
					break;

				case 4104064296:
					PreferAvailableVariations = (bool) p_Value;
					break;

				case 1921308722:
					PersistentVariationCount = (sbyte) p_Value;
					break;

				case 1014205285:
					ChannelCount = (sbyte) p_Value;
					break;

				case 662714529:
					VoicePriority = (sbyte) p_Value;
					break;

				case 3821472468:
					PrimePriority = (sbyte) p_Value;
					break;

				case 3706845382:
					RequestPriority = (sbyte) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2728063271:
					return Variations;

				case 13208870:
					return Localization;

				case 2609603178:
					return SubtitleStringIds;

				case 299217285:
					return Selection;

				case 1617753829:
					return StreamPool;

				case 1308586775:
					return Seekable;

				case 4104064296:
					return PreferAvailableVariations;

				case 1921308722:
					return PersistentVariationCount;

				case 1014205285:
					return ChannelCount;

				case 662714529:
					return VoicePriority;

				case 3821472468:
					return PrimePriority;

				case 3706845382:
					return RequestPriority;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2728063271:
					return typeof(SoundWaveAsset).GetProperty(nameof(Variations));

				case 13208870:
					return typeof(SoundWaveAsset).GetProperty(nameof(Localization));

				case 2609603178:
					return typeof(SoundWaveAsset).GetProperty(nameof(SubtitleStringIds));

				case 299217285:
					return typeof(SoundWaveAsset).GetProperty(nameof(Selection));

				case 1617753829:
					return typeof(SoundWaveAsset).GetProperty(nameof(StreamPool));

				case 1308586775:
					return typeof(SoundWaveAsset).GetProperty(nameof(Seekable));

				case 4104064296:
					return typeof(SoundWaveAsset).GetProperty(nameof(PreferAvailableVariations));

				case 1921308722:
					return typeof(SoundWaveAsset).GetProperty(nameof(PersistentVariationCount));

				case 1014205285:
					return typeof(SoundWaveAsset).GetProperty(nameof(ChannelCount));

				case 662714529:
					return typeof(SoundWaveAsset).GetProperty(nameof(VoicePriority));

				case 3821472468:
					return typeof(SoundWaveAsset).GetProperty(nameof(PrimePriority));

				case 3706845382:
					return typeof(SoundWaveAsset).GetProperty(nameof(RequestPriority));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
