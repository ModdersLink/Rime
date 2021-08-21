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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class VoiceOverProbabilityNode : 
		VoiceOverExpressionNode
	{
		protected CtrRef<VoiceOverValue> m_False = new CtrRef<VoiceOverValue>();
		[ContainerField(Name: "False", Offset: 8, NameHash: 206401336, Flags: 53)]
		public CtrRef<VoiceOverValue> False { get { return m_False; } set { if (OnPropertyChanging("VoiceOverProbabilityNode." + nameof(False), this, m_False, value)) m_False = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverValue> m_True = new CtrRef<VoiceOverValue>();
		[ContainerField(Name: "True", Offset: 12, NameHash: 2089293587, Flags: 53)]
		public CtrRef<VoiceOverValue> True { get { return m_True; } set { if (OnPropertyChanging("VoiceOverProbabilityNode." + nameof(True), this, m_True, value)) m_True = value; } } // 0xC (12)
		
		protected float m_Probability = new float();
		[ContainerField(Name: "Probability", Offset: 16, NameHash: 35957416, Flags: 49469), LayoutImmutable, Blittable]
		public float Probability { get { return m_Probability; } set { if (OnPropertyChanging("VoiceOverProbabilityNode." + nameof(Probability), this, m_Probability, value)) m_Probability = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 206401336:
					False = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 2089293587:
					True = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 35957416:
					Probability = (float) p_Value;
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
				case 206401336:
					return False;

				case 2089293587:
					return True;

				case 35957416:
					return Probability;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 206401336:
					return typeof(VoiceOverProbabilityNode).GetProperty(nameof(False));

				case 2089293587:
					return typeof(VoiceOverProbabilityNode).GetProperty(nameof(True));

				case 35957416:
					return typeof(VoiceOverProbabilityNode).GetProperty(nameof(Probability));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
