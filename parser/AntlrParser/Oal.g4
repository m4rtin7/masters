

// Derived from https://json.org
// https://andreabergia.com/blog/2015/02/a-grammar-for-json-with-antlr-v4/

grammar Oal;

json
   : (codeLine)* EOF
   ;
    
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
    | whileCycle
    | ifCondition
    | parallel
    | forEach
    | inicialization
    ;
    
instanceCreation
    : 'create object instance 'instanceName' of 'className';'
    ;
    
functionCall
    : instanceName'.'functionName'('param*');'
    | instanceName'.'functionName'();'
    ;
    
whileCycle
    : 'while ' CONDITION  
    (codeLine)* 
    'end while;'
    ;
    
ifElseCondition
    : 'else if ' CONDITION 
    (codeLine)*
    ;
    
elseCondition
    : 'else' 
    (codeLine)* 
    ;
    
ifCondition
    : 'if ' CONDITION  
    (codeLine)* 
    (ifElseCondition)* 
    (elseCondition)? 
    'end if;'
    ;
    
forEach
    : 'for each ' element ' in 'elements
    (codeLine)*
    'end for;'
    ;
    
thread
    : 'thread'
    (codeLine)*
    'end thread;'
    ;

parallel
    : 'par'
    (thread)*
    'end par;'
    ;
    
inicialization
    : NAME '=' NAME
    | NAME'.'NAME '=' NAME';'
    ;
    
element
    : NAME
    ;
    
elements
    : NAME
    | NAME'.'NAME
    ;
    
param
    : NAME
    | NAME'.'NAME
    | NAME','
    | NAME'.'NAME','
    ;
      
NAME
    :[a-zA-Z_#][a-zA-Z0-9_#]*
    ;
   

CONDITION
    : '('~[()]+')'WS 
    ;
    
OPERANT
    : '<' | '>' | '==' | '<=' | '>=' | '!='
    ;

fragment WORD
    : [a-zA-Z0-9><=!]+
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