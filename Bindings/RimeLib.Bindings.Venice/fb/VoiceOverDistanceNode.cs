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
	public class VoiceOverDistanceNode : 
		VoiceOverExpressionNode
	{
		[ContainerField(8)]
		public CtrRef<VoiceOverValueConnection> A { get; set; } = new CtrRef<VoiceOverValueConnection>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<VoiceOverValueConnection> B { get; set; } = new CtrRef<VoiceOverValueConnection>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<VoiceOverValueConnection> Threshold { get; set; } = new CtrRef<VoiceOverValueConnection>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<VoiceOverValue> Distance { get; set; } = new CtrRef<VoiceOverValue>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<VoiceOverValue> False { get; set; } = new CtrRef<VoiceOverValue>(); // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<VoiceOverValue> True { get; set; } = new CtrRef<VoiceOverValue>(); // 0x1C (28)
		
		[ContainerField(32)]
		public VoiceOverCompareExpressionType Operation { get; set; } = new VoiceOverCompareExpressionType(); // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 177636:
					A = (CtrRef<VoiceOverValueConnection>) p_Value;
					break;

				case 177639:
					B = (CtrRef<VoiceOverValueConnection>) p_Value;
					break;

				case 3768602130:
					Threshold = (CtrRef<VoiceOverValueConnection>) p_Value;
					break;

				case 408560070:
					Distance = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 206401336:
					False = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 2089293587:
					True = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 2346271248:
					Operation = (VoiceOverCompareExpressionType) Enum.ToObject(typeof(VoiceOverCompareExpressionType), p_Value);
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
				case 177636:
					return A;

				case 177639:
					return B;

				case 3768602130:
					return Threshold;

				case 408560070:
					return Distance;

				case 206401336:
					return False;

				case 2089293587:
					return True;

				case 2346271248:
					return Operation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 177636:
					return typeof(VoiceOverDistanceNode).GetProperty(nameof(A));

				case 177639:
					return typeof(VoiceOverDistanceNode).GetProperty(nameof(B));

				case 3768602130:
					return typeof(VoiceOverDistanceNode).GetProperty(nameof(Threshold));

				case 408560070:
					return typeof(VoiceOverDistanceNode).GetProperty(nameof(Distance));

				case 206401336:
					return typeof(VoiceOverDistanceNode).GetProperty(nameof(False));

				case 2089293587:
					return typeof(VoiceOverDistanceNode).GetProperty(nameof(True));

				case 2346271248:
					return typeof(VoiceOverDistanceNode).GetProperty(nameof(Operation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
