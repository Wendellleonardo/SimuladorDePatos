namespace FormsPatos
{
    public class DuckController
    {
        public string ExecutarAcao(Duck pato, string acao)
        {
            return pato.Executar(acao);
        }

        public string ObterCaminhoGif(Duck pato, string acao) => acao switch
        {
            "Quack" => "Gifs/quack.gif";
            "Voar" => "Gifs/fly.gif";
            "Nadar" => "Gifs/swim.gif";
            "Dormir" => "Gifs/sleep.gif";
            "Acordar" => "Gifs/wakeup.gif";
            _ => null
        };
    }
}
