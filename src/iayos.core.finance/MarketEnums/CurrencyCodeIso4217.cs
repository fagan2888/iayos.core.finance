namespace iayos.core.finance.MarketEnums
{
	public enum CurrencyCodeIso4217
	{
		/// <summary>
		/// By setting this to zero, we know it will be the default, and will alert us when we've forgotten to initialise
		/// </summary>
		IAYOS_UNINIT_ERROR = 0,

		AUD,
		CAD,
		CHF,			// swiss franc
		DKK,			// danish krone
		EUR,
		GBP,
		ISK,			// icelandic krona
		SEK,			// swedish krona
		USD
	}
}
