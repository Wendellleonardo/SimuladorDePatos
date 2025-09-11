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
            if (pato is RubberDuck && (acao == "Voar" || acao == "Nadar" || acao == "Dormir" || acao == "Acordar"))
            {
                return null;
            }

            switch (acao)
            {
                case "Quack": return "Gifs/quack.gif";
                case "Voar": return "Gifs/fly.gif";
                case "Nadar": return "Gifs/swim.gif";
                case "Dormir": return "Gifs/sleep.gif";
                case "Acordar": return "Gifs/wakeup.gif";
                default: return null;
            }
        }
    }
}