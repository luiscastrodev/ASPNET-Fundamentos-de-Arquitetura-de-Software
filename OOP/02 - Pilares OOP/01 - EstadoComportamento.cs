using System;

namespace OOP
{
    public class Pessoa
    {
        //estado seria os atributos
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        // o comportamento é quando gera uma nova informacao atravez da propria classe
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }
    }
}