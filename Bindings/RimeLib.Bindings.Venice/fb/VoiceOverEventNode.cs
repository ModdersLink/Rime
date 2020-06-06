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
	public class VoiceOverEventNode : 
		VoiceOverStructureNode
	{
		[ContainerField(12)]
		public CtrRef<VoiceOverIntervalNode> Interval { get; set; } = new CtrRef<VoiceOverIntervalNode>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<VoiceOverStructureNode> Relationship { get; set; } = new RefArray<VoiceOverStructureNode>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<VoiceOverValueRedirect> Redirects { get; set; } = new RefArray<VoiceOverValueRedirect>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<VoiceOverEvent> Event { get; set; } = new CtrRef<VoiceOverEvent>(); // 0x18 (24)
		
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
