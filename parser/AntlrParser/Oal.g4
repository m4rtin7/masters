

// Derived from https://json.org
// https://andreabergia.com/blog/2015/02/a-grammar-for-json-with-antlr-v4/

grammar Oal;

json
   : (codeLine)* EOF
   ;

//obj
//   : '{' pair (',' pair)* '}'
//   | '{' '}'
//   ;
//
//pair
//   : STRING ':' value
//   | name
//   | code
//   | animationName
//   | methods
//   ;
//   
//methods
//    : '"Methods"' ':' arr
//    ;
//   
//animationName
//    : '"AnimationName"' ':' STRING
//    ;
//
//code
//    : '"Code"' ':' (codeLine)+
//    ;
    
className
    : NAME
    ;
    
instanceName
    : NAME
    ;

functionName
    : NAME
    ;

codeLine
    : instanceCreation
    | functionCall
    ;
    
instanceCreation
    : 'create object instance ' instanceName ' of ' className ';'
    ;
    
functionCall
    : instanceName'.'functionName'();'
    ;
    

//arr
//   : '[' value (',' value)* ']'
//   | '[' ']'
//   ;
//
//value
//   : STRING
//   | obj
//   | arr
//   ;

//name 
//    : '"Name"' ':' value
//    ;
    
//xmiId 
//    : '"XmiId"' ':' value
//    ;
//    
//xmiIdRef 
//    : '"XmiIdRef"' ':' value
//    ;
//
//lifeline
//    : STRING ':' '"uml:Lifeline"'
//    ;
//    
//message
//    : STRING ':' '"uml:Message"'
//    ;
//
//occurenceSpecification
//    : STRING ':' '"uml:OccurrenceSpecification"'
//    ;
//   
//covered
//    : '"covered"' ':' value
//    ;
//    
//receiveEvent
//    : '"receiveEvent"' ':' value
//    ;
//    
//sendEvent
//    : '"sendEvent"' ':' value
//    ;

//NAME
//   : '"'~('"')*':name"'
//   ;

NAME
    :   [a-zA-Z_#][a-zA-Z0-9_#]*
    ;
    
STRING
   : '"' (ESC | SAFECODEPOINT)* '"'
   ;

fragment ESC
   : '\\' (["\\/bfnrt] | UNICODE)
   ;


fragment UNICODE
   : 'u' HEX HEX HEX HEX
   ;


fragment HEX
   : [0-9a-fA-F]
   ;


fragment SAFECODEPOINT
   : ~ ["\\\u0000-\u001F]
   ;


NUMBER
   : '-'? INT ('.' [0-9] +)? EXP?
   ;


fragment INT
   // integer part forbis leading 0s (e.g. `01`)
   : '0' | [1-9] [0-9]*
   ;

// no leading zeros

fragment EXP
   // exponent number permits leading 0s (e.g. `1e01`)
   : [Ee] [+\-]? [0-9]+
   ;

// \- since - means "range" inside [...]

WS
   : [ \t\n\r] + -> skip
   ;