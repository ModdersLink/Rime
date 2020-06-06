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
	public class SoundTestTask : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<SoundTestTaskSpec> Spec { get; set; } = new CtrRef<SoundTestTaskSpec>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<SoundTestTaskParam> Param { get; set; } = new CtrRef<SoundTestTaskParam>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float StartTime { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint Repetitions { get; set; } // 0x14 (20)
		
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
