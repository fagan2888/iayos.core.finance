namespace iayos.core.finance.MarketEnums
{

	/// <summary>
	/// Ideally parse a full list into some referential resource from:
	/// http://www.iso15022.org/mic/homepagemic.htm
	/// But for now, this approach is flawed... have to factor difference between "segment" and "operating" mics.
	/// Also, sometimes something like nasdaq omx just lists "First North" but there are lots of instances.
	/// http://www.iotafinance.com/en/ISO-10383-Market-Identification-Codes-MIC.html
	/// </summary>
	public enum MarketIdCodeIso10383
	{
		DEVELOPER_ERROR = 0,
		XHEL,       // NASDAQ HELSINKI Ltd
		NASD,       // NASDAQ DARK
		XASX,       // AUSTRALIAN STOCK EXCHANGE (ALL MARKETS)
		XLON,       // LONDON STOCK EXCHANGE
		XNYS,        // NEW YORK STOCK EXCHANGE

		XCSE,		// First North Denmark

	}


	public enum OperatingMarketIdCodeIso10383
	{
		DEVELOPER_ERROR = 0,
		FNDK,			// North North Denmark

	}
}
