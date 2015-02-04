using System;

namespace TwinCitiesCodeCamp
{
	public static class Constants
	{
		public const string BlogDateTimeFormat = "MM.dd.yyyy hh:mm:ss tt";
		public static readonly Guid BlogId = new Guid("662ce475-4a14-4d5f-83cb-5b1a2f5302e6");
		public static readonly TimeZoneInfo TimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
		public const string MonthYearVisibleFormat = "MMM yyyy";
	}
}