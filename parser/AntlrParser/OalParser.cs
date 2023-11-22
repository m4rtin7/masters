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
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public partial class OalParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, NAME=15, STRING=16, STATEMENT=17, 
		OPERANT=18, NUMBER=19, WS=20;
	public const int
		RULE_json = 0, RULE_className = 1, RULE_instanceName = 2, RULE_functionName = 3, 
		RULE_codeLine = 4, RULE_instanceCreation = 5, RULE_functionCall = 6, RULE_whileCycle = 7, 
		RULE_ifElseCondition = 8, RULE_elseCondition = 9, RULE_ifCondition = 10;
	public static readonly string[] ruleNames = {
		"json", "className", "instanceName", "functionName", "codeLine", "instanceCreation", 
		"functionCall", "whileCycle", "ifElseCondition", "elseCondition", "ifCondition"
	};

	private static readonly string[] _LiteralNames = {
		null, "'create object instance '", "' of '", "';'", "'.'", "'();'", "'while ('", 
		"')'", "'end while;'", "'else if ('", "'end else if;'", "'else'", "'end else;'", 
		"'if ('", "'end if;'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, "NAME", "STRING", "STATEMENT", "OPERANT", "NUMBER", 
		"WS"
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

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static OalParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public OalParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public OalParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class JsonContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(OalParser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public CodeLineContext[] codeLine() {
			return GetRuleContexts<CodeLineContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public CodeLineContext codeLine(int i) {
			return GetRuleContext<CodeLineContext>(i);
		}
		public JsonContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_json; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.EnterJson(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.ExitJson(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOalVisitor<TResult> typedVisitor = visitor as IOalVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitJson(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public JsonContext json() {
		JsonContext _localctx = new JsonContext(Context, State);
		EnterRule(_localctx, 0, RULE_json);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 25;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 41026L) != 0)) {
				{
				{
				State = 22;
				codeLine();
				}
				}
				State = 27;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 28;
			Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ClassNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NAME() { return GetToken(OalParser.NAME, 0); }
		public ClassNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_className; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.EnterClassName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.ExitClassName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOalVisitor<TResult> typedVisitor = visitor as IOalVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitClassName(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ClassNameContext className() {
		ClassNameContext _localctx = new ClassNameContext(Context, State);
		EnterRule(_localctx, 2, RULE_className);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 30;
			Match(NAME);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InstanceNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NAME() { return GetToken(OalParser.NAME, 0); }
		public InstanceNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_instanceName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.EnterInstanceName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.ExitInstanceName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOalVisitor<TResult> typedVisitor = visitor as IOalVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInstanceName(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InstanceNameContext instanceName() {
		InstanceNameContext _localctx = new InstanceNameContext(Context, State);
		EnterRule(_localctx, 4, RULE_instanceName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 32;
			Match(NAME);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FunctionNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NAME() { return GetToken(OalParser.NAME, 0); }
		public FunctionNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_functionName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.EnterFunctionName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.ExitFunctionName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOalVisitor<TResult> typedVisitor = visitor as IOalVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFunctionName(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FunctionNameContext functionName() {
		FunctionNameContext _localctx = new FunctionNameContext(Context, State);
		EnterRule(_localctx, 6, RULE_functionName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 34;
			Match(NAME);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CodeLineContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public InstanceCreationContext instanceCreation() {
			return GetRuleContext<InstanceCreationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FunctionCallContext functionCall() {
			return GetRuleContext<FunctionCallContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public WhileCycleContext whileCycle() {
			return GetRuleContext<WhileCycleContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IfConditionContext ifCondition() {
			return GetRuleContext<IfConditionContext>(0);
		}
		public CodeLineContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_codeLine; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.EnterCodeLine(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.ExitCodeLine(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOalVisitor<TResult> typedVisitor = visitor as IOalVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCodeLine(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CodeLineContext codeLine() {
		CodeLineContext _localctx = new CodeLineContext(Context, State);
		EnterRule(_localctx, 8, RULE_codeLine);
		try {
			State = 40;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__0:
				EnterOuterAlt(_localctx, 1);
				{
				State = 36;
				instanceCreation();
				}
				break;
			case NAME:
				EnterOuterAlt(_localctx, 2);
				{
				State = 37;
				functionCall();
				}
				break;
			case T__5:
				EnterOuterAlt(_localctx, 3);
				{
				State = 38;
				whileCycle();
				}
				break;
			case T__12:
				EnterOuterAlt(_localctx, 4);
				{
				State = 39;
				ifCondition();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InstanceCreationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public InstanceNameContext instanceName() {
			return GetRuleContext<InstanceNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassNameContext className() {
			return GetRuleContext<ClassNameContext>(0);
		}
		public InstanceCreationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_instanceCreation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.EnterInstanceCreation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.ExitInstanceCreation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOalVisitor<TResult> typedVisitor = visitor as IOalVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInstanceCreation(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InstanceCreationContext instanceCreation() {
		InstanceCreationContext _localctx = new InstanceCreationContext(Context, State);
		EnterRule(_localctx, 10, RULE_instanceCreation);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 42;
			Match(T__0);
			State = 43;
			instanceName();
			State = 44;
			Match(T__1);
			State = 45;
			className();
			State = 46;
			Match(T__2);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FunctionCallContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public InstanceNameContext instanceName() {
			return GetRuleContext<InstanceNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FunctionNameContext functionName() {
			return GetRuleContext<FunctionNameContext>(0);
		}
		public FunctionCallContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_functionCall; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.EnterFunctionCall(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.ExitFunctionCall(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOalVisitor<TResult> typedVisitor = visitor as IOalVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFunctionCall(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FunctionCallContext functionCall() {
		FunctionCallContext _localctx = new FunctionCallContext(Context, State);
		EnterRule(_localctx, 12, RULE_functionCall);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 48;
			instanceName();
			State = 49;
			Match(T__3);
			State = 50;
			functionName();
			State = 51;
			Match(T__4);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WhileCycleContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATEMENT() { return GetToken(OalParser.STATEMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public CodeLineContext[] codeLine() {
			return GetRuleContexts<CodeLineContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public CodeLineContext codeLine(int i) {
			return GetRuleContext<CodeLineContext>(i);
		}
		public WhileCycleContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_whileCycle; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.EnterWhileCycle(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.ExitWhileCycle(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOalVisitor<TResult> typedVisitor = visitor as IOalVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitWhileCycle(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public WhileCycleContext whileCycle() {
		WhileCycleContext _localctx = new WhileCycleContext(Context, State);
		EnterRule(_localctx, 14, RULE_whileCycle);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 53;
			Match(T__5);
			State = 54;
			Match(STATEMENT);
			State = 55;
			Match(T__6);
			State = 59;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 41026L) != 0)) {
				{
				{
				State = 56;
				codeLine();
				}
				}
				State = 61;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 62;
			Match(T__7);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IfElseConditionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATEMENT() { return GetToken(OalParser.STATEMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public CodeLineContext[] codeLine() {
			return GetRuleContexts<CodeLineContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public CodeLineContext codeLine(int i) {
			return GetRuleContext<CodeLineContext>(i);
		}
		public IfElseConditionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ifElseCondition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.EnterIfElseCondition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.ExitIfElseCondition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOalVisitor<TResult> typedVisitor = visitor as IOalVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIfElseCondition(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IfElseConditionContext ifElseCondition() {
		IfElseConditionContext _localctx = new IfElseConditionContext(Context, State);
		EnterRule(_localctx, 16, RULE_ifElseCondition);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 64;
			Match(T__8);
			State = 65;
			Match(STATEMENT);
			State = 66;
			Match(T__6);
			State = 70;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 41026L) != 0)) {
				{
				{
				State = 67;
				codeLine();
				}
				}
				State = 72;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 73;
			Match(T__9);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ElseConditionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public CodeLineContext[] codeLine() {
			return GetRuleContexts<CodeLineContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public CodeLineContext codeLine(int i) {
			return GetRuleContext<CodeLineContext>(i);
		}
		public ElseConditionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_elseCondition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.EnterElseCondition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.ExitElseCondition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOalVisitor<TResult> typedVisitor = visitor as IOalVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitElseCondition(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ElseConditionContext elseCondition() {
		ElseConditionContext _localctx = new ElseConditionContext(Context, State);
		EnterRule(_localctx, 18, RULE_elseCondition);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 75;
			Match(T__10);
			State = 79;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 41026L) != 0)) {
				{
				{
				State = 76;
				codeLine();
				}
				}
				State = 81;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 82;
			Match(T__11);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IfConditionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATEMENT() { return GetToken(OalParser.STATEMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public CodeLineContext[] codeLine() {
			return GetRuleContexts<CodeLineContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public CodeLineContext codeLine(int i) {
			return GetRuleContext<CodeLineContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IfElseConditionContext[] ifElseCondition() {
			return GetRuleContexts<IfElseConditionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IfElseConditionContext ifElseCondition(int i) {
			return GetRuleContext<IfElseConditionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ElseConditionContext elseCondition() {
			return GetRuleContext<ElseConditionContext>(0);
		}
		public IfConditionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ifCondition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.EnterIfCondition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IOalListener typedListener = listener as IOalListener;
			if (typedListener != null) typedListener.ExitIfCondition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOalVisitor<TResult> typedVisitor = visitor as IOalVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIfCondition(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IfConditionContext ifCondition() {
		IfConditionContext _localctx = new IfConditionContext(Context, State);
		EnterRule(_localctx, 20, RULE_ifCondition);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 84;
			Match(T__12);
			State = 85;
			Match(STATEMENT);
			State = 86;
			Match(T__6);
			State = 90;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 41026L) != 0)) {
				{
				{
				State = 87;
				codeLine();
				}
				}
				State = 92;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 93;
			Match(T__13);
			State = 97;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==T__8) {
				{
				{
				State = 94;
				ifElseCondition();
				}
				}
				State = 99;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 101;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==T__10) {
				{
				State = 100;
				elseCondition();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static int[] _serializedATN = {
		4,1,20,104,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,7,
		7,7,2,8,7,8,2,9,7,9,2,10,7,10,1,0,5,0,24,8,0,10,0,12,0,27,9,0,1,0,1,0,
		1,1,1,1,1,2,1,2,1,3,1,3,1,4,1,4,1,4,1,4,3,4,41,8,4,1,5,1,5,1,5,1,5,1,5,
		1,5,1,6,1,6,1,6,1,6,1,6,1,7,1,7,1,7,1,7,5,7,58,8,7,10,7,12,7,61,9,7,1,
		7,1,7,1,8,1,8,1,8,1,8,5,8,69,8,8,10,8,12,8,72,9,8,1,8,1,8,1,9,1,9,5,9,
		78,8,9,10,9,12,9,81,9,9,1,9,1,9,1,10,1,10,1,10,1,10,5,10,89,8,10,10,10,
		12,10,92,9,10,1,10,1,10,5,10,96,8,10,10,10,12,10,99,9,10,1,10,3,10,102,
		8,10,1,10,0,0,11,0,2,4,6,8,10,12,14,16,18,20,0,0,102,0,25,1,0,0,0,2,30,
		1,0,0,0,4,32,1,0,0,0,6,34,1,0,0,0,8,40,1,0,0,0,10,42,1,0,0,0,12,48,1,0,
		0,0,14,53,1,0,0,0,16,64,1,0,0,0,18,75,1,0,0,0,20,84,1,0,0,0,22,24,3,8,
		4,0,23,22,1,0,0,0,24,27,1,0,0,0,25,23,1,0,0,0,25,26,1,0,0,0,26,28,1,0,
		0,0,27,25,1,0,0,0,28,29,5,0,0,1,29,1,1,0,0,0,30,31,5,15,0,0,31,3,1,0,0,
		0,32,33,5,15,0,0,33,5,1,0,0,0,34,35,5,15,0,0,35,7,1,0,0,0,36,41,3,10,5,
		0,37,41,3,12,6,0,38,41,3,14,7,0,39,41,3,20,10,0,40,36,1,0,0,0,40,37,1,
		0,0,0,40,38,1,0,0,0,40,39,1,0,0,0,41,9,1,0,0,0,42,43,5,1,0,0,43,44,3,4,
		2,0,44,45,5,2,0,0,45,46,3,2,1,0,46,47,5,3,0,0,47,11,1,0,0,0,48,49,3,4,
		2,0,49,50,5,4,0,0,50,51,3,6,3,0,51,52,5,5,0,0,52,13,1,0,0,0,53,54,5,6,
		0,0,54,55,5,17,0,0,55,59,5,7,0,0,56,58,3,8,4,0,57,56,1,0,0,0,58,61,1,0,
		0,0,59,57,1,0,0,0,59,60,1,0,0,0,60,62,1,0,0,0,61,59,1,0,0,0,62,63,5,8,
		0,0,63,15,1,0,0,0,64,65,5,9,0,0,65,66,5,17,0,0,66,70,5,7,0,0,67,69,3,8,
		4,0,68,67,1,0,0,0,69,72,1,0,0,0,70,68,1,0,0,0,70,71,1,0,0,0,71,73,1,0,
		0,0,72,70,1,0,0,0,73,74,5,10,0,0,74,17,1,0,0,0,75,79,5,11,0,0,76,78,3,
		8,4,0,77,76,1,0,0,0,78,81,1,0,0,0,79,77,1,0,0,0,79,80,1,0,0,0,80,82,1,
		0,0,0,81,79,1,0,0,0,82,83,5,12,0,0,83,19,1,0,0,0,84,85,5,13,0,0,85,86,
		5,17,0,0,86,90,5,7,0,0,87,89,3,8,4,0,88,87,1,0,0,0,89,92,1,0,0,0,90,88,
		1,0,0,0,90,91,1,0,0,0,91,93,1,0,0,0,92,90,1,0,0,0,93,97,5,14,0,0,94,96,
		3,16,8,0,95,94,1,0,0,0,96,99,1,0,0,0,97,95,1,0,0,0,97,98,1,0,0,0,98,101,
		1,0,0,0,99,97,1,0,0,0,100,102,3,18,9,0,101,100,1,0,0,0,101,102,1,0,0,0,
		102,21,1,0,0,0,8,25,40,59,70,79,90,97,101
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
