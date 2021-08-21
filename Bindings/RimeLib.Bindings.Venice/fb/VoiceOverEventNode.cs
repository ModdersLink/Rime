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
	public class VoiceOverEventNode : 
		VoiceOverStructureNode
	{
		protected CtrRef<VoiceOverIntervalNode> m_Interval = new CtrRef<VoiceOverIntervalNode>();
		[ContainerField(Name: "Interval", Offset: 12, NameHash: 4280103418, Flags: 53)]
		public CtrRef<VoiceOverIntervalNode> Interval { get { return m_Interval; } set { if (OnPropertyChanging("VoiceOverEventNode." + nameof(Interval), this, m_Interval, value)) m_Interval = value; } } // 0xC (12)
		
		protected RefArray<VoiceOverStructureNode> m_Relationship = new RefArray<VoiceOverStructureNode>();
		[ContainerField(Name: "Relationship", Offset: 16, NameHash: 1551797377, Flags: 65)]
		public RefArray<VoiceOverStructureNode> Relationship { get { return m_Relationship; } set { if (OnPropertyChanging("VoiceOverEventNode." + nameof(Relationship), this, m_Relationship, value)) m_Relationship = value; } } // 0x10 (16)
		
		protected RefArray<VoiceOverValueRedirect> m_Redirects = new RefArray<VoiceOverValueRedirect>();
		[ContainerField(Name: "Redirects", Offset: 20, NameHash: 1117013132, Flags: 65)]
		public RefArray<VoiceOverValueRedirect> Redirects { get { return m_Redirects; } set { if (OnPropertyChanging("VoiceOverEventNode." + nameof(Redirects), this, m_Redirects, value)) m_Redirects = value; } } // 0x14 (20)
		
		protected CtrRef<VoiceOverEvent> m_Event = new CtrRef<VoiceOverEvent>();
		[ContainerField(Name: "Event", Offset: 24, NameHash: 201427689, Flags: 53)]
		public CtrRef<VoiceOverEvent> Event { get { return m_Event; } set { if (OnPropertyChanging("VoiceOverEventNode." + nameof(Event), this, m_Event, value)) m_Event = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4280103418:
					Interval = (CtrRef<VoiceOverIntervalNode>) p_Value;
					break;

				case 1551797377:
					Relationship = (RefArray<VoiceOverStructureNode>) p_Value;
					break;

				case 1117013132:
					Redirects = (RefArray<VoiceOverValueRedirect>) p_Value;
					break;

				case 201427689:
					Event = (CtrRef<VoiceOverEvent>) p_Value;
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
				case 4280103418:
					return Interval;

				case 1551797377:
					return Relationship;

				case 1117013132:
					return Redirects;

				case 201427689:
					return Event;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4280103418:
					return typeof(VoiceOverEventNode).GetProperty(nameof(Interval));

				case 1551797377:
					return typeof(VoiceOverEventNode).GetProperty(nameof(Relationship));

				case 1117013132:
					return typeof(VoiceOverEventNode).GetProperty(nameof(Redirects));

				case 201427689:
					return typeof(VoiceOverEventNode).GetProperty(nameof(Event));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
