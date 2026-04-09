///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 72)]
	public partial class CoreSettings :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private int _RandomTickSeed;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		private string _AvailableLanguages = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private int _RandomSessionId;
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private int _RandomTimeSeed;
		
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _HardwareGpuBias;
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private HardwareProfile _HardwareProfile = new();
		
		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private int _JobProcessorCount;
		
		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private int _MaxJobThreadCount;
		
		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		private string _Host = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		private string _HostUser = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		private string _HostUserDomain = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		private string _InitSeed = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private CoreLogLevel _LogLevel = new();
		
		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _HardwareCpuBias;
		
		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, JsonProperty(Order = 56)]
		private string _GameConfigurationName = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, JsonProperty(Order = 60)]
		private string _ProfileDirectoryName = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private bool _DisplayAsserts;
		
		[ObservableProperty]
		[property: ContainerField(65), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
		private bool _LiveEditingEnable;
		
		[ObservableProperty]
		[property: ContainerField(66), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
		private bool _UseStorageServer;
		
		[ObservableProperty]
		[property: ContainerField(67), LayoutImmutable, Blittable, JsonProperty(Order = 67)]
		private bool _UseDiskCaching;
		
		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private bool _CrashOnFatalErrors;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(RandomTickSeed);
			p_Writer.Write(p_EbxWriter.WriteString(AvailableLanguages));
			p_Writer.Write(RandomSessionId);
			p_Writer.Write(RandomTimeSeed);
			p_Writer.Write(HardwareGpuBias);
			p_Writer.Write((int) HardwareProfile);
			p_Writer.Write(JobProcessorCount);
			p_Writer.Write(MaxJobThreadCount);
			p_Writer.Write(p_EbxWriter.WriteString(Host));
			p_Writer.Write(p_EbxWriter.WriteString(HostUser));
			p_Writer.Write(p_EbxWriter.WriteString(HostUserDomain));
			p_Writer.Write(p_EbxWriter.WriteString(InitSeed));
			p_Writer.Write((int) LogLevel);
			p_Writer.Write(HardwareCpuBias);
			p_Writer.Write(p_EbxWriter.WriteString(GameConfigurationName));
			p_Writer.Write(p_EbxWriter.WriteString(ProfileDirectoryName));
			p_Writer.Write(DisplayAsserts);
			p_Writer.Write(LiveEditingEnable);
			p_Writer.Write(UseStorageServer);
			p_Writer.Write(UseDiskCaching);
			p_Writer.Write(CrashOnFatalErrors);
			p_Writer.WriteNullBytes(3);
		}
	}
}
