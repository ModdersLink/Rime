using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFxTool.Scaleform
{
    public enum SwfTag
    {
        End = 0,
        EndFrame = 1,
        DefineShape = 2,

        PlaceObject = 4,
        RemoveObject = 5,
        DefineBitsJpeg = 6,
        ButtonCharacter = 7,
        JpegTables = 8,
        SetBackgroundColor = 9,
        DefineFont = 10,
        DefineText = 11,

        DoAction = 12,
        DefineFontInfo = 13,
        DefineSound = 14,
        StartSound = 15,

        ButtonSound = 17,
        SoundStreamHead = 18,
        SoundStreamBlock = 19,
        DefineBitsLossless = 20,
        DefineBitsJpeg2 = 21,
        DefineShape2 = 22,
        DefineButtonCxform = 23,
        Protect = 24,

        PlaceObject2 = 26,

        RemoveObject2 = 28,

        DefineShape3 = 32,
        DefineText2 = 33,
        ButtonCharacter2 = 34,
        DefineBitsJpeg3 = 35,
        DefineBitsLossless2 = 36,
        DefineEditText = 37,
        
        Sprite = 39,
        
        SerialNumber = 41,
        
        FrameLabel = 43,
        
        SoundStreamHead2 = 45,
        DefineShapeMorph = 46,
        
        DefineFont2 = 48,

        Export = 56,
        Import = 57,
        DoInitAction = 59,
        DefineVideoStream = 60,
        VideoFrame = 61,
        
        DefineFontInfo2 = 62,
        DebugID = 63,
        EnableDebugger2 = 64,
        ScriptLimits = 65,
        SetTabIndex = 66,
        
        FileAttributes = 69,
        PlaceObject3 = 70,
        Import2 = 71,
        
        DefineFontAlignZones = 73,
        CSMTextSettings = 74,
        DefineFont3 = 75,
        SymbolClass = 76,
        Metadata = 77,
        DefineScale9Grid = 78,
        
        DoABC = 82,
        DefineShape4 = 83,
        DefineShapeMorph2 = 84,
        //SWF_TagTableEnd = 85,
        
        DefineSceneAndFrameLabelData = 86,
        DefineBinaryData = 87,
        DefineFontName = 88,
        StartSound2 = 89,
        DefineBitsJPEG4 = 90,
        DefineFont4 = 91,

        //GFX_TagTableBegin = 1000,
        GFX_ExporterInfo = 1000,
        GFX_DefineExternalImage = 1001,
        GFX_FontTextureInfo = 1002,
        GFX_DefineExternalGradient = 1003,
        GFX_DefineGradientMap = 1004,
        GFX_DefineCompactedFont = 1005,
        GFX_DefineExternalSound = 1006,
        GFX_DefineExternalStreamSound = 1007,
        GFX_DefineSubImage = 1008,
        GFX_DefineExternalImage2 = 1009,
        GFX_TagTableEnd = 1010,
    }
}
