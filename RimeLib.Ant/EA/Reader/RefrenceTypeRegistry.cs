using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Ant.EA.Readers
{
    public class RefrenceTypeRegistry
    {
        protected static RefrenceTypeRegistry? _instance = null;
        public static RefrenceTypeRegistry Instance => _instance ??= new RefrenceTypeRegistry();


        private Dictionary<string, string> m_BaseClassDictionary = new();

        private Dictionary<string, string> m_DataRefDictionary = new();
        private Dictionary<string, string> m_GuidRefDictionary = new();


        public void AddBase(string p_Class, string p_BaseClass)
        {
            if (m_BaseClassDictionary.TryGetValue(p_Class, out var s_ExistingBase))
            {
                if (s_ExistingBase != p_BaseClass)
                    Console.WriteLine($"class [{p_Class}] has existing base [{s_ExistingBase}], but is trying to add [{p_BaseClass}]. Does this base have a shared base?");

                return;
            }

            m_BaseClassDictionary.Add(p_Class, p_BaseClass);
        }


        public void AddDataRef(string p_ClassField, string p_RefClass)
        {
            if (m_DataRefDictionary.TryGetValue(p_ClassField, out var s_ExistingRef))
            {
                if (s_ExistingRef != p_RefClass)
                    Console.WriteLine($"class [{p_ClassField}] has existing dataref [{s_ExistingRef}], but is trying to add [{p_RefClass}]. Does this base have a shared base?");

                return;
            }
            m_DataRefDictionary.Add(p_ClassField, p_RefClass);
        }

        public void AddGuidRef(string p_ClassField, string p_RefClass)
        {
            if (m_GuidRefDictionary.TryGetValue(p_ClassField, out var s_ExistingRef))
            {
                if (s_ExistingRef != p_RefClass)
                    Console.WriteLine($"class [{p_ClassField}] has existing guid ref [{s_ExistingRef}], but is trying to add [{p_RefClass}]. Does this base have a shared base?");

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

                File.WriteAllText(Path.Combine(p_Path, "baseclasses.txt"), s_BaseArray);
            }
            {
                string s_BaseArray = "";

                foreach (var s_BasePair in m_DataRefDictionary)
                    s_BaseArray += $"{{ \"{s_BasePair.Key}\", \"{s_BasePair.Value}\" }},\n";

                File.WriteAllText(Path.Combine(p_Path, "datarefs.txt"), s_BaseArray);
            }
            {
                string s_BaseArray = "";

                foreach (var s_BasePair in m_GuidRefDictionary)
                    s_BaseArray += $"{{ \"{s_BasePair.Key}\", \"{s_BasePair.Value}\" }},\n";


                File.WriteAllText(Path.Combine(p_Path, "guidrefs.txt"), s_BaseArray);
            }
        }
    }
}
