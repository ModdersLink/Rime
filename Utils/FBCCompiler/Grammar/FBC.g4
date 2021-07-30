grammar FBC;

/* Parser Rules */

fbc
	: includeBlock namespaceBlock EOF
	| includeBlock (definition*) EOF
	;

accessModifier
	: PUBLIC
	| PRIVATE
	| PROTECTED
	;

memberType
	: FLOAT
	| DOUBLE
	| BOOL
	| STRING
	| GUID
	| SHA1
	| INT64
	| UINT64
	| INT32
	| UINT32
	| INT16
	| UINT16
	| INT8
	| UINT8
	| namespaceString
	;

integerType
	: INT64
	| UINT64
	| INT32
	| UINT32
	| INT16
	| UINT16
	| INT8
	| UINT8
	;

fileInclude
	: INCLUDE ANGLE_STRING
	;

includeBlock
	:
	| fileInclude*
	| SINGLE_LINE_COMMENT
	| DELIMITED_COMMENT
	;

namespaceBlock
	: namespace (definition*)
	| SINGLE_LINE_COMMENT
	| DELIMITED_COMMENT
	;

namespace
	: NAMESPACE namespaceString SEMICOLON
	;

namespaceString
	: IDENTIFIER
	| IDENTIFIER (DOUBLECOLON IDENTIFIER)*
	;

definition
	: classBlock
	| structBlock
	| enumBlock
	| SINGLE_LINE_COMMENT
	| DELIMITED_COMMENT
	;

attributeParam
	: INTEGER
	| DASH INTEGER
	| FLOAT_NUMBER
	| DASH FLOAT_NUMBER
	| TRUE
	| FALSE
	| QUOTED_STRING
	;

attribute
	: IDENTIFIER
	| IDENTIFIER LPAREN attributeParam (COMMA attributeParam)* RPAREN
	;

attributeBlock
	: LBRACKET attribute (COMMA attribute)* RBRACKET
	;

typeContents
	: typeMember
	| typeEvent
	| typeNativeFunction
	| typeManagedFunction
	| SINGLE_LINE_COMMENT
	| DELIMITED_COMMENT
	;

arrayModifier
	: LBRACKET RBRACKET
	;

// TODO: Add support for default values
typeMember
	: attributeBlock* accessModifier memberType arrayModifier? IDENTIFIER COLON INTEGER SEMICOLON
	;

typeEvent
	: attributeBlock* EVENT IDENTIFIER SEMICOLON
	;

// TODO
typeNativeFunction
	: NATIVE_START BLOCK_END
	;

// TODO
typeManagedFunction
	: MANAGED_START BLOCK_END
	;

blockBody
	: LBRACE (typeContents*) RBRACE
	;

classBlock
	: attributeBlock* CLASS typeAlignment? IDENTIFIER classInheritance? blockBody
	;

classInheritance
	: COLON namespaceString
	| COLON namespaceString (COMMA namespaceString)*
	;

structBlock
	: attributeBlock* STRUCT typeAlignment? IDENTIFIER blockBody
	;

enumBlock
	: attributeBlock* ENUM IDENTIFIER enumDataType? enumBody
	;

enumDataType
	: COLON integerType
	;

enumBody
	: LBRACE enumValue* enumLastMember RBRACE
    | LBRACE RBRACE
	;

enumValue
	: attributeBlock* IDENTIFIER enumMemberValue? COMMA
	;

enumLastMember
	: attributeBlock* IDENTIFIER enumMemberValue? enumTerminator
	;

enumMemberValue
	: EQUALS INTEGER
    | EQUALS DASH INTEGER
	;

enumTerminator
	:
	| COMMA
	;

typeAlignment
	: ALIGN LPAREN INTEGER RPAREN
	;

/* Lexer Rules */

PUBLIC : 'public' ;
PRIVATE : 'private' ;
PROTECTED : 'protected' ;

FLOAT : 'float' ;
DOUBLE : 'double' ;
INT64 : 'int64' ;
UINT64 : 'uint64' ;
INT32 : 'int32' ;
UINT32 : 'uint32' ;
INT16 : 'int16' ;
UINT16 : 'uint16' ;
INT8 : 'int8' ;
UINT8 : 'uint8' ;
BOOL : 'bool' ;
STRING : 'string' ;
GUID : 'guid' ;
SHA1 : 'sha1' ;

TRUE : 'true' ;
FALSE : 'false' ;

CLASS_MEMBER : 'class_member' ;
ENUM_MEMBER : 'enum_member' ;
STRUCT_MEMBER : 'struct_member' ;
ARRAY : 'array' ;

LBRACKET : '[' ;
RBRACKET : ']' ;
LBRACE : '{' ;
RBRACE : '}' ;
LPAREN : '(' ;
RPAREN : ')' ;

NATIVE_START : '/#N' ;
MANAGED_START : '/#M' ;
BLOCK_END : '#/' ;

NAMESPACE : 'namespace' ;
CLASS : 'class' ;
ENUM : 'enum' ;
STRUCT : 'struct' ;
EVENT : 'event' ;
INCLUDE : '#include' ;
ALIGN : 'align' ;

DOT : '.' ;
COMMA : ',' ;
COLON : ':' ;
SEMICOLON : ';' ;
DOUBLECOLON : '::' ;
EQUALS : '=' ;
DASH : '-' ;

IDENTIFIER
	: Identifier_start_character Identifier_part_character*
	;

fragment Identifier_start_character
	: [a-zA-Z_]
	;

fragment Identifier_part_character
	: [a-zA-Z0-9_]
	;

fragment RealNumber
	: [0-9]
	;

FLOAT_NUMBER
	: RealNumber DOT RealNumber+
	| DASH RealNumber DOT RealNumber+
	;

INTEGER
	: [0-9]+
	| '0x' Hex_digits
	;

SINGLE_LINE_COMMENT
	: ('//' Input_character*) -> channel(HIDDEN)
	;

fragment Input_characters
	: Input_character+
	;

fragment Input_character
	: ~([\u000D\u000A\u0085\u2028\u2029]) //'<Any Unicode Character Except A NEW_LINE_CHARACTER>'
	;

fragment NEW_LINE_CHARACTER
	: '\u000D' //'<Carriage Return Character (U+000D)>'
	| '\u000A' //'<Line Feed Character (U+000A)>'
	| '\u0085' //'<Next Line Character (U+0085)>'
	| '\u2028' //'<Line Separator Character (U+2028)>'
	| '\u2029' //'<Paragraph Separator Character (U+2029)>'
	;

DELIMITED_COMMENT
	: ('/*' Delimited_comment_section* Asterisks '/') -> channel(HIDDEN)
	;

fragment Delimited_comment_section
	: '/'
	| Asterisks? Not_slash_or_asterisk
	;

fragment Asterisks
	: '*'+
	;

fragment Not_slash_or_asterisk
	: ~( '/' | '*' )
	;

WHITESPACE
	: (Whitespace_characters) -> channel(HIDDEN)
	;

fragment Whitespace_characters
	: Whitespace_character+
	;

fragment Whitespace_character
	: UNICODE_CLASS_ZS //'<Any Character With Unicode Class Zs>'
	| '\u0009' //'<Horizontal Tab Character (U+0009)>'
	| '\u000B' //'<Vertical Tab Character (U+000B)>'
	| '\u000C' //'<Form Feed Character (U+000C)>'
	;

fragment Unicode_escape_sequence
	: '\\u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
	| '\\U' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
	;

fragment UNICODE_CLASS_ZS
	: '\u0020' // SPACE
	| '\u00A0' // NO_BREAK SPACE
	| '\u1680' // OGHAM SPACE MARK
	| '\u180E' // MONGOLIAN VOWEL SEPARATOR
	| '\u2000' // EN QUAD
	| '\u2001' // EM QUAD
	| '\u2002' // EN SPACE
	| '\u2003' // EM SPACE
	| '\u2004' // THREE_PER_EM SPACE
	| '\u2005' // FOUR_PER_EM SPACE
	| '\u2006' // SIX_PER_EM SPACE
	| '\u2008' // PUNCTUATION SPACE
	| '\u2009' // THIN SPACE
	| '\u200A' // HAIR SPACE
	| '\u202F' // NARROW NO_BREAK SPACE
	| '\u3000' // IDEOGRAPHIC SPACE
	| '\u205F' // MEDIUM MATHEMATICAL SPACE
	;

fragment Hex_digits
	: HEX_DIGIT+
	;

fragment HEX_DIGIT
	: '0'..'9'
	| 'A'..'F'
	| 'a'..'f'
	;

ANGLE_STRING
    : '<' .*? '>'
    ;

QUOTED_STRING 
	: '"' (~[\\"] | '\\' [\\"])* '"'
	;

WS
	: [ \r\t\n]+ -> skip ;