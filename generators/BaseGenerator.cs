using System.Collections.Generic;

namespace Generators;
abstract class BaseGenerator
{
	private Dictionary<string, string> tags;

	public BaseGenerator(Dictionary<string, string> tags)
	{
		this.tags = tags;
	}

	public abstract void generate();

}