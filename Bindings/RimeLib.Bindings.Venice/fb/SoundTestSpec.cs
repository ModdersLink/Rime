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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(32), ContainerClass]
	public class SoundTestSpec : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("SoundTestSpec." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected string m_Description = string.Empty;
		[ContainerField(12), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1636673251)]
		public string Description { get { return m_Description; } set { if (OnPropertyChanging("SoundTestSpec." + nameof(Description), this, m_Description, value)) m_Description = value; } } // 0xC (12)
		
		protected CtrRef<SoundTestTask> m_MainStartTask = new CtrRef<SoundTestTask>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(6996003), ContainerCtrRef]
		public CtrRef<SoundTestTask> MainStartTask { get { return m_MainStartTask; } set { if (OnPropertyChanging("SoundTestSpec." + nameof(MainStartTask), this, m_MainStartTask, value)) m_MainStartTask = value; } } // 0x10 (16)
		
		protected CtrRef<SoundTestTask> m_MainStopTask = new CtrRef<SoundTestTask>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(2755082011), ContainerCtrRef]
		public CtrRef<SoundTestTask> MainStopTask { get { return m_MainStopTask; } set { if (OnPropertyChanging("SoundTestSpec." + nameof(MainStopTask), this, m_MainStopTask, value)) m_MainStopTask = value; } } // 0x14 (20)
		
		protected float m_Duration = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1828507227)]
		public float Duration { get { return m_Duration; } set { if (OnPropertyChanging("SoundTestSpec." + nameof(Duration), this, m_Duration, value)) m_Duration = value; } } // 0x18 (24)
		
		protected RefArray<SoundTestTask> m_Tasks = new RefArray<SoundTestTask>();
		[ContainerField(28), MemberInfoFlag(65), ContainerFieldNameHash(227574651), ContainerRefArray]
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
