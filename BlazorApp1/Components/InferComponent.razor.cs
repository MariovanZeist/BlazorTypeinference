using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace BlazorApp1.Components
{
	partial class InferComponent<T>
		//where T : IMyInterface
	{
		[Parameter] public IEnumerable<T> Items { get; set; }
	}
}
