using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CineTurbo.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[] { 85, 97, "2h", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/8tZYtuWezp8JbcsvHYO0O46tFbo.jpg", "Acao", new DateTime(2015, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mad Max: Estrada da Fúria", "Em um mundo pós-apocalíptico, Max se une a uma misteriosa mulher para fugir de um tirano." });

            migrationBuilder.UpdateData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Avaliacao", "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[] { 4, 74, 86, "1h 41min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/fZPSd91yGE9fCcCe6OoQr6E3Bev.jpg", "Acao", new DateTime(2014, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Wick", "Um ex-assassino busca vingança contra aqueles que destruíram sua vida." });

            migrationBuilder.UpdateData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[] { 82, 94, "2h 12min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/1nAfchiXHQB3iyhK8fCJJEnNs5A.jpg", "Acao", new DateTime(1988, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duro de Matar", "Um policial de Nova York enfrenta terroristas que tomam um arranha-céu em Los Angeles." });

            migrationBuilder.UpdateData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[] { 90, 94, "2h 32min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/qJ2tW6WMUDux911r6m7haRef0WH.jpg", "Acao", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Cavaleiro das Trevas", "Batman enfrenta o Coringa, um criminoso que semeia o caos em Gotham." });

            migrationBuilder.UpdateData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[] { 85, 77, "2h 35min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/ty8TGRuvJLPUmAR1H1nRIsgwvim.jpg", "Acao", new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gladiador", "Um general romano busca vingança após ser traído e ver sua família assassinada." });

            migrationBuilder.UpdateData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[] { 85, 95, "1h 55min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/ceG9VzoRAVGwivFU403Wc3AHRys.jpg", "Aventura", new DateTime(1981, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indiana Jones e os Caçadores da Arca Perdida", "Em 1936, o arqueólogo e aventureiro Indiana Jones é contratado pelo governo dos EUA para encontrar a Arca da Aliança antes que os nazistas a obtenham. Em uma corrida contra o tempo, Jones enfrenta perigos mortais em locais exóticos, desvendando enigmas antigos e enfrentando inimigos implacáveis em sua busca por um artefato sagrado que pode mudar o curso da história." });

            migrationBuilder.UpdateData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[] { 80, 79, "2h 23min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/l3peI54mf6Z9EBSvS3hnRmOBbFT.jpg", "Aventura", new DateTime(2003, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Piratas do Caribe: A Maldição do Pérola Negra", "O capitão Jack Sparrow embarca em uma jornada para recuperar seu navio, o Pérola Negra, das mãos do traiçoeiro capitão Barbossa, que lidera uma tripulação amaldiçoada. Com a ajuda de Will Turner e Elizabeth Swann, Jack enfrenta perigos sobrenaturais, batalhas épicas e traições em alto-mar, em uma aventura repleta de ação e humor." });

            migrationBuilder.UpdateData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Avaliacao", "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[] { 4, 73, 74, "1h 47min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/lSzqfKyzb7nRCZ3qihPhdspZeMA.jpg", "Aventura", new DateTime(2011, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "As Aventuras de Tintim", "O jovem repórter Tintim e seu fiel cão Milu descobrem um modelo de navio que contém pistas sobre um tesouro perdido. Juntos, eles embarcam em uma jornada ao redor do mundo, enfrentando vilões perigosos e desvendando mistérios ancestrais, em uma aventura cheia de ação, suspense e descobertas." });

            migrationBuilder.InsertData(
                table: "FilmesDB",
                columns: new[] { "Id", "Avaliacao", "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[,]
                {
                    { 9, 4, 71, 55, "1h 44min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/vgpXmVaVyUL7GGiDeiK1mKEKzcX.jpg", "Aventura", new DateTime(1995, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jumanji", "Ao descobrir um misterioso jogo de tabuleiro, dois irmãos libertam Alan Parrish, que estava preso no jogo há 26 anos. Agora, eles devem enfrentar criaturas selvagens e desafios perigosos que escapam do jogo para o mundo real, tentando terminar a partida para restaurar a normalidade." },
                    { 10, 5, 86, 97, "2h 5min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/39wmItIWsg5sZMyRUHLkWBcuVCM.jpg", "Aventura", new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Viagem de Chihiro", "Chihiro, uma garota de 10 anos, se vê presa em um mundo mágico após seus pais serem transformados em porcos. Para salvá-los e retornar ao mundo real, ela deve trabalhar em uma casa de banhos para espíritos, enfrentando desafios e descobrindo sua coragem interior em uma jornada de autodescoberta." },
                    { 11, 5, 81, 98, "1h 35min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/lRHE0vzf3oYJrhbsHXjIkF4Tl5A.jpg", "Animacao", new DateTime(2015, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Divertida Mente", "Riley é uma garota de 11 anos que enfrenta mudanças importantes em sua vida quando seus pais decidem se mudar para San Francisco. Dentro de sua mente, cinco emoções — Alegria, Tristeza, Medo, Raiva e Nojinho — trabalham juntas para guiá-la em sua nova realidade, enfrentando desafios e aprendendo a lidar com sentimentos complexos." },
                    { 12, 5, 84, 97, "1h 45min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/gGEsBPAijhVUFoiNpgZXqRVWJt2.jpg", "Animacao", new DateTime(2017, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viva: A Vida é uma Festa", "Miguel é um garoto mexicano de 12 anos que sonha em se tornar um grande músico, apesar da proibição de sua família. Determinado a provar seu talento, ele acaba transportado para a Terra dos Mortos, onde encontra seus ancestrais e descobre segredos sobre sua história familiar, embarcando em uma jornada emocionante sobre memória e identidade." },
                    { 13, 5, 80, 98, "1h 48min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/jyjBSQ7lCS2XolhbLeAH5HhXahY.jpg", "Animacao", new DateTime(2016, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zootopia", "Em uma cidade habitada por animais antropomórficos, a coelha Judy Hopps realiza seu sonho de se tornar a primeira oficial de polícia de sua espécie. Para provar seu valor, ela se une ao raposo trapaceiro Nick Wilde para desvendar um mistério que ameaça a paz entre predadores e presas." },
                    { 14, 5, 82, 98, "1h 36min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/6FnpYYl90HeR2tnAgOTaa7jk8oD.jpg", "Animacao", new DateTime(2009, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Up: Altas Aventuras", "Carl Fredricksen, um vendedor de balões de 78 anos, realiza o sonho de sua falecida esposa ao prender milhares de balões em sua casa e voar para a América do Sul. Sem querer, ele leva consigo Russell, um escoteiro de 8 anos, e juntos vivem uma aventura inesquecível cheia de descobertas e amizades." },
                    { 15, 5, 84, 95, "1h 38min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/2TfYp0eMPrcKNjX6PTKGGQODjfF.jpg", "Animacao", new DateTime(2008, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wall-E", "Em um futuro distante, a Terra está coberta de lixo e abandonada pelos humanos. Wall-E, um pequeno robô compactador de lixo, continua sua rotina solitária até encontrar Eva, uma robô enviada para procurar sinais de vida. Juntos, eles embarcam em uma jornada que pode determinar o futuro da humanidade." },
                    { 16, 5, 78, 79, "1h 40min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/uluhlXubGu1VxU63X9VHCLWDAYP.jpg", "Comedia", new DateTime(2009, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Se Beber, Não Case!", "Quatro amigos viajam para Las Vegas para uma despedida de solteiro inesquecível. Após uma noite de festas, eles acordam sem memória dos acontecimentos e descobrem que o noivo desapareceu. Em uma corrida contra o tempo, eles tentam reconstruir os eventos da noite anterior para encontrar seu amigo antes do casamento." },
                    { 17, 4, 56, 15, "1h 49min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/aJZOcorpgloDLkPP6ED0t9sXjNu.jpg", "Comedia", new DateTime(2004, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "As Branquelas", "Dois agentes do FBI, após uma missão fracassada, precisam proteger duas herdeiras de uma possível ameaça de sequestro. Para isso, eles se disfarçam como as irmãs ricas, mergulhando em um mundo de alta sociedade e enfrentando situações hilárias enquanto tentam manter suas identidades em segredo." },
                    { 18, 5, 78, 80, "1h 43min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/kUqhcfr5IoaE76NOIQl53gn3y3Q.jpg", "Comedia", new DateTime(1986, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Curtindo a Vida Adoidado", "Ferris Bueller, um estudante do ensino médio, decide tirar um dia de folga e viver aventuras com sua namorada e melhor amigo. Enquanto isso, o diretor da escola está determinado a desmascarar sua farsa, levando a uma série de situações cômicas e inesquecíveis." },
                    { 19, 4, 70, 85, "1h 56min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/e2qfitm4lm1g3mGc7nGmnnnQa3c.jpg", "Comedia", new DateTime(2005, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Virgem de 40 Anos", "Andy Stitzer é um homem de 40 anos que nunca teve relações sexuais. Quando seus colegas de trabalho descobrem seu segredo, eles se propõem a ajudá-lo a perder a virgindade, levando a uma série de encontros desastrosos e situações embaraçosas." },
                    { 20, 5, 69, 77, "1h 41min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/q9O7aYk2unOdKXt6HCCalF9Jup8.jpg", "Comedia", new DateTime(1994, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Máskara", "Stanley Ipkiss é um bancário tímido que encontra uma máscara mágica que o transforma em um personagem carismático e cheio de energia. Com seus novos poderes, ele enfrenta criminosos e conquista a atenção da mulher de seus sonhos, mas também atrai a atenção de inimigos perigosos." },
                    { 21, 5, 79, 100, "1h 39min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/wvaVhCRVPSYZp2A3utfyrPl0dNw.jpg", "Documentario", new DateTime(2010, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Waste Land", "O artista plástico Vik Muniz viaja ao maior aterro sanitário do mundo, o Jardim Gramacho, no Rio de Janeiro, para criar obras de arte com materiais recicláveis e retratar a vida dos catadores. O documentário mostra como a arte pode transformar vidas e trazer dignidade a pessoas marginalizadas." },
                    { 22, 5, 78, 96, "1h 34min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/zdwN4o7OGAZGJw9T64lRAGTEP8b.jpg", "Documentario", new DateTime(2008, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Food, Inc.", "Este documentário investiga a indústria alimentícia dos Estados Unidos, revelando práticas questionáveis na produção de alimentos e os impactos na saúde pública e no meio ambiente. Com entrevistas e análises, o filme busca conscientizar os consumidores sobre a origem dos alimentos que consomem." },
                    { 23, 4, 78, 90, "1h 13min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/fLJ56kNgzJnvv82oLumG395NKk5.jpg", "Documentario", new DateTime(2001, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janela da Alma", "Dezenove pessoas com diferentes graus de deficiência visual compartilham suas experiências e percepções sobre o mundo. O documentário aborda como a visão (ou a falta dela) influencia a maneira como cada indivíduo interpreta a realidade." },
                    { 24, 5, 78, 93, "1h 57min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/cvO51xxtIUHc5w5ZgFsigiFaUaO.jpg", "Documentario", new DateTime(2022, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "All the Beauty and the Bloodshed", "A fotógrafa Nan Goldin lidera uma campanha contra a família Sackler, responsabilizando-os pela crise dos opioides nos EUA. O documentário entrelaça sua trajetória artística com sua luta ativista, revelando os impactos devastadores do vício em opioides." },
                    { 25, 4, 75, 86, "1h", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/5xz2tR3j4poNVHZWVXHzflOrTnM.jpg", "Documentario", new DateTime(2018, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rotten", "Esta série documental investiga a corrupção e os problemas éticos na cadeia de produção de alimentos ao redor do mundo. Cada episódio expõe práticas controversas em diferentes setores da indústria alimentícia, alertando sobre os riscos para os consumidores." },
                    { 26, 5, 93, 91, "2h 22min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/q6y0Go1tsGEsmtFryDOJo3dEmqu.jpg", "Drama", new DateTime(1994, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Um Sonho de Liberdade", "Andy Dufresne, um banqueiro condenado injustamente pelo assassinato de sua esposa e do amante dela, é enviado à Penitenciária Estadual de Shawshank. Lá, ele forma uma amizade com Red, um prisioneiro que cumpre pena há décadas. Ao longo dos anos, Andy mantém sua esperança viva e planeja uma fuga que mudará sua vida para sempre." },
                    { 27, 4, 68, 94, "2h 6min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/kEy48iCzGnp0ao1cZbNeWR6yIhC.jpg", "Drama", new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Poder do Cão", "Em 1925, os irmãos Phil e George Burbank administram um rancho em Montana. Quando George se casa com Rose, uma viúva local, Phil inicia uma campanha cruel contra ela e seu filho Peter. No entanto, à medida que os eventos se desenrolam, segredos são revelados e as relações entre eles se tornam cada vez mais complexas." },
                    { 28, 5, 76, 98, "2h 59min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/9z4jRr43JdtU66P0iy8h18OyLql.jpg", "Drama", new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Drive My Car", "Yusuke Kafuku, um renomado ator e diretor de teatro, ainda lidando com a perda de sua esposa, aceita dirigir uma peça em Hiroshima. Lá, ele conhece Misaki, uma jovem motorista designada para conduzi-lo. À medida que passam tempo juntos, compartilham segredos e traumas, formando uma conexão profunda que os ajuda a enfrentar suas dores." },
                    { 29, 5, 75, 73, "2h 6min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/cij4dd21v2Rk2YtUQbV5kW69WB2.jpg", "Acao", new DateTime(1989, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman", "Em Gotham City, um misterioso vigilante conhecido como Batman combate o crime e enfrenta seu maior inimigo, o Coringa, um criminoso insano que ameaça mergulhar a cidade no caos." },
                    { 30, 5, 76, 98, "2h 4min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/uKzsziGc04NGRa7ceK06Ivvhzac.jpg", "Drama", new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mangrove", "Baseado em eventos reais, o filme retrata a luta de Frank Crichlow, dono do restaurante Mangrove em Notting Hill, Londres, que se torna alvo de perseguição policial. Em resposta, ele e outros ativistas organizam protestos que culminam em um julgamento histórico, expondo o racismo institucionalizado na polícia britânica." },
                    { 31, 5, 91, 93, "3h 21min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/rCzpDGLbOoPwLjy3OAm5NUPOTrC.jpg", "Fantasia", new DateTime(2003, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Senhor dos Anéis: O Retorno do Rei", "A conclusão épica da trilogia acompanha Frodo e Sam em sua jornada final para destruir o Um Anel, enquanto Aragorn lidera as forças de Gondor contra Sauron. Uma batalha monumental pelo destino da Terra Média se aproxima." },
                    { 32, 5, 78, 90, "2h 22min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/aWxwnYoe8p2d2fcxOqtvAtJ72Rw.jpg", "Fantasia", new DateTime(2004, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter e o Prisioneiro de Azkaban", "No terceiro ano em Hogwarts, Harry descobre que Sirius Black, um perigoso prisioneiro, escapou de Azkaban e pode estar atrás dele. Enquanto isso, segredos sobre o passado de seus pais vêm à tona." },
                    { 33, 5, 82, 95, "1h 58min", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTyxxX4QmH1ucMni22YcJU6pW-xqoqsrwT9OA&s", "Fantasia", new DateTime(2006, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Labirinto do Fauno", "Na Espanha pós-guerra, a jovem Ofélia descobre um mundo mágico onde encontra um fauno que lhe propõe três tarefas para provar que é a reencarnação de uma princesa perdida." },
                    { 34, 4, 69, 76, "2h 23min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/iREd0rNCjYdf5Ar0vfaW32yrkm.jpg", "Fantasia", new DateTime(2005, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "As Crônicas de Nárnia: O Leão, a Feiticeira e o Guarda-Roupa", "Quatro irmãos descobrem um guarda-roupa que os transporta para Nárnia, um mundo mágico onde se juntam ao leão Aslan para derrotar a Feiticeira Branca e restaurar a paz." },
                    { 35, 5, 85, 97, "2h 5min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/39wmItIWsg5sZMyRUHLkWBcuVCM.jpg", "Fantasia", new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Viagem de Chihiro", "Chihiro, uma garota de 10 anos, entra em um mundo mágico dominado por deuses, bruxas e espíritos, onde humanos são transformados em animais. Para salvar seus pais, ela deve encontrar coragem e sabedoria." },
                    { 36, 5, 89, 97, "2h 58min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/bX2xnavhMYjWDoZp1VM6VnU1xwe.jpg", "Faroeste", new DateTime(1966, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Três Homens em Conflito", "Durante a Guerra Civil Americana, três pistoleiros — o Bom, o Mau e o Feio — formam uma aliança instável em busca de um tesouro em ouro enterrado em um cemitério. Em meio a traições e confrontos, eles enfrentam perigos e desafios em uma jornada épica pelo Velho Oeste." },
                    { 37, 5, 82, 96, "2h 10min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/54roTwbX9fltg85zjsmrooXAs12.jpg", "Faroeste", new DateTime(1992, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Os Imperdoáveis", "Um pistoleiro aposentado é convencido a realizar um último trabalho para vingar uma prostituta desfigurada. Ao lado de antigos parceiros, ele enfrenta dilemas morais e confronta seu passado violento em um Oeste em transformação." },
                    { 38, 4, 76, 96, "1h 50min", "https://m.media-amazon.com/images/M/MV5BMTU5MjU3MTI4OF5BMl5BanBnXkFtZTcwMTQxOTAxNA@@._V1_FMjpg_UX1000_.jpg", "Faroeste", new DateTime(2010, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bravura Indômita", "Após o assassinato de seu pai, uma jovem determinada contrata um xerife alcoólatra para ajudá-la a capturar o criminoso. Juntos, eles enfrentam perigos e desafios em uma jornada pelo território indígena." },
                    { 39, 5, 84, 87, "2h 45min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/7oWY8VDWW7thTzWh3OKYRkWUlD5.jpg", "Faroeste", new DateTime(2012, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Django Livre", "No sul dos Estados Unidos, dois anos antes da Guerra Civil, Django, um escravo liberto, une forças com um caçador de recompensas alemão para resgatar sua esposa das mãos de um brutal fazendeiro." },
                    { 40, 4, 74, 77, "2h 40min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/2d1S6fJS80fvseg6mJE8eq5o7Kx.jpg", "Faroeste", new DateTime(2007, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Assassinato de Jesse James pelo Covarde Robert Ford", "A história do lendário fora-da-lei Jesse James e sua relação complexa com Robert Ford, um jovem admirador que eventualmente se torna seu assassino, explorando temas de fama, traição e arrependimento." },
                    { 41, 5, 87, 72, "2h 49min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/nCbkOyOMTEwlEV0LtCOvCnwEONA.jpg", "FiccaoCientifica", new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interestelar", "Em um futuro próximo, a Terra está à beira do colapso ambiental. Um grupo de astronautas embarca em uma missão interestelar para encontrar um novo lar para a humanidade, enfrentando desafios cósmicos e dilemas emocionais ao longo do caminho." },
                    { 42, 5, 80, 88, "2h 44min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/aMpyrCizvSdc0UIMblJ1srVgAEF.jpg", "FiccaoCientifica", new DateTime(2017, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blade Runner 2049", "Trinta anos após os eventos do primeiro filme, um novo blade runner, o oficial K, desenterra um segredo há muito enterrado que tem o potencial de mergulhar o que resta da sociedade no caos." },
                    { 43, 5, 79, 94, "1h 56min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/dc3mXcrPJLRsbcdnlKqYJx718RZ.jpg", "FiccaoCientifica", new DateTime(2016, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Chegada", "Quando misteriosas naves espaciais pousam ao redor do mundo, uma equipe de elite liderada pela linguista Louise Banks é reunida para investigar. Enquanto a humanidade está à beira de uma guerra global, Banks e sua equipe correm contra o tempo para encontrar respostas." },
                    { 44, 5, 77, 92, "1h 48min", "https://www.themoviedb.org/t/p/w1280/hfpnFtgcYom9Gk9s1IyWiovpZYg.jpg", "FiccaoCientifica", new DateTime(2015, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ex Machina: Instinto Artificial", "Um jovem programador é selecionado para participar de um experimento inovador em inteligência artificial, avaliando as capacidades e a consciência de um robô humanoide avançado." },
                    { 45, 5, 79, 91, "1h 53min", "https://www.themoviedb.org/t/p/w1280/ibubeKZuo4ZI2Zu2Dm2s0gmMvuk.jpg", "FiccaoCientifica", new DateTime(2014, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "No Limite do Amanhã", "Em um futuro próximo, a Terra é invadida por uma raça alienígena. O major William Cage é forçado a lutar e, ao ser morto, descobre que está preso em um loop temporal, revivendo o mesmo dia de combate repetidamente." },
                    { 46, 5, 78, 53, "2h 3min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/rNzQyW4f8B8cQeg7Dgj3n6eT5k9.jpg", "Romance", new DateTime(2004, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diário de uma Paixão", "Em um asilo, um homem lê diariamente para uma mulher a história de Noah e Allie, jovens de classes sociais diferentes que se apaixonam na década de 1940. Apesar das adversidades e da oposição familiar, seu amor perdura ao longo dos anos, enfrentando separações e desafios até se reencontrarem." },
                    { 47, 5, 78, 89, "3h 14min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/9xjZS2rlVxm8SFx8kPC3aIGCOYQ.jpg", "Romance", new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Titanic", "Em 1912, a jovem aristocrata Rose embarca no luxuoso navio Titanic e conhece Jack, um artista pobre. Eles vivem um intenso romance a bordo, desafiando as convenções sociais, até que a tragédia do naufrágio muda suas vidas para sempre." },
                    { 48, 4, 71, 54, "1h 50min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/Ia3dzj5LnCj1ZBdlVeJrbKJQxG.jpg", "Romance", new DateTime(2016, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Como Eu Era Antes de Você", "Louisa Clark é contratada para cuidar de Will Traynor, um jovem rico que ficou tetraplégico após um acidente. Com personalidades opostas, eles desenvolvem uma relação que transforma suas vidas, enfrentando dilemas sobre amor e escolhas difíceis." },
                    { 49, 5, 92, 97, "2h 55min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/3bhkrj58Vtu7enYsRolD1fZdja1.jpg", "Drama", new DateTime(1972, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Poderoso Chefão", "Um poderoso chefão do crime entrega o controle de seu império clandestino ao filho relutante. Uma história épica sobre lealdade, poder e a família mafiosa Corleone nos Estados Unidos da década de 1940." },
                    { 50, 5, 78, 86, "2h 9min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/sGjIvtVvTlWnia2zfJfHz81pZ9Q.jpg", "Romance", new DateTime(2005, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orgulho e Preconceito", "Na Inglaterra do século XIX, Elizabeth Bennet enfrenta pressões sociais para se casar. Quando conhece o orgulhoso Sr. Darcy, surge uma relação marcada por mal-entendidos e sentimentos conflitantes, desafiando as convenções da época." },
                    { 51, 5, 86, 96, "1h 58min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/uS9m8OBk1A8eM9I042bx8XXpqAq.jpg", "Suspense", new DateTime(1991, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Silêncio dos Inocentes", "A agente do FBI Clarice Starling busca a ajuda do brilhante, mas perigoso, Dr. Hannibal Lecter, um psiquiatra canibal encarcerado, para capturar outro serial killer conhecido como Buffalo Bill. À medida que Clarice mergulha na mente de Lecter, ela enfrenta seus próprios medos e traumas." },
                    { 52, 5, 86, 81, "2h 7min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/191nKfP0ehp3uIvWqgPbFmI4lv9.jpg", "Suspense", new DateTime(1995, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seven: Os Sete Crimes Capitais", "Dois detetives, um prestes a se aposentar e outro novato, investigam uma série de assassinatos brutais que seguem os sete pecados capitais. À medida que se aprofundam no caso, descobrem uma trama sombria e perturbadora." },
                    { 53, 5, 81, 87, "2h 29min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/ts996lKsxvjkO2yiYG0ht4qAicO.jpg", "Suspense", new DateTime(2014, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garota Exemplar", "No dia do seu quinto aniversário de casamento, Amy desaparece misteriosamente. Sob pressão da polícia e da mídia, o marido Nick começa a apresentar um comportamento estranho, levantando suspeitas sobre seu envolvimento no desaparecimento." },
                    { 54, 5, 82, 68, "2h 18min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/nrmXQ0zcZUL8jFLrakWc90IR8z9.jpg", "Suspense", new DateTime(2010, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ilha do Medo", "Em 1954, os agentes federais Teddy Daniels e Chuck Aule investigam o desaparecimento de uma paciente no hospital psiquiátrico Ashecliffe, localizado em uma ilha remota. Conforme a investigação avança, Teddy confronta segredos obscuros e enfrenta seus próprios demônios." },
                    { 55, 5, 86, 86, "1h 47min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/vOyfUXNFSnaTk7Vk5AjpsKTUWsu.jpg", "Suspense", new DateTime(1999, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Sexto Sentido", "O psicólogo infantil Malcolm Crowe atende Cole Sear, um garoto que afirma ver espíritos de pessoas mortas. À medida que Malcolm tenta ajudar Cole, ambos enfrentam revelações que mudarão suas vidas para sempre." },
                    { 56, 5, 85, 83, "2h 2min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/4ucLGcXVVSVnsfkGtbLY4XAius8.jpg", "Terror", new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Exorcista", "Uma atriz percebe mudanÃ§as assustadoras no comportamento de sua filha de 12 anos. Desesperada, busca ajuda de um padre, que conclui que a garota estÃ¡ possuÃ­da por uma entidade demonÃ­aca. Um exorcista experiente Ã© chamado para enfrentar o mal que habita a menina." },
                    { 57, 5, 84, 84, "2h 26min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/xazWoLealQwEgqZ89MLZklLZD3k.jpg", "Terror", new DateTime(1980, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Iluminado", "Jack Torrance aceita o emprego de zelador de um hotel isolado nas montanhas durante o inverno. Ele se muda com a esposa e o filho, que possui habilidades psÃ­quicas. O isolamento e forÃ§as sobrenaturais levam Jack Ã  loucura, colocando sua famÃ­lia em perigo." },
                    { 58, 5, 85, 98, "1h 57min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/vfrQk5IPloGg1v9Rzbh2Eg3VGyM.jpg", "Terror", new DateTime(1979, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alien: O Oitavo Passageiro", "A tripulaÃ§Ã£o da nave Nostromo responde a um chamado de socorro em um planeta distante. LÃ¡, eles encontram uma forma de vida alienÃ­gena que comeÃ§a a caÃ§Ã¡-los um a um dentro da nave, transformando a missÃ£o em uma luta desesperada pela sobrevivÃªncia." },
                    { 59, 5, 75, 86, "1h 52min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/wVYREutTvI2tmxr6ujrHT704wGF.jpg", "Terror", new DateTime(2013, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Invocação    do Mal", "Baseado em eventos reais, o filme acompanha os investigadores paranormais Ed e Lorraine Warren, que ajudam uma famÃ­lia aterrorizada por uma presenÃ§a sombria em sua casa de campo. Eles enfrentam uma entidade demonÃ­aca poderosa que desafia suas habilidades." },
                    { 60, 5, 73, 89, "2h 7min", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/lHV8HHlhwNup2VbpiACtlKzaGIQ.jpg", "Terror", new DateTime(2018, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hereditário", "ApÃ³s a morte da matriarca da famÃ­lia Graham, sua filha Annie e seus entes queridos comeÃ§am a desvendar segredos sombrios sobre sua ascendÃªncia. Eventos sobrenaturais e tragÃ©dias se intensificam, levando a famÃ­lia a um destino aterrorizante e inevitÃ¡vel." },
                    { 61, 4, 70, 30, "1h 56min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/4ttmnglFa2WxDK3yBkMX1VlpkTo.jpg", "Romance", new DateTime(2007, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Passageiros", "Uma nave espacial viajando para uma colônia em um distante planeta e transportando milhares de pessoas tem um mau funcionamento em suas câmaras do sono. Como resultado, dois passageiros são despertados 90 anos antes.." }
                });

            migrationBuilder.InsertData(
                table: "SeriesDB",
                columns: new[] { "Id", "Avaliacao", "AvaliacaoImdb", "AvaliacaoTomates", "Episodios", "Foto", "Genero", "Lancamento", "Nome", "Sinopse", "Temporadas" },
                values: new object[,]
                {
                    { 1, 5, 86, 88, 204, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/24horas.jpg", "Acao", new DateTime(2001, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "24 Horas", "O agente Jack Bauer tenta impedir ataques terroristas em tempo real.", 9 },
                    { 2, 5, 84, 89, 90, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/prisonbreak.jpg", "Acao", new DateTime(2005, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prison Break", "Um homem elabora um plano para tirar seu irmão do corredor da morte.", 5 },
                    { 3, 4, 74, 85, 170, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/arrow.jpg", "Acao", new DateTime(2012, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arrow", "Um bilionário se torna vigilante para combater o crime.", 8 },
                    { 4, 5, 85, 91, 26, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/punisher.jpg", "Acao", new DateTime(2017, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Punisher", "Um vigilante busca vingança após a morte de sua família.", 2 },
                    { 5, 4, 79, 73, 30, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/jackryan.jpg", "Acao", new DateTime(2018, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack Ryan", "Um analista da CIA é arrastado para perigosas missões ao redor do mundo.", 4 },
                    { 6, 5, 86, 85, 121, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/lost.jpg", "Aventura", new DateTime(2004, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lost", "Sobreviventes de um acidente de avião tentam sobreviver em uma ilha misteriosa.", 6 },
                    { 7, 5, 92, 89, 73, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/got.jpg", "Aventura", new DateTime(2011, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Game of Thrones", "Famílias nobres disputam o trono de ferro em um mundo de fantasia.", 8 },
                    { 8, 5, 88, 85, 89, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/vikings.jpg", "Aventura", new DateTime(2013, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vikings", "A jornada do lendário guerreiro Ragnar Lothbrok.", 6 },
                    { 9, 4, 81, 69, 24, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/witcher.jpg", "Aventura", new DateTime(2019, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher", "Um caçador de monstros luta para encontrar seu lugar em um mundo caótico.", 3 },
                    { 10, 5, 84, 89, 155, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/doctorwho.jpg", "Aventura", new DateTime(2005, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor Who", "Um Senhor do Tempo viaja pelo espaço-tempo enfrentando ameaças.", 13 },
                    { 11, 5, 91, 94, 70, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/8kOWDBK6XlPUzckuHDo3wwVRFwt.jpg", "Animacao", new DateTime(2013, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rick and Morty", "Um cientista excêntrico e seu neto vivem aventuras bizarras pelo universo.", 7 },
                    { 12, 5, 84, 93, 77, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/pB5c5zRC3E0bF71U3xkYBKpVrpV.jpg", "Animacao", new DateTime(2014, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "BoJack Horseman", "Um cavalo ex-astro de TV tenta recuperar sua fama e lidar com questões pessoais.", 6 },
                    { 13, 5, 93, 100, 61, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/2YvPCZ2Re5KcJwBBeBLBUmPpi93.jpg", "Animacao", new DateTime(2005, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avatar: A Lenda de Aang", "Um jovem dobrador de ar deve salvar o mundo dos ataques da Nação do Fogo.", 3 },
                    { 14, 5, 92, 100, 9, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/qzd5xyw1EkaQb5dE4HU2TA7e4nN.jpg", "Animacao", new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arcane", "Baseado no universo de League of Legends, duas irmãs lutam em lados opostos de uma guerra entre tecnologias mágicas e convicções opostas.", 1 },
                    { 15, 5, 87, 85, 35, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/dkMD5qlogeRMiEixC4YNPUvax2T.jpg", "Animacao", new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love, Death & Robots", "Uma coleção de histórias animadas de ficção científica, fantasia, horror e comédia.", 3 },
                    { 16, 5, 85, 95, 153, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/fYVDC2wppxXNfBjL0bBzI8YzRWh.jpg", "Comedia", new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brooklyn Nine-Nine", "Detetives de uma delegacia do Brooklyn enfrentam crimes e situações hilárias.", 8 },
                    { 17, 5, 89, 81, 201, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/qWnJzyZhyy74gjpSjIXWmuk0ifX.jpg", "Comedia", new DateTime(2005, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Office (US)", "Um falso documentário sobre o cotidiano de um escritório de papel.", 9 },
                    { 18, 5, 84, 83, 208, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/fu3QGKuNEwGq8gJ6Q1N7yoEfcXp.jpg", "Comedia", new DateTime(2005, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "How I Met Your Mother", "Ted narra aos filhos como conheceu sua mãe, com várias histórias cômicas.", 9 },
                    { 19, 5, 89, 79, 236, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/f496cm9enuEsZkSPzCwnTESEK5s.jpg", "Comedia", new DateTime(1994, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friends", "Seis amigos vivem aventuras e desventuras em Nova York.", 10 },
                    { 20, 5, 82, 82, 279, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/ooBGRQBdbGzBxAVfDppC5Pi6L3S.jpg", "Comedia", new DateTime(2007, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Big Bang Theory", "Físicos brilhantes lidam com a vida social e suas excentricidades.", 12 },
                    { 21, 5, 93, 88, 8, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/tuIk9wS0IGoI8A1jvhFJrbIYq3A.jpg", "Documentario", new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Our Planet", "Série documental sobre a biodiversidade da Terra e os impactos ambientais.", 1 },
                    { 22, 5, 93, 95, 13, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/6WlHylUzUjaPZBs26y6UoN9zXCu.jpg", "Documentario", new DateTime(2014, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cosmos: Uma Odisséia do Espaço-Tempo", "Neil deGrasse Tyson explora o universo e as leis da natureza.", 1 },
                    { 23, 4, 84, 83, 20, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/sydkFfqwpr5XH7v9iK4e7f3mcTU.jpg", "Documentario", new DateTime(2015, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Making a Murderer", "A história real de Steven Avery, acusado injustamente de um crime.", 2 },
                    { 24, 4, 81, 90, 6, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/ih0CzS9BTtKOzY3csQDRgvYfGbn.jpg", "Documentario", new DateTime(2020, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Night on Earth", "A vida selvagem à noite com tecnologia de filmagem de ponta.", 1 },
                    { 25, 4, 75, 86, 12, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/5xz2tR3j4poNVHZWVXHzflOrTnM.jpg", "Documentario", new DateTime(2018, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rotten", "Investiga a corrupção e os perigos na indústria alimentícia global.", 2 },
                    { 26, 5, 95, 96, 62, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/ggFHVNu6YYI5L9pCfOacjizRGt.jpg", "Drama", new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breaking Bad", "Um professor com câncer começa a fabricar metanfetamina para sustentar sua família.", 5 },
                    { 27, 5, 84, 90, 60, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/4gCkH4ft62prYqpFLPzLi3f1XrP.jpg", "Drama", new DateTime(2016, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Crown", "A história da Rainha Elizabeth II e os eventos históricos durante seu reinado.", 6 },
                    { 28, 5, 85, 92, 106, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/rlXXLpxM3OcQBHXwdHiRvs9F7c6.jpg", "Drama", new DateTime(2016, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "This Is Us", "A vida da família Pearson em diferentes períodos de tempo.", 6 },
                    { 29, 5, 84, 81, 56, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/oIkxqt6ug5zT5ZSUUyc1Iqopf02.jpg", "Drama", new DateTime(2017, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Handmaid's Tale", "Uma mulher luta para sobreviver e encontrar sua filha em um regime totalitário.", 5 },
                    { 30, 4, 84, 88, 18, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/jtnfNzqZwN4E32FGGxx1YZaBWWf.jpg", "Drama", new DateTime(2019, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Euphoria", "Jovens enfrentam dilemas sobre sexo, drogas e identidade.", 2 },
                    { 31, 5, 88, 93, 34, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/x2LSRK2Cm7MZhjluni1msVJ3wDF.jpg", "Fantasia", new DateTime(2016, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stranger Things", "Crianças enfrentam forças sobrenaturais em uma cidade dos anos 80.", 4 },
                    { 32, 5, 84, 91, 327, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/KoYWXbnYuS3b0GyQPkbuexlVK9.jpg", "Fantasia", new DateTime(2005, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supernatural", "Dois irmãos caçam criaturas sobrenaturais em todo o país.", 15 },
                    { 33, 4, 83, 86, 93, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/4EYPN5mVIhKLfxGruy7Dy41dTVn.jpg", "Fantasia", new DateTime(2016, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucifer", "O diabo decide tirar férias em Los Angeles e se envolve com a polícia local.", 6 },
                    { 34, 4, 78, 87, 11, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/q54qEgagGOYCq5D1903eBVMNkbo.jpg", "Fantasia", new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sandman", "Morpheus escapa do cativeiro e tenta restaurar seu reino dos sonhos.", 1 },
                    { 35, 4, 77, 81, 23, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/48cKa4pjGxFbnfURn3q4ysjSrSk.jpg", "Fantasia", new DateTime(2019, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "His Dark Materials", "Uma jovem embarca em uma jornada para entender o pó e descobrir verdades perigosas.", 3 },
                    { 36, 5, 86, 92, 36, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/3CqM03vddNuhLZdD9ejgCn1jKkn.jpg", "Faroeste", new DateTime(2004, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deadwood", "Uma cidade sem lei atrai foras da lei e empreendedores no Velho Oeste.", 3 },
                    { 37, 4, 81, 85, 7, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/rk3c7SddkeWPPG7cG6sS9QYDQ8c.jpg", "Faroeste", new DateTime(2017, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Godless", "Um fora da lei busca vingança em uma cidade governada por mulheres.", 1 },
                    { 38, 5, 87, 89, 10, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/oKt4J3TFjWirVwBqoHyIvv5IImd.jpg", "Faroeste", new DateTime(2021, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "1883", "A família Dutton embarca em uma jornada através das grandes planícies.", 1 },
                    { 39, 4, 84, 78, 63, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/jAeRUT8ZsoCOvJWgkB5NqV0L1VZ.jpg", "Faroeste", new DateTime(2012, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Longmire", "Um xerife enfrenta crimes enquanto lida com tragédias pessoais.", 6 },
                    { 40, 3, 61, 65, 57, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/6TjllWT3cGrPFyqDXurVZ3L8bBi.jpg", "Faroeste", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walker", "Um Texas Ranger volta para casa após dois anos disfarçado.", 3 },
                    { 41, 5, 84, 83, 27, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/pXeuSWSKguhD4GzS7H1syFf8mQB.jpg", "FiccaoCientifica", new DateTime(2011, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Mirror", "Uma antologia que explora o impacto da tecnologia na sociedade.", 6 },
                    { 42, 5, 87, 95, 26, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/apbrbWs8M9lyOpJYU5WXrpFbk1Z.jpg", "FiccaoCientifica", new DateTime(2017, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark", "Quatro famílias descobrem um segredo misterioso que abrange várias gerações.", 3 },
                    { 43, 5, 86, 90, 100, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/nzs9NqJqPefwz3IiWcB2MRAGr7l.jpg", "FiccaoCientifica", new DateTime(2008, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fringe", "Uma equipe do FBI investiga fenômenos inexplicáveis.", 5 },
                    { 44, 5, 87, 94, 62, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/4zjX4WezXJOAtj7iC3ypgEUBcX0.jpg", "FiccaoCientifica", new DateTime(2015, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Expanse", "Conspirações interplanetárias ameaçam a paz entre a Terra, Marte e o Cinturão.", 6 },
                    { 45, 4, 78, 75, 18, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/vLCogyfQGxVLDC1gqUdNAIkc29L.jpg", "FiccaoCientifica", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Altered Carbon", "Em um futuro onde a consciência pode ser transferida para outros corpos.", 2 },
                    { 46, 5, 84, 89, 83, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/yCvp5sKw2JdB1lmxZ46zRKOZhA0.jpg", "Romance", new DateTime(2014, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Outlander", "Uma mulher viaja no tempo e se vê dividida entre dois amores.", 7 },
                    { 47, 4, 76, 82, 24, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/lu8A85oIDv24rM2GQgE7VgALhVg.jpg", "Romance", new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bridgerton", "Os escândalos e romances da alta sociedade londrina do século XIX.", 3 },
                    { 48, 4, 85, 91, 12, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/9E8T6FZ9GqH1eWkH7Z6yQpRI3pu.jpg", "Romance", new DateTime(2020, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal People", "Dois jovens lidam com amor, amizade e amadurecimento na Irlanda.", 1 },
                    { 49, 4, 75, 80, 52, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/vdqA2rGAKNoU0gQjIBmK1bfQMO7.jpg", "Romance", new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virgin River", "Uma enfermeira busca um novo começo em uma pequena cidade.", 5 },
                    { 50, 3, 66, 63, 30, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/3iYQTLGoy7QnjcUyAgzDdgH2Gby.jpg", "Romance", new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily in Paris", "Emily se muda para Paris e precisa adaptar sua vida profissional e pessoal.", 3 },
                    { 51, 5, 85, 97, 19, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/7vrIXTKfSxnV4xDig3t1fguRJU2.jpg", "Suspense", new DateTime(2017, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mindhunter", "Agentes do FBI desenvolvem técnicas de perfis psicológicos para serial killers.", 2 },
                    { 52, 4, 78, 91, 40, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/5b0biZk5EEC2Zz1gMV9wYpJ83A4.jpg", "Suspense", new DateTime(2018, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "You", "Um homem desenvolve uma obsessão perigosa por uma mulher.", 4 },
                    { 53, 4, 87, 72, 96, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/zR6E4a4zXxvC9id4uRDoBe5gLdv.jpg", "Suspense", new DateTime(2006, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dexter", "Um analista forense que também é um serial killer de criminosos.", 8 },
                    { 54, 4, 81, 84, 17, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/4vXUFEJ3qUbEW9Ns4MJwCW0Dnvw.jpg", "Suspense", new DateTime(2013, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Fall", "Um detetive persegue um assassino em série em Belfast.", 3 },
                    { 55, 4, 85, 91, 24, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/4A2n2yOU9H9F9EmeVOzvAPxM9tr.jpg", "Suspense", new DateTime(2013, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Broadchurch", "A investigação do assassinato de um garoto em uma pequena cidade.", 3 },
                    { 56, 5, 86, 93, 10, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/8yZAXy4vs2FAGQ1qtCq6f7yk3Mf.jpg", "Terror", new DateTime(2018, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Haunting of Hill House", "Uma família enfrenta traumas do passado após viver em uma casa assombrada.", 1 },
                    { 57, 4, 81, 77, 129, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/xUwBTkQW2pP4ysjFY4lTr9tqD36.jpg", "Terror", new DateTime(2011, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "American Horror Story", "Cada temporada conta uma história de terror diferente com o mesmo elenco.", 12 },
                    { 58, 4, 74, 88, 8, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/vkL1r2q73e0syxEoGOYl6T7aMyD.jpg", "Terror", new DateTime(2019, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marianne", "Uma escritora de terror descobre que seus pesadelos são reais.", 1 },
                    { 59, 4, 84, 91, 27, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/7zeShpQxs2oLJ8K6JbFxXNBmB5s.jpg", "Terror", new DateTime(2014, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Penny Dreadful", "Personagens clássicos do horror se encontram em uma Londres sombria.", 3 },
                    { 60, 4, 80, 79, 177, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/reKs8y4mPwPkZG99ZpbKRhBPKsX.jpg", "Terror", new DateTime(2010, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Walking Dead", "Sobreviventes tentam resistir em um mundo dominado por zumbis.", 11 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "SeriesDB",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.UpdateData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[] { 87, 88, "2h 16min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/1aadn0aD7h1VKq4yap2uKl7cTSL.jpg", "Ficção Científica", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matrix", "Um hacker descobre a verdade sobre sua realidade." });

            migrationBuilder.UpdateData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Avaliacao", "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[] { 5, 87, 88, "2h 16min", "https://www.themoviedb.org/t/p/w1280/9e3Dz7aCANy5aRUQF745IlNloJ1.jpg", "Ficção Científica", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matrix", "Um hacker descobre a verdade sobre sua realidade." });

            migrationBuilder.UpdateData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[] { 87, 88, "2h 16min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/4lj1ikfsSmMZNyfdi8R8Tv5tsgb.jpg", "Ficção Científica", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matrix", "Um hacker descobre a verdade sobre sua realidade." });

            migrationBuilder.UpdateData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[] { 88, 91, "2h 58min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/qVf6lTFzDsBZUbYbk8m9dk9SipX.jpg", "Fantasia", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Senhor dos Anéis: A Sociedade do Anel", "Um hobbit embarca em uma jornada épica para destruir um anel maligno." });

            migrationBuilder.UpdateData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[] { 88, 91, "2h 58min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/x5hsAHiwLQrM7jlSZzR7AdWZquk.jpg", "Fantasia", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Senhor dos Anéis: A Sociedade do Anel", "Um hobbit embarca em uma jornada épica para destruir um anel maligno." });

            migrationBuilder.UpdateData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[] { 88, 91, "2h 58min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/TpcNor0WkmD1SBO3n3tlkQqmOf.jpg", "Fantasia", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Senhor dos Anéis: A Sociedade do Anel", "Um hobbit embarca em uma jornada épica para destruir um anel maligno." });

            migrationBuilder.UpdateData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[] { 88, 91, "2h 58min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/wd9fppMrD3KbH8jAMTqCF28QejD.jpg", "Fantasia", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Senhor dos Anéis: A Sociedade do Anel", "Um hobbit embarca em uma jornada épica para destruir um anel maligno." });

            migrationBuilder.UpdateData(
                table: "FilmesDB",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Avaliacao", "AvaliacaoImdb", "AvaliacaoTomates", "Duracao", "Foto", "Genero", "Lancamento", "Nome", "Sinopse" },
                values: new object[] { 5, 88, 91, "2h 58min", "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/9e0Yftt4svEI268iogQQdMXvng6.jpg", "Fantasia", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "O Senhor dos Anéis: A Sociedade do Anel", "Um hobbit embarca em uma jornada épica para destruir um anel maligno." });
        }
    }
}
