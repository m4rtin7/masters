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

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="OalParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public interface IOalListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.json"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJson([NotNull] OalParser.JsonContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.json"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJson([NotNull] OalParser.JsonContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.className"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassName([NotNull] OalParser.ClassNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.className"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassName([NotNull] OalParser.ClassNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.instanceName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstanceName([NotNull] OalParser.InstanceNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.instanceName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstanceName([NotNull] OalParser.InstanceNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.functionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionName([NotNull] OalParser.FunctionNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.functionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionName([NotNull] OalParser.FunctionNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.codeLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCodeLine([NotNull] OalParser.CodeLineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.codeLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCodeLine([NotNull] OalParser.CodeLineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.instanceCreation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstanceCreation([NotNull] OalParser.InstanceCreationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.instanceCreation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstanceCreation([NotNull] OalParser.InstanceCreationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] OalParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] OalParser.FunctionCallContext context);
}
