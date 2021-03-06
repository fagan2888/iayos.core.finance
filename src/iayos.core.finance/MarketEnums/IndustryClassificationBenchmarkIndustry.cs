﻿namespace iayos.core.finance.MarketEnums
{
	/// <summary>
	/// https://en.wikipedia.org/wiki/Industry_Classification_Benchmark
	/// </summary>
	public enum IndustryClassificationBenchmarkIndustry
	{
		/// <summary>
		/// By setting this to zero, we know it will be the default, and will alert us when we've forgotten to initialise
		/// </summary>
		IAYOS_UNINIT_ERROR = 0,

		OilAndGas = 0001,
		BasicMaterials = 1000,
		Industrials = 2000,
		ConsumerGoods = 3000,
		HealthCare = 4000,
		ConsumerServices = 5000,
		Telecommunications = 6000,
		Utilities = 7000,
		Financials = 8000,
		Technology = 9000
	}
}