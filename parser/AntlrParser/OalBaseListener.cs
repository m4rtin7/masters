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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IOalListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class OalBaseListener : IOalListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.json"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJson([NotNull] OalParser.JsonContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.json"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJson([NotNull] OalParser.JsonContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.className"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassName([NotNull] OalParser.ClassNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.className"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassName([NotNull] OalParser.ClassNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.instanceName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInstanceName([NotNull] OalParser.InstanceNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.instanceName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInstanceName([NotNull] OalParser.InstanceNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.functionName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionName([NotNull] OalParser.FunctionNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.functionName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionName([NotNull] OalParser.FunctionNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.codeLine"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCodeLine([NotNull] OalParser.CodeLineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.codeLine"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCodeLine([NotNull] OalParser.CodeLineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.instanceCreation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInstanceCreation([NotNull] OalParser.InstanceCreationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.instanceCreation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInstanceCreation([NotNull] OalParser.InstanceCreationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCall([NotNull] OalParser.FunctionCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCall([NotNull] OalParser.FunctionCallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.whileCycle"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileCycle([NotNull] OalParser.WhileCycleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.whileCycle"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileCycle([NotNull] OalParser.WhileCycleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.ifElseCondition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfElseCondition([NotNull] OalParser.IfElseConditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.ifElseCondition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfElseCondition([NotNull] OalParser.IfElseConditionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.elseCondition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElseCondition([NotNull] OalParser.ElseConditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.elseCondition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElseCondition([NotNull] OalParser.ElseConditionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.ifCondition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfCondition([NotNull] OalParser.IfConditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.ifCondition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfCondition([NotNull] OalParser.IfConditionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.forEach"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForEach([NotNull] OalParser.ForEachContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.forEach"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForEach([NotNull] OalParser.ForEachContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.thread"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThread([NotNull] OalParser.ThreadContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.thread"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThread([NotNull] OalParser.ThreadContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.parallel"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParallel([NotNull] OalParser.ParallelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.parallel"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParallel([NotNull] OalParser.ParallelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.object"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject([NotNull] OalParser.ObjectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.object"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject([NotNull] OalParser.ObjectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.objects"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObjects([NotNull] OalParser.ObjectsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.objects"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObjects([NotNull] OalParser.ObjectsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OalParser.params"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParams([NotNull] OalParser.ParamsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OalParser.params"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParams([NotNull] OalParser.ParamsContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
