// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
using Elasticsearch.Net.Specification.SecurityApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	///<summary>Descriptor for Authenticate <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-authenticate.html</para></summary>
	public partial class AuthenticateDescriptor : RequestDescriptorBase<AuthenticateDescriptor, AuthenticateRequestParameters, IAuthenticateRequest>, IAuthenticateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityAuthenticate;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for ChangePassword <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-change-password.html</para></summary>
	public partial class ChangePasswordDescriptor : RequestDescriptorBase<ChangePasswordDescriptor, ChangePasswordRequestParameters, IChangePasswordRequest>, IChangePasswordRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityChangePassword;
		///<summary>/_security/user/{username}/_password</summary>
		///<param name = "username">Optional, accepts null</param>
		public ChangePasswordDescriptor(Name username): base(r => r.Optional("username", username))
		{
		}

		///<summary>/_security/user/_password</summary>
		public ChangePasswordDescriptor(): base()
		{
		}

		// values part of the url path
		Name IChangePasswordRequest.Username => Self.RouteValues.Get<Name>("username");
		///<summary>The username of the user to change the password for</summary>
		public ChangePasswordDescriptor Username(Name username) => Assign(username, (a, v) => a.RouteValues.Optional("username", v));
		// Request parameters
		///<summary>If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` then do nothing with refreshes.</summary>
		public ChangePasswordDescriptor Refresh(Refresh? refresh) => Qs("refresh", refresh);
	}

	///<summary>Descriptor for ClearCachedRealms <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-clear-cache.html</para></summary>
	public partial class ClearCachedRealmsDescriptor : RequestDescriptorBase<ClearCachedRealmsDescriptor, ClearCachedRealmsRequestParameters, IClearCachedRealmsRequest>, IClearCachedRealmsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityClearCachedRealms;
		///<summary>/_security/realm/{realms}/_clear_cache</summary>
		///<param name = "realms">this parameter is required</param>
		public ClearCachedRealmsDescriptor(Names realms): base(r => r.Required("realms", realms))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected ClearCachedRealmsDescriptor(): base()
		{
		}

		// values part of the url path
		Names IClearCachedRealmsRequest.Realms => Self.RouteValues.Get<Names>("realms");
		// Request parameters
		///<summary>Comma-separated list of usernames to clear from the cache</summary>
		public ClearCachedRealmsDescriptor Usernames(params string[] usernames) => Qs("usernames", usernames);
	}

	///<summary>Descriptor for ClearCachedRoles <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-clear-role-cache.html</para></summary>
	public partial class ClearCachedRolesDescriptor : RequestDescriptorBase<ClearCachedRolesDescriptor, ClearCachedRolesRequestParameters, IClearCachedRolesRequest>, IClearCachedRolesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityClearCachedRoles;
		///<summary>/_security/role/{name}/_clear_cache</summary>
		///<param name = "name">this parameter is required</param>
		public ClearCachedRolesDescriptor(Names name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected ClearCachedRolesDescriptor(): base()
		{
		}

		// values part of the url path
		Names IClearCachedRolesRequest.Name => Self.RouteValues.Get<Names>("name");
	// Request parameters
	}

	///<summary>Descriptor for CreateApiKey <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-create-api-key.html</para></summary>
	public partial class CreateApiKeyDescriptor : RequestDescriptorBase<CreateApiKeyDescriptor, CreateApiKeyRequestParameters, ICreateApiKeyRequest>, ICreateApiKeyRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityCreateApiKey;
		// values part of the url path
		// Request parameters
		///<summary>If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` then do nothing with refreshes.</summary>
		public CreateApiKeyDescriptor Refresh(Refresh? refresh) => Qs("refresh", refresh);
	}

	///<summary>Descriptor for DeletePrivileges <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-delete-privilege.html</para></summary>
	public partial class DeletePrivilegesDescriptor : RequestDescriptorBase<DeletePrivilegesDescriptor, DeletePrivilegesRequestParameters, IDeletePrivilegesRequest>, IDeletePrivilegesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityDeletePrivileges;
		///<summary>/_security/privilege/{application}/{name}</summary>
		///<param name = "application">this parameter is required</param>
		///<param name = "name">this parameter is required</param>
		public DeletePrivilegesDescriptor(Name application, Name name): base(r => r.Required("application", application).Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeletePrivilegesDescriptor(): base()
		{
		}

		// values part of the url path
		Name IDeletePrivilegesRequest.Application => Self.RouteValues.Get<Name>("application");
		Name IDeletePrivilegesRequest.Name => Self.RouteValues.Get<Name>("name");
		// Request parameters
		///<summary>If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` then do nothing with refreshes.</summary>
		public DeletePrivilegesDescriptor Refresh(Refresh? refresh) => Qs("refresh", refresh);
	}

	///<summary>Descriptor for DeleteRole <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-delete-role.html</para></summary>
	public partial class DeleteRoleDescriptor : RequestDescriptorBase<DeleteRoleDescriptor, DeleteRoleRequestParameters, IDeleteRoleRequest>, IDeleteRoleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityDeleteRole;
		///<summary>/_security/role/{name}</summary>
		///<param name = "name">this parameter is required</param>
		public DeleteRoleDescriptor(Name name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteRoleDescriptor(): base()
		{
		}

		// values part of the url path
		Name IDeleteRoleRequest.Name => Self.RouteValues.Get<Name>("name");
		// Request parameters
		///<summary>If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` then do nothing with refreshes.</summary>
		public DeleteRoleDescriptor Refresh(Refresh? refresh) => Qs("refresh", refresh);
	}

	///<summary>Descriptor for DeleteRoleMapping <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-delete-role-mapping.html</para></summary>
	public partial class DeleteRoleMappingDescriptor : RequestDescriptorBase<DeleteRoleMappingDescriptor, DeleteRoleMappingRequestParameters, IDeleteRoleMappingRequest>, IDeleteRoleMappingRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityDeleteRoleMapping;
		///<summary>/_security/role_mapping/{name}</summary>
		///<param name = "name">this parameter is required</param>
		public DeleteRoleMappingDescriptor(Name name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteRoleMappingDescriptor(): base()
		{
		}

		// values part of the url path
		Name IDeleteRoleMappingRequest.Name => Self.RouteValues.Get<Name>("name");
		// Request parameters
		///<summary>If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` then do nothing with refreshes.</summary>
		public DeleteRoleMappingDescriptor Refresh(Refresh? refresh) => Qs("refresh", refresh);
	}

	///<summary>Descriptor for DeleteUser <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-delete-user.html</para></summary>
	public partial class DeleteUserDescriptor : RequestDescriptorBase<DeleteUserDescriptor, DeleteUserRequestParameters, IDeleteUserRequest>, IDeleteUserRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityDeleteUser;
		///<summary>/_security/user/{username}</summary>
		///<param name = "username">this parameter is required</param>
		public DeleteUserDescriptor(Name username): base(r => r.Required("username", username))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteUserDescriptor(): base()
		{
		}

		// values part of the url path
		Name IDeleteUserRequest.Username => Self.RouteValues.Get<Name>("username");
		// Request parameters
		///<summary>If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` then do nothing with refreshes.</summary>
		public DeleteUserDescriptor Refresh(Refresh? refresh) => Qs("refresh", refresh);
	}

	///<summary>Descriptor for DisableUser <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-disable-user.html</para></summary>
	public partial class DisableUserDescriptor : RequestDescriptorBase<DisableUserDescriptor, DisableUserRequestParameters, IDisableUserRequest>, IDisableUserRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityDisableUser;
		///<summary>/_security/user/{username}/_disable</summary>
		///<param name = "username">this parameter is required</param>
		public DisableUserDescriptor(Name username): base(r => r.Required("username", username))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DisableUserDescriptor(): base()
		{
		}

		// values part of the url path
		Name IDisableUserRequest.Username => Self.RouteValues.Get<Name>("username");
		// Request parameters
		///<summary>If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` then do nothing with refreshes.</summary>
		public DisableUserDescriptor Refresh(Refresh? refresh) => Qs("refresh", refresh);
	}

	///<summary>Descriptor for EnableUser <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-enable-user.html</para></summary>
	public partial class EnableUserDescriptor : RequestDescriptorBase<EnableUserDescriptor, EnableUserRequestParameters, IEnableUserRequest>, IEnableUserRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityEnableUser;
		///<summary>/_security/user/{username}/_enable</summary>
		///<param name = "username">this parameter is required</param>
		public EnableUserDescriptor(Name username): base(r => r.Required("username", username))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected EnableUserDescriptor(): base()
		{
		}

		// values part of the url path
		Name IEnableUserRequest.Username => Self.RouteValues.Get<Name>("username");
		// Request parameters
		///<summary>If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` then do nothing with refreshes.</summary>
		public EnableUserDescriptor Refresh(Refresh? refresh) => Qs("refresh", refresh);
	}

	///<summary>Descriptor for GetApiKey <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-api-key.html</para></summary>
	public partial class GetApiKeyDescriptor : RequestDescriptorBase<GetApiKeyDescriptor, GetApiKeyRequestParameters, IGetApiKeyRequest>, IGetApiKeyRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetApiKey;
		// values part of the url path
		// Request parameters
		///<summary>API key id of the API key to be retrieved</summary>
		public GetApiKeyDescriptor Id(string id) => Qs("id", id);
		///<summary>API key name of the API key to be retrieved</summary>
		public GetApiKeyDescriptor Name(string name) => Qs("name", name);
		///<summary>flag to query API keys owned by the currently authenticated user</summary>
		public GetApiKeyDescriptor Owner(bool? owner = true) => Qs("owner", owner);
		///<summary>realm name of the user who created this API key to be retrieved</summary>
		public GetApiKeyDescriptor RealmName(string realmname) => Qs("realm_name", realmname);
		///<summary>user name of the user who created this API key to be retrieved</summary>
		public GetApiKeyDescriptor Username(string username) => Qs("username", username);
	}

	///<summary>Descriptor for GetBuiltinPrivileges <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-builtin-privileges.html</para></summary>
	public partial class GetBuiltinPrivilegesDescriptor : RequestDescriptorBase<GetBuiltinPrivilegesDescriptor, GetBuiltinPrivilegesRequestParameters, IGetBuiltinPrivilegesRequest>, IGetBuiltinPrivilegesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetBuiltinPrivileges;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for GetPrivileges <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-privileges.html</para></summary>
	public partial class GetPrivilegesDescriptor : RequestDescriptorBase<GetPrivilegesDescriptor, GetPrivilegesRequestParameters, IGetPrivilegesRequest>, IGetPrivilegesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetPrivileges;
		///<summary>/_security/privilege</summary>
		public GetPrivilegesDescriptor(): base()
		{
		}

		///<summary>/_security/privilege/{application}</summary>
		///<param name = "application">Optional, accepts null</param>
		public GetPrivilegesDescriptor(Name application): base(r => r.Optional("application", application))
		{
		}

		///<summary>/_security/privilege/{application}/{name}</summary>
		///<param name = "application">Optional, accepts null</param>
		///<param name = "name">Optional, accepts null</param>
		public GetPrivilegesDescriptor(Name application, Name name): base(r => r.Optional("application", application).Optional("name", name))
		{
		}

		// values part of the url path
		Name IGetPrivilegesRequest.Application => Self.RouteValues.Get<Name>("application");
		Name IGetPrivilegesRequest.Name => Self.RouteValues.Get<Name>("name");
		///<summary>Application name</summary>
		public GetPrivilegesDescriptor Application(Name application) => Assign(application, (a, v) => a.RouteValues.Optional("application", v));
		///<summary>Privilege name</summary>
		public GetPrivilegesDescriptor Name(Name name) => Assign(name, (a, v) => a.RouteValues.Optional("name", v));
	// Request parameters
	}

	///<summary>Descriptor for GetRole <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-role.html</para></summary>
	public partial class GetRoleDescriptor : RequestDescriptorBase<GetRoleDescriptor, GetRoleRequestParameters, IGetRoleRequest>, IGetRoleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetRole;
		///<summary>/_security/role/{name}</summary>
		///<param name = "name">Optional, accepts null</param>
		public GetRoleDescriptor(Name name): base(r => r.Optional("name", name))
		{
		}

		///<summary>/_security/role</summary>
		public GetRoleDescriptor(): base()
		{
		}

		// values part of the url path
		Name IGetRoleRequest.Name => Self.RouteValues.Get<Name>("name");
		///<summary>Role name</summary>
		public GetRoleDescriptor Name(Name name) => Assign(name, (a, v) => a.RouteValues.Optional("name", v));
	// Request parameters
	}

	///<summary>Descriptor for GetRoleMapping <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-role-mapping.html</para></summary>
	public partial class GetRoleMappingDescriptor : RequestDescriptorBase<GetRoleMappingDescriptor, GetRoleMappingRequestParameters, IGetRoleMappingRequest>, IGetRoleMappingRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetRoleMapping;
		///<summary>/_security/role_mapping/{name}</summary>
		///<param name = "name">Optional, accepts null</param>
		public GetRoleMappingDescriptor(Name name): base(r => r.Optional("name", name))
		{
		}

		///<summary>/_security/role_mapping</summary>
		public GetRoleMappingDescriptor(): base()
		{
		}

		// values part of the url path
		Name IGetRoleMappingRequest.Name => Self.RouteValues.Get<Name>("name");
		///<summary>Role-Mapping name</summary>
		public GetRoleMappingDescriptor Name(Name name) => Assign(name, (a, v) => a.RouteValues.Optional("name", v));
	// Request parameters
	}

	///<summary>Descriptor for GetUserAccessToken <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-token.html</para></summary>
	public partial class GetUserAccessTokenDescriptor : RequestDescriptorBase<GetUserAccessTokenDescriptor, GetUserAccessTokenRequestParameters, IGetUserAccessTokenRequest>, IGetUserAccessTokenRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetUserAccessToken;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for GetUser <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-user.html</para></summary>
	public partial class GetUserDescriptor : RequestDescriptorBase<GetUserDescriptor, GetUserRequestParameters, IGetUserRequest>, IGetUserRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetUser;
		///<summary>/_security/user/{username}</summary>
		///<param name = "username">Optional, accepts null</param>
		public GetUserDescriptor(Names username): base(r => r.Optional("username", username))
		{
		}

		///<summary>/_security/user</summary>
		public GetUserDescriptor(): base()
		{
		}

		// values part of the url path
		Names IGetUserRequest.Username => Self.RouteValues.Get<Names>("username");
		///<summary>A comma-separated list of usernames</summary>
		public GetUserDescriptor Username(Names username) => Assign(username, (a, v) => a.RouteValues.Optional("username", v));
	// Request parameters
	}

	///<summary>Descriptor for GetUserPrivileges <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-privileges.html</para></summary>
	public partial class GetUserPrivilegesDescriptor : RequestDescriptorBase<GetUserPrivilegesDescriptor, GetUserPrivilegesRequestParameters, IGetUserPrivilegesRequest>, IGetUserPrivilegesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetUserPrivileges;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for HasPrivileges <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-has-privileges.html</para></summary>
	public partial class HasPrivilegesDescriptor : RequestDescriptorBase<HasPrivilegesDescriptor, HasPrivilegesRequestParameters, IHasPrivilegesRequest>, IHasPrivilegesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityHasPrivileges;
		///<summary>/_security/user/_has_privileges</summary>
		public HasPrivilegesDescriptor(): base()
		{
		}

		///<summary>/_security/user/{user}/_has_privileges</summary>
		///<param name = "user">Optional, accepts null</param>
		public HasPrivilegesDescriptor(Name user): base(r => r.Optional("user", user))
		{
		}

		// values part of the url path
		Name IHasPrivilegesRequest.User => Self.RouteValues.Get<Name>("user");
		///<summary>Username</summary>
		public HasPrivilegesDescriptor User(Name user) => Assign(user, (a, v) => a.RouteValues.Optional("user", v));
	// Request parameters
	}

	///<summary>Descriptor for InvalidateApiKey <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-invalidate-api-key.html</para></summary>
	public partial class InvalidateApiKeyDescriptor : RequestDescriptorBase<InvalidateApiKeyDescriptor, InvalidateApiKeyRequestParameters, IInvalidateApiKeyRequest>, IInvalidateApiKeyRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityInvalidateApiKey;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for InvalidateUserAccessToken <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-invalidate-token.html</para></summary>
	public partial class InvalidateUserAccessTokenDescriptor : RequestDescriptorBase<InvalidateUserAccessTokenDescriptor, InvalidateUserAccessTokenRequestParameters, IInvalidateUserAccessTokenRequest>, IInvalidateUserAccessTokenRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityInvalidateUserAccessToken;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for PutPrivileges <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-put-privileges.html</para></summary>
	public partial class PutPrivilegesDescriptor : RequestDescriptorBase<PutPrivilegesDescriptor, PutPrivilegesRequestParameters, IPutPrivilegesRequest>, IPutPrivilegesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityPutPrivileges;
		// values part of the url path
		// Request parameters
		///<summary>If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` then do nothing with refreshes.</summary>
		public PutPrivilegesDescriptor Refresh(Refresh? refresh) => Qs("refresh", refresh);
	}

	///<summary>Descriptor for PutRole <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-put-role.html</para></summary>
	public partial class PutRoleDescriptor : RequestDescriptorBase<PutRoleDescriptor, PutRoleRequestParameters, IPutRoleRequest>, IPutRoleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityPutRole;
		///<summary>/_security/role/{name}</summary>
		///<param name = "name">this parameter is required</param>
		public PutRoleDescriptor(Name name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PutRoleDescriptor(): base()
		{
		}

		// values part of the url path
		Name IPutRoleRequest.Name => Self.RouteValues.Get<Name>("name");
		// Request parameters
		///<summary>If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` then do nothing with refreshes.</summary>
		public PutRoleDescriptor Refresh(Refresh? refresh) => Qs("refresh", refresh);
	}

	///<summary>Descriptor for PutRoleMapping <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-put-role-mapping.html</para></summary>
	public partial class PutRoleMappingDescriptor : RequestDescriptorBase<PutRoleMappingDescriptor, PutRoleMappingRequestParameters, IPutRoleMappingRequest>, IPutRoleMappingRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityPutRoleMapping;
		///<summary>/_security/role_mapping/{name}</summary>
		///<param name = "name">this parameter is required</param>
		public PutRoleMappingDescriptor(Name name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PutRoleMappingDescriptor(): base()
		{
		}

		// values part of the url path
		Name IPutRoleMappingRequest.Name => Self.RouteValues.Get<Name>("name");
		// Request parameters
		///<summary>If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` then do nothing with refreshes.</summary>
		public PutRoleMappingDescriptor Refresh(Refresh? refresh) => Qs("refresh", refresh);
	}

	///<summary>Descriptor for PutUser <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-put-user.html</para></summary>
	public partial class PutUserDescriptor : RequestDescriptorBase<PutUserDescriptor, PutUserRequestParameters, IPutUserRequest>, IPutUserRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityPutUser;
		///<summary>/_security/user/{username}</summary>
		///<param name = "username">this parameter is required</param>
		public PutUserDescriptor(Name username): base(r => r.Required("username", username))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PutUserDescriptor(): base()
		{
		}

		// values part of the url path
		Name IPutUserRequest.Username => Self.RouteValues.Get<Name>("username");
		// Request parameters
		///<summary>If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` then do nothing with refreshes.</summary>
		public PutUserDescriptor Refresh(Refresh? refresh) => Qs("refresh", refresh);
	}

	///<summary>Descriptor for GetCertificates <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-ssl.html</para></summary>
	public partial class GetCertificatesDescriptor : RequestDescriptorBase<GetCertificatesDescriptor, GetCertificatesRequestParameters, IGetCertificatesRequest>, IGetCertificatesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetCertificates;
	// values part of the url path
	// Request parameters
	}
}