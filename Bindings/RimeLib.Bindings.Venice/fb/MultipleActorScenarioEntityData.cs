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
    [ContainerType(16)]
	public class MultipleActorScenarioEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform WorldSpaceConnectTransform { get; set; } = new LinearTransform(); // 0x50 (80)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public int Actor5Part { get; set; } // 0x90 (144)
		
		[ContainerField(148)]
		public AntRef ScenarioAntRef { get; set; } = new AntRef(); // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public int LevelChoice { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public int ScenarioChoice { get; set; } // 0x9C (156)
		
		[ContainerField(160)]
		public Realm Realm { get; set; } = new Realm(); // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public int Actor6Part { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public int Actor1 { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public int Actor1Part { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public int Actor1SecondPart { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public int Actor2 { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public int Actor2Part { get; set; } // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public int Actor2SecondPart { get; set; } // 0xBC (188)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public int Actor3 { get; set; } // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public int Actor3Part { get; set; } // 0xC4 (196)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public int Actor3SecondPart { get; set; } // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public int Actor4 { get; set; } // 0xCC (204)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public int Actor4Part { get; set; } // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public int Actor4SecondPart { get; set; } // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public int Actor5 { get; set; } // 0xD8 (216)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public int Actor5SecondPart { get; set; } // 0xDC (220)
		
		[ContainerField(224), LayoutImmutable, Blittable]
		public int Actor6SecondPart { get; set; } // 0xE0 (224)
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public int Actor6 { get; set; } // 0xE4 (228)
		
		[ContainerField(232), LayoutImmutable, Blittable]
		public float ExternalTime { get; set; } // 0xE8 (232)
		
		[ContainerField(236), LayoutImmutable, Blittable]
		public bool AligningEnabled { get; set; } // 0xEC (236)
		
		[ContainerField(237), LayoutImmutable, Blittable]
		public bool ScenarioActive { get; set; } // 0xED (237)
		
		[ContainerField(238), LayoutImmutable, Blittable]
		public bool Actor1Prepared { get; set; } // 0xEE (238)
		
		[ContainerField(239), LayoutImmutable, Blittable]
		public bool Actor2Prepared { get; set; } // 0xEF (239)
		
		[ContainerField(240), LayoutImmutable, Blittable]
		public bool Actor3Prepared { get; set; } // 0xF0 (240)
		
		[ContainerField(241), LayoutImmutable, Blittable]
		public bool Actor4Prepared { get; set; } // 0xF1 (241)
		
		[ContainerField(242), LayoutImmutable, Blittable]
		public bool Actor5Prepared { get; set; } // 0xF2 (242)
		
		[ContainerField(243), LayoutImmutable, Blittable]
		public bool Actor6Prepared { get; set; } // 0xF3 (243)
		
		[ContainerField(244), LayoutImmutable, Blittable]
		public bool CheckActor1Finished { get; set; } // 0xF4 (244)
		
		[ContainerField(245), LayoutImmutable, Blittable]
		public bool CheckActor2Finished { get; set; } // 0xF5 (245)
		
		[ContainerField(246), LayoutImmutable, Blittable]
		public bool CheckActor3Finished { get; set; } // 0xF6 (246)
		
		[ContainerField(247), LayoutImmutable, Blittable]
		public bool CheckActor4Finished { get; set; } // 0xF7 (247)
		
		[ContainerField(248), LayoutImmutable, Blittable]
		public bool CheckActor5Finished { get; set; } // 0xF8 (248)
		
		[ContainerField(249), LayoutImmutable, Blittable]
		public bool CheckActor6Finished { get; set; } // 0xF9 (249)
		
		[ContainerField(250), LayoutImmutable, Blittable]
		public bool UseInputEventPlayerAsPlayer1 { get; set; } // 0xFA (250)
		
		[ContainerField(251), LayoutImmutable, Blittable]
		public bool UseExternalTime { get; set; } // 0xFB (251)
		
		[ContainerField(252), LayoutImmutable, Blittable]
		public bool WorldSpace { get; set; } // 0xFC (252)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1100259089:
					WorldSpaceConnectTransform = (LinearTransform) p_Value;
					break;

				case 4063426348:
					Actor5Part = (int) p_Value;
					break;

				case 3249359201:
					ScenarioAntRef = (AntRef) p_Value;
					break;

				case 1514666168:
					LevelChoice = (int) p_Value;
					break;

				case 3315992608:
					ScenarioChoice = (int) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 4064329455:
					Actor6Part = (int) p_Value;
					break;

				case 2484184607:
					Actor1 = (int) p_Value;
					break;

				case 4068170024:
					Actor1Part = (int) p_Value;
					break;

				case 3245706712:
					Actor1SecondPart = (int) p_Value;
					break;

				case 2484184604:
					Actor2 = (int) p_Value;
					break;

				case 4069073131:
					Actor2Part = (int) p_Value;
					break;

				case 1494016859:
					Actor2SecondPart = (int) p_Value;
					break;

				case 2484184605:
					Actor3 = (int) p_Value;
					break;

				case 4070394026:
					Actor3Part = (int) p_Value;
					break;

				case 2441148378:
					Actor3SecondPart = (int) p_Value;
					break;

				case 2484184602:
					Actor4 = (int) p_Value;
					break;

				case 4062105453:
					Actor4Part = (int) p_Value;
					break;

				case 3250112349:
					Actor4SecondPart = (int) p_Value;
					break;

				case 2484184603:
					Actor5 = (int) p_Value;
					break;

				case 4197243868:
					Actor5SecondPart = (int) p_Value;
					break;

				case 2445554015:
					Actor6SecondPart = (int) p_Value;
					break;

				case 2484184600:
					Actor6 = (int) p_Value;
					break;

				case 2162678253:
					ExternalTime = (float) p_Value;
					break;

				case 1454127501:
					AligningEnabled = (bool) p_Value;
					break;

				case 3253317991:
					ScenarioActive = (bool) p_Value;
					break;

				case 3975066650:
					Actor1Prepared = (bool) p_Value;
					break;

				case 2878190105:
					Actor2Prepared = (bool) p_Value;
					break;

				case 770618392:
					Actor3Prepared = (bool) p_Value;
					break;

				case 2873438751:
					Actor4Prepared = (bool) p_Value;
					break;

				case 765867038:
					Actor5Prepared = (bool) p_Value;
					break;

				case 3963957789:
					Actor6Prepared = (bool) p_Value;
					break;

				case 2061362539:
					CheckActor1Finished = (bool) p_Value;
					break;

				case 4180155688:
					CheckActor2Finished = (bool) p_Value;
					break;

				case 2998814185:
					CheckActor3Finished = (bool) p_Value;
					break;

				case 1137974702:
					CheckActor4Finished = (bool) p_Value;
					break;

				case 4251600495:
					CheckActor5Finished = (bool) p_Value;
					break;

				case 2075426348:
					CheckActor6Finished = (bool) p_Value;
					break;

				case 2839224479:
					UseInputEventPlayerAsPlayer1 = (bool) p_Value;
					break;

				case 2902061742:
					UseExternalTime = (bool) p_Value;
					break;

				case 632957315:
					WorldSpace = (bool) p_Value;
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
				case 1100259089:
					return WorldSpaceConnectTransform;

				case 4063426348:
					return Actor5Part;

				case 3249359201:
					return ScenarioAntRef;

				case 1514666168:
					return LevelChoice;

				case 3315992608:
					return ScenarioChoice;

				case 229961746:
					return Realm;

				case 4064329455:
					return Actor6Part;

				case 2484184607:
					return Actor1;

				case 4068170024:
					return Actor1Part;

				case 3245706712:
					return Actor1SecondPart;

				case 2484184604:
					return Actor2;

				case 4069073131:
					return Actor2Part;

				case 1494016859:
					return Actor2SecondPart;

				case 2484184605:
					return Actor3;

				case 4070394026:
					return Actor3Part;

				case 2441148378:
					return Actor3SecondPart;

				case 2484184602:
					return Actor4;

				case 4062105453:
					return Actor4Part;

				case 3250112349:
					return Actor4SecondPart;

				case 2484184603:
					return Actor5;

				case 4197243868:
					return Actor5SecondPart;

				case 2445554015:
					return Actor6SecondPart;

				case 2484184600:
					return Actor6;

				case 2162678253:
					return ExternalTime;

				case 1454127501:
					return AligningEnabled;

				case 3253317991:
					return ScenarioActive;

				case 3975066650:
					return Actor1Prepared;

				case 2878190105:
					return Actor2Prepared;

				case 770618392:
					return Actor3Prepared;

				case 2873438751:
					return Actor4Prepared;

				case 765867038:
					return Actor5Prepared;

				case 3963957789:
					return Actor6Prepared;

				case 2061362539:
					return CheckActor1Finished;

				case 4180155688:
					return CheckActor2Finished;

				case 2998814185:
					return CheckActor3Finished;

				case 1137974702:
					return CheckActor4Finished;

				case 4251600495:
					return CheckActor5Finished;

				case 2075426348:
					return CheckActor6Finished;

				case 2839224479:
					return UseInputEventPlayerAsPlayer1;

				case 2902061742:
					return UseExternalTime;

				case 632957315:
					return WorldSpace;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1100259089:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(WorldSpaceConnectTransform));

				case 4063426348:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor5Part));

				case 3249359201:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(ScenarioAntRef));

				case 1514666168:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(LevelChoice));

				case 3315992608:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(ScenarioChoice));

				case 229961746:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Realm));

				case 4064329455:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor6Part));

				case 2484184607:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor1));

				case 4068170024:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor1Part));

				case 3245706712:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor1SecondPart));

				case 2484184604:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor2));

				case 4069073131:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor2Part));

				case 1494016859:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor2SecondPart));

				case 2484184605:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor3));

				case 4070394026:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor3Part));

				case 2441148378:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor3SecondPart));

				case 2484184602:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor4));

				case 4062105453:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor4Part));

				case 3250112349:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor4SecondPart));

				case 2484184603:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor5));

				case 4197243868:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor5SecondPart));

				case 2445554015:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor6SecondPart));

				case 2484184600:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor6));

				case 2162678253:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(ExternalTime));

				case 1454127501:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(AligningEnabled));

				case 3253317991:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(ScenarioActive));

				case 3975066650:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor1Prepared));

				case 2878190105:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor2Prepared));

				case 770618392:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor3Prepared));

				case 2873438751:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor4Prepared));

				case 765867038:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor5Prepared));

				case 3963957789:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor6Prepared));

				case 2061362539:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(CheckActor1Finished));

				case 4180155688:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(CheckActor2Finished));

				case 2998814185:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(CheckActor3Finished));

				case 1137974702:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(CheckActor4Finished));

				case 4251600495:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(CheckActor5Finished));

				case 2075426348:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(CheckActor6Finished));

				case 2839224479:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(UseInputEventPlayerAsPlayer1));

				case 2902061742:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(UseExternalTime));

				case 632957315:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(WorldSpace));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
