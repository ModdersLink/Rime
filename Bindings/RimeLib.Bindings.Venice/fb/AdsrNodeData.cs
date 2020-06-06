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
	public class AdsrNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Trigger { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Release { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort A { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort D { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		[ContainerField(40)]
		public AudioGraphNodePort S { get; set; } = new AudioGraphNodePort(); // 0x28 (40)
		
		[ContainerField(48)]
		public AudioGraphNodePort R { get; set; } = new AudioGraphNodePort(); // 0x30 (48)
		
		[ContainerField(56)]
		public AudioGraphNodePort Value { get; set; } = new AudioGraphNodePort(); // 0x38 (56)
		
		[ContainerField(64)]
		public AudioGraphNodePort Finished { get; set; } = new AudioGraphNodePort(); // 0x40 (64)
		
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
