//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/m4rtin7/Desktop/masters/parser/AntlrParser/Oal.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public partial class OalLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, NAME=21, CONDITION=22, OPERANT=23, NUMBER=24, 
		WS=25;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "NAME", "CONDITION", "OPERANT", "WORD", "ESC", 
		"UNICODE", "HEX", "SAFECODEPOINT", "NUMBER", "INT", "EXP", "WS"
	};


	public OalLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public OalLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'create object instance '", "' of '", "';'", "'.'", "'('", "');'", 
		"'();'", "'while '", "'end while;'", "'else if '", "'else'", "'if '", 
		"'end if;'", "'for each '", "' in '", "'end for;'", "'thread'", "'end thread;'", 
		"'par'", "'end par;'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, "NAME", "CONDITION", 
		"OPERANT", "NUMBER", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Oal.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static OalLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,25,295,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,
		1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,1,1,1,1,
		1,1,1,1,1,1,2,1,2,1,3,1,3,1,4,1,4,1,5,1,5,1,5,1,6,1,6,1,6,1,6,1,7,1,7,
		1,7,1,7,1,7,1,7,1,7,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,9,1,
		9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,10,1,10,1,10,1,10,1,10,1,11,1,11,1,11,
		1,11,1,12,1,12,1,12,1,12,1,12,1,12,1,12,1,12,1,13,1,13,1,13,1,13,1,13,
		1,13,1,13,1,13,1,13,1,13,1,14,1,14,1,14,1,14,1,14,1,15,1,15,1,15,1,15,
		1,15,1,15,1,15,1,15,1,15,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,17,1,17,
		1,17,1,17,1,17,1,17,1,17,1,17,1,17,1,17,1,17,1,17,1,18,1,18,1,18,1,18,
		1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,20,1,20,5,20,210,8,20,10,
		20,12,20,213,9,20,1,21,1,21,4,21,217,8,21,11,21,12,21,218,1,21,1,21,1,
		21,1,22,1,22,1,22,1,22,1,22,1,22,1,22,1,22,1,22,3,22,233,8,22,1,23,4,23,
		236,8,23,11,23,12,23,237,1,24,1,24,1,24,3,24,243,8,24,1,25,1,25,1,25,1,
		25,1,25,1,25,1,26,1,26,1,27,1,27,1,28,3,28,256,8,28,1,28,1,28,1,28,4,28,
		261,8,28,11,28,12,28,262,3,28,265,8,28,1,28,3,28,268,8,28,1,29,1,29,1,
		29,5,29,273,8,29,10,29,12,29,276,9,29,3,29,278,8,29,1,30,1,30,3,30,282,
		8,30,1,30,4,30,285,8,30,11,30,12,30,286,1,31,4,31,290,8,31,11,31,12,31,
		291,1,31,1,31,0,0,32,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,
		11,23,12,25,13,27,14,29,15,31,16,33,17,35,18,37,19,39,20,41,21,43,22,45,
		23,47,0,49,0,51,0,53,0,55,0,57,24,59,0,61,0,63,25,1,0,13,4,0,35,35,65,
		90,95,95,97,122,5,0,35,35,48,57,65,90,95,95,97,122,1,0,40,41,2,0,60,60,
		62,62,5,0,33,33,48,57,60,62,65,90,97,122,8,0,34,34,47,47,92,92,98,98,102,
		102,110,110,114,114,116,116,3,0,48,57,65,70,97,102,3,0,0,31,34,34,92,92,
		1,0,48,57,1,0,49,57,2,0,69,69,101,101,2,0,43,43,45,45,3,0,9,10,13,13,32,
		32,304,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,
		1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,
		0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,
		1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,
		0,0,45,1,0,0,0,0,57,1,0,0,0,0,63,1,0,0,0,1,65,1,0,0,0,3,89,1,0,0,0,5,94,
		1,0,0,0,7,96,1,0,0,0,9,98,1,0,0,0,11,100,1,0,0,0,13,103,1,0,0,0,15,107,
		1,0,0,0,17,114,1,0,0,0,19,125,1,0,0,0,21,134,1,0,0,0,23,139,1,0,0,0,25,
		143,1,0,0,0,27,151,1,0,0,0,29,161,1,0,0,0,31,166,1,0,0,0,33,175,1,0,0,
		0,35,182,1,0,0,0,37,194,1,0,0,0,39,198,1,0,0,0,41,207,1,0,0,0,43,214,1,
		0,0,0,45,232,1,0,0,0,47,235,1,0,0,0,49,239,1,0,0,0,51,244,1,0,0,0,53,250,
		1,0,0,0,55,252,1,0,0,0,57,255,1,0,0,0,59,277,1,0,0,0,61,279,1,0,0,0,63,
		289,1,0,0,0,65,66,5,99,0,0,66,67,5,114,0,0,67,68,5,101,0,0,68,69,5,97,
		0,0,69,70,5,116,0,0,70,71,5,101,0,0,71,72,5,32,0,0,72,73,5,111,0,0,73,
		74,5,98,0,0,74,75,5,106,0,0,75,76,5,101,0,0,76,77,5,99,0,0,77,78,5,116,
		0,0,78,79,5,32,0,0,79,80,5,105,0,0,80,81,5,110,0,0,81,82,5,115,0,0,82,
		83,5,116,0,0,83,84,5,97,0,0,84,85,5,110,0,0,85,86,5,99,0,0,86,87,5,101,
		0,0,87,88,5,32,0,0,88,2,1,0,0,0,89,90,5,32,0,0,90,91,5,111,0,0,91,92,5,
		102,0,0,92,93,5,32,0,0,93,4,1,0,0,0,94,95,5,59,0,0,95,6,1,0,0,0,96,97,
		5,46,0,0,97,8,1,0,0,0,98,99,5,40,0,0,99,10,1,0,0,0,100,101,5,41,0,0,101,
		102,5,59,0,0,102,12,1,0,0,0,103,104,5,40,0,0,104,105,5,41,0,0,105,106,
		5,59,0,0,106,14,1,0,0,0,107,108,5,119,0,0,108,109,5,104,0,0,109,110,5,
		105,0,0,110,111,5,108,0,0,111,112,5,101,0,0,112,113,5,32,0,0,113,16,1,
		0,0,0,114,115,5,101,0,0,115,116,5,110,0,0,116,117,5,100,0,0,117,118,5,
		32,0,0,118,119,5,119,0,0,119,120,5,104,0,0,120,121,5,105,0,0,121,122,5,
		108,0,0,122,123,5,101,0,0,123,124,5,59,0,0,124,18,1,0,0,0,125,126,5,101,
		0,0,126,127,5,108,0,0,127,128,5,115,0,0,128,129,5,101,0,0,129,130,5,32,
		0,0,130,131,5,105,0,0,131,132,5,102,0,0,132,133,5,32,0,0,133,20,1,0,0,
		0,134,135,5,101,0,0,135,136,5,108,0,0,136,137,5,115,0,0,137,138,5,101,
		0,0,138,22,1,0,0,0,139,140,5,105,0,0,140,141,5,102,0,0,141,142,5,32,0,
		0,142,24,1,0,0,0,143,144,5,101,0,0,144,145,5,110,0,0,145,146,5,100,0,0,
		146,147,5,32,0,0,147,148,5,105,0,0,148,149,5,102,0,0,149,150,5,59,0,0,
		150,26,1,0,0,0,151,152,5,102,0,0,152,153,5,111,0,0,153,154,5,114,0,0,154,
		155,5,32,0,0,155,156,5,101,0,0,156,157,5,97,0,0,157,158,5,99,0,0,158,159,
		5,104,0,0,159,160,5,32,0,0,160,28,1,0,0,0,161,162,5,32,0,0,162,163,5,105,
		0,0,163,164,5,110,0,0,164,165,5,32,0,0,165,30,1,0,0,0,166,167,5,101,0,
		0,167,168,5,110,0,0,168,169,5,100,0,0,169,170,5,32,0,0,170,171,5,102,0,
		0,171,172,5,111,0,0,172,173,5,114,0,0,173,174,5,59,0,0,174,32,1,0,0,0,
		175,176,5,116,0,0,176,177,5,104,0,0,177,178,5,114,0,0,178,179,5,101,0,
		0,179,180,5,97,0,0,180,181,5,100,0,0,181,34,1,0,0,0,182,183,5,101,0,0,
		183,184,5,110,0,0,184,185,5,100,0,0,185,186,5,32,0,0,186,187,5,116,0,0,
		187,188,5,104,0,0,188,189,5,114,0,0,189,190,5,101,0,0,190,191,5,97,0,0,
		191,192,5,100,0,0,192,193,5,59,0,0,193,36,1,0,0,0,194,195,5,112,0,0,195,
		196,5,97,0,0,196,197,5,114,0,0,197,38,1,0,0,0,198,199,5,101,0,0,199,200,
		5,110,0,0,200,201,5,100,0,0,201,202,5,32,0,0,202,203,5,112,0,0,203,204,
		5,97,0,0,204,205,5,114,0,0,205,206,5,59,0,0,206,40,1,0,0,0,207,211,7,0,
		0,0,208,210,7,1,0,0,209,208,1,0,0,0,210,213,1,0,0,0,211,209,1,0,0,0,211,
		212,1,0,0,0,212,42,1,0,0,0,213,211,1,0,0,0,214,216,5,40,0,0,215,217,8,
		2,0,0,216,215,1,0,0,0,217,218,1,0,0,0,218,216,1,0,0,0,218,219,1,0,0,0,
		219,220,1,0,0,0,220,221,5,41,0,0,221,222,3,63,31,0,222,44,1,0,0,0,223,
		233,7,3,0,0,224,225,5,61,0,0,225,233,5,61,0,0,226,227,5,60,0,0,227,233,
		5,61,0,0,228,229,5,62,0,0,229,233,5,61,0,0,230,231,5,33,0,0,231,233,5,
		61,0,0,232,223,1,0,0,0,232,224,1,0,0,0,232,226,1,0,0,0,232,228,1,0,0,0,
		232,230,1,0,0,0,233,46,1,0,0,0,234,236,7,4,0,0,235,234,1,0,0,0,236,237,
		1,0,0,0,237,235,1,0,0,0,237,238,1,0,0,0,238,48,1,0,0,0,239,242,5,92,0,
		0,240,243,7,5,0,0,241,243,3,51,25,0,242,240,1,0,0,0,242,241,1,0,0,0,243,
		50,1,0,0,0,244,245,5,117,0,0,245,246,3,53,26,0,246,247,3,53,26,0,247,248,
		3,53,26,0,248,249,3,53,26,0,249,52,1,0,0,0,250,251,7,6,0,0,251,54,1,0,
		0,0,252,253,8,7,0,0,253,56,1,0,0,0,254,256,5,45,0,0,255,254,1,0,0,0,255,
		256,1,0,0,0,256,257,1,0,0,0,257,264,3,59,29,0,258,260,5,46,0,0,259,261,
		7,8,0,0,260,259,1,0,0,0,261,262,1,0,0,0,262,260,1,0,0,0,262,263,1,0,0,
		0,263,265,1,0,0,0,264,258,1,0,0,0,264,265,1,0,0,0,265,267,1,0,0,0,266,
		268,3,61,30,0,267,266,1,0,0,0,267,268,1,0,0,0,268,58,1,0,0,0,269,278,5,
		48,0,0,270,274,7,9,0,0,271,273,7,8,0,0,272,271,1,0,0,0,273,276,1,0,0,0,
		274,272,1,0,0,0,274,275,1,0,0,0,275,278,1,0,0,0,276,274,1,0,0,0,277,269,
		1,0,0,0,277,270,1,0,0,0,278,60,1,0,0,0,279,281,7,10,0,0,280,282,7,11,0,
		0,281,280,1,0,0,0,281,282,1,0,0,0,282,284,1,0,0,0,283,285,7,8,0,0,284,
		283,1,0,0,0,285,286,1,0,0,0,286,284,1,0,0,0,286,287,1,0,0,0,287,62,1,0,
		0,0,288,290,7,12,0,0,289,288,1,0,0,0,290,291,1,0,0,0,291,289,1,0,0,0,291,
		292,1,0,0,0,292,293,1,0,0,0,293,294,6,31,0,0,294,64,1,0,0,0,15,0,211,218,
		232,237,242,255,262,264,267,274,277,281,286,291,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
