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
	public class AdsrNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_Trigger = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(2606354109)]
		public AudioGraphNodePort Trigger { get { return m_Trigger; } set { if (OnPropertyChanging("AdsrNodeData." + nameof(Trigger), this, m_Trigger, value)) m_Trigger = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Release = new AudioGraphNodePort();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(1335266828)]
		public AudioGraphNodePort Release { get { return m_Release; } set { if (OnPropertyChanging("AdsrNodeData." + nameof(Release), this, m_Release, value)) m_Release = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_A = new AudioGraphNodePort();
		[ContainerField(24), MemberInfoFlag(41), ContainerFieldNameHash(177636)]
		public AudioGraphNodePort A { get { return m_A; } set { if (OnPropertyChanging("AdsrNodeData." + nameof(A), this, m_A, value)) m_A = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_D = new AudioGraphNodePort();
		[ContainerField(32), MemberInfoFlag(41), ContainerFieldNameHash(177633)]
		public AudioGraphNodePort D { get { return m_D; } set { if (OnPropertyChanging("AdsrNodeData." + nameof(D), this, m_D, value)) m_D = value; } } // 0x20 (32)
		
		protected AudioGraphNodePort m_S = new AudioGraphNodePort();
		[ContainerField(40), MemberInfoFlag(41), ContainerFieldNameHash(177654)]
		public AudioGraphNodePort S { get { return m_S; } set { if (OnPropertyChanging("AdsrNodeData." + nameof(S), this, m_S, value)) m_S = value; } } // 0x28 (40)
		
		protected AudioGraphNodePort m_R = new AudioGraphNodePort();
		[ContainerField(48), MemberInfoFlag(41), ContainerFieldNameHash(177655)]
		public AudioGraphNodePort R { get { return m_R; } set { if (OnPropertyChanging("AdsrNodeData." + nameof(R), this, m_R, value)) m_R = value; } } // 0x30 (48)
		
		protected AudioGraphNodePort m_Value = new AudioGraphNodePort();
		[ContainerField(56), MemberInfoFlag(41), ContainerFieldNameHash(225375086)]
		public AudioGraphNodePort Value { get { return m_Value; } set { if (OnPropertyChanging("AdsrNodeData." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0x38 (56)
		
		protected AudioGraphNodePort m_Finished = new AudioGraphNodePort();
		[ContainerField(64), MemberInfoFlag(41), ContainerFieldNameHash(1223765815)]
		public AudioGraphNodePort Finished { get { return m_Finished; } set { if (OnPropertyChanging("AdsrNodeData." + nameof(Finished), this, m_Finished, value)) m_Finished = value; } } // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2606354109:
					Trigger = (AudioGraphNodePort) p_Value;
					break;

				case 1335266828:
					Release = (AudioGraphNodePort) p_Value;
					break;

				case 177636:
					A = (AudioGraphNodePort) p_Value;
					break;

				case 177633:
					D = (AudioGraphNodePort) p_Value;
					break;

				case 177654:
					S = (AudioGraphNodePort) p_Value;
					break;

				case 177655:
					R = (AudioGraphNodePort) p_Value;
					break;

				case 225375086:
					Value = (AudioGraphNodePort) p_Value;
					break;

				case 1223765815:
					Finished = (AudioGraphNodePort) p_Value;
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
				case 2606354109:
					return Trigger;

				case 1335266828:
					return Release;

				case 177636:
					return A;

				case 177633:
					return D;

				case 177654:
					return S;

				case 177655:
					return R;

				case 225375086:
					return Value;

				case 1223765815:
					return Finished;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2606354109:
					return typeof(AdsrNodeData).GetProperty(nameof(Trigger));

				case 1335266828:
					return typeof(AdsrNodeData).GetProperty(nameof(Release));

				case 177636:
					return typeof(AdsrNodeData).GetProperty(nameof(A));

				case 177633:
					return typeof(AdsrNodeData).GetProperty(nameof(D));

				case 177654:
					return typeof(AdsrNodeData).GetProperty(nameof(S));

				case 177655:
					return typeof(AdsrNodeData).GetProperty(nameof(R));

				case 225375086:
					return typeof(AdsrNodeData).GetProperty(nameof(Value));

				case 1223765815:
					return typeof(AdsrNodeData).GetProperty(nameof(Finished));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
