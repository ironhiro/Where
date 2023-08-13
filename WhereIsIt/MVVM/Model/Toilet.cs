using System;
namespace WhereIsIt.MVVM.Model
{
	public struct ToiletCounts
	{
		public ToiletCounts(int male_poop, int male_urin,
			int male_poopH, int male_urinH, int male_poopC, int male_urinC,
			int female_poop, int female_poopH, int female_poopC)
		{
			this.male_poop = male_poop;
			this.male_poopC = male_poopC;
			this.male_poopH = male_poopH;
			this.male_urin = male_urin;
			this.male_urinC = male_urinC;
			this.male_urinH = male_urinH;
			this.female_poop = female_poop;
			this.female_poopC = female_poopC;
			this.female_poopH = female_poopH;
		}

		public int male_poop { get; private set; }
		public int male_urin { get; private set; }
		public int male_poopH { get; private set; }
		public int male_urinH { get; private set; }
		public int male_poopC { get; private set; }
		public int male_urinC { get; private set; }
		public int female_poop { get; private set; }
		public int female_poopH { get; private set; }
		public int female_poopC { get; private set; }
	}

	public enum ToiletType
	{
		개방화장실,
		공중화장실,
		이동화장실,
		간이화장실,
	}

	public class Toilet
	{
		public Toilet()
		{
		}

		public int index { get; set; }
		public ToiletType toiletType { get; set; }
		public string toiletName { get; set; }
		public double latitude { get; set; }
		public List<string> address { get; set; }
		public double longitude { get; set; }
		public ToiletCounts toiletCounts { get; set; }
		public string administrator { get; set;}
		public bool hasCCTV { get; set; }
		public string openTime { get; set; }
		public bool hasEmergency { get; set; }
		public string EmergencyLoc { get; set; }
		public string contact { get; set; }
		public DateTime dataDate { get; set; }
	}
}

