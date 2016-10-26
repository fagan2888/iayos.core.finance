namespace iayos.core.finance.MarketEnums
{

	/// <summary>
	/// https://en.wikipedia.org/wiki/Global_Industry_Classification_Standard
	/// </summary>
	public enum GlobalIndustryClassificationStandardSector
	{
		/// <summary>
		/// By setting this to zero, we know it will be the default, and will alert us when we've forgotten to initialise
		/// </summary>
		IAYOS_UNINIT_ERROR = 0,

		Energy = 10,
		Materials = 15,
		Industrials = 20,
		ConsumerDiscetionary = 25,
		ConsumerStaples = 30,
		HealthCare = 35,
		Financials = 40,
		InformationTechnology = 45,
		TelecommunicationsServices = 50,
		Utilities = 55
	}
}