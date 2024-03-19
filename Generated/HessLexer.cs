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

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public partial class HessLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, BOARDPOSITION=21, IDENTIFIER=22, NATURAL_NUMBER=23, 
		CAP_LETTER=24, WS=25;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "BOARDPOSITION", "IDENTIFIER", "NATURAL_NUMBER", 
		"CAP_LETTER", "WS"
	};


	public HessLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public HessLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "'BOARD('", "')'", "'STARTGAME('", "','", "'='", "'{'", "'}'", 
		"'PLACE('", "'Direct'", "'Path'", "'true'", "'false'", "'ATTACK'", "'MOVE'", 
		"'ATKMOVE'", "'UP'", "'LEFT'", "'RIGHT'", "'DOWN'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, "BOARDPOSITION", 
		"IDENTIFIER", "NATURAL_NUMBER", "CAP_LETTER", "WS"
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

	public override string GrammarFileName { get { return "Hess.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static HessLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,25,181,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
		1,2,1,2,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,4,1,4,1,5,1,5,1,
		6,1,6,1,7,1,7,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,9,1,9,1,9,1,9,1,9,1,9,1,9,
		1,10,1,10,1,10,1,10,1,10,1,11,1,11,1,11,1,11,1,11,1,12,1,12,1,12,1,12,
		1,12,1,12,1,13,1,13,1,13,1,13,1,13,1,13,1,13,1,14,1,14,1,14,1,14,1,14,
		1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,16,1,16,1,16,1,17,1,17,1,17,
		1,17,1,17,1,18,1,18,1,18,1,18,1,18,1,18,1,19,1,19,1,19,1,19,1,19,1,20,
		1,20,1,20,5,20,154,8,20,10,20,12,20,157,9,20,1,21,1,21,5,21,161,8,21,10,
		21,12,21,164,9,21,1,22,1,22,5,22,168,8,22,10,22,12,22,171,9,22,1,23,1,
		23,1,24,4,24,176,8,24,11,24,12,24,177,1,24,1,24,0,0,25,1,1,3,2,5,3,7,4,
		9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,15,31,16,33,17,
		35,18,37,19,39,20,41,21,43,22,45,23,47,24,49,25,1,0,6,1,0,49,57,1,0,48,
		57,3,0,65,90,95,95,97,122,4,0,48,57,65,90,95,95,97,122,1,0,65,90,3,0,9,
		10,13,13,32,32,184,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,
		1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,
		0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,
		1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,
		0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,1,51,1,0,0,0,3,53,
		1,0,0,0,5,60,1,0,0,0,7,62,1,0,0,0,9,73,1,0,0,0,11,75,1,0,0,0,13,77,1,0,
		0,0,15,79,1,0,0,0,17,81,1,0,0,0,19,88,1,0,0,0,21,95,1,0,0,0,23,100,1,0,
		0,0,25,105,1,0,0,0,27,111,1,0,0,0,29,118,1,0,0,0,31,123,1,0,0,0,33,131,
		1,0,0,0,35,134,1,0,0,0,37,139,1,0,0,0,39,145,1,0,0,0,41,150,1,0,0,0,43,
		158,1,0,0,0,45,165,1,0,0,0,47,172,1,0,0,0,49,175,1,0,0,0,51,52,5,59,0,
		0,52,2,1,0,0,0,53,54,5,66,0,0,54,55,5,79,0,0,55,56,5,65,0,0,56,57,5,82,
		0,0,57,58,5,68,0,0,58,59,5,40,0,0,59,4,1,0,0,0,60,61,5,41,0,0,61,6,1,0,
		0,0,62,63,5,83,0,0,63,64,5,84,0,0,64,65,5,65,0,0,65,66,5,82,0,0,66,67,
		5,84,0,0,67,68,5,71,0,0,68,69,5,65,0,0,69,70,5,77,0,0,70,71,5,69,0,0,71,
		72,5,40,0,0,72,8,1,0,0,0,73,74,5,44,0,0,74,10,1,0,0,0,75,76,5,61,0,0,76,
		12,1,0,0,0,77,78,5,123,0,0,78,14,1,0,0,0,79,80,5,125,0,0,80,16,1,0,0,0,
		81,82,5,80,0,0,82,83,5,76,0,0,83,84,5,65,0,0,84,85,5,67,0,0,85,86,5,69,
		0,0,86,87,5,40,0,0,87,18,1,0,0,0,88,89,5,68,0,0,89,90,5,105,0,0,90,91,
		5,114,0,0,91,92,5,101,0,0,92,93,5,99,0,0,93,94,5,116,0,0,94,20,1,0,0,0,
		95,96,5,80,0,0,96,97,5,97,0,0,97,98,5,116,0,0,98,99,5,104,0,0,99,22,1,
		0,0,0,100,101,5,116,0,0,101,102,5,114,0,0,102,103,5,117,0,0,103,104,5,
		101,0,0,104,24,1,0,0,0,105,106,5,102,0,0,106,107,5,97,0,0,107,108,5,108,
		0,0,108,109,5,115,0,0,109,110,5,101,0,0,110,26,1,0,0,0,111,112,5,65,0,
		0,112,113,5,84,0,0,113,114,5,84,0,0,114,115,5,65,0,0,115,116,5,67,0,0,
		116,117,5,75,0,0,117,28,1,0,0,0,118,119,5,77,0,0,119,120,5,79,0,0,120,
		121,5,86,0,0,121,122,5,69,0,0,122,30,1,0,0,0,123,124,5,65,0,0,124,125,
		5,84,0,0,125,126,5,75,0,0,126,127,5,77,0,0,127,128,5,79,0,0,128,129,5,
		86,0,0,129,130,5,69,0,0,130,32,1,0,0,0,131,132,5,85,0,0,132,133,5,80,0,
		0,133,34,1,0,0,0,134,135,5,76,0,0,135,136,5,69,0,0,136,137,5,70,0,0,137,
		138,5,84,0,0,138,36,1,0,0,0,139,140,5,82,0,0,140,141,5,73,0,0,141,142,
		5,71,0,0,142,143,5,72,0,0,143,144,5,84,0,0,144,38,1,0,0,0,145,146,5,68,
		0,0,146,147,5,79,0,0,147,148,5,87,0,0,148,149,5,78,0,0,149,40,1,0,0,0,
		150,151,3,47,23,0,151,155,7,0,0,0,152,154,7,1,0,0,153,152,1,0,0,0,154,
		157,1,0,0,0,155,153,1,0,0,0,155,156,1,0,0,0,156,42,1,0,0,0,157,155,1,0,
		0,0,158,162,7,2,0,0,159,161,7,3,0,0,160,159,1,0,0,0,161,164,1,0,0,0,162,
		160,1,0,0,0,162,163,1,0,0,0,163,44,1,0,0,0,164,162,1,0,0,0,165,169,7,0,
		0,0,166,168,7,1,0,0,167,166,1,0,0,0,168,171,1,0,0,0,169,167,1,0,0,0,169,
		170,1,0,0,0,170,46,1,0,0,0,171,169,1,0,0,0,172,173,7,4,0,0,173,48,1,0,
		0,0,174,176,7,5,0,0,175,174,1,0,0,0,176,177,1,0,0,0,177,175,1,0,0,0,177,
		178,1,0,0,0,178,179,1,0,0,0,179,180,6,24,0,0,180,50,1,0,0,0,5,0,155,162,
		169,177,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
