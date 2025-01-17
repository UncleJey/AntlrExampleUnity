//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Tortoise.g4 by ANTLR 4.11.1

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

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public partial class TortoiseLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		MOV=1, ROT=2, DIR=3, VAL=4, INT=5, NEWLINE=6, WS=7;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"MOV", "ROT", "DIR", "VAL", "INT", "NEWLINE", "WS"
	};


		public TortoiseCompiler Compiler = new TortoiseCompiler();


	public TortoiseLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public TortoiseLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'mov'", "'rot'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "MOV", "ROT", "DIR", "VAL", "INT", "NEWLINE", "WS"
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

	public override string GrammarFileName { get { return "Tortoise.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static TortoiseLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,7,53,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,
		1,0,1,0,1,0,1,0,1,1,1,1,1,1,1,1,1,2,1,2,1,2,1,2,1,2,1,2,3,2,30,8,2,1,3,
		1,3,1,4,3,4,35,8,4,1,4,4,4,38,8,4,11,4,12,4,39,1,5,3,5,43,8,5,1,5,1,5,
		1,6,4,6,48,8,6,11,6,12,6,49,1,6,1,6,0,0,7,1,1,3,2,5,3,7,4,9,5,11,6,13,
		7,1,0,1,3,0,9,10,13,13,32,32,57,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,
		7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,1,15,1,0,0,0,3,19,1,0,
		0,0,5,29,1,0,0,0,7,31,1,0,0,0,9,34,1,0,0,0,11,42,1,0,0,0,13,47,1,0,0,0,
		15,16,5,109,0,0,16,17,5,111,0,0,17,18,5,118,0,0,18,2,1,0,0,0,19,20,5,114,
		0,0,20,21,5,111,0,0,21,22,5,116,0,0,22,4,1,0,0,0,23,24,5,102,0,0,24,25,
		5,119,0,0,25,30,5,100,0,0,26,27,5,98,0,0,27,28,5,119,0,0,28,30,5,100,0,
		0,29,23,1,0,0,0,29,26,1,0,0,0,30,6,1,0,0,0,31,32,3,9,4,0,32,8,1,0,0,0,
		33,35,5,45,0,0,34,33,1,0,0,0,34,35,1,0,0,0,35,37,1,0,0,0,36,38,2,48,57,
		0,37,36,1,0,0,0,38,39,1,0,0,0,39,37,1,0,0,0,39,40,1,0,0,0,40,10,1,0,0,
		0,41,43,5,13,0,0,42,41,1,0,0,0,42,43,1,0,0,0,43,44,1,0,0,0,44,45,5,10,
		0,0,45,12,1,0,0,0,46,48,7,0,0,0,47,46,1,0,0,0,48,49,1,0,0,0,49,47,1,0,
		0,0,49,50,1,0,0,0,50,51,1,0,0,0,51,52,6,6,0,0,52,14,1,0,0,0,6,0,29,34,
		39,42,49,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
