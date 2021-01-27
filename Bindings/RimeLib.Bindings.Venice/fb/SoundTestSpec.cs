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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class SoundTestSpec : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(Name: "Name", Offset: 8, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("SoundTestSpec." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected string m_Description = string.Empty;
		[ContainerField(Name: "Description", Offset: 12, NameHash: 1636673251, Flags: 16509), LayoutImmutable]
		public string Description { get { return m_Description; } set { if (OnPropertyChanging("SoundTestSpec." + nameof(Description), this, m_Description, value)) m_Description = value; } } // 0xC (12)
		
		protected CtrRef<SoundTestTask> m_MainStartTask = new CtrRef<SoundTestTask>();
		[ContainerField(Name: "MainStartTask", Offset: 16, NameHash: 6996003, Flags: 53)]
		public CtrRef<SoundTestTask> MainStartTask { get { return m_MainStartTask; } set { if (OnPropertyChanging("SoundTestSpec." + nameof(MainStartTask), this, m_MainStartTask, value)) m_MainStartTask = value; } } // 0x10 (16)
		
		protected CtrRef<SoundTestTask> m_MainStopTask = new CtrRef<SoundTestTask>();
		[ContainerField(Name: "MainStopTask", Offset: 20, NameHash: 2755082011, Flags: 53)]
		public CtrRef<SoundTestTask> MainStopTask { get { return m_MainStopTask; } set { if (OnPropertyChanging("SoundTestSpec." + nameof(MainStopTask), this, m_MainStopTask, value)) m_MainStopTask = value; } } // 0x14 (20)
		
		protected float m_Duration = new float();
		[ContainerField(Name: "Duration", Offset: 24, NameHash: 1828507227, Flags: 49469), LayoutImmutable, Blittable]
		public float Duration { get { return m_Duration; } set { if (OnPropertyChanging("SoundTestSpec." + nameof(Duration), this, m_Duration, value)) m_Duration = value; } } // 0x18 (24)
		
		protected RefArray<SoundTestTask> m_Tasks = new RefArray<SoundTestTask>();
		[ContainerField(Name: "Tasks", Offset: 28, NameHash: 227574651, Flags: 65)]
		public RefArray<SoundTestTask> Tasks { get { return m_Tasks; } set { if (OnPropertyChanging("SoundTestSpec." + nameof(Tasks), this, m_Tasks, value)) m_Tasks = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 1636673251:
					Description = (string) p_Value;
					break;

				case 6996003:
					MainStartTask = (CtrRef<SoundTestTask>) p_Value;
					break;

				case 2755082011:
					MainStopTask = (CtrRef<SoundTestTask>) p_Value;
					break;

				case 1828507227:
					Duration = (float) p_Value;
					break;

				case 227574651:
					Tasks = (RefArray<SoundTestTask>) p_Value;
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
				case 2088949890:
					return Name;

				case 1636673251:
					return Description;

				case 6996003:
					return MainStartTask;

				case 2755082011:
					return MainStopTask;

				case 1828507227:
					return Duration;

				case 227574651:
					return Tasks;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(SoundTestSpec).GetProperty(nameof(Name));

				case 1636673251:
					return typeof(SoundTestSpec).GetProperty(nameof(Description));

				case 6996003:
					return typeof(SoundTestSpec).GetProperty(nameof(MainStartTask));

				case 2755082011:
					return typeof(SoundTestSpec).GetProperty(nameof(MainStopTask));

				case 1828507227:
					return typeof(SoundTestSpec).GetProperty(nameof(Duration));

				case 227574651:
					return typeof(SoundTestSpec).GetProperty(nameof(Tasks));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
