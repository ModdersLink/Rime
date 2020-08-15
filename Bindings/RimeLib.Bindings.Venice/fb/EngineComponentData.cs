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
	[ContainerType(16)]
	public class EngineComponentData : 
		ComponentData
	{
		protected CtrRef<EngineConfigData> m_Config = new CtrRef<EngineConfigData>();
		[ContainerField(96), ContainerFieldNameHash(2713732399)]
		public CtrRef<EngineConfigData> Config { get { return m_Config; } set { if (OnPropertyChanging("EngineComponentData." + nameof(Config), this, m_Config, value)) m_Config = value; } } // 0x60 (96)
		
		protected CtrRef<SoundAsset> m_SoundEffect = new CtrRef<SoundAsset>();
		[ContainerField(100), ContainerFieldNameHash(3556609201)]
		public CtrRef<SoundAsset> SoundEffect { get { return m_SoundEffect; } set { if (OnPropertyChanging("EngineComponentData." + nameof(SoundEffect), this, m_SoundEffect, value)) m_SoundEffect = value; } } // 0x64 (100)
		
		protected CtrRef<SoundAsset> m_SurfaceSoundEffect = new CtrRef<SoundAsset>();
		[ContainerField(104), ContainerFieldNameHash(3348100644)]
		public CtrRef<SoundAsset> SurfaceSoundEffect { get { return m_SurfaceSoundEffect; } set { if (OnPropertyChanging("EngineComponentData." + nameof(SurfaceSoundEffect), this, m_SurfaceSoundEffect, value)) m_SurfaceSoundEffect = value; } } // 0x68 (104)
		
		protected bool m_UseFirstPersonSounds = new bool();
		[ContainerField(108), LayoutImmutable, Blittable, ContainerFieldNameHash(2865323833)]
		public bool UseFirstPersonSounds { get { return m_UseFirstPersonSounds; } set { if (OnPropertyChanging("EngineComponentData." + nameof(UseFirstPersonSounds), this, m_UseFirstPersonSounds, value)) m_UseFirstPersonSounds = value; } } // 0x6C (108)
		
		protected bool m_OutputIsEngineInWater = new bool();
		[ContainerField(109), LayoutImmutable, Blittable, ContainerFieldNameHash(844188796)]
		public bool OutputIsEngineInWater { get { return m_OutputIsEngineInWater; } set { if (OnPropertyChanging("EngineComponentData." + nameof(OutputIsEngineInWater), this, m_OutputIsEngineInWater, value)) m_OutputIsEngineInWater = value; } } // 0x6D (109)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2713732399:
					Config = (CtrRef<EngineConfigData>) p_Value;
					break;

				case 3556609201:
					SoundEffect = (CtrRef<SoundAsset>) p_Value;
					break;

				case 3348100644:
					SurfaceSoundEffect = (CtrRef<SoundAsset>) p_Value;
					break;

				case 2865323833:
					UseFirstPersonSounds = (bool) p_Value;
					break;

				case 844188796:
					OutputIsEngineInWater = (bool) p_Value;
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
				case 2713732399:
					return Config;

				case 3556609201:
					return SoundEffect;

				case 3348100644:
					return SurfaceSoundEffect;

				case 2865323833:
					return UseFirstPersonSounds;

				case 844188796:
					return OutputIsEngineInWater;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2713732399:
					return typeof(EngineComponentData).GetProperty(nameof(Config));

				case 3556609201:
					return typeof(EngineComponentData).GetProperty(nameof(SoundEffect));

				case 3348100644:
					return typeof(EngineComponentData).GetProperty(nameof(SurfaceSoundEffect));

				case 2865323833:
					return typeof(EngineComponentData).GetProperty(nameof(UseFirstPersonSounds));

				case 844188796:
					return typeof(EngineComponentData).GetProperty(nameof(OutputIsEngineInWater));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
