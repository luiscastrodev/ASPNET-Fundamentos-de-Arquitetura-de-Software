namespace OOP
{
    // Definição de Classe
    //estrutura de codigo que tem a funcao de mapear algo do mundo real
    public class Casa
    {
        public int TamanhoM2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroVagas { get; set; }
    }

    public class Objeto
    {
        //Objeto é quando tem uma classe sendo instanciada , ela fica alocada na memoria ela passa a ser um objeto 
        //apesar de ser uma classe temos um objeto com valores
        public Objeto()
        {
            // Definição de Objeto
            var casa = new Casa
            {
                TamanhoM2 = 100,
                Andares = 2,
                Valor = 100000,
                NumeroVagas = 3
            };
        }
    }
}