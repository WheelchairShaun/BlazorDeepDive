namespace ServerManagement.Models;

public class CitiesRepository
{
	private static List<string> cities = new()
	{
		"Toronto",
		"Montreal",
		"Ottawa",
		"Calgary",
		"Halifax"
	};

	public static List<string> GetCities() => cities;
}
