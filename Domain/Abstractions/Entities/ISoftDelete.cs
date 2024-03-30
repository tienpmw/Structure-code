using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions.Entities
{
	public interface ISoftDelete
	{
		bool IsDeleted { get; set; }
		DateTimeOffset DeletedAt { get; set; }
	}
}
