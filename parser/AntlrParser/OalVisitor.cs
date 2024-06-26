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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="OalParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public interface IOalVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="OalParser.json"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJson([NotNull] OalParser.JsonContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OalParser.className"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassName([NotNull] OalParser.ClassNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OalParser.instanceName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInstanceName([NotNull] OalParser.InstanceNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OalParser.functionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionName([NotNull] OalParser.FunctionNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OalParser.codeLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCodeLine([NotNull] OalParser.CodeLineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OalParser.instanceCreation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInstanceCreation([NotNull] OalParser.InstanceCreationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OalParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] OalParser.FunctionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OalParser.whileCycle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileCycle([NotNull] OalParser.WhileCycleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OalParser.ifElseCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfElseCondition([NotNull] OalParser.IfElseConditionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OalParser.elseCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseCondition([NotNull] OalParser.ElseConditionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OalParser.ifCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfCondition([NotNull] OalParser.IfConditionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OalParser.forEach"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForEach([NotNull] OalParser.ForEachContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OalParser.thread"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitThread([NotNull] OalParser.ThreadContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OalParser.parallel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParallel([NotNull] OalParser.ParallelContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OalParser.element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElement([NotNull] OalParser.ElementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OalParser.elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElements([NotNull] OalParser.ElementsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OalParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParams([NotNull] OalParser.ParamsContext context);
}
