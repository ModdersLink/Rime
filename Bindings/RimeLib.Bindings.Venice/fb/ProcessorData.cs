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
	public class ProcessorData : 
		EmitterComponentData
	{
		protected Vec4 m_DefaultValues = new Vec4();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(3755111798)]
		public Vec4 DefaultValues { get { return m_DefaultValues; } set { if (OnPropertyChanging("ProcessorData." + nameof(DefaultValues), this, m_DefaultValues, value)) m_DefaultValues = value; } } // 0x10 (16)
		
		protected CtrRef<ProcessorData> m_NextProcessor = new CtrRef<ProcessorData>();
		[ContainerField(32), ContainerFieldNameHash(4017683988)]
		public CtrRef<ProcessorData> NextProcessor { get { return m_NextProcessor; } set { if (OnPropertyChanging("ProcessorData." + nameof(NextProcessor), this, m_NextProcessor, value)) m_NextProcessor = value; } } // 0x20 (32)
		
		protected CtrRef<EmitterComponentData> m_Pre = new CtrRef<EmitterComponentData>();
		[ContainerField(36), ContainerFieldNameHash(193466786)]
		public CtrRef<EmitterComponentData> Pre { get { return m_Pre; } set { if (OnPropertyChanging("ProcessorData." + nameof(Pre), this, m_Pre, value)) m_Pre = value; } } // 0x24 (36)
		
		protected EmittableField m_EvaluatorInput = new EmittableField();
		[ContainerField(40), ContainerFieldNameHash(1132314832)]
		public EmittableField EvaluatorInput { get { return m_EvaluatorInput; } set { if (OnPropertyChanging("ProcessorData." + nameof(EvaluatorInput), this, m_EvaluatorInput, value)) m_EvaluatorInput = value; } } // 0x28 (40)
		
		protected bool m_Enable = new bool();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("ProcessorData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x2C (44)
		
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
