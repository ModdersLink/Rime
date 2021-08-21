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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class SoundTestAsset : 
		Asset
	{
		protected RefArray<SoundTestTaskSpec> m_TaskSpecs = new RefArray<SoundTestTaskSpec>();
		[ContainerField(Name: "TaskSpecs", Offset: 12, NameHash: 2660376702, Flags: 65)]
		public RefArray<SoundTestTaskSpec> TaskSpecs { get { return m_TaskSpecs; } set { if (OnPropertyChanging("SoundTestAsset." + nameof(TaskSpecs), this, m_TaskSpecs, value)) m_TaskSpecs = value; } } // 0xC (12)
		
		protected RefArray<SoundTestSpec> m_TestSpecs = new RefArray<SoundTestSpec>();
		[ContainerField(Name: "TestSpecs", Offset: 16, NameHash: 1413619717, Flags: 65)]
		public RefArray<SoundTestSpec> TestSpecs { get { return m_TestSpecs; } set { if (OnPropertyChanging("SoundTestAsset." + nameof(TestSpecs), this, m_TestSpecs, value)) m_TestSpecs = value; } } // 0x10 (16)
		
		protected RefArray<SoundTestSuite> m_Suites = new RefArray<SoundTestSuite>();
		[ContainerField(Name: "Suites", Offset: 20, NameHash: 3318968904, Flags: 65)]
		public RefArray<SoundTestSuite> Suites { get { return m_Suites; } set { if (OnPropertyChanging("SoundTestAsset." + nameof(Suites), this, m_Suites, value)) m_Suites = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2660376702:
					TaskSpecs = (RefArray<SoundTestTaskSpec>) p_Value;
					break;

				case 1413619717:
					TestSpecs = (RefArray<SoundTestSpec>) p_Value;
					break;

				case 3318968904:
					Suites = (RefArray<SoundTestSuite>) p_Value;
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
				case 2660376702:
					return TaskSpecs;

				case 1413619717:
					return TestSpecs;

				case 3318968904:
					return Suites;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2660376702:
					return typeof(SoundTestAsset).GetProperty(nameof(TaskSpecs));

				case 1413619717:
					return typeof(SoundTestAsset).GetProperty(nameof(TestSpecs));

				case 3318968904:
					return typeof(SoundTestAsset).GetProperty(nameof(Suites));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
