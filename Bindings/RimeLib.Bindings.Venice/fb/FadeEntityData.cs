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
	public class FadeEntityData : 
		EntityData
	{
		protected float m_FadeTime = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4001222838)]
		public float FadeTime { get { return m_FadeTime; } set { if (OnPropertyChanging("FadeEntityData." + nameof(FadeTime), this, m_FadeTime, value)) m_FadeTime = value; } } // 0xC (12)
		
		protected float m_MaxWaitFadedWhileStreamingTime = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3945633230)]
		public float MaxWaitFadedWhileStreamingTime { get { return m_MaxWaitFadedWhileStreamingTime; } set { if (OnPropertyChanging("FadeEntityData." + nameof(MaxWaitFadedWhileStreamingTime), this, m_MaxWaitFadedWhileStreamingTime, value)) m_MaxWaitFadedWhileStreamingTime = value; } } // 0x10 (16)
		
		protected bool m_FadeScreen = new bool();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1880126671)]
		public bool FadeScreen { get { return m_FadeScreen; } set { if (OnPropertyChanging("FadeEntityData." + nameof(FadeScreen), this, m_FadeScreen, value)) m_FadeScreen = value; } } // 0x14 (20)
		
		protected bool m_FadeUI = new bool();
		[ContainerField(21), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2515973727)]
		public bool FadeUI { get { return m_FadeUI; } set { if (OnPropertyChanging("FadeEntityData." + nameof(FadeUI), this, m_FadeUI, value)) m_FadeUI = value; } } // 0x15 (21)
		
		protected bool m_FadeRumble = new bool();
		[ContainerField(22), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1825215970)]
		public bool FadeRumble { get { return m_FadeRumble; } set { if (OnPropertyChanging("FadeEntityData." + nameof(FadeRumble), this, m_FadeRumble, value)) m_FadeRumble = value; } } // 0x16 (22)
		
		protected bool m_FadeAudio = new bool();
		[ContainerField(23), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3169106133)]
		public bool FadeAudio { get { return m_FadeAudio; } set { if (OnPropertyChanging("FadeEntityData." + nameof(FadeAudio), this, m_FadeAudio, value)) m_FadeAudio = value; } } // 0x17 (23)
		
		protected bool m_FadeMovie = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3182278683)]
		public bool FadeMovie { get { return m_FadeMovie; } set { if (OnPropertyChanging("FadeEntityData." + nameof(FadeMovie), this, m_FadeMovie, value)) m_FadeMovie = value; } } // 0x18 (24)
		
		protected bool m_StartFaded = new bool();
		[ContainerField(25), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2729539719)]
		public bool StartFaded { get { return m_StartFaded; } set { if (OnPropertyChanging("FadeEntityData." + nameof(StartFaded), this, m_StartFaded, value)) m_StartFaded = value; } } // 0x19 (25)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4001222838:
					FadeTime = (float) p_Value;
					break;

				case 3945633230:
					MaxWaitFadedWhileStreamingTime = (float) p_Value;
					break;

				case 1880126671:
					FadeScreen = (bool) p_Value;
					break;

				case 2515973727:
					FadeUI = (bool) p_Value;
					break;

				case 1825215970:
					FadeRumble = (bool) p_Value;
					break;

				case 3169106133:
					FadeAudio = (bool) p_Value;
					break;

				case 3182278683:
					FadeMovie = (bool) p_Value;
					break;

				case 2729539719:
					StartFaded = (bool) p_Value;
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
				case 4001222838:
					return FadeTime;

				case 3945633230:
					return MaxWaitFadedWhileStreamingTime;

				case 1880126671:
					return FadeScreen;

				case 2515973727:
					return FadeUI;

				case 1825215970:
					return FadeRumble;

				case 3169106133:
					return FadeAudio;

				case 3182278683:
					return FadeMovie;

				case 2729539719:
					return StartFaded;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4001222838:
					return typeof(FadeEntityData).GetProperty(nameof(FadeTime));

				case 3945633230:
					return typeof(FadeEntityData).GetProperty(nameof(MaxWaitFadedWhileStreamingTime));

				case 1880126671:
					return typeof(FadeEntityData).GetProperty(nameof(FadeScreen));

				case 2515973727:
					return typeof(FadeEntityData).GetProperty(nameof(FadeUI));

				case 1825215970:
					return typeof(FadeEntityData).GetProperty(nameof(FadeRumble));

				case 3169106133:
					return typeof(FadeEntityData).GetProperty(nameof(FadeAudio));

				case 3182278683:
					return typeof(FadeEntityData).GetProperty(nameof(FadeMovie));

				case 2729539719:
					return typeof(FadeEntityData).GetProperty(nameof(StartFaded));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
