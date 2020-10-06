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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(20), ContainerClass]
	public class VoiceOverProbabilityNode : 
		VoiceOverExpressionNode
	{
		protected CtrRef<VoiceOverValue> m_False = new CtrRef<VoiceOverValue>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(206401336), ContainerCtrRef]
		public CtrRef<VoiceOverValue> False { get { return m_False; } set { if (OnPropertyChanging("VoiceOverProbabilityNode." + nameof(False), this, m_False, value)) m_False = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverValue> m_True = new CtrRef<VoiceOverValue>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(2089293587), ContainerCtrRef]
		public CtrRef<VoiceOverValue> True { get { return m_True; } set { if (OnPropertyChanging("VoiceOverProbabilityNode." + nameof(True), this, m_True, value)) m_True = value; } } // 0xC (12)
		
		protected float m_Probability = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(35957416)]
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
