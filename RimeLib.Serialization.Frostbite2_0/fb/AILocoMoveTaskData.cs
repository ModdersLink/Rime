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
	[ContainerType(16, 48)]
	public partial class AILocoMoveTaskData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private Vec3 _WantedPos = new();
		
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _WorldAngle;
		
		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _WaitTime;
		
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AntPoseEnum _EnterPose = new();
		
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private AntPoseEnum _ExitPose = new();
		
		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private bool _OverrideAngle;
		
		[ObservableProperty]
		[property: ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		private bool _UseClientPosition;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			WantedPos.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(WorldAngle);
			p_Writer.Write(WaitTime);
			p_Writer.Write((int) EnterPose);
			p_Writer.Write((int) ExitPose);
			p_Writer.Write(OverrideAngle);
			p_Writer.Write(UseClientPosition);
			p_Writer.WriteNullBytes(14);
		}
	}
}
