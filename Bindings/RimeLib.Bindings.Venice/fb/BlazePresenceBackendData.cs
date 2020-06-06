///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class BlazePresenceBackendData : 
		PresenceBackendData
	{
		[ContainerField(16)]
		public RefArray<MatchmakingSession> MatchmakingSessions { get; set; } = new RefArray<MatchmakingSession>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool UseDemanglerService { get; set; } // 0x14 (20)
		
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
