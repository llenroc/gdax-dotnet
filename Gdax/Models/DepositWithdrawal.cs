﻿using System;
using Newtonsoft.Json;

namespace Gdax.Models
{
	public class DepositWithdrawal
	{

		[JsonProperty("id")]
		public String Id { get; set; }

		[JsonProperty("amount")]
		public Decimal Amount { get; set; }

		[JsonProperty("currency")]
		public String Currency { get; set; }

		[JsonProperty("payout_at")]
		public DateTime Payout_At { get; set; }
	}

}
