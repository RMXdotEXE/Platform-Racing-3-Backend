﻿using PlatformRacing3.Common.Customization;

namespace PlatformRacing3.Common.Extensions;

public static class PartExtensions
{
	public static bool IsStaffOnly(this Part part)
	{
		return part switch
		{
			Part.Invisible or Part.MEME or Part.Steve or Part.RatLegacy => true,

			_ => false,
		};
	}

	public static bool IsTournamentPrize(this Part part)
	{
		return part switch
		{
			Part.Hoodie or Part.Cheetah or Part.Cyborg or Part.Spider or Part.Scientist or Part.Abomination => true,

			_ => false,
		};
	}

	public static (bool Head, bool Body, bool Feet) HasParts(this Part part)
	{
		return part switch
		{
			Part.Hoodie => (false, true, false),

			_ => (true, true, true)
		};
	}
}
