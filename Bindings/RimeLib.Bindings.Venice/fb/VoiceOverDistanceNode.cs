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
	[ContainerType(4)]
	public class VoiceOverDistanceNode : 
		VoiceOverExpressionNode
	{
		protected CtrRef<VoiceOverValueConnection> m_A = new CtrRef<VoiceOverValueConnection>();
		[ContainerField(8), ContainerFieldNameHash(177636)]
		public CtrRef<VoiceOverValueConnection> A { get { return m_A; } set { if (OnPropertyChanging("VoiceOverDistanceNode." + nameof(A), this, m_A, value)) m_A = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverValueConnection> m_B = new CtrRef<VoiceOverValueConnection>();
		[ContainerField(12), ContainerFieldNameHash(177639)]
		public CtrRef<VoiceOverValueConnection> B { get { return m_B; } set { if (OnPropertyChanging("VoiceOverDistanceNode." + nameof(B), this, m_B, value)) m_B = value; } } // 0xC (12)
		
		protected CtrRef<VoiceOverValueConnection> m_Threshold = new CtrRef<VoiceOverValueConnection>();
		[ContainerField(16), ContainerFieldNameHash(3768602130)]
		public CtrRef<VoiceOverValueConnection> Threshold { get { return m_Threshold; } set { if (OnPropertyChanging("VoiceOverDistanceNode." + nameof(Threshold), this, m_Threshold, value)) m_Threshold = value; } } // 0x10 (16)
		
		protected CtrRef<VoiceOverValue> m_Distance = new CtrRef<VoiceOverValue>();
		[ContainerField(20), ContainerFieldNameHash(408560070)]
		public CtrRef<VoiceOverValue> Distance { get { return m_Distance; } set { if (OnPropertyChanging("VoiceOverDistanceNode." + nameof(Distance), this, m_Distance, value)) m_Distance = value; } } // 0x14 (20)
		
		protected CtrRef<VoiceOverValue> m_False = new CtrRef<VoiceOverValue>();
		[ContainerField(24), ContainerFieldNameHash(206401336)]
		public CtrRef<VoiceOverValue> False { get { return m_False; } set { if (OnPropertyChanging("VoiceOverDistanceNode." + nameof(False), this, m_False, value)) m_False = value; } } // 0x18 (24)
		
		protected CtrRef<VoiceOverValue> m_True = new CtrRef<VoiceOverValue>();
		[ContainerField(28), ContainerFieldNameHash(2089293587)]
		public CtrRef<VoiceOverValue> True { get { return m_True; } set { if (OnPropertyChanging("VoiceOverDistanceNode." + nameof(True), this, m_True, value)) m_True = value; } } // 0x1C (28)
		
		protected VoiceOverCompareExpressionType m_Operation = new VoiceOverCompareExpressionType();
		[ContainerField(32), ContainerFieldNameHash(2346271248)]
		public VoiceOverCompareExpressionType Operation { get { return m_Operation; } set { if (OnPropertyChanging("VoiceOverDistanceNode." + nameof(Operation), this, m_Operation, value)) m_Operation = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 177636:
					A = (CtrRef<VoiceOverValueConnection>) p_Value;
					break;

				case 177639:
					B = (CtrRef<VoiceOverValueConnection>) p_Value;
					break;

				case 3768602130:
					Threshold = (CtrRef<VoiceOverValueConnection>) p_Value;
					break;

				case 408560070:
					Distance = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 206401336:
					False = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 2089293587:
					True = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 2346271248:
					Operation = (VoiceOverCompareExpressionType) Enum.ToObject(typeof(VoiceOverCompareExpressionType), p_Value);
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
				case 177636:
					return A;

				case 177639:
					return B;

				case 3768602130:
					return Threshold;

				case 408560070:
					return Distance;

				case 206401336:
					return False;

				case 2089293587:
					return True;

				case 2346271248:
					return Operation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 177636:
					return typeof(VoiceOverDistanceNode).GetProperty(nameof(A));

				case 177639:
					return typeof(VoiceOverDistanceNode).GetProperty(nameof(B));

				case 3768602130:
					return typeof(VoiceOverDistanceNode).GetProperty(nameof(Threshold));

				case 408560070:
					return typeof(VoiceOverDistanceNode).GetProperty(nameof(Distance));

				case 206401336:
					return typeof(VoiceOverDistanceNode).GetProperty(nameof(False));

				case 2089293587:
					return typeof(VoiceOverDistanceNode).GetProperty(nameof(True));

				case 2346271248:
					return typeof(VoiceOverDistanceNode).GetProperty(nameof(Operation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
