namespace AluraNutricao
{
	public class Refeicao
	{
		public double Calorias { get; private set; }
		public string Descricao { get; private set; }

		public Refeicao(string descricao, double calorias)
		{
			Descricao = descricao;
			Calorias = calorias;
		}
	}
}