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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(40), ContainerClass]
	public class MixerGraphData : 
		AudioGraphData
	{
		protected RefArray<AudioGraphParameter> m_Inputs = new RefArray<AudioGraphParameter>();
		[ContainerField(28), MemberInfoFlag(65), ContainerFieldNameHash(2784267136), ContainerRefArray]
		public RefArray<AudioGraphParameter> Inputs { get { return m_Inputs; } set { if (OnPropertyChanging("MixerGraphData." + nameof(Inputs), this, m_Inputs, value)) m_Inputs = value; } } // 0x1C (28)
		
		protected List<MixerValueAccumulateMode> m_AccumulateModes = new List<MixerValueAccumulateMode>();
		[ContainerField(32), MemberInfoFlag(65), ContainerFieldNameHash(918507941), ContainerArray]
		public List<MixerValueAccumulateMode> AccumulateModes { get { return m_AccumulateModes; } set { if (OnPropertyChanging("MixerGraphData." + nameof(AccumulateModes), this, m_AccumulateModes, value)) m_AccumulateModes = value; } } // 0x20 (32)
		
		protected RefArray<AudioGraphParameter> m_Outputs = new RefArray<AudioGraphParameter>();
		[ContainerField(36), MemberInfoFlag(65), ContainerFieldNameHash(1070022089), ContainerRefArray]
		public RefArray<AudioGraphParameter> Outputs { get { return m_Outputs; } set { if (OnPropertyChanging("MixerGraphData." + nameof(Outputs), this, m_Outputs, value)) m_Outputs = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2784267136:
					Inputs = (RefArray<AudioGraphParameter>) p_Value;
					break;

				case 918507941:
					if (p_Value.GetType() == typeof (List<uint>))
						AccumulateModes = ((List<uint>) p_Value).Select(x => (MixerValueAccumulateMode) Enum.ToObject(typeof(MixerValueAccumulateMode), x)).ToList();
					else
						AccumulateModes = (List<MixerValueAccumulateMode>) p_Value;
					break;

				case 1070022089:
					Outputs = (RefArray<AudioGraphParameter>) p_Value;
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
				case 2784267136:
					return Inputs;

				case 918507941:
					return AccumulateModes;

				case 1070022089:
					return Outputs;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2784267136:
					return typeof(MixerGraphData).GetProperty(nameof(Inputs));

				case 918507941:
					return typeof(MixerGraphData).GetProperty(nameof(AccumulateModes));

				case 1070022089:
					return typeof(MixerGraphData).GetProperty(nameof(Outputs));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
