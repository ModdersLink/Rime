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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(28), ContainerClass]
	public class VoiceOverLogicAsset : 
		Asset
	{
		protected RefArray<VoiceOverEvent> m_Events = new RefArray<VoiceOverEvent>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(2352146554), ContainerRefArray]
		public RefArray<VoiceOverEvent> Events { get { return m_Events; } set { if (OnPropertyChanging("VoiceOverLogicAsset." + nameof(Events), this, m_Events, value)) m_Events = value; } } // 0xC (12)
		
		protected RefArray<VoiceOverGroup> m_Groups = new RefArray<VoiceOverGroup>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(2573340009), ContainerRefArray]
		public RefArray<VoiceOverGroup> Groups { get { return m_Groups; } set { if (OnPropertyChanging("VoiceOverLogicAsset." + nameof(Groups), this, m_Groups, value)) m_Groups = value; } } // 0x10 (16)
		
		protected RefArray<VoiceOverLogicFlow> m_Flows = new RefArray<VoiceOverLogicFlow>();
		[ContainerField(20), MemberInfoFlag(65), ContainerFieldNameHash(207046276), ContainerRefArray]
		public RefArray<VoiceOverLogicFlow> Flows { get { return m_Flows; } set { if (OnPropertyChanging("VoiceOverLogicAsset." + nameof(Flows), this, m_Flows, value)) m_Flows = value; } } // 0x14 (20)
		
		protected CtrRef<VoiceOverSystemAsset> m_System = new CtrRef<VoiceOverSystemAsset>();
		[ContainerField(24), MemberInfoFlag(53), ContainerFieldNameHash(3333232768), ContainerCtrRef]
		public CtrRef<VoiceOverSystemAsset> System { get { return m_System; } set { if (OnPropertyChanging("VoiceOverLogicAsset." + nameof(System), this, m_System, value)) m_System = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2352146554:
					Events = (RefArray<VoiceOverEvent>) p_Value;
					break;

				case 2573340009:
					Groups = (RefArray<VoiceOverGroup>) p_Value;
					break;

				case 207046276:
					Flows = (RefArray<VoiceOverLogicFlow>) p_Value;
					break;

				case 3333232768:
					System = (CtrRef<VoiceOverSystemAsset>) p_Value;
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
				case 2352146554:
					return Events;

				case 2573340009:
					return Groups;

				case 207046276:
					return Flows;

				case 3333232768:
					return System;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2352146554:
					return typeof(VoiceOverLogicAsset).GetProperty(nameof(Events));

				case 2573340009:
					return typeof(VoiceOverLogicAsset).GetProperty(nameof(Groups));

				case 207046276:
					return typeof(VoiceOverLogicAsset).GetProperty(nameof(Flows));

				case 3333232768:
					return typeof(VoiceOverLogicAsset).GetProperty(nameof(System));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
