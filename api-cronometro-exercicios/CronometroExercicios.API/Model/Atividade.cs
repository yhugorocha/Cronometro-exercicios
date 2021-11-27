namespace CronometroExercicios.API.Model
{
    public class Atividade
    {
        public int AtividadeId { get; set; }
        public string Nome { get; set; }
        public int Duracao { get; set; }
        public int Repeticoes { get; set; }
        public int TempoPreparacao { get; set; }
        public int Descanso { get; set; }
    }
}