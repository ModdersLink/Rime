///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class SoundWaveAsset : 
		SoundDataAsset
	{
		protected RefArray<SoundWaveVariation> m_Variations = new RefArray<SoundWaveVariation>();
		[ContainerField(20), MemberInfoFlag(65), ContainerFieldNameHash(2728063271), ContainerRefArray]
		public RefArray<SoundWaveVariation> Variations { get { return m_Variations; } set { if (OnPropertyChanging("SoundWaveAsset." + nameof(Variations), this, m_Variations, value)) m_Variations = value; } } // 0x14 (20)
		
		protected List<SoundWaveLocalizationInfo> m_Localization = new List<SoundWaveLocalizationInfo>();
		[ContainerField(24), MemberInfoFlag(65), ContainerFieldNameHash(13208870), ContainerArray]
		public List<SoundWaveLocalizationInfo> Localization { get { return m_Localization; } set { if (OnPropertyChanging("SoundWaveAsset." + nameof(Localization), this, m_Localization, value)) m_Localization = value; } } // 0x18 (24)
		
		protected List<string> m_SubtitleStringIds = new List<string>();
		[ContainerField(28), MemberInfoFlag(65), ContainerFieldNameHash(2609603178), ContainerArray]
		public List<string> SubtitleStringIds { get { return m_SubtitleStringIds; } set { if (OnPropertyChanging("SoundWaveAsset." + nameof(SubtitleStringIds), this, m_SubtitleStringIds, value)) m_SubtitleStringIds = value; } } // 0x1C (28)
		
		protected SoundWaveVariationSelection m_Selection = new SoundWaveVariationSelection();
		[ContainerField(32), MemberInfoFlag(137), ContainerFieldNameHash(299217285)]
		public SoundWaveVariationSelection Selection { get { return m_Selection; } set { if (OnPropertyChanging("SoundWaveAsset." + nameof(Selection), this, m_Selection, value)) m_Selection = value; } } // 0x20 (32)
		
		protected CtrRef<StreamPoolAsset> m_StreamPool = new CtrRef<StreamPoolAsset>();
		[ContainerField(36), MemberInfoFlag(53), ContainerFieldNameHash(1617753829), ContainerCtrRef]
		public CtrRef<StreamPoolAsset> StreamPool { get { return m_StreamPool; } set { if (OnPropertyChanging("SoundWaveAsset." + nameof(StreamPool), this, m_StreamPool, value)) m_StreamPool = value; } } // 0x24 (36)
		
		protected bool m_Seekable = new bool();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1308586775)]
		public bool Seekable { get { return m_Seekable; } set { if (OnPropertyChanging("SoundWaveAsset." + nameof(Seekable), this, m_Seekable, value)) m_Seekable = value; } } // 0x28 (40)
		
		protected bool m_PreferAvailableVariations = new bool();
		[ContainerField(41), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4104064296)]
		public bool PreferAvailableVariations { get { return m_PreferAvailableVariations; } set { if (OnPropertyChanging("SoundWaveAsset." + nameof(PreferAvailableVariations), this, m_PreferAvailableVariations, value)) m_PreferAvailableVariations = value; } } // 0x29 (41)
		
		protected sbyte m_PersistentVariationCount = new sbyte();
		[ContainerField(42), LayoutImmutable, Blittable, MemberInfoFlag(49341), ContainerFieldNameHash(1921308722)]
		public sbyte PersistentVariationCount { get { return m_PersistentVariationCount; } set { if (OnPropertyChanging("SoundWaveAsset." + nameof(PersistentVariationCount), this, m_PersistentVariationCount, value)) m_PersistentVariationCount = value; } } // 0x2A (42)
		
		protected sbyte m_ChannelCount = new sbyte();
		[ContainerField(43), LayoutImmutable, Blittable, MemberInfoFlag(49341), ContainerFieldNameHash(1014205285)]
		public sbyte ChannelCount { get { return m_ChannelCount; } set { if (OnPropertyChanging("SoundWaveAsset." + nameof(ChannelCount), this, m_ChannelCount, value)) m_ChannelCount = value; } } // 0x2B (43)
		
		protected sbyte m_VoicePriority = new sbyte();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49341), ContainerFieldNameHash(662714529)]
		public sbyte VoicePriority { get { return m_VoicePriority; } set { if (OnPropertyChanging("SoundWaveAsset." + nameof(VoicePriority), this, m_VoicePriority, value)) m_VoicePriority = value; } } // 0x2C (44)
		
		protected sbyte m_PrimePriority = new sbyte();
		[ContainerField(45), LayoutImmutable, Blittable, MemberInfoFlag(49341), ContainerFieldNameHash(3821472468)]
		public sbyte PrimePriority { get { return m_PrimePriority; } set { if (OnPropertyChanging("SoundWaveAsset." + nameof(PrimePriority), this, m_PrimePriority, value)) m_PrimePriority = value; } } // 0x2D (45)
		
		protected sbyte m_RequestPriority = new sbyte();
		[ContainerField(46), LayoutImmutable, Blittable, MemberInfoFlag(49341), ContainerFieldNameHash(3706845382)]
		public sbyte RequestPriority { get { return m_RequestPriority; } set { if (OnPropertyChanging("SoundWaveAsset." + nameof(RequestPriority), this, m_RequestPriority, value)) m_RequestPriority = value; } } // 0x2E (46)
		
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
