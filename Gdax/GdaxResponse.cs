﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;

namespace Gdax
{
	public class GdaxResponse
	{
		public GdaxResponse(KeyValuePair<String, IEnumerable<String>>[] headers, HttpStatusCode statusCode, String content)
		{
			this.Headers = headers.ToArray();
			this.StatusCode = statusCode;
			this.Content = content;

			// Show JSON response status in output
			Debug.WriteLine(this.StatusCode);
			Debug.WriteLine(this.Content);
		}

		public KeyValuePair<String, IEnumerable<String>>[] Headers { get; }
		public HttpStatusCode StatusCode { get; }
		public String Content { get; }

		
	}
}
