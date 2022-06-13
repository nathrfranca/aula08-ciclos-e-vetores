String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };


// 1.1. Apresenta todos os filmes da lista separados por ponto e vírgula.
string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
{
    string lista = "";
    for (int i = 0; i < listaDeFilmes.Length; i++)
    {
        lista += ($"{listaDeFilmes[i]}; ");
    }
    return lista;
}
Console.WriteLine(apresentaTodosOsFilmesSeparadosPorPontoVirgula());


// 1.2. Apresentar quantidade de filmes da lista.
int quantidadeTotalDeFilmes()
{
    return listaDeFilmes.Length;
}
Console.WriteLine(quantidadeTotalDeFilmes());


// 1.3. Buscar o nome do filme de acordo com seu índice.
string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
{
    return listaDeFilmes[indiceDoFilme];
}
Console.WriteLine(buscarNomeDoFilmePeloIndice(2));

// 1.4. Adiciona um novo filme a lista pelo seu nome.
String[] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
{
    listaDeFilmes[listaDeFilmes.Length - 1] = nomeDoFilme;
    return listaDeFilmes;
}
Console.WriteLine(adicionaUmNovoFilmePeloSeuNome("Batman"));

// 1.5. Atualiza um filme a partir do seu índice na lista.
string[] atualizarUmFilmePeloSeuIndice(int indiceDoFilme, string filmeSubstituto)
{
    listaDeFilmes[indiceDoFilme] = filmeSubstituto;
    return listaDeFilmes;
}
Console.WriteLine(atualizarUmFilmePeloSeuIndice(1, "NovoFilme"));
Console.WriteLine(apresentaTodosOsFilmesSeparadosPorPontoVirgula());


// 1.6. Listar todos os filmes com seu índice/posição na lista.
String listarTodosOsFilmesComSeuIndiceNaLista()
{
    string lista = "";
    for (int i = 0; i < listaDeFilmes.Length; i++)
    {
        int posicao = i + 1;
        lista += ($"indice:{i} - Posição:{posicao} - conteudo:{listaDeFilmes[i]}; \r\n");
    }
    return lista;
}
Console.WriteLine(listarTodosOsFilmesComSeuIndiceNaLista());