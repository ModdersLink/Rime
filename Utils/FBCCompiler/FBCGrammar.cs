/*
using Irony.Parsing;

namespace FBCC
{
    [Language("FBC", "1.0", "Frostbite Container Description Language")]
    public class FBCGrammar : Irony.Parsing.Grammar
    {
        public FBCGrammar()
            : base(false)
        {
            / * [BNF Grammar]
             * 
             * fbc ::= (include_block)* namespace_block (definition)* 
             * 
             * access_modifier ::= "public" | "private" | "protected"
             * reserved_type ::= "float" | "double" | "int64" | "uint64" | "int32" | "uint32" | "int16" | "uint16" | 
             *      "int8" | "uint8" | "bool" | "blob" | "string" | enum_type | class_type | array_type | "guid" |
             *      "sha1"
             *      
             * enum_type ::= "enum" identifier
             * class_type ::= "class" identifier
             * array_type ::= "array" identifier
             * 
             * integer_type ::= "int64" | "uint64" | "int32" | "uint32" | "int16" | "uint16" | "int8" | "uint8" 
             * 
             * include_block ::= (ε | include)
             * include ::= "#include" identifier ";"
             * 
             * namespace_block ::= (ε | namespace)
             * namespace ::= "namespace" namespace_str ";"
             * namespace_str ::= identifier | identifier ("::" identifier)*
             * 
             * definition ::= (ε | class_block | struct_block | enum_block)
             * 
             * attribute_block ::= (ε | attribute)
             * attribute ::= "[" any_char "]" // TODO: Make attributes fully parseable.
             * 
             * type_contents ::= (definition | type_member | type_event | type_native_function | type_managed_function)
             * type_member ::= (attribute_block)* access_modifier reserved_type identifier ":" number ";"
             * type_event ::= (attribute_block)* "event" identifier ";"
             * type_native_function ::= "/#N" any_char "#/"
             * type_managed_function ::= "/#M" any_char "#/"
             * 
             * class_block ::= (attribute_block)* class
             * 
             * class ::= "class" identifier class_body | "class" identifier class_inheritance class_body
             * class_inheritance ::= ":" namespace_str | ":" namespace_str ("," namespace_str)*
             * class_body ::= "{" (type_contents)* "}"
             * 
             * struct_block ::= (attribute_block)* struct
             *
             * struct ::= "struct" identifier struct_body
             * struct_body ::= "{" (type_contents)* "}"
             * 
             * enum_block ::= (attribute_block)* enum
             * 
             * enum ::= "enum" identifier enum_datatype enum_body
             * enum_datatype = ε | ":" integer_type
             * enum_body ::= "{" enum_first_members enum_last_member "}"
             * enum_member ::= (attribute_block)* identifier enum_member_value ","
             * enum_first_members ::= ε | (enum_member)*
             * enum_last_member ::= (attribute_block)* identifier enum_member_value enum_terminator
             * enum_member_value ::= ε | "=" number
             * enum_terminator ::= ε | ","
             * /

            / *var comment = new CommentTerminal("Comment", "//", "\n", "\r");
            var block_comment = new CommentTerminal("BlockComment", "/ *", "* /");

            NonGrammarTerminals.Add(comment);
            NonGrammarTerminals.Add(block_comment);

            var number = new NumberLiteral("Number");
            var identifier = new IdentifierTerminal("Identifier");
            var native_function = new BlockTerminal("NativeFunction", "/#N", "#/", true);
            var managed_function = new BlockTerminal("ManagedFunction", "/#M", "#/", true);
            var attribute = new BlockTerminal("Attribute", "[", "]");

            // Non Terminals.
            var fbc_rule = new NonTerminal("FBC");
            var access_modifier_rule = new NonTerminal("AccessModifier");
            var reserved_type_rule = new NonTerminal("ReservedType");
            var enum_type_rule = new NonTerminal("EnumType");
            var class_type_rule = new NonTerminal("ClassType");
            var array_type_rule = new NonTerminal("ArrayType");
            var integer_type_rule = new NonTerminal("IntegerType");
            var include_block_rule = new NonTerminal("IncludeBlock");
            var include_rule = new NonTerminal("Include");
            var namespace_block_rule = new NonTerminal("NamespaceBlock");
            var namespace_rule = new NonTerminal("Namespace");
            var namespace_str_rule = new NonTerminal("NamespaceStr");
            var definition_rule = new NonTerminal("Definition");
            var attribute_block_rule = new NonTerminal("AttributeBlock");
            var type_contents_rule = new NonTerminal("TypeContents");
            var type_member_rule = new NonTerminal("TypeMember");
            var type_event_rule = new NonTerminal("TypeEvent");
            var class_block_rule = new NonTerminal("ClassBlock");
            var class_rule = new NonTerminal("Class");
            var class_inheritance_rule = new NonTerminal("ClassInheritance");
            var class_body_rule = new NonTerminal("ClassBody");
            var struct_block_rule = new NonTerminal("StructBlock");
            var struct_rule = new NonTerminal("Struct");
            var struct_body_rule = new NonTerminal("StructBody");
            var enum_block_rule = new NonTerminal("EnumBlock");
            var enum_rule = new NonTerminal("Enum");
            var enum_datatype_rule = new NonTerminal("EnumDatatype");
            var enum_body_rule = new NonTerminal("EnumBody");
            var enum_member_rule = new NonTerminal("EnumMember");
            var enum_first_members_rule = new NonTerminal("EnumFirstMembers");
            var enum_last_member_rule = new NonTerminal("EnumLastMember");
            var enum_member_value_rule = new NonTerminal("EnumMemberValue");
            var enum_terminator_rule = new NonTerminal("EnumTerminator");

            // Grammar rules.
            fbc_rule.Rule = MakeStarRule(fbc_rule, include_block_rule) + namespace_block_rule +
                            MakeStarRule(fbc_rule, definition_rule);


            access_modifier_rule.Rule = ToTerm("public") | "private" | "protected";


            reserved_type_rule.Rule = ToTerm("float") | "double" | "int64" | "uint64" | "int32" | "uint32" | "int16" |
                                      "uint16" | "int8" | "uint8" | "bool" | "blob" | "string" | enum_type_rule |
                                      class_type_rule | array_type_rule | "guid" | "sha1";


            enum_type_rule.Rule = "enum" + identifier;
            class_type_rule.Rule = "class" + identifier;
            array_type_rule.Rule = "array" + identifier;


            integer_type_rule.Rule = ToTerm("int64") | "uint64" | "int32" | "uint32" | "int16" | "uint16" | "int8" | "uint8";


            include_block_rule.Rule = Empty | include_rule;
            include_rule.Rule = "#include" + identifier + ";";


            namespace_block_rule.Rule = Empty | namespace_rule;
            namespace_rule.Rule = "namespace" + namespace_str_rule + ";";
            namespace_str_rule.Rule = identifier | MakeStarRule(namespace_str_rule, ToTerm("::"), identifier);


            definition_rule.Rule = Empty | class_block_rule | struct_block_rule | enum_block_rule;


            attribute_block_rule.Rule = Empty | attribute;


            type_contents_rule.Rule = definition_rule | type_member_rule | type_event_rule | native_function |
                                      managed_function;
            type_member_rule.Rule = MakeStarRule(type_member_rule, attribute_block_rule) + access_modifier_rule +
                                    reserved_type_rule + identifier + ":" + number + ";";
            type_event_rule.Rule = MakeStarRule(type_event_rule, attribute_block_rule) + "event" + identifier + ";";


            class_block_rule.Rule = MakeStarRule(class_block_rule, attribute_block_rule) + class_rule;


            class_rule.Rule = ("class" + identifier + class_body_rule) |
                              ("class" + identifier + class_inheritance_rule + class_body_rule);
            class_inheritance_rule.Rule = (":" + namespace_str_rule) |
                                          (":" + MakeStarRule(class_inheritance_rule, ToTerm(","), namespace_str_rule));
            class_body_rule.Rule = "{" + MakeStarRule(class_body_rule, type_contents_rule) + "}";


            struct_block_rule.Rule = MakeStarRule(struct_block_rule, attribute_block_rule) + struct_rule;


            struct_rule.Rule = "struct" + identifier + struct_body_rule;
            struct_body_rule.Rule = "{" + MakeStarRule(struct_body_rule, type_contents_rule) + "}";


            enum_block_rule.Rule = MakeStarRule(enum_block_rule, type_contents_rule) + enum_rule;


            enum_rule.Rule = "enum" + identifier + enum_datatype_rule + enum_body_rule;
            enum_datatype_rule.Rule = Empty | (":" + integer_type_rule);
            enum_body_rule.Rule = "{" + enum_first_members_rule + enum_last_member_rule + "}";
            enum_member_rule.Rule = MakeStarRule(enum_member_rule, attribute_block_rule) + identifier +
                                    enum_member_value_rule + ",";
            enum_first_members_rule.Rule = Empty | MakeStarRule(enum_first_members_rule, enum_member_rule);
            enum_last_member_rule.Rule = MakeStarRule(enum_last_member_rule, attribute_block_rule) + identifier +
                                         enum_member_value_rule + enum_terminator_rule;
            enum_member_value_rule.Rule = Empty | "=" + number;
            enum_terminator_rule.Rule = Empty | ",";

            // Root rule.
            Root = fbc_rule;

            // Reserved words, punctuation, etc.
            MarkReservedWords("class", "new", "interface", "namespace", "public", "private", "protected", "abstract",
                "this", "ref", "sealed", "break", "for", "do", "if", "while", "foreach", "finally", "true", "false",
                "enum", "struct", "try", "string", "sizeof", "virtual", "static");

            AddToNoReportGroup("{", "}", ";");
            MarkPunctuation("{", "}", ";", "[", "]", "[]");

            RegisterBracePair("{", "}");* /
        }
    }
}
*/
