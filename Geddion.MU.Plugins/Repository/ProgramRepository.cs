using Geddion.MU.Plugins.Model;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;

namespace Geddion.MU.Plugins.Repository;

/// <summary>
/// Program Repository
/// </summary>
public class ProgramRepository
{
	private readonly IOrganizationService _service;

	/// <summary>
	/// Program Repository
	/// </summary>
	/// <param name="service">Crm service</param>
	public ProgramRepository(IOrganizationService service)
	{
		_service = service;
	}

	/// <summary>
	/// Get
	/// </summary>
	/// <param name="programId">Program id</param>
	/// <param name="attributes">Entity attributes</param>
	/// <returns></returns>
	public Program Get(Guid programId, params string[] attributes)
	{
		return _service.Retrieve(Program.EntityLogicalName, programId, new ColumnSet(attributes))
			.ToEntity<Program>();
	}
}