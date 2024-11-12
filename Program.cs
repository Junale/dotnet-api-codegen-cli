using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using Generators;
internal class Program
{
	private static void Main(string[] args)
	{
		if (args.Length < 1)
		{
			Console.WriteLine("Usage: dotnet api-codegen generate [component] [tags:value]");
			return;
		}

		var component = args[2];
		var tags = new Dictionary<string, string>();
		for (int i = 3; i < args.Length; i++)
		{
			var tag = args[i].Split(':');
			var key = tag[0];
			var value = tag[1];
			tags[key] = value;
		}

		switch (component)
		{
			case "resource":
				ResourceGenerator resource = new ResourceGenerator(tags);
				resource.generate();
				break;
			default:
				Console.WriteLine("Invalid component: " + component);
				break;
		}
	}
}