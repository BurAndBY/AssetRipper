using AssetRipper.Core.Parser.Files;
using ICSharpCode.Decompiler.CSharp;
using System;

namespace AssetRipper.Library.Configuration
{
	public enum ScriptLanguageVersion
	{
		CSharp4 = 4,
		CSharp6 = 6,
		Latest = int.MaxValue
	}

	public static class ScriptLanguageVersionExtensions
	{
		public static LanguageVersion ToCSharpLanguageVersion(this ScriptLanguageVersion scriptLanguageVersion, UnityVersion unityVersion)
		{
			return scriptLanguageVersion switch
			{
				ScriptLanguageVersion.CSharp4 => LanguageVersion.CSharp4,
				ScriptLanguageVersion.CSharp6 => LanguageVersion.CSharp6,
				ScriptLanguageVersion.Latest => LanguageVersion.Latest,
				_ => throw new ArgumentOutOfRangeException(nameof(scriptLanguageVersion), $"{scriptLanguageVersion}"),
			};
		}
	}
}
