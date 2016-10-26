namespace iayos.core.finance.MarketEnums
{
	/// <summary>
	/// DEVELOPER_ERROR = 0,
	///	CAPO,		// Capital Portion
	///	FLFR,		// Fully Franked
	///	INCO,		// Income Portion
	///	INTR,		// Interest
	///	SOIC,		// Sundry or Other Income
	///	TXBL,		// Taxable Portion
	///	TXDF,		// Tax Deferred
	///	TXFR,		// Tax Free
	///	UNFR,		// Unfranked
	///	LTCG,		// Long Term Capital Gain
	///	STCG,		// Short term Capital Gain
	///	FUPU,		// Full Period Units Income Portion
	///	PAPU,		// Part Way Period Units Income Portion
	///	REES		// Real Estate Property Income Portion
	/// https://www.iso20022.org/standardsrepository/public/wqt/Description/mx/dico/codesets/_axET5tp-Ed-ak6NoX_4Aeg_-411764395
	/// </summary>
	public enum DividendRateTypeCodeIso20022
	{
		/// <summary>
		/// By setting this to zero, we know it will be the default, and will alert us when we've forgotten to initialise
		/// </summary>
		IAYOS_UNINIT_ERROR = 0,

		CAPO,		// Capital Portion
		FLFR,		// Fully Franked
		INCO,		// Income Portion
		INTR,		// Interest
		SOIC,		// Sundry or Other Income
		TXBL,		// Taxable Portion
		TXDF,		// Tax Deferred
		TXFR,		// Tax Free
		UNFR,		// Unfranked
		LTCG,		// Long Term Capital Gain
		STCG,		// Short term Capital Gain
		FUPU,		// Full Period Units Income Portion
		PAPU,		// Part Way Period Units Income Portion
		REES		// Real Estate Property Income Portion
	}
}