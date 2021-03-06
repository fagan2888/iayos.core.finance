﻿namespace iayos.core.finance.MarketEnums
{

	/// <summary>
	/// DEVELOPER_ERROR = 0,
	///	CASH - Name: Cash
	///	UNIT - Code: Units,
	///	SCRI - Name: Scrip,
	///	KIND - Name: InKind,
	/// https://www.iso20022.org/standardsrepository/public/wqt/Description/mx/dico/codesets/_axNd2dp-Ed-ak6NoX_4Aeg_-1189024253
	/// </summary>
	public enum DividendTypeCodeIso20022
	{
		/// <summary>
		/// By setting this to zero, we know it will be the default, and will alert us when we've forgotten to initialise
		/// </summary>
		IAYOS_UNINIT_ERROR = 0,

		CASH = 10, // Name: Cash
		UNIT = 20, // Code: Units,
		SCRI = 30, // Name: Scrip,
		KIND = 40  // Name: InKind,
	}
}
