//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Hess.g4 by ANTLR 4.12.0

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
/// This class provides an empty implementation of <see cref="IHessListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class HessBaseListener : IHessListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="HessParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] HessParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HessParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] HessParser.ProgramContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="HessParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLine([NotNull] HessParser.LineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HessParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLine([NotNull] HessParser.LineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="HessParser.defineBoard"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefineBoard([NotNull] HessParser.DefineBoardContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HessParser.defineBoard"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefineBoard([NotNull] HessParser.DefineBoardContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="HessParser.startGame"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStartGame([NotNull] HessParser.StartGameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HessParser.startGame"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStartGame([NotNull] HessParser.StartGameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="HessParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] HessParser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HessParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] HessParser.AssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="HessParser.moveList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMoveList([NotNull] HessParser.MoveListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HessParser.moveList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMoveList([NotNull] HessParser.MoveListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="HessParser.move"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMove([NotNull] HessParser.MoveContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HessParser.move"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMove([NotNull] HessParser.MoveContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="HessParser.moveExtra"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMoveExtra([NotNull] HessParser.MoveExtraContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HessParser.moveExtra"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMoveExtra([NotNull] HessParser.MoveExtraContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="HessParser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstant([NotNull] HessParser.ConstantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HessParser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstant([NotNull] HessParser.ConstantContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="HessParser.player"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPlayer([NotNull] HessParser.PlayerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HessParser.player"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPlayer([NotNull] HessParser.PlayerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="HessParser.place"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPlace([NotNull] HessParser.PlaceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HessParser.place"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPlace([NotNull] HessParser.PlaceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="HessParser.placeType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPlaceType([NotNull] HessParser.PlaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HessParser.placeType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPlaceType([NotNull] HessParser.PlaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="HessParser.boardpositionlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBoardpositionlist([NotNull] HessParser.BoardpositionlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HessParser.boardpositionlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBoardpositionlist([NotNull] HessParser.BoardpositionlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="HessParser.movetype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMovetype([NotNull] HessParser.MovetypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HessParser.movetype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMovetype([NotNull] HessParser.MovetypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="HessParser.collision"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCollision([NotNull] HessParser.CollisionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HessParser.collision"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCollision([NotNull] HessParser.CollisionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="HessParser.attacktype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttacktype([NotNull] HessParser.AttacktypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HessParser.attacktype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttacktype([NotNull] HessParser.AttacktypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="HessParser.direction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDirection([NotNull] HessParser.DirectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="HessParser.direction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDirection([NotNull] HessParser.DirectionContext context) { }

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
