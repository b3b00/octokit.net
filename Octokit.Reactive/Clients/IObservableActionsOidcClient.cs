﻿using System;
using System.Reactive;


namespace Octokit.Reactive
{
	/// <summary>
	/// A client for GitHub's Actions OIDC API.
	/// </summary>
	/// <remarks>
	/// See the <a href="https://developer.github.com/v3/actions/oidc/">Actions OIDC API documentation</a> for more information.
	/// </remarks>
	public interface IObservableActionsOidcClient
	{
		/// <summary>
		/// Get the customization template for an OIDC subject claim for an organization.
		/// </summary>
		/// <remarks>
		/// https://docs.github.com/en/rest/actions/oidc?apiVersion=2022-11-28#get-the-customization-template-for-an-oidc-subject-claim-for-an-organization
		/// </remarks>
		/// <param name="organization">The organization name.</param>
		IObservable<OrganizationOidcSubjectClaim> GetOrganizationOidcSubjectClaim(string organization);


		/// <summary>
		/// Set the customization template for an OIDC subject claim for an organization.
		/// </summary>
		/// <remarks>
		/// https://docs.github.com/en/rest/actions/oidc?apiVersion=2022-11-28#set-the-customization-template-for-an-oidc-subject-claim-for-an-organization
		/// </remarks>
		/// <param name="organization">The organization name.</param>
		/// <param name="oidcSubjectClaim">The OIDC subject claim to set for the organization.</param>
		IObservable<Unit> SetOrganizationOidcSubjectClaim(string organization, OrganizationOidcSubjectClaimRequest oidcSubjectClaim);

		/// <summary>
		/// Get the customization template for an OIDC subject claim for a repository.
		/// </summary>
		/// <remarks>
		/// https://docs.github.com/en/rest/actions/oidc?apiVersion=2022-11-28#get-the-customization-template-for-an-oidc-subject-claim-for-a-repository
		/// </remarks>
		/// <param name="owner">The account owner of the repository.</param>
		/// <param name="repository">The name of the repository.</param>
		/// <returns></returns>
		IObservable<RepositoryOidcSubjectClaim> GetRepositoryOidcSubjectClaim(string owner, string repository);

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// https://docs.github.com/en/rest/actions/oidc?apiVersion=2022-11-28#set-the-customization-template-for-an-oidc-subject-claim-for-a-repository
		/// </remarks>
		/// <param name="owner">The account owner of the repository.</param>
		/// <param name="repository">The name of the repository.</param>
		/// <param name="oidcSubjectClaim">The OIDC subject claim to set for the repository.</param>
		/// <returns></returns>
		IObservable<Unit> SetRepositoryOidcSubjectClaim(string owner, string repository, RepositoryOidcSubjectClaimRequest oidcSubjectClaim);
	}
}
