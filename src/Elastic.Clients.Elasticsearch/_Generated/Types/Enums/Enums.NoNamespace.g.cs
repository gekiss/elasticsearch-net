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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using Elastic.Transport;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	[JsonConverter(typeof(BoundaryScannerConverter))]
	public enum BoundaryScanner
	{
		Word,
		Sentence,
		Chars
	}

	public class BoundaryScannerConverter : JsonConverter<BoundaryScanner>
	{
		public override BoundaryScanner Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "word":
					return BoundaryScanner.Word;
				case "sentence":
					return BoundaryScanner.Sentence;
				case "chars":
					return BoundaryScanner.Chars;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, BoundaryScanner value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case BoundaryScanner.Word:
					writer.WriteStringValue("word");
					return;
				case BoundaryScanner.Sentence:
					writer.WriteStringValue("sentence");
					return;
				case BoundaryScanner.Chars:
					writer.WriteStringValue("chars");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(DefaultOperatorConverter))]
	public enum DefaultOperator
	{
		Or,
		And
	}

	public class DefaultOperatorConverter : JsonConverter<DefaultOperator>
	{
		public override DefaultOperator Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "OR":
					return DefaultOperator.Or;
				case "AND":
					return DefaultOperator.And;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, DefaultOperator value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case DefaultOperator.Or:
					writer.WriteStringValue("OR");
					return;
				case DefaultOperator.And:
					writer.WriteStringValue("AND");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(DistanceUnitConverter))]
	public enum DistanceUnit
	{
		Yards,
		NauticMiles,
		Millimeters,
		Miles,
		Meters,
		Kilometers,
		Inches,
		Feet,
		Centimeters
	}

	public class DistanceUnitConverter : JsonConverter<DistanceUnit>
	{
		public override DistanceUnit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "yd":
					return DistanceUnit.Yards;
				case "nmi":
					return DistanceUnit.NauticMiles;
				case "mm":
					return DistanceUnit.Millimeters;
				case "mi":
					return DistanceUnit.Miles;
				case "m":
					return DistanceUnit.Meters;
				case "km":
					return DistanceUnit.Kilometers;
				case "in":
					return DistanceUnit.Inches;
				case "ft":
					return DistanceUnit.Feet;
				case "cm":
					return DistanceUnit.Centimeters;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, DistanceUnit value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case DistanceUnit.Yards:
					writer.WriteStringValue("yd");
					return;
				case DistanceUnit.NauticMiles:
					writer.WriteStringValue("nmi");
					return;
				case DistanceUnit.Millimeters:
					writer.WriteStringValue("mm");
					return;
				case DistanceUnit.Miles:
					writer.WriteStringValue("mi");
					return;
				case DistanceUnit.Meters:
					writer.WriteStringValue("m");
					return;
				case DistanceUnit.Kilometers:
					writer.WriteStringValue("km");
					return;
				case DistanceUnit.Inches:
					writer.WriteStringValue("in");
					return;
				case DistanceUnit.Feet:
					writer.WriteStringValue("ft");
					return;
				case DistanceUnit.Centimeters:
					writer.WriteStringValue("cm");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(ExpandWildcardOptionsConverter))]
	public enum ExpandWildcardOptions
	{
		Open,
		None,
		Hidden,
		Closed,
		All
	}

	public class ExpandWildcardOptionsConverter : JsonConverter<ExpandWildcardOptions>
	{
		public override ExpandWildcardOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "open":
					return ExpandWildcardOptions.Open;
				case "none":
					return ExpandWildcardOptions.None;
				case "hidden":
					return ExpandWildcardOptions.Hidden;
				case "closed":
					return ExpandWildcardOptions.Closed;
				case "all":
					return ExpandWildcardOptions.All;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, ExpandWildcardOptions value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case ExpandWildcardOptions.Open:
					writer.WriteStringValue("open");
					return;
				case ExpandWildcardOptions.None:
					writer.WriteStringValue("none");
					return;
				case ExpandWildcardOptions.Hidden:
					writer.WriteStringValue("hidden");
					return;
				case ExpandWildcardOptions.Closed:
					writer.WriteStringValue("closed");
					return;
				case ExpandWildcardOptions.All:
					writer.WriteStringValue("all");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(GeoDistanceTypeConverter))]
	public enum GeoDistanceType
	{
		Plane,
		Arc
	}

	public class GeoDistanceTypeConverter : JsonConverter<GeoDistanceType>
	{
		public override GeoDistanceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "plane":
					return GeoDistanceType.Plane;
				case "arc":
					return GeoDistanceType.Arc;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, GeoDistanceType value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case GeoDistanceType.Plane:
					writer.WriteStringValue("plane");
					return;
				case GeoDistanceType.Arc:
					writer.WriteStringValue("arc");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(HealthConverter))]
	public enum Health
	{
		Yellow,
		Red,
		Green
	}

	public class HealthConverter : JsonConverter<Health>
	{
		public override Health Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "yellow":
					return Health.Yellow;
				case "red":
					return Health.Red;
				case "green":
					return Health.Green;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, Health value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case Health.Yellow:
					writer.WriteStringValue("yellow");
					return;
				case Health.Red:
					writer.WriteStringValue("red");
					return;
				case Health.Green:
					writer.WriteStringValue("green");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(HighlighterEncoderConverter))]
	public enum HighlighterEncoder
	{
		Html,
		Default
	}

	public class HighlighterEncoderConverter : JsonConverter<HighlighterEncoder>
	{
		public override HighlighterEncoder Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "html":
					return HighlighterEncoder.Html;
				case "default":
					return HighlighterEncoder.Default;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, HighlighterEncoder value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case HighlighterEncoder.Html:
					writer.WriteStringValue("html");
					return;
				case HighlighterEncoder.Default:
					writer.WriteStringValue("default");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(HighlighterFragmenterConverter))]
	public enum HighlighterFragmenter
	{
		Span,
		Simple
	}

	public class HighlighterFragmenterConverter : JsonConverter<HighlighterFragmenter>
	{
		public override HighlighterFragmenter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "span":
					return HighlighterFragmenter.Span;
				case "simple":
					return HighlighterFragmenter.Simple;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, HighlighterFragmenter value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case HighlighterFragmenter.Span:
					writer.WriteStringValue("span");
					return;
				case HighlighterFragmenter.Simple:
					writer.WriteStringValue("simple");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(HighlighterOrderConverter))]
	public enum HighlighterOrder
	{
		Score
	}

	public class HighlighterOrderConverter : JsonConverter<HighlighterOrder>
	{
		public override HighlighterOrder Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "score":
					return HighlighterOrder.Score;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, HighlighterOrder value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case HighlighterOrder.Score:
					writer.WriteStringValue("score");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(HighlighterTagsSchemaConverter))]
	public enum HighlighterTagsSchema
	{
		Styled
	}

	public class HighlighterTagsSchemaConverter : JsonConverter<HighlighterTagsSchema>
	{
		public override HighlighterTagsSchema Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "styled":
					return HighlighterTagsSchema.Styled;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, HighlighterTagsSchema value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case HighlighterTagsSchema.Styled:
					writer.WriteStringValue("styled");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(HighlighterTypeConverter))]
	public enum HighlighterType
	{
		Unified,
		Plain,
		Fvh
	}

	public class HighlighterTypeConverter : JsonConverter<HighlighterType>
	{
		public override HighlighterType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "unified":
					return HighlighterType.Unified;
				case "plain":
					return HighlighterType.Plain;
				case "fvh":
					return HighlighterType.Fvh;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, HighlighterType value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case HighlighterType.Unified:
					writer.WriteStringValue("unified");
					return;
				case HighlighterType.Plain:
					writer.WriteStringValue("plain");
					return;
				case HighlighterType.Fvh:
					writer.WriteStringValue("fvh");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(LevelConverter))]
	public enum Level
	{
		Shards,
		Indices,
		Cluster
	}

	public class LevelConverter : JsonConverter<Level>
	{
		public override Level Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "shards":
					return Level.Shards;
				case "indices":
					return Level.Indices;
				case "cluster":
					return Level.Cluster;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, Level value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case Level.Shards:
					writer.WriteStringValue("shards");
					return;
				case Level.Indices:
					writer.WriteStringValue("indices");
					return;
				case Level.Cluster:
					writer.WriteStringValue("cluster");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(ScoreModeConverter))]
	public enum ScoreMode
	{
		Total,
		Multiply,
		Min,
		Max,
		Avg
	}

	public class ScoreModeConverter : JsonConverter<ScoreMode>
	{
		public override ScoreMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "total":
					return ScoreMode.Total;
				case "multiply":
					return ScoreMode.Multiply;
				case "min":
					return ScoreMode.Min;
				case "max":
					return ScoreMode.Max;
				case "avg":
					return ScoreMode.Avg;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, ScoreMode value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case ScoreMode.Total:
					writer.WriteStringValue("total");
					return;
				case ScoreMode.Multiply:
					writer.WriteStringValue("multiply");
					return;
				case ScoreMode.Min:
					writer.WriteStringValue("min");
					return;
				case ScoreMode.Max:
					writer.WriteStringValue("max");
					return;
				case ScoreMode.Avg:
					writer.WriteStringValue("avg");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(ScriptLanguageConverter))]
	public enum ScriptLanguage
	{
		Painless,
		Mustache,
		Java,
		Expression
	}

	public class ScriptLanguageConverter : JsonConverter<ScriptLanguage>
	{
		public override ScriptLanguage Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "painless":
					return ScriptLanguage.Painless;
				case "mustache":
					return ScriptLanguage.Mustache;
				case "java":
					return ScriptLanguage.Java;
				case "expression":
					return ScriptLanguage.Expression;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, ScriptLanguage value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case ScriptLanguage.Painless:
					writer.WriteStringValue("painless");
					return;
				case ScriptLanguage.Mustache:
					writer.WriteStringValue("mustache");
					return;
				case ScriptLanguage.Java:
					writer.WriteStringValue("java");
					return;
				case ScriptLanguage.Expression:
					writer.WriteStringValue("expression");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(SearchTypeConverter))]
	public enum SearchType
	{
		QueryThenFetch,
		DfsQueryThenFetch
	}

	public class SearchTypeConverter : JsonConverter<SearchType>
	{
		public override SearchType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "query_then_fetch":
					return SearchType.QueryThenFetch;
				case "dfs_query_then_fetch":
					return SearchType.DfsQueryThenFetch;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, SearchType value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case SearchType.QueryThenFetch:
					writer.WriteStringValue("query_then_fetch");
					return;
				case SearchType.DfsQueryThenFetch:
					writer.WriteStringValue("dfs_query_then_fetch");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(SortModeConverter))]
	public enum SortMode
	{
		Sum,
		Min,
		Median,
		Max,
		Avg
	}

	public class SortModeConverter : JsonConverter<SortMode>
	{
		public override SortMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "sum":
					return SortMode.Sum;
				case "min":
					return SortMode.Min;
				case "median":
					return SortMode.Median;
				case "max":
					return SortMode.Max;
				case "avg":
					return SortMode.Avg;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, SortMode value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case SortMode.Sum:
					writer.WriteStringValue("sum");
					return;
				case SortMode.Min:
					writer.WriteStringValue("min");
					return;
				case SortMode.Median:
					writer.WriteStringValue("median");
					return;
				case SortMode.Max:
					writer.WriteStringValue("max");
					return;
				case SortMode.Avg:
					writer.WriteStringValue("avg");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(SortOrderConverter))]
	public enum SortOrder
	{
		Desc,
		Asc,
		Document
	}

	public class SortOrderConverter : JsonConverter<SortOrder>
	{
		public override SortOrder Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "desc":
					return SortOrder.Desc;
				case "asc":
					return SortOrder.Asc;
				case "_doc":
					return SortOrder.Document;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, SortOrder value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case SortOrder.Desc:
					writer.WriteStringValue("desc");
					return;
				case SortOrder.Asc:
					writer.WriteStringValue("asc");
					return;
				case SortOrder.Document:
					writer.WriteStringValue("_doc");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(StringDistanceConverter))]
	public enum StringDistance
	{
		Ngram,
		Levenshtein,
		JaroWinkler,
		Internal,
		DamerauLevenshtein
	}

	public class StringDistanceConverter : JsonConverter<StringDistance>
	{
		public override StringDistance Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "ngram":
					return StringDistance.Ngram;
				case "levenshtein":
					return StringDistance.Levenshtein;
				case "jaro_winkler":
					return StringDistance.JaroWinkler;
				case "internal":
					return StringDistance.Internal;
				case "damerau_levenshtein":
					return StringDistance.DamerauLevenshtein;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, StringDistance value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case StringDistance.Ngram:
					writer.WriteStringValue("ngram");
					return;
				case StringDistance.Levenshtein:
					writer.WriteStringValue("levenshtein");
					return;
				case StringDistance.JaroWinkler:
					writer.WriteStringValue("jaro_winkler");
					return;
				case StringDistance.Internal:
					writer.WriteStringValue("internal");
					return;
				case StringDistance.DamerauLevenshtein:
					writer.WriteStringValue("damerau_levenshtein");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(SuggestModeConverter))]
	public enum SuggestMode
	{
		Popular,
		Missing,
		Always
	}

	public class SuggestModeConverter : JsonConverter<SuggestMode>
	{
		public override SuggestMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "popular":
					return SuggestMode.Popular;
				case "missing":
					return SuggestMode.Missing;
				case "always":
					return SuggestMode.Always;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, SuggestMode value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case SuggestMode.Popular:
					writer.WriteStringValue("popular");
					return;
				case SuggestMode.Missing:
					writer.WriteStringValue("missing");
					return;
				case SuggestMode.Always:
					writer.WriteStringValue("always");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(SuggestSortConverter))]
	public enum SuggestSort
	{
		Score,
		Frequency
	}

	public class SuggestSortConverter : JsonConverter<SuggestSort>
	{
		public override SuggestSort Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "score":
					return SuggestSort.Score;
				case "frequency":
					return SuggestSort.Frequency;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, SuggestSort value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case SuggestSort.Score:
					writer.WriteStringValue("score");
					return;
				case SuggestSort.Frequency:
					writer.WriteStringValue("frequency");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(TotalHitsRelationConverter))]
	public enum TotalHitsRelation
	{
		Gte,
		Eq
	}

	public class TotalHitsRelationConverter : JsonConverter<TotalHitsRelation>
	{
		public override TotalHitsRelation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "gte":
					return TotalHitsRelation.Gte;
				case "eq":
					return TotalHitsRelation.Eq;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, TotalHitsRelation value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case TotalHitsRelation.Gte:
					writer.WriteStringValue("gte");
					return;
				case TotalHitsRelation.Eq:
					writer.WriteStringValue("eq");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(VersionTypeConverter))]
	public enum VersionType
	{
		Internal,
		Force,
		ExternalGte,
		External
	}

	public class VersionTypeConverter : JsonConverter<VersionType>
	{
		public override VersionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "internal":
					return VersionType.Internal;
				case "force":
					return VersionType.Force;
				case "external_gte":
					return VersionType.ExternalGte;
				case "external":
					return VersionType.External;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, VersionType value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case VersionType.Internal:
					writer.WriteStringValue("internal");
					return;
				case VersionType.Force:
					writer.WriteStringValue("force");
					return;
				case VersionType.ExternalGte:
					writer.WriteStringValue("external_gte");
					return;
				case VersionType.External:
					writer.WriteStringValue("external");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(WaitForActiveShardOptionsConverter))]
	public enum WaitForActiveShardOptions
	{
		All
	}

	public class WaitForActiveShardOptionsConverter : JsonConverter<WaitForActiveShardOptions>
	{
		public override WaitForActiveShardOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "all":
					return WaitForActiveShardOptions.All;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, WaitForActiveShardOptions value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case WaitForActiveShardOptions.All:
					writer.WriteStringValue("all");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(WaitForEventsConverter))]
	public enum WaitForEvents
	{
		Urgent,
		Normal,
		Low,
		Languid,
		Immediate,
		High
	}

	public class WaitForEventsConverter : JsonConverter<WaitForEvents>
	{
		public override WaitForEvents Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "urgent":
					return WaitForEvents.Urgent;
				case "normal":
					return WaitForEvents.Normal;
				case "low":
					return WaitForEvents.Low;
				case "languid":
					return WaitForEvents.Languid;
				case "immediate":
					return WaitForEvents.Immediate;
				case "high":
					return WaitForEvents.High;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, WaitForEvents value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case WaitForEvents.Urgent:
					writer.WriteStringValue("urgent");
					return;
				case WaitForEvents.Normal:
					writer.WriteStringValue("normal");
					return;
				case WaitForEvents.Low:
					writer.WriteStringValue("low");
					return;
				case WaitForEvents.Languid:
					writer.WriteStringValue("languid");
					return;
				case WaitForEvents.Immediate:
					writer.WriteStringValue("immediate");
					return;
				case WaitForEvents.High:
					writer.WriteStringValue("high");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(WaitForStatusConverter))]
	public enum WaitForStatus
	{
		Yellow,
		Red,
		Green
	}

	public class WaitForStatusConverter : JsonConverter<WaitForStatus>
	{
		public override WaitForStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "yellow":
					return WaitForStatus.Yellow;
				case "red":
					return WaitForStatus.Red;
				case "green":
					return WaitForStatus.Green;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, WaitForStatus value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case WaitForStatus.Yellow:
					writer.WriteStringValue("yellow");
					return;
				case WaitForStatus.Red:
					writer.WriteStringValue("red");
					return;
				case WaitForStatus.Green:
					writer.WriteStringValue("green");
					return;
			}

			writer.WriteNullValue();
		}
	}
}