///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class ProcessorData : 
		EmitterComponentData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 DefaultValues { get; set; } = new Vec4(); // 0x10 (16)
		
		[ContainerField(32)]
		public CtrRef<ProcessorData> NextProcessor { get; set; } = new CtrRef<ProcessorData>(); // 0x20 (32)
		
		[ContainerField(36)]
		public CtrRef<EmitterComponentData> Pre { get; set; } = new CtrRef<EmitterComponentData>(); // 0x24 (36)
		
		[ContainerField(40)]
		public EmittableField EvaluatorInput { get; set; } = new EmittableField(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3755111798:
					DefaultValues = (Vec4) p_Value;
					break;

				case 4017683988:
					NextProcessor = (CtrRef<ProcessorData>) p_Value;
					break;

				case 193466786:
					Pre = (CtrRef<EmitterComponentData>) p_Value;
					break;

				case 1132314832:
					EvaluatorInput = (EmittableField) Enum.ToObject(typeof(EmittableField), p_Value);
					break;

				case 2342790116:
					Enable = (bool) p_Value;
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
				case 3755111798:
					return DefaultValues;

				case 4017683988:
					return NextProcessor;

				case 193466786:
					return Pre;

				case 1132314832:
					return EvaluatorInput;

				case 2342790116:
					return Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3755111798:
					return typeof(ProcessorData).GetProperty(nameof(DefaultValues));

				case 4017683988:
					return typeof(ProcessorData).GetProperty(nameof(NextProcessor));

				case 193466786:
					return typeof(ProcessorData).GetProperty(nameof(Pre));

				case 1132314832:
					return typeof(ProcessorData).GetProperty(nameof(EvaluatorInput));

				case 2342790116:
					return typeof(ProcessorData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
