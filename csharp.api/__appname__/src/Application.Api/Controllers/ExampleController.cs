using System.Net;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Application.api.Controllers;

/// <summary></summary>
[Route("api/examples")]
[ApiController]
public class ExampleController
{
	/// <summary>
	/// summary of the method
	/// </summary>
	/// <remarks>
	/// remarks here
	/// </remarks>
	/// <param name="id">param info</param>
	/// <returns>returns info</returns>
	[HttpGet]
	[Route("{id:long}")]
	[ProducesDefaultResponseType(typeof(string))]
	[ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
	public IActionResult ExampleGet([FromRoute] long id)
	{
		return null!;
	}
	
}