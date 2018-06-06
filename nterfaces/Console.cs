using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces {
	class Console : IPrint, IWrite {
		public void Print(string s) {
			System.Console.WriteLine(s);
		}

		public void PrintAll(string[] strings) {
			foreach (string str in strings) {
				Print(str);

			}
		}

		public void Test() {
			throw new NotImplementedException();
		}

		public void Write(string s) {
			throw new NotImplementedException();
		}
	}
}
