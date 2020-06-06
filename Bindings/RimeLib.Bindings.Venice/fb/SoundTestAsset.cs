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
	public class SoundTestAsset : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<SoundTestTaskSpec> TaskSpecs { get; set; } = new RefArray<SoundTestTaskSpec>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<SoundTestSpec> TestSpecs { get; set; } = new RefArray<SoundTestSpec>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<SoundTestSuite> Suites { get; set; } = new RefArray<SoundTestSuite>(); // 0x14 (20)
		
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
