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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class BlazePresenceBackendData : 
		PresenceBackendData
	{
		protected RefArray<MatchmakingSession> m_MatchmakingSessions = new RefArray<MatchmakingSession>();
		[ContainerField(Name: "MatchmakingSessions", Offset: 16, NameHash: 971927356, Flags: 65)]
		public RefArray<MatchmakingSession> MatchmakingSessions { get { return m_MatchmakingSessions; } set { if (OnPropertyChanging("BlazePresenceBackendData." + nameof(MatchmakingSessions), this, m_MatchmakingSessions, value)) m_MatchmakingSessions = value; } } // 0x10 (16)
		
		protected bool m_UseDemanglerService = new bool();
		[ContainerField(Name: "UseDemanglerService", Offset: 20, NameHash: 1785911844, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseDemanglerService { get { return m_UseDemanglerService; } set { if (OnPropertyChanging("BlazePresenceBackendData." + nameof(UseDemanglerService), this, m_UseDemanglerService, value)) m_UseDemanglerService = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 971927356:
					MatchmakingSessions = (RefArray<MatchmakingSession>) p_Value;
					break;

				case 1785911844:
					UseDemanglerService = (bool) p_Value;
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
				case 971927356:
					return MatchmakingSessions;

				case 1785911844:
					return UseDemanglerService;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 971927356:
					return typeof(BlazePresenceBackendData).GetProperty(nameof(MatchmakingSessions));

				case 1785911844:
					return typeof(BlazePresenceBackendData).GetProperty(nameof(UseDemanglerService));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
