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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class VoiceOverIntervalNode : 
		VoiceOverExpressionNode
	{
		protected CtrRef<VoiceOverValueConnection> m_Threshold = new CtrRef<VoiceOverValueConnection>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(3768602130), ContainerCtrRef]
		public CtrRef<VoiceOverValueConnection> Threshold { get { return m_Threshold; } set { if (OnPropertyChanging("VoiceOverIntervalNode." + nameof(Threshold), this, m_Threshold, value)) m_Threshold = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverValue> m_Time = new CtrRef<VoiceOverValue>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(2089313744), ContainerCtrRef]
		public CtrRef<VoiceOverValue> Time { get { return m_Time; } set { if (OnPropertyChanging("VoiceOverIntervalNode." + nameof(Time), this, m_Time, value)) m_Time = value; } } // 0xC (12)
		
		protected CtrRef<VoiceOverValue> m_False = new CtrRef<VoiceOverValue>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(206401336), ContainerCtrRef]
		public CtrRef<VoiceOverValue> False { get { return m_False; } set { if (OnPropertyChanging("VoiceOverIntervalNode." + nameof(False), this, m_False, value)) m_False = value; } } // 0x10 (16)
		
		protected CtrRef<VoiceOverValue> m_True = new CtrRef<VoiceOverValue>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(2089293587), ContainerCtrRef]
		public CtrRef<VoiceOverValue> True { get { return m_True; } set { if (OnPropertyChanging("VoiceOverIntervalNode." + nameof(True), this, m_True, value)) m_True = value; } } // 0x14 (20)
		
		protected CtrRef<VoiceOverInterval> m_Interval = new CtrRef<VoiceOverInterval>();
		[ContainerField(24), MemberInfoFlag(53), ContainerFieldNameHash(4280103418), ContainerCtrRef]
		public CtrRef<VoiceOverInterval> Interval { get { return m_Interval; } set { if (OnPropertyChanging("VoiceOverIntervalNode." + nameof(Interval), this, m_Interval, value)) m_Interval = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3768602130:
					Threshold = (CtrRef<VoiceOverValueConnection>) p_Value;
					break;

				case 2089313744:
					Time = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 206401336:
					False = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 2089293587:
					True = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 4280103418:
					Interval = (CtrRef<VoiceOverInterval>) p_Value;
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
				case 3768602130:
					return Threshold;

				case 2089313744:
					return Time;

				case 206401336:
					return False;

				case 2089293587:
					return True;

				case 4280103418:
					return Interval;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3768602130:
					return typeof(VoiceOverIntervalNode).GetProperty(nameof(Threshold));

				case 2089313744:
					return typeof(VoiceOverIntervalNode).GetProperty(nameof(Time));

				case 206401336:
					return typeof(VoiceOverIntervalNode).GetProperty(nameof(False));

				case 2089293587:
					return typeof(VoiceOverIntervalNode).GetProperty(nameof(True));

				case 4280103418:
					return typeof(VoiceOverIntervalNode).GetProperty(nameof(Interval));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
