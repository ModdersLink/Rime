using System;
using System.Collections.Generic;
using System.IO;

namespace RimeLib.Animation.EA.Readers
{
    public class ReferenceTypeRegistry
    {
        protected static ReferenceTypeRegistry? _instance = null;
        public static ReferenceTypeRegistry Instance => _instance ??= new ReferenceTypeRegistry();


        private Dictionary<string, string> m_BaseClassDictionary = new();

        private Dictionary<string, string> m_DataRefDictionary = new();
        private Dictionary<string, string> m_GuidRefDictionary = new();

        private HashSet<string> m_Errors = new();
        
        public void AddBase(string p_Class, string p_BaseClass)
        {
            if (m_BaseClassDictionary.TryGetValue(p_Class, out var s_ExistingBase))
            {
                if (s_ExistingBase != p_BaseClass)
                {
                    var s_Key = $"class [{p_Class}] has existing base [{s_ExistingBase}], but is trying to add [{p_BaseClass}]. Does this base have a shared base?";

                    if (m_Errors.Contains(s_Key))
                        return;

                    m_Errors.Add(s_Key);
                    Console.WriteLine(s_Key);
                }

                return;
            }

            m_BaseClassDictionary.Add(p_Class, p_BaseClass);
        }


        public void AddDataRef(string p_ClassField, string p_RefClass)
        {
            if (m_DataRefDictionary.TryGetValue(p_ClassField, out var s_ExistingRef))
            {
                if (s_ExistingRef != p_RefClass)
                {
                    var s_Key =
                        $"class [{p_ClassField}] has existing dataref [{s_ExistingRef}], but is trying to add [{p_RefClass}]. Does this base have a shared base?";
                    
                    if (m_Errors.Contains(s_Key))
                        return;

                    m_Errors.Add(s_Key);
                    Console.WriteLine(s_Key);
                }

                return;
            }
            m_DataRefDictionary.Add(p_ClassField, p_RefClass);
        }

        public void AddGuidRef(string p_ClassField, string p_RefClass)
        {
            if (m_GuidRefDictionary.TryGetValue(p_ClassField, out var s_ExistingRef))
            {
                if (s_ExistingRef != p_RefClass)
                {
                    var s_Key = $"class [{p_ClassField}] has existing guid ref [{s_ExistingRef}], but is trying to add [{p_RefClass}]. Does this base have a shared base?";

                    if (m_Errors.Contains(s_Key))
                        return;

                    m_Errors.Add(s_Key);
                    Console.WriteLine(s_Key);
                }
                return;
            }
            m_GuidRefDictionary.Add(p_ClassField, p_RefClass);
        }


        public void Save(string p_Path)
        {
            {
                string s_BaseArray = "";

                foreach (var s_BasePair in m_BaseClassDictionary)
                    s_BaseArray += $"{{ \"{s_BasePair.Key}\", \"{s_BasePair.Value}\" }},\n";

                File.WriteAllText(Path.Combine(p_Path, "ant-baseclasses.txt"), s_BaseArray);
            }
            {
                string s_BaseArray = "";

                foreach (var s_BasePair in m_DataRefDictionary)
                    s_BaseArray += $"{{ \"{s_BasePair.Key}\", \"{s_BasePair.Value}\" }},\n";

                File.WriteAllText(Path.Combine(p_Path, "ant-datarefs.txt"), s_BaseArray);
            }
            {
                string s_BaseArray = "";

                foreach (var s_BasePair in m_GuidRefDictionary)
                    s_BaseArray += $"{{ \"{s_BasePair.Key}\", \"{s_BasePair.Value}\" }},\n";


                File.WriteAllText(Path.Combine(p_Path, "ant-guidrefs.txt"), s_BaseArray);
            }
            
            {
                string s_ErrorString = "";

                foreach (var s_Error in m_Errors)
                    s_ErrorString += $"{s_Error}\n";


                File.WriteAllText(Path.Combine(p_Path, "ant-errors.txt"), s_ErrorString);
            }
        }
    }
}
