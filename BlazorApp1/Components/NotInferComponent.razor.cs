using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace BlazorApp1.Components
{
	public partial class NotInferComponent<T>
		where T : IMyInterface
	{
		[Parameter] public IEnumerable<T> Items { get; set; }
	}
}
