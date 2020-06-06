///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VoiceOverLabelNode : 
		VoiceOverExpressionNode
	{
		[ContainerField(8)]
		public RefArray<VoiceOverLabelSource> Sources { get; set; } = new RefArray<VoiceOverLabelSource>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<VoiceOverValue> False { get; set; } = new CtrRef<VoiceOverValue>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<VoiceOverValue> True { get; set; } = new CtrRef<VoiceOverValue>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<VoiceOverLabel> WantedLabels { get; set; } = new RefArray<VoiceOverLabel>(); // 0x14 (20)
		
		[ContainerField(24)]
		public RefArray<VoiceOverLabel> UnwantedLabels { get; set; } = new RefArray<VoiceOverLabel>(); // 0x18 (24)
		
		[ContainerField(28)]
		public VoiceOverLabelSourceMode SourceMode { get; set; } = new VoiceOverLabelSourceMode(); // 0x1C (28)
		
		[ContainerField(32)]
		public VoiceOverLabelCompareMode WantedCompareMode { get; set; } = new VoiceOverLabelCompareMode(); // 0x20 (32)
		
		[ContainerField(36)]
		public VoiceOverLabelCompareMode UnwantedCompareMode { get; set; } = new VoiceOverLabelCompareMode(); // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2837180395:
					Sources = (RefArray<VoiceOverLabelSource>) p_Value;
					break;

				case 206401336:
					False = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 2089293587:
					True = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 591591005:
					WantedLabels = (RefArray<VoiceOverLabel>) p_Value;
					break;

				case 2244868070:
					UnwantedLabels = (RefArray<VoiceOverLabel>) p_Value;
					break;

				case 1522324635:
					SourceMode = (VoiceOverLabelSourceMode) Enum.ToObject(typeof(VoiceOverLabelSourceMode), p_Value);
					break;

				case 1232611212:
					WantedCompareMode = (VoiceOverLabelCompareMode) Enum.ToObject(typeof(VoiceOverLabelCompareMode), p_Value);
					break;

				case 133443287:
					UnwantedCompareMode = (VoiceOverLabelCompareMode) Enum.ToObject(typeof(VoiceOverLabelCompareMode), p_Value);
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
				case 2837180395:
					return Sources;

				case 206401336:
					return False;

				case 2089293587:
					return True;

				case 591591005:
					return WantedLabels;

				case 2244868070:
					return UnwantedLabels;

				case 1522324635:
					return SourceMode;

				case 1232611212:
					return WantedCompareMode;

				case 133443287:
					return UnwantedCompareMode;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2837180395:
					return typeof(VoiceOverLabelNode).GetProperty(nameof(Sources));

				case 206401336:
					return typeof(VoiceOverLabelNode).GetProperty(nameof(False));

				case 2089293587:
					return typeof(VoiceOverLabelNode).GetProperty(nameof(True));

				case 591591005:
					return typeof(VoiceOverLabelNode).GetProperty(nameof(WantedLabels));

				case 2244868070:
					return typeof(VoiceOverLabelNode).GetProperty(nameof(UnwantedLabels));

				case 1522324635:
					return typeof(VoiceOverLabelNode).GetProperty(nameof(SourceMode));

				case 1232611212:
					return typeof(VoiceOverLabelNode).GetProperty(nameof(WantedCompareMode));

				case 133443287:
					return typeof(VoiceOverLabelNode).GetProperty(nameof(UnwantedCompareMode));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
