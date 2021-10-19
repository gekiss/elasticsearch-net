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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public class SearchRequestParameters : RequestParameters<SearchRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public bool? AllowPartialSearchResults { get => Q<bool?>("allow_partial_search_results"); set => Q("allow_partial_search_results", value); }

		[JsonIgnore]
		public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

		[JsonIgnore]
		public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

		[JsonIgnore]
		public object? BatchedReduceSize { get => Q<object?>("batched_reduce_size"); set => Q("batched_reduce_size", value); }

		[JsonIgnore]
		public bool? CcsMinimizeRoundtrips { get => Q<bool?>("ccs_minimize_roundtrips"); set => Q("ccs_minimize_roundtrips", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.DefaultOperator? DefaultOperator { get => Q<Elastic.Clients.Elasticsearch.DefaultOperator?>("default_operator"); set => Q("default_operator", value); }

		[JsonIgnore]
		public string? Df { get => Q<string?>("df"); set => Q("df", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? DocvalueFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("docvalue_fields"); set => Q("docvalue_fields", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? Explain { get => Q<bool?>("explain"); set => Q("explain", value); }

		[JsonIgnore]
		public bool? IgnoreThrottled { get => Q<bool?>("ignore_throttled"); set => Q("ignore_throttled", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

		[JsonIgnore]
		public object? MaxConcurrentShardRequests { get => Q<object?>("max_concurrent_shard_requests"); set => Q("max_concurrent_shard_requests", value); }

		[JsonIgnore]
		public string? MinCompatibleShardNode { get => Q<string?>("min_compatible_shard_node"); set => Q("min_compatible_shard_node", value); }

		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public object? PreFilterShardSize { get => Q<object?>("pre_filter_shard_size"); set => Q("pre_filter_shard_size", value); }

		[JsonIgnore]
		public bool? RequestCache { get => Q<bool?>("request_cache"); set => Q("request_cache", value); }

		[JsonIgnore]
		public string? Routing { get => Q<string?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Scroll { get => Q<Elastic.Clients.Elasticsearch.Time?>("scroll"); set => Q("scroll", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.SearchType? SearchType { get => Q<Elastic.Clients.Elasticsearch.SearchType?>("search_type"); set => Q("search_type", value); }

		[JsonIgnore]
		public IEnumerable<string>? Stats { get => Q<IEnumerable<string>?>("stats"); set => Q("stats", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? StoredFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("stored_fields"); set => Q("stored_fields", value); }

		[JsonIgnore]
		public string? SuggestField { get => Q<string?>("suggest_field"); set => Q("suggest_field", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.SuggestMode? SuggestMode { get => Q<Elastic.Clients.Elasticsearch.SuggestMode?>("suggest_mode"); set => Q("suggest_mode", value); }

		[JsonIgnore]
		public object? SuggestSize { get => Q<object?>("suggest_size"); set => Q("suggest_size", value); }

		[JsonIgnore]
		public string? SuggestText { get => Q<string?>("suggest_text"); set => Q("suggest_text", value); }

		[JsonIgnore]
		public object? TerminateAfter { get => Q<object?>("terminate_after"); set => Q("terminate_after", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Union<bool?, int?>? TrackTotalHits { get => Q<Union<bool?, int?>?>("track_total_hits"); set => Q("track_total_hits", value); }

		[JsonIgnore]
		public bool? TrackScores { get => Q<bool?>("track_scores"); set => Q("track_scores", value); }

		[JsonIgnore]
		public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }

		[JsonIgnore]
		public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

		[JsonIgnore]
		public bool? Version { get => Q<bool?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Union<bool?, Elastic.Clients.Elasticsearch.Fields?>? Source { get => Q<Union<bool?, Elastic.Clients.Elasticsearch.Fields?>?>("_source"); set => Q("_source", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_includes"); set => Q("_source_includes", value); }

		[JsonIgnore]
		public bool? SeqNoPrimaryTerm { get => Q<bool?>("seq_no_primary_term"); set => Q("seq_no_primary_term", value); }

		[JsonIgnore]
		public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }

		[JsonIgnore]
		public int? Size { get => Q<int?>("size"); set => Q("size", value); }

		[JsonIgnore]
		public int? From { get => Q<int?>("from"); set => Q("from", value); }

		[JsonIgnore]
		public IEnumerable<string>? Sort { get => Q<IEnumerable<string>?>("sort"); set => Q("sort", value); }
	}

	[InterfaceConverterAttribute(typeof(SearchRequestDescriptorConverter<SearchRequest>))]
	public partial interface ISearchRequest : IRequest<SearchRequestParameters>
	{
		Dictionary<string, Aggregations.IAggregationContainer>? Aggs { get; set; }

		Dictionary<string, Aggregations.IAggregationContainer>? Aggregations { get; set; }

		IFieldCollapse? Collapse { get; set; }

		IHighlight? Highlight { get; set; }

		IEnumerable<Dictionary<Elastic.Clients.Elasticsearch.IndexName, double>>? IndicesBoost { get; set; }

		double? MinScore { get; set; }

		QueryDsl.IQueryContainer? PostFilter { get; set; }

		bool? Profile { get; set; }

		QueryDsl.IQueryContainer? Query { get; set; }

		IEnumerable<IRescore>? Rescore { get; set; }

		Dictionary<string, IScriptField>? ScriptFields { get; set; }

		IEnumerable<object>? SearchAfter { get; set; }

		ISlicedScroll? Slice { get; set; }

		IEnumerable<Union<string?, IDateField?>>? Fields { get; set; }

		Union<ISuggestContainer?, Dictionary<string, ISuggestContainer>?>? Suggest { get; set; }

		IPointInTimeReference? Pit { get; set; }

		Dictionary<string, Mapping.IRuntimeField>? RuntimeMappings { get; set; }
	}

	public partial class SearchRequest : PlainRequestBase<SearchRequestParameters>, ISearchRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceSearch;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public bool? AllowPartialSearchResults { get => Q<bool?>("allow_partial_search_results"); set => Q("allow_partial_search_results", value); }

		[JsonIgnore]
		public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

		[JsonIgnore]
		public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

		[JsonIgnore]
		public object? BatchedReduceSize { get => Q<object?>("batched_reduce_size"); set => Q("batched_reduce_size", value); }

		[JsonIgnore]
		public bool? CcsMinimizeRoundtrips { get => Q<bool?>("ccs_minimize_roundtrips"); set => Q("ccs_minimize_roundtrips", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.DefaultOperator? DefaultOperator { get => Q<Elastic.Clients.Elasticsearch.DefaultOperator?>("default_operator"); set => Q("default_operator", value); }

		[JsonIgnore]
		public string? Df { get => Q<string?>("df"); set => Q("df", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? DocvalueFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("docvalue_fields"); set => Q("docvalue_fields", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? Explain { get => Q<bool?>("explain"); set => Q("explain", value); }

		[JsonIgnore]
		public bool? IgnoreThrottled { get => Q<bool?>("ignore_throttled"); set => Q("ignore_throttled", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

		[JsonIgnore]
		public object? MaxConcurrentShardRequests { get => Q<object?>("max_concurrent_shard_requests"); set => Q("max_concurrent_shard_requests", value); }

		[JsonIgnore]
		public string? MinCompatibleShardNode { get => Q<string?>("min_compatible_shard_node"); set => Q("min_compatible_shard_node", value); }

		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public object? PreFilterShardSize { get => Q<object?>("pre_filter_shard_size"); set => Q("pre_filter_shard_size", value); }

		[JsonIgnore]
		public bool? RequestCache { get => Q<bool?>("request_cache"); set => Q("request_cache", value); }

		[JsonIgnore]
		public string? Routing { get => Q<string?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Scroll { get => Q<Elastic.Clients.Elasticsearch.Time?>("scroll"); set => Q("scroll", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.SearchType? SearchType { get => Q<Elastic.Clients.Elasticsearch.SearchType?>("search_type"); set => Q("search_type", value); }

		[JsonIgnore]
		public IEnumerable<string>? Stats { get => Q<IEnumerable<string>?>("stats"); set => Q("stats", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? StoredFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("stored_fields"); set => Q("stored_fields", value); }

		[JsonIgnore]
		public string? SuggestField { get => Q<string?>("suggest_field"); set => Q("suggest_field", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.SuggestMode? SuggestMode { get => Q<Elastic.Clients.Elasticsearch.SuggestMode?>("suggest_mode"); set => Q("suggest_mode", value); }

		[JsonIgnore]
		public object? SuggestSize { get => Q<object?>("suggest_size"); set => Q("suggest_size", value); }

		[JsonIgnore]
		public string? SuggestText { get => Q<string?>("suggest_text"); set => Q("suggest_text", value); }

		[JsonIgnore]
		public object? TerminateAfter { get => Q<object?>("terminate_after"); set => Q("terminate_after", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Union<bool?, int?>? TrackTotalHits { get => Q<Union<bool?, int?>?>("track_total_hits"); set => Q("track_total_hits", value); }

		[JsonIgnore]
		public bool? TrackScores { get => Q<bool?>("track_scores"); set => Q("track_scores", value); }

		[JsonIgnore]
		public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }

		[JsonIgnore]
		public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

		[JsonIgnore]
		public bool? Version { get => Q<bool?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Union<bool?, Elastic.Clients.Elasticsearch.Fields?>? Source { get => Q<Union<bool?, Elastic.Clients.Elasticsearch.Fields?>?>("_source"); set => Q("_source", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_includes"); set => Q("_source_includes", value); }

		[JsonIgnore]
		public bool? SeqNoPrimaryTerm { get => Q<bool?>("seq_no_primary_term"); set => Q("seq_no_primary_term", value); }

		[JsonIgnore]
		public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }

		[JsonIgnore]
		public int? Size { get => Q<int?>("size"); set => Q("size", value); }

		[JsonIgnore]
		public int? From { get => Q<int?>("from"); set => Q("from", value); }

		[JsonIgnore]
		public IEnumerable<string>? Sort { get => Q<IEnumerable<string>?>("sort"); set => Q("sort", value); }

		[JsonInclude]
		[JsonPropertyName("aggs")]
		public Dictionary<string, Aggregations.IAggregationContainer>? Aggs { get; set; }

		[JsonInclude]
		[JsonPropertyName("aggregations")]
		public Dictionary<string, Aggregations.IAggregationContainer>? Aggregations { get; set; }

		[JsonInclude]
		[JsonPropertyName("collapse")]
		public IFieldCollapse? Collapse { get; set; }

		[JsonInclude]
		[JsonPropertyName("highlight")]
		public IHighlight? Highlight { get; set; }

		[JsonInclude]
		[JsonPropertyName("indices_boost")]
		public IEnumerable<Dictionary<Elastic.Clients.Elasticsearch.IndexName, double>>? IndicesBoost { get; set; }

		[JsonInclude]
		[JsonPropertyName("min_score")]
		public double? MinScore { get; set; }

		[JsonInclude]
		[JsonPropertyName("post_filter")]
		public QueryDsl.IQueryContainer? PostFilter { get; set; }

		[JsonInclude]
		[JsonPropertyName("profile")]
		public bool? Profile { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public QueryDsl.IQueryContainer? Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("rescore")]
		public IEnumerable<IRescore>? Rescore { get; set; }

		[JsonInclude]
		[JsonPropertyName("script_fields")]
		public Dictionary<string, IScriptField>? ScriptFields { get; set; }

		[JsonInclude]
		[JsonPropertyName("search_after")]
		public IEnumerable<object>? SearchAfter { get; set; }

		[JsonInclude]
		[JsonPropertyName("slice")]
		public ISlicedScroll? Slice { get; set; }

		[JsonInclude]
		[JsonPropertyName("fields")]
		public IEnumerable<Union<string?, IDateField?>>? Fields { get; set; }

		[JsonInclude]
		[JsonPropertyName("suggest")]
		public Union<ISuggestContainer?, Dictionary<string, ISuggestContainer>?>? Suggest { get; set; }

		[JsonInclude]
		[JsonPropertyName("pit")]
		public IPointInTimeReference? Pit { get; set; }

		[JsonInclude]
		[JsonPropertyName("runtime_mappings")]
		public Dictionary<string, Mapping.IRuntimeField>? RuntimeMappings { get; set; }
	}

	public partial class SearchRequestDescriptor : RequestDescriptorBase<SearchRequestDescriptor, SearchRequestParameters, ISearchRequest>, ISearchRequest
	{
		///<summary>/_search</summary>
        public SearchRequestDescriptor() : base()
		{
		}

		///<summary>/{index}/_search</summary>
        public SearchRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("indices", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceSearch;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		Dictionary<string, Aggregations.IAggregationContainer>? ISearchRequest.Aggs { get; set; }

		Dictionary<string, Aggregations.IAggregationContainer>? ISearchRequest.Aggregations { get; set; }

		IFieldCollapse? ISearchRequest.Collapse { get; set; }

		IHighlight? ISearchRequest.Highlight { get; set; }

		IEnumerable<Dictionary<Elastic.Clients.Elasticsearch.IndexName, double>>? ISearchRequest.IndicesBoost { get; set; }

		double? ISearchRequest.MinScore { get; set; }

		QueryDsl.IQueryContainer? ISearchRequest.PostFilter { get; set; }

		bool? ISearchRequest.Profile { get; set; }

		QueryDsl.IQueryContainer? ISearchRequest.Query { get; set; }

		IEnumerable<IRescore>? ISearchRequest.Rescore { get; set; }

		Dictionary<string, IScriptField>? ISearchRequest.ScriptFields { get; set; }

		IEnumerable<object>? ISearchRequest.SearchAfter { get; set; }

		ISlicedScroll? ISearchRequest.Slice { get; set; }

		IEnumerable<Union<string?, IDateField?>>? ISearchRequest.Fields { get; set; }

		Union<ISuggestContainer?, Dictionary<string, ISuggestContainer>?>? ISearchRequest.Suggest { get; set; }

		IPointInTimeReference? ISearchRequest.Pit { get; set; }

		Dictionary<string, Mapping.IRuntimeField>? ISearchRequest.RuntimeMappings { get; set; }

		public SearchRequestDescriptor Aggs(Dictionary<string, Aggregations.IAggregationContainer>? aggs) => Assign(aggs, (a, v) => a.Aggs = v);
		public SearchRequestDescriptor Aggregations(Dictionary<string, Aggregations.IAggregationContainer>? aggregations) => Assign(aggregations, (a, v) => a.Aggregations = v);
		public SearchRequestDescriptor Collapse(IFieldCollapse? collapse) => Assign(collapse, (a, v) => a.Collapse = v);
		public SearchRequestDescriptor Highlight(IHighlight? highlight) => Assign(highlight, (a, v) => a.Highlight = v);
		public SearchRequestDescriptor IndicesBoost(IEnumerable<Dictionary<Elastic.Clients.Elasticsearch.IndexName, double>>? indicesBoost) => Assign(indicesBoost, (a, v) => a.IndicesBoost = v);
		public SearchRequestDescriptor MinScore(double? minScore) => Assign(minScore, (a, v) => a.MinScore = v);
		public SearchRequestDescriptor PostFilter(QueryDsl.IQueryContainer? postFilter) => Assign(postFilter, (a, v) => a.PostFilter = v);
		public SearchRequestDescriptor Profile(bool? profile) => Assign(profile, (a, v) => a.Profile = v);
		public SearchRequestDescriptor Query(QueryDsl.IQueryContainer? query) => Assign(query, (a, v) => a.Query = v);
		public SearchRequestDescriptor Rescore(IEnumerable<IRescore>? rescore) => Assign(rescore, (a, v) => a.Rescore = v);
		public SearchRequestDescriptor ScriptFields(Dictionary<string, IScriptField>? scriptFields) => Assign(scriptFields, (a, v) => a.ScriptFields = v);
		public SearchRequestDescriptor SearchAfter(IEnumerable<object>? searchAfter) => Assign(searchAfter, (a, v) => a.SearchAfter = v);
		public SearchRequestDescriptor Slice(ISlicedScroll? slice) => Assign(slice, (a, v) => a.Slice = v);
		public SearchRequestDescriptor Fields(IEnumerable<Union<string?, IDateField?>>? fields) => Assign(fields, (a, v) => a.Fields = v);
		public SearchRequestDescriptor Suggest(Union<ISuggestContainer?, Dictionary<string, ISuggestContainer>?>? suggest) => Assign(suggest, (a, v) => a.Suggest = v);
		public SearchRequestDescriptor Pit(IPointInTimeReference? pit) => Assign(pit, (a, v) => a.Pit = v);
		public SearchRequestDescriptor RuntimeMappings(Dictionary<string, Mapping.IRuntimeField>? runtimeMappings) => Assign(runtimeMappings, (a, v) => a.RuntimeMappings = v);
		public SearchRequestDescriptor AllowNoIndices(bool? allowNoIndices) => Qs("allow_no_indices", allowNoIndices);
		public SearchRequestDescriptor AllowPartialSearchResults(bool? allowPartialSearchResults) => Qs("allow_partial_search_results", allowPartialSearchResults);
		public SearchRequestDescriptor Analyzer(string? analyzer) => Qs("analyzer", analyzer);
		public SearchRequestDescriptor AnalyzeWildcard(bool? analyzeWildcard) => Qs("analyze_wildcard", analyzeWildcard);
		public SearchRequestDescriptor BatchedReduceSize(object? batchedReduceSize) => Qs("batched_reduce_size", batchedReduceSize);
		public SearchRequestDescriptor CcsMinimizeRoundtrips(bool? ccsMinimizeRoundtrips) => Qs("ccs_minimize_roundtrips", ccsMinimizeRoundtrips);
		public SearchRequestDescriptor DefaultOperator(Elastic.Clients.Elasticsearch.DefaultOperator? defaultOperator) => Qs("default_operator", defaultOperator);
		public SearchRequestDescriptor Df(string? df) => Qs("df", df);
		public SearchRequestDescriptor DocvalueFields(Elastic.Clients.Elasticsearch.Fields? docvalueFields) => Qs("docvalue_fields", docvalueFields);
		public SearchRequestDescriptor ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public SearchRequestDescriptor Explain(bool? explain) => Qs("explain", explain);
		public SearchRequestDescriptor IgnoreThrottled(bool? ignoreThrottled) => Qs("ignore_throttled", ignoreThrottled);
		public SearchRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable) => Qs("ignore_unavailable", ignoreUnavailable);
		public SearchRequestDescriptor Lenient(bool? lenient) => Qs("lenient", lenient);
		public SearchRequestDescriptor MaxConcurrentShardRequests(object? maxConcurrentShardRequests) => Qs("max_concurrent_shard_requests", maxConcurrentShardRequests);
		public SearchRequestDescriptor MinCompatibleShardNode(string? minCompatibleShardNode) => Qs("min_compatible_shard_node", minCompatibleShardNode);
		public SearchRequestDescriptor Preference(string? preference) => Qs("preference", preference);
		public SearchRequestDescriptor PreFilterShardSize(object? preFilterShardSize) => Qs("pre_filter_shard_size", preFilterShardSize);
		public SearchRequestDescriptor RequestCache(bool? requestCache) => Qs("request_cache", requestCache);
		public SearchRequestDescriptor Routing(string? routing) => Qs("routing", routing);
		public SearchRequestDescriptor Scroll(Elastic.Clients.Elasticsearch.Time? scroll) => Qs("scroll", scroll);
		public SearchRequestDescriptor SearchType(Elastic.Clients.Elasticsearch.SearchType? searchType) => Qs("search_type", searchType);
		public SearchRequestDescriptor Stats(IEnumerable<string>? stats) => Qs("stats", stats);
		public SearchRequestDescriptor StoredFields(Elastic.Clients.Elasticsearch.Fields? storedFields) => Qs("stored_fields", storedFields);
		public SearchRequestDescriptor SuggestField(string? suggestField) => Qs("suggest_field", suggestField);
		public SearchRequestDescriptor SuggestMode(Elastic.Clients.Elasticsearch.SuggestMode? suggestMode) => Qs("suggest_mode", suggestMode);
		public SearchRequestDescriptor SuggestSize(object? suggestSize) => Qs("suggest_size", suggestSize);
		public SearchRequestDescriptor SuggestText(string? suggestText) => Qs("suggest_text", suggestText);
		public SearchRequestDescriptor TerminateAfter(object? terminateAfter) => Qs("terminate_after", terminateAfter);
		public SearchRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public SearchRequestDescriptor TrackTotalHits(Union<bool?, int?>? trackTotalHits) => Qs("track_total_hits", trackTotalHits);
		public SearchRequestDescriptor TrackScores(bool? trackScores) => Qs("track_scores", trackScores);
		public SearchRequestDescriptor TypedKeys(bool? typedKeys) => Qs("typed_keys", typedKeys);
		public SearchRequestDescriptor RestTotalHitsAsInt(bool? restTotalHitsAsInt) => Qs("rest_total_hits_as_int", restTotalHitsAsInt);
		public SearchRequestDescriptor Version(bool? version) => Qs("version", version);
		public SearchRequestDescriptor Source(Union<bool?, Elastic.Clients.Elasticsearch.Fields?>? source) => Qs("_source", source);
		public SearchRequestDescriptor SourceExcludes(Elastic.Clients.Elasticsearch.Fields? sourceExcludes) => Qs("_source_excludes", sourceExcludes);
		public SearchRequestDescriptor SourceIncludes(Elastic.Clients.Elasticsearch.Fields? sourceIncludes) => Qs("_source_includes", sourceIncludes);
		public SearchRequestDescriptor SeqNoPrimaryTerm(bool? seqNoPrimaryTerm) => Qs("seq_no_primary_term", seqNoPrimaryTerm);
		public SearchRequestDescriptor QueryLuceneSyntax(string? q) => Qs("q", q);
		public SearchRequestDescriptor Size(int? size) => Qs("size", size);
		public SearchRequestDescriptor From(int? from) => Qs("from", from);
		public SearchRequestDescriptor Sort(IEnumerable<string>? sort) => Qs("sort", sort);
	}

	public class SearchRequestDescriptorConverter<TReadAs> : JsonConverter<ISearchRequest> where TReadAs : class, ISearchRequest
	{
		public override ISearchRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => JsonSerializer.Deserialize<TReadAs>(ref reader, options);
		public override void Write(Utf8JsonWriter writer, ISearchRequest value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (value.Aggs is not null)
			{
				writer.WritePropertyName("aggs");
				JsonSerializer.Serialize(writer, value.Aggs, options);
			}

			if (value.Aggregations is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, value.Aggregations, options);
			}

			if (value.Collapse is not null)
			{
				writer.WritePropertyName("collapse");
				JsonSerializer.Serialize(writer, value.Collapse, options);
			}

			if (value.Highlight is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, value.Highlight, options);
			}

			if (value.IndicesBoost is not null)
			{
				writer.WritePropertyName("indices_boost");
				JsonSerializer.Serialize(writer, value.IndicesBoost, options);
			}

			if (value.MinScore.HasValue)
			{
				writer.WritePropertyName("min_score");
				writer.WriteNumberValue(value.MinScore.Value);
			}

			if (value.PostFilter is not null)
			{
				writer.WritePropertyName("post_filter");
				JsonSerializer.Serialize(writer, value.PostFilter, options);
			}

			if (value.Profile.HasValue)
			{
				writer.WritePropertyName("profile");
				writer.WriteBooleanValue(value.Profile.Value);
			}

			if (value.Query is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, value.Query, options);
			}

			if (value.Rescore is not null)
			{
				writer.WritePropertyName("rescore");
				JsonSerializer.Serialize(writer, value.Rescore, options);
			}

			if (value.ScriptFields is not null)
			{
				writer.WritePropertyName("script_fields");
				JsonSerializer.Serialize(writer, value.ScriptFields, options);
			}

			if (value.SearchAfter is not null)
			{
				writer.WritePropertyName("search_after");
				JsonSerializer.Serialize(writer, value.SearchAfter, options);
			}

			if (value.Slice is not null)
			{
				writer.WritePropertyName("slice");
				JsonSerializer.Serialize(writer, value.Slice, options);
			}

			if (value.Fields is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, value.Fields, options);
			}

			if (value.Suggest is not null)
			{
				writer.WritePropertyName("suggest");
				JsonSerializer.Serialize(writer, value.Suggest, options);
			}

			if (value.Pit is not null)
			{
				writer.WritePropertyName("pit");
				JsonSerializer.Serialize(writer, value.Pit, options);
			}

			if (value.RuntimeMappings is not null)
			{
				writer.WritePropertyName("runtime_mappings");
				JsonSerializer.Serialize(writer, value.RuntimeMappings, options);
			}

			writer.WriteEndObject();
		}
	}
}