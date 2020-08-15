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
	[ContainerType(4)]
	public class SoundStateSettingsAsset : 
		Asset
	{
		protected RefArray<SoundState> m_SoundStates = new RefArray<SoundState>();
		[ContainerField(12), ContainerFieldNameHash(4087884162)]
		public RefArray<SoundState> SoundStates { get { return m_SoundStates; } set { if (OnPropertyChanging("SoundStateSettingsAsset." + nameof(SoundStates), this, m_SoundStates, value)) m_SoundStates = value; } } // 0xC (12)
		
		protected float m_ImpairedHearingImpulseThreshold = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(3350088792)]
		public float ImpairedHearingImpulseThreshold { get { return m_ImpairedHearingImpulseThreshold; } set { if (OnPropertyChanging("SoundStateSettingsAsset." + nameof(ImpairedHearingImpulseThreshold), this, m_ImpairedHearingImpulseThreshold, value)) m_ImpairedHearingImpulseThreshold = value; } } // 0x10 (16)
		
		protected float m_ScreamThreshold = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(3986899289)]
		public float ScreamThreshold { get { return m_ScreamThreshold; } set { if (OnPropertyChanging("SoundStateSettingsAsset." + nameof(ScreamThreshold), this, m_ScreamThreshold, value)) m_ScreamThreshold = value; } } // 0x14 (20)
		
		protected float m_SupressionThreshold = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(1285763547)]
		public float SupressionThreshold { get { return m_SupressionThreshold; } set { if (OnPropertyChanging("SoundStateSettingsAsset." + nameof(SupressionThreshold), this, m_SupressionThreshold, value)) m_SupressionThreshold = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4087884162:
					SoundStates = (RefArray<SoundState>) p_Value;
					break;

				case 3350088792:
					ImpairedHearingImpulseThreshold = (float) p_Value;
					break;

				case 3986899289:
					ScreamThreshold = (float) p_Value;
					break;

				case 1285763547:
					SupressionThreshold = (float) p_Value;
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
				case 4087884162:
					return SoundStates;

				case 3350088792:
					return ImpairedHearingImpulseThreshold;

				case 3986899289:
					return ScreamThreshold;

				case 1285763547:
					return SupressionThreshold;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4087884162:
					return typeof(SoundStateSettingsAsset).GetProperty(nameof(SoundStates));

				case 3350088792:
					return typeof(SoundStateSettingsAsset).GetProperty(nameof(ImpairedHearingImpulseThreshold));

				case 3986899289:
					return typeof(SoundStateSettingsAsset).GetProperty(nameof(ScreamThreshold));

				case 1285763547:
					return typeof(SoundStateSettingsAsset).GetProperty(nameof(SupressionThreshold));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
