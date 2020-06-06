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
	public class VoiceOverIntervalNode : 
		VoiceOverExpressionNode
	{
		[ContainerField(8)]
		public CtrRef<VoiceOverValueConnection> Threshold { get; set; } = new CtrRef<VoiceOverValueConnection>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<VoiceOverValue> Time { get; set; } = new CtrRef<VoiceOverValue>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<VoiceOverValue> False { get; set; } = new CtrRef<VoiceOverValue>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<VoiceOverValue> True { get; set; } = new CtrRef<VoiceOverValue>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<VoiceOverInterval> Interval { get; set; } = new CtrRef<VoiceOverInterval>(); // 0x18 (24)
		
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
