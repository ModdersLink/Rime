///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SoundTestSpec : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable]
		public string Description { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<SoundTestTask> MainStartTask { get; set; } = new CtrRef<SoundTestTask>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<SoundTestTask> MainStopTask { get; set; } = new CtrRef<SoundTestTask>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Duration { get; set; } // 0x18 (24)
		
		[ContainerField(28)]
		public RefArray<SoundTestTask> Tasks { get; set; } = new RefArray<SoundTestTask>(); // 0x1C (28)
		
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
