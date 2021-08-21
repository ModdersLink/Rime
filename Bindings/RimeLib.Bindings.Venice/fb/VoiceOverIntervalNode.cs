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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class VoiceOverIntervalNode : 
		VoiceOverExpressionNode
	{
		protected CtrRef<VoiceOverValueConnection> m_Threshold = new CtrRef<VoiceOverValueConnection>();
		[ContainerField(Name: "Threshold", Offset: 8, NameHash: 3768602130, Flags: 53)]
		public CtrRef<VoiceOverValueConnection> Threshold { get { return m_Threshold; } set { if (OnPropertyChanging("VoiceOverIntervalNode." + nameof(Threshold), this, m_Threshold, value)) m_Threshold = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverValue> m_Time = new CtrRef<VoiceOverValue>();
		[ContainerField(Name: "Time", Offset: 12, NameHash: 2089313744, Flags: 53)]
		public CtrRef<VoiceOverValue> Time { get { return m_Time; } set { if (OnPropertyChanging("VoiceOverIntervalNode." + nameof(Time), this, m_Time, value)) m_Time = value; } } // 0xC (12)
		
		protected CtrRef<VoiceOverValue> m_False = new CtrRef<VoiceOverValue>();
		[ContainerField(Name: "False", Offset: 16, NameHash: 206401336, Flags: 53)]
		public CtrRef<VoiceOverValue> False { get { return m_False; } set { if (OnPropertyChanging("VoiceOverIntervalNode." + nameof(False), this, m_False, value)) m_False = value; } } // 0x10 (16)
		
		protected CtrRef<VoiceOverValue> m_True = new CtrRef<VoiceOverValue>();
		[ContainerField(Name: "True", Offset: 20, NameHash: 2089293587, Flags: 53)]
		public CtrRef<VoiceOverValue> True { get { return m_True; } set { if (OnPropertyChanging("VoiceOverIntervalNode." + nameof(True), this, m_True, value)) m_True = value; } } // 0x14 (20)
		
		protected CtrRef<VoiceOverInterval> m_Interval = new CtrRef<VoiceOverInterval>();
		[ContainerField(Name: "Interval", Offset: 24, NameHash: 4280103418, Flags: 53)]
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
