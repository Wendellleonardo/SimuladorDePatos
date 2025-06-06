namespace FormsPatos
{
    public class DuckController
    {
        public string ExecutarAcao(Duck pato, string acao)
        {
            return pato.Executar(acao);
        }

        public string ObterCaminhoGif(Duck pato, string acao)
        {
            if (pato is RubberDuck && (acao == "Voar" || acao == "Dormir" || acao == "Acordar"))
            {
                return null;
            }

            if (acao == "Quack")
                return "Gifs/quack.gif";
            else if (acao == "Voar")
                return "Gifs/fly.gif";
            else if (acao == "Nadar")
                return "Gifs/swim.gif";
            else if (acao == "Dormir")
                return "Gifs/sleep.gif";
            else if (acao == "Acordar")
                return "Gifs/wakeup.gif";
            else
                return null;
        }
    }
}