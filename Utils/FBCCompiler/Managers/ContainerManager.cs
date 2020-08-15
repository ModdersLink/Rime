using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using FBCC.Containers;
using FBCC.Generators;
using FBCC.Grammar;

namespace FBCC.Managers
{
    static class ContainerManager
    {
        public static FrostbiteContainer BaseContainer { get; private set; }

        private static readonly Dictionary<string, FrostbiteContainer> m_Containers;

        private static readonly List<IGenerator> m_Generators; 

        static ContainerManager()
        {
            m_Containers = new Dictionary<string, FrostbiteContainer>();
            m_Generators = new List<IGenerator>();
        }

        public static void RegisterGenerator(IGenerator p_Generator)
        {
            m_Generators.Add(p_Generator);
        }

        public static Dictionary<string, string> GenerateCode()
        {
            // TODO: Re-enable this.
            /*if (BaseContainer == null)
                return new Dictionary<string, string>();

            var s_Files = new Dictionary<string, string>();

            foreach (var s_Generator in m_Generators)
            {
                var s_GeneratedFiles = s_Generator.Generate(BaseContainer);

                foreach (var s_File in s_GeneratedFiles)
                    s_Files.Add(s_Generator.Name + "/" + s_File.Key, s_File.Value);
            }

            return s_Files;*/

            if (BaseContainer == null)
                return new Dictionary<string, string>();

            var s_Files = new Dictionary<string, string>();

            foreach (var s_Pair in m_Containers)
            {
                foreach (var s_Generator in m_Generators)
                {
                    var s_GeneratedFiles = s_Generator.Generate(s_Pair.Value);

                    foreach (var s_File in s_GeneratedFiles)
                        s_Files.Add(s_Generator.Name + "/" + s_File.Key, s_File.Value);
                }
            }

            return s_Files;

            //var s_Files = m_Generators.Select(p_Generator => p_Generator.Generate(BaseContainer)).ToList();
            //return s_Files.SelectMany(p_Dict => p_Dict).ToDictionary(p_Pair => p_Pair.Key, p_Pair => p_Pair.Value);
        }

        public static FrostbiteContainer ParseContainer(string p_Path)
        {
            //Console.WriteLine("Parsing FBC file '{0}'", Path.GetFileName(p_Path));

            var s_Stream = new FileStream(p_Path, FileMode.Open);
            var s_InputStream = new AntlrInputStream(s_Stream);

            var s_Lexer = new FBCLexer(s_InputStream);
            var s_Tokens = new CommonTokenStream(s_Lexer);

            var s_Parser = new FBCParser(s_Tokens);
            IParseTree s_Tree = s_Parser.fbc();

            var s_Visitor = new FBCCVisitor(p_Path);
            s_Visitor.Visit(s_Tree);

            var s_Container = s_Visitor.Container;

            s_Stream.Dispose();

            return s_Container;
        }

        public static FrostbiteContainer RegisterContainer(string p_Path, bool p_Base, out bool p_Exists)
        {
            if (m_Containers.ContainsKey(p_Path))
            {
                p_Exists = true;
                return null;
            }

            var s_Container = ParseContainer(p_Path);
            RegisterContainer(s_Container, p_Base, out p_Exists);
            return s_Container;
        }

        public static FrostbiteContainer RegisterContainer(FrostbiteContainer p_Container, bool p_Base, out bool p_Exists)
        {
            // Container is already registered; skip.
            if (m_Containers.ContainsKey(p_Container.FilePath))
            {
                p_Exists = true;
                return p_Container;
            }

            p_Exists = false;
            m_Containers.Add(p_Container.FilePath, p_Container);

            // Set the base container if requested.
            if (p_Base)
                BaseContainer = p_Container;

            return p_Container;
        }

        public static void RemoveContainer(FrostbiteContainer p_Container)
        {
            m_Containers.Remove(p_Container.FilePath);
        }

        public static FrostbiteContainer GetContainerByName(string p_Name)
        {
            return m_Containers.FirstOrDefault(p_Container => p_Container.Value.Name == p_Name).Value;
        }

        public static FrostbiteContainer GetContainerByPath(string p_Path)
        {
            return m_Containers.FirstOrDefault(p_Container => p_Container.Value.FilePath == p_Path).Value;
        }

        public static List<FrostbiteContainer> GetContainers()
        {
            return m_Containers.Values.ToList();
        }

        public static void ClearContainers()
        {
            m_Containers.Clear();
            BaseContainer = null;
        }

        public static bool HasClass(ContainerNamespace p_Namespace)
        {
            return HasClass(p_Namespace.Components[p_Namespace.Components.Count - 1]);
        }

        public static bool HasClass(string p_ClassName)
        {
            if (p_ClassName == "DataContainer" ||
                p_ClassName == "Mat4")
                return true;

            return m_Containers.Any(p_Container => p_Container.Value.GetClasses().Any(p_Class => p_Class.Name == p_ClassName));
        }

        public static bool HasStruct(ContainerNamespace p_Namespace)
        {
            return HasStruct(p_Namespace.Components[p_Namespace.Components.Count - 1]);
        }

        public static bool HasStruct(string p_StructName)
        {
            if (p_StructName == "LinearTransform" ||
                p_StructName == "Vec2" ||
                p_StructName == "Vec3" ||
                p_StructName == "Vec4" ||
                p_StructName == "Guid" ||
                p_StructName == "AxisAlignedBox")
                return true;

            return m_Containers.Any(p_Container => p_Container.Value.GetStructs().Any(p_Struct => p_Struct.Name == p_StructName));
        }

        public static bool HasEnum(ContainerNamespace p_Namespace)
        {
            return HasEnum(p_Namespace.Components[p_Namespace.Components.Count - 1]);
        }

        public static bool HasEnum(string p_EnumName)
        {
            return m_Containers.Any(p_Container => p_Container.Value.GetEnums().Any(p_Enum => p_Enum.Name == p_EnumName));
        }

        public static bool HasType(ContainerNamespace p_Namespace)
        {
            return HasType(p_Namespace.Components[p_Namespace.Components.Count - 1]);
        }

        public static bool HasType(string p_TypeName)
        {
            if (p_TypeName == "LinearTransform" ||
                p_TypeName == "Vec2" ||
                p_TypeName == "Vec3" ||
                p_TypeName == "Vec4" ||
                p_TypeName == "Mat4" ||
                p_TypeName == "Guid" ||
                p_TypeName == "AxisAlignedBox" ||
                p_TypeName == "ResourceRef" ||
                p_TypeName == "DataContainer")
                return true;

            foreach (var s_Container in m_Containers)
            {
                if (s_Container.Value.GetClasses().Any(p_Class => p_Class.Name == p_TypeName))
                    return true;

                if (s_Container.Value.GetStructs().Any(p_Struct => p_Struct.Name == p_TypeName))
                    return true;

                if (s_Container.Value.GetEnums().Any(p_Enum => p_Enum.Name == p_TypeName))
                    return true;
            }

            return false;
        }
    }
}
