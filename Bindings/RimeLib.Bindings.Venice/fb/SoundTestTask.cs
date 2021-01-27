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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class SoundTestTask : 
		DataContainer
	{
		protected CtrRef<SoundTestTaskSpec> m_Spec = new CtrRef<SoundTestTaskSpec>();
		[ContainerField(Name: "Spec", Offset: 8, NameHash: 2089404960, Flags: 53)]
		public CtrRef<SoundTestTaskSpec> Spec { get { return m_Spec; } set { if (OnPropertyChanging("SoundTestTask." + nameof(Spec), this, m_Spec, value)) m_Spec = value; } } // 0x8 (8)
		
		protected CtrRef<SoundTestTaskParam> m_Param = new CtrRef<SoundTestTaskParam>();
		[ContainerField(Name: "Param", Offset: 12, NameHash: 232319210, Flags: 53)]
		public CtrRef<SoundTestTaskParam> Param { get { return m_Param; } set { if (OnPropertyChanging("SoundTestTask." + nameof(Param), this, m_Param, value)) m_Param = value; } } // 0xC (12)
		
		protected float m_StartTime = new float();
		[ContainerField(Name: "StartTime", Offset: 16, NameHash: 3727579056, Flags: 49469), LayoutImmutable, Blittable]
		public float StartTime { get { return m_StartTime; } set { if (OnPropertyChanging("SoundTestTask." + nameof(StartTime), this, m_StartTime, value)) m_StartTime = value; } } // 0x10 (16)
		
		protected uint m_Repetitions = new uint();
		[ContainerField(Name: "Repetitions", Offset: 20, NameHash: 1673296181, Flags: 49421), LayoutImmutable, Blittable]
		public uint Repetitions { get { return m_Repetitions; } set { if (OnPropertyChanging("SoundTestTask." + nameof(Repetitions), this, m_Repetitions, value)) m_Repetitions = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089404960:
					Spec = (CtrRef<SoundTestTaskSpec>) p_Value;
					break;

				case 232319210:
					Param = (CtrRef<SoundTestTaskParam>) p_Value;
					break;

				case 3727579056:
					StartTime = (float) p_Value;
					break;

				case 1673296181:
					Repetitions = (uint) p_Value;
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
				case 2089404960:
					return Spec;

				case 232319210:
					return Param;

				case 3727579056:
					return StartTime;

				case 1673296181:
					return Repetitions;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089404960:
					return typeof(SoundTestTask).GetProperty(nameof(Spec));

				case 232319210:
					return typeof(SoundTestTask).GetProperty(nameof(Param));

				case 3727579056:
					return typeof(SoundTestTask).GetProperty(nameof(StartTime));

				case 1673296181:
					return typeof(SoundTestTask).GetProperty(nameof(Repetitions));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
