// dllmain.cpp : Defines the entry point for the DLL application.
#include <windows.h>
#include <string>
#include <cstdio>
#include <filesystem>
#include <fstream>

#include "Headers.h"
#include "Refrences.h"



std::string ToString(Sdk::GD::LayoutType p_Type)
{
    switch (p_Type)
    {
    case Sdk::GD::LayoutType::Bool:
        return "bool";
    case Sdk::GD::LayoutType::Int8:
        return "sbyte";
    case Sdk::GD::LayoutType::UInt8:
        return "byte";
    case Sdk::GD::LayoutType::Int16:
        return "short";
    case Sdk::GD::LayoutType::UInt16:
        return "ushort";
    case Sdk::GD::LayoutType::Int32:
        return "int";
    case Sdk::GD::LayoutType::UInt32:
        return "uint";
    case Sdk::GD::LayoutType::Int64:
        return "long";
    case Sdk::GD::LayoutType::UInt64:
        return "ulong";
    case Sdk::GD::LayoutType::Float:
        return "float";
    case Sdk::GD::LayoutType::Vector2:
        return "AntVector2";
    case Sdk::GD::LayoutType::Vector3:
        return "AntVector3";
    case Sdk::GD::LayoutType::Vector4:
        return "AntVector4";
    case Sdk::GD::LayoutType::Quaternion:
        return "AntQuaternion";
    case Sdk::GD::LayoutType::Matrix44:
        return "AntMatrix44";
    case Sdk::GD::LayoutType::Guid:
        return "Guid";
    case Sdk::GD::LayoutType::String:
        return "string";
    case Sdk::GD::LayoutType::DataRef:
        return "DataRef";
    case Sdk::GD::LayoutType::LayoutTypeCount:
        return "IdRef";
    }

    return "";
}



std::string FindDataRef(Sdk::GD::Layout* pLayout, Sdk::GD::Entry* pEntry)
{
    std::string SearchString = std::format("{}.{}", pLayout->GetLayoutName(), pLayout->GetString(pEntry->m_NameOffset));


    auto FindResult = c_DataRefs.find(SearchString);
    if (FindResult == c_DataRefs.end())
        return "AntObject";

    return FindResult->second;
}


std::string FindIdRef(Sdk::GD::Layout* pLayout, Sdk::GD::Entry* pEntry)
{
    std::string SearchString = std::format("{}.{}", pLayout->GetLayoutName(), pLayout->GetString(pEntry->m_NameOffset));


    auto FindResult = c_GuidRefs.find(SearchString);
    if (FindResult == c_GuidRefs.end())
        return "AntObject";

    return FindResult->second;
}


/*
[ContainerType(16, 48)]
public class AABBData :
    BaseShapeData
{
    [ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
    public Vec3 Position { get; set; } = new();

    [ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
    public Vec3 HalfExtents { get; set; } = new();

    public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
    {
        base.Serialize(p_Writer, p_EbxWriter);
        p_Writer.WriteNullBytes(4);
        Position.Serialize(p_Writer, p_EbxWriter);
        HalfExtents.Serialize(p_Writer, p_EbxWriter);
    }
}
*/

void DumpType(std::filesystem::path p_OutPath, Sdk::GD::Layout* p_Layout)
{
    std::string ClassString = "";

    ClassString += "///////////////////////////////////////////////////////////////\n";
    ClassString += "//                                                           //\n";
    ClassString += "// This is an automatically generated file.                  //\n";
    ClassString += "// As type schemas dont contain full information, modifying  //\n";
    ClassString += "// can be done to fix information thats wrong or missing.    //\n";
    ClassString += "//                                                           //\n";
    ClassString += "///////////////////////////////////////////////////////////////\n";
    ClassString += "\n";

    ClassString += "using System.Collections.Generic;\n";
    ClassString += "using RimeLib.Ant.EA.Attributes;\n";
    ClassString += "using RimeLib.Ant.EA.Types;\n";
    ClassString += "\n";

    ClassString += "namespace ant\n";
    ClassString += "{\n\n";


    ClassString += std::format("\t[AntBinding({:#08x})]\n", p_Layout->m_Hash);
    ClassString += std::format("\tpublic class {}\n", p_Layout->GetLayoutName());

    auto BaseClassFindResult = c_BaseClasses.find(p_Layout->GetLayoutName());
    if (BaseClassFindResult != c_BaseClasses.end())
        ClassString += std::format("\t\t: {}\n", BaseClassFindResult->second);
    else
        ClassString += "\t\t: AntObject\n";

    ClassString += "\t{\n";

    for (int32_t i = 0; i < p_Layout->TotalSlotCount(); i++)
    {
        auto SlotId = p_Layout->m_MinSlot + i;

        // skip standard slots, and put it in a base class
        if (SlotId < 0)
            continue;

        auto* pField = p_Layout->GetEntry(i);

        if (pField->m_LayoutHash == Sdk::GD::LayoutType::Invalid)
            continue;

        auto* pFieldName = p_Layout->GetString(pField->m_NameOffset);
        auto* pFieldLayout = pField->m_Layout.m_pPtr;

        if (!pFieldLayout)
        {
            printf("Unknown field layout?!? [%s]\n", pFieldName);
            continue;
        }
        auto LayoutName = pFieldLayout->GetLayoutName();


        bool IsArray = pField->m_Flags & 1;

        bool IsConstArray = pField->m_Count > 1;
        if (IsConstArray)
            printf("Found array at [%s]-----------\n", pFieldName);

        if (pField->m_Count == 0)
            printf("Found hidden value at [%s]-----------\n", pFieldName);



        if (strstr(pFieldName, "LodDistancesNear") != nullptr)
            printf("Found stuff!");

        ClassString += std::format("\t\t[AntField({})]\n", SlotId);

        if (pField->GetType() == Sdk::GD::Guid && IsArray)
        {
            ClassString += std::format("\t\tpublic IdRefArray<{}> {} {{ get; set; }} = new();\n", FindIdRef(p_Layout, pField), pFieldName);
        }
        else  if (pField->GetType() == Sdk::GD::Guid && !IsArray)
        {
            ClassString += std::format("\t\tpublic IdRef<{}> {} {{ get; set; }} = new();\n", FindIdRef(p_Layout, pField), pFieldName);
        }

        else if (!IsArray && !IsConstArray)
        {
            if (pField->GetType() == Sdk::GD::DataRef) //DataRef is same as relocptr kinda. nullable ref should be fine
            {
                //TypeString = std::format("{}?", FindDataRef(p_Layout, pField));

                ClassString += std::format("\t\tpublic {}? {} {{ get; set; }} = null;\n", FindDataRef(p_Layout, pField), pFieldName);
            }
            else
            {

                std::string TypeString = ToString(pField->GetType());
                if (!pField->IsBasicType())
                    TypeString = LayoutName;

                switch (pField->GetType())
                {
                case Sdk::GD::LayoutType::Bool:
                case Sdk::GD::LayoutType::Int8:
                case Sdk::GD::LayoutType::UInt8:
                case Sdk::GD::LayoutType::Int16:
                case Sdk::GD::LayoutType::UInt16:
                case Sdk::GD::LayoutType::Int32:
                case Sdk::GD::LayoutType::UInt32:
                case Sdk::GD::LayoutType::Int64:
                case Sdk::GD::LayoutType::UInt64:
                case Sdk::GD::LayoutType::Float:
                    ClassString += std::format("\t\tpublic {} {} {{ get; set; }}\n", TypeString, pFieldName);
                    break;

                default:
                case Sdk::GD::LayoutType::Vector2:
                case Sdk::GD::LayoutType::Vector3:
                case Sdk::GD::LayoutType::Vector4:
                case Sdk::GD::LayoutType::Quaternion:
                case Sdk::GD::LayoutType::Matrix44:
                case Sdk::GD::LayoutType::Guid:
                    ClassString += std::format("\t\tpublic {} {} {{ get; set; }} = new();\n", TypeString, pFieldName);
                    break;
                case Sdk::GD::LayoutType::String:
                    ClassString += std::format("\t\tpublic {} {} {{ get; set; }} = string.Empty;\n", TypeString, pFieldName);
                    break;
            
                }
            }
            
        }
        else if (IsArray)
        {
            if (pField->GetType() == Sdk::GD::DataRef) //DataRef is same as relocptr kinda. nullable ref should be fine
            {
                //TypeString = std::format("{}?", FindDataRef(p_Layout, pField));

                ClassString += std::format("\t\tpublic List<{}?> {} {{ get; set; }} = new();\n", FindDataRef(p_Layout, pField), pFieldName);
            }
            else
            {

                std::string TypeString = ToString(pField->GetType());
                if (!pField->IsBasicType())
                    TypeString = LayoutName;


                ClassString += std::format("\t\tpublic List<{}> {} {{ get; set; }} = new();\n", TypeString, pFieldName);

            }

        }
        else if (IsConstArray)
        {
            if (pField->GetType() == Sdk::GD::DataRef) //DataRef is same as relocptr kinda. nullable ref should be fine
            {
                //TypeString = std::format("{}?", FindDataRef(p_Layout, pField));

                auto RefName = FindDataRef(p_Layout, pField);

                std::string InitializerString = "";


                ClassString += std::format("\t\tpublic {}?[] {} {{ get; set; }} = new {}?[{}];\n", RefName, pFieldName , RefName, pField->m_Count);
            }
            else
            {

                std::string TypeString = ToString(pField->GetType());
                if (!pField->IsBasicType())
                    TypeString = LayoutName;

                switch (pField->GetType())
                {
                case Sdk::GD::LayoutType::Bool:
                case Sdk::GD::LayoutType::Int8:
                case Sdk::GD::LayoutType::UInt8:
                case Sdk::GD::LayoutType::Int16:
                case Sdk::GD::LayoutType::UInt16:
                case Sdk::GD::LayoutType::Int32:
                case Sdk::GD::LayoutType::UInt32:
                case Sdk::GD::LayoutType::Int64:
                case Sdk::GD::LayoutType::UInt64:
                case Sdk::GD::LayoutType::Float:
                    ClassString += std::format("\t\tpublic {}[] {} {{ get; set; }} = new {}[{}];\n", TypeString, pFieldName, TypeString, pField->m_Count);
                    break;

                default:
                case Sdk::GD::LayoutType::Vector2:
                case Sdk::GD::LayoutType::Vector3:
                case Sdk::GD::LayoutType::Vector4:
                case Sdk::GD::LayoutType::Quaternion:
                case Sdk::GD::LayoutType::Matrix44:
                case Sdk::GD::LayoutType::Guid:
                    ClassString += std::format("\t\tpublic {}[] {} {{ get; set; }} = new {}[{}];\n", TypeString, pFieldName, TypeString, pField->m_Count);
                    break;
                case Sdk::GD::LayoutType::String:
                    ClassString += std::format("\t\tpublic string[] {} {{ get; set; }} = new string[{}];\n", pFieldName, pField->m_Count);
                    break;

                }
            }
        }

        

        //ClassString += std::format("\t\t{} {} = new();\n", TypeString, pFieldName);

        ClassString += "\n";
        //printf("\t %s%s %s; //0x%04x | 0x%x\n", pFieldLayoutName, pArray, pRootLayout->GetString(pField->m_NameOffset), pField->m_Offset, pField->m_RLE);
    }

    ClassString += "\t}\n";
    ClassString += "}\n";


    auto OutPath = std::filesystem::path(p_OutPath) += std::filesystem::path(std::string(p_Layout->GetLayoutName()) + ".cs");
    
    printf("%ls\n", OutPath.c_str());

    std::ofstream FileStream(OutPath, std::ios::out);

    if (FileStream.is_open())
    {
        FileStream.write(ClassString.c_str(), ClassString.length());
        FileStream.close();
    }

    //printf("%s", ClassString.c_str());

}


void Dump(std::filesystem::path p_OutPath)
{

    auto* pRegistry = Sdk::Ant::Generics::SchemaRegistry::GetInstance();

    //printf("pRegistry [0x%x]\n", pRegistry);

    for (auto& Entry : pRegistry->m_mRegistryByName)
    {
        if (!Entry.second)
            continue;


        //printf("Entry.second [0x%x]\n", Entry.second);

        auto* pRootLayout = Entry.second->m_pLayout;

        if (!pRootLayout)
            continue;

        DumpType(p_OutPath, pRootLayout);

    }
}


DWORD UnloadThread(HINSTANCE hDll)
{


    while (!GetAsyncKeyState((IsDebuggerPresent() ? VK_INSERT : VK_F10)))
        Sleep(100);

    printf("[+] Unloading Dll!\n");
    Sleep(500);
    FreeLibraryAndExitThread(hDll, 0);
}

void CreateConsole()
{
    AllocConsole();
    freopen("CONIN$", "r", stdin);
    freopen("CONOUT$", "w", stdout);

    HANDLE cHandle = GetStdHandle(STD_OUTPUT_HANDLE);

    SetConsoleTitleA("--|-- Consoles are nice! --|--");

}


BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
        DisableThreadLibraryCalls(hModule);
        CreateConsole();


        SetConsoleTitleA("--|-- Consoles are nice! --|--");

        CreateThread(nullptr, 0, reinterpret_cast<LPTHREAD_START_ROUTINE>(UnloadThread), hModule, 0, nullptr);


        Dump("F:\\bf3\\antbindings\\");

        break;

    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }

    // force dll exit
    return TRUE;
}

