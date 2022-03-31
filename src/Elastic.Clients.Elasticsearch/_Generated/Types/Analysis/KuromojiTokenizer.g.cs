// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public partial class KuromojiTokenizer : Analysis.TokenizerBase, ITokenizerDefinition
	{
		[JsonInclude]
		[JsonPropertyName("discard_compound_token")]
		public bool? DiscardCompoundToken { get; init; }

		[JsonInclude]
		[JsonPropertyName("discard_punctuation")]
		public bool? DiscardPunctuation { get; init; }

		[JsonInclude]
		[JsonPropertyName("mode")]
		public Elastic.Clients.Elasticsearch.Analysis.KuromojiTokenizationMode Mode { get; init; }

		[JsonInclude]
		[JsonPropertyName("nbest_cost")]
		public int? NbestCost { get; init; }

		[JsonInclude]
		[JsonPropertyName("nbest_examples")]
		public string? NbestExamples { get; init; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "kuromoji_tokenizer";
		[JsonInclude]
		[JsonPropertyName("user_dictionary")]
		public string? UserDictionary { get; init; }

		[JsonInclude]
		[JsonPropertyName("user_dictionary_rules")]
		public IReadOnlyCollection<string>? UserDictionaryRules { get; init; }
	}
}