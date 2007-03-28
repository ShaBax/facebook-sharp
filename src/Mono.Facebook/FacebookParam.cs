//
// Mono.Facebook.FacebookParam.cs:
//
// Authors:
//	Thomas Van Machelen (thomas.vanmachelen@gmail.com)
//
// (C) Copyright 2007 Novell, Inc. (http://www.novell.com)
//

// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System;

namespace Mono.Facebook
{
	public class FacebookParam : IComparable
	{
		private string name;
		private object value;

		public string Name
		{
			get { return name; }
		}

		public object Value
		{
			get { return value; }
		}

		public FacebookParam (string name, object value)
		{
			this.name = name;
			this.value = value;
		}

		public override string ToString ()
		{
			return string.Format ("{0}={1}", name, value.ToString ());
		}

		public static FacebookParam Create (string name, object value)
		{
			return new FacebookParam (name, value);
		}

		public int CompareTo (object obj)
		{
			if (!(obj is FacebookParam))
				return -1;

			return this.name.CompareTo ((obj as FacebookParam).name);
		}
	}
}
