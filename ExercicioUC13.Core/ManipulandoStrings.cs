using System;

namespace ExercicioUC13.Core
{
    public static class ManipulandoStrings
    {
        //Deve retornar o nome da "Olá " + o nome informado.
        //Ex: input "Fulano", output: "Olá Fulano"
        //Deve retornar vazio para nomes inválidos
        public static string OlaPessoa(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                return string.Empty;

            return $"Olá {nome}";
        }

        /*
        Processar linhas de Log.
        Toda linha de log segue esse padrão: "[<LEVEL>]: <MENSAGEM>".

        Há 3 diferentes níveis:

        INFO
        WARNING
        ERROR

        Ex1: "[ERROR]: Operação inválida"
        Ex2: "[WARNING]: Conexão limitada"
        Ex3: "[INFO]: Operação concluída"
         */


        public static string ExtrairMensagemDoLog(string mensagem)
        {
            return mensagem.Substring(mensagem.IndexOf(":") + 1);
        }

        /* Removedor de espaços duplicado
         * Devolve um texto sem duplos espaços, ou espaços extras no início e fim
         * Ex: input: " Bom  dia", output: "Bom dia"
         */
        public static string RemoveEspacosDuplicados(string texto)
        {
            while (texto.Contains("  ")) 
                texto = texto.Replace("  ", " ");

            return texto;
        }
    }
}
