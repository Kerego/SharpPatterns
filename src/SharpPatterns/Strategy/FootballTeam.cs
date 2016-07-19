namespace SharpPatterns.Strategy
{
	public class FootballTeam
	{
		public string Name { get; set; }

		private IFormation _formation;

		public void Play() => _formation.Play(Name);

		public void SetPlayFormation(IFormation formation) => _formation = formation; 
		
	}
}
