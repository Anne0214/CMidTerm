using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMain
{
	public interface IExportCSV
	{
		string[] Columns { get; set; }
	}
}
