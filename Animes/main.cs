using System;
using System.Collections.Generic;

public class Program {
  
  public static void Main(){

    try{
      Sistema.ArquivosAbrir();
    }
    catch (Exception erro) {
      Console.WriteLine(erro.Message);
    }
    
    Console.WriteLine("Bem vindo aos AnimesIf Oficial!");
    Console.WriteLine("Seu Programa de Pirataria Oficial!");    
    Console.WriteLine("⠀⠀⠀⠀⣠⣶⡾⠏⠉⠙⠳⢦⡀⠀⠀⠀ ⢠⠞⠉⠙⠲⡀⠀");
    Console.WriteLine("⠀⠀⠀⣴⠿⠏⠀⠀⠀⠀⠀  ⢳⡀⠀ ⡏⠀⠀⠀⠀ ⢷");
    Console.WriteLine("⠀⠀⢠⣟⣋⡀  ⣀⡀⠀⣀⡀ ⣧⠀⢸⠀⠀⠀ ⠀⠀ ⡇");
    Console.WriteLine("⠀⠀⢸⣯⡭⠁⠸⣛⣟⠆⡴⣻⡲ ⣿⠀⣸⠀⠀ OK  ⡇");
    Console.WriteLine("⠀⠀⣟⣿⡭⠀⠀⠀⠀⠀⠀⢱⠀⠀⣿⠀⢹⠀⠀⠀⠀⠀⠀ ⡇");
    Console.WriteLine("⠀⠀⠙⢿⣯⠄⠀⠀⠀ ⢀.⡀⠀⡿⠀⠀⡇⠀ ⠀⠀⠀⡼");
    Console.WriteLine("⠀⠀⠀⠀⠹⣶⠆⠀⠀⠀⠀⠀⠀⡴⠃⠀⠀⠘⠤⣄⣠⠞⠀");
    Console.WriteLine("⠀⠀⠀⠀⢸⣷⡦⢤⡤⢤⣞⣁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
    Console.WriteLine("⠀⠀⢀⣤⣴⣿⣏⠁⠀⠀⠸⣏⢯⣷⣖⣦⡀⠀⠀⠀⠀⠀⠀");
    Console.WriteLine("⢀⣾⣽⣿⣿⣿⣿⠛⢲⣶⣾⢉⡷⣿⣿⠵⣿⠀⠀⠀⠀⠀⠀");
    Console.WriteLine("⣼⣿⠍⠉⣿⡭⠉⠙⢺⣇⣼⡏⠀⠀⠀⠀⣄⢸⠀⠀⠀⠀⠀⠀");
    Console.WriteLine("⣿⣿⣧⣀⣿ ……… ⣀⣰⣏⣘⣆⣀⠀⠀");
    int op = 0;
    int perfil = 0;
    do{
      try {
      if (perfil == 0){
        op = 0;
        perfil = MenuUsuario();
      }
      if (perfil == 1) {
        op = MenuAdmin();
          switch(op){
            case 1 : GeneroInserir(); break;
            case 2 : GeneroListar(); break;
            case 3 : GeneroAtualizar(); break;
            case 4 : GeneroExcluir(); break;
            case 5 : AnimeInserir(); break;
            case 6 : AnimeListar(); break;
            case 7 : AnimeAtualizar(); break;
            case 8 : AnimeExcluir(); break;
            case 9 : EpisodioInserir(); break;
            case 10 : EpisodioListar(); break;
            case 11 : EpisodioAtualizar(); break;
            case 12 : EpisodioExcluir(); break;
            case 99 : perfil = 0; break;
          }
      }
      if (perfil == 2) {
        op = MenuVisitante();
          switch(op) {
            case 1 : GeneroListar(); break;
            case 2 : AnimeListar(); break;
            case 3 : EpisodioListar(); break;
            case 99: perfil = 0; break;
          }
      }
    }
    catch (Exception erro) {
      op = -1;
      Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
      Console.WriteLine("████▌▄▌▄▐▐▌█████");
      Console.WriteLine("████▌▄▌▄▐▐▌▀████");
      Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
    }
  } while(op != 0);

  try{
      Sistema.ArquivosSalvar();
    }
    catch (Exception erro) {
      Console.WriteLine(erro.Message);
    }
    
}
  public static int MenuUsuario(){
    Console.WriteLine();
    Console.WriteLine("-----------Entrar como:-----------");
    Console.WriteLine("1 - Admin");
    Console.WriteLine("2 - Visitante");
    Console.WriteLine("0 - Encerrar");
    Console.WriteLine("----------------------------------");
    Console.WriteLine("Qual sua escolha?");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

  
  public static int MenuAdmin(){
    Console.WriteLine();
    Console.WriteLine("--------------Gêneros--------------");
    Console.WriteLine("01 - preciso adcionar um gênero");
    Console.WriteLine("02 - mostrar os gêneros já cadastrados");
    Console.WriteLine("03 - preciso editar gêneros");
    Console.WriteLine("04 - preciso apagar gêneros");
    Console.WriteLine(" ");
    Console.WriteLine("--------------Animes--------------");
    Console.WriteLine("05 - preciso adicionar um anime");
    Console.WriteLine("06 - mostrar animes já cadastrados");
    Console.WriteLine("07 - preciso editar um anime");
    Console.WriteLine("08 - preciso apagar um anime");
    Console.WriteLine(" ");
    Console.WriteLine("-------------Episodios-------------");
    Console.WriteLine("09 - preciso adicionar um episodio");
    Console.WriteLine("10 - mostrar episodios já cadastrados");
    Console.WriteLine("11 - preciso editar um episodio");
    Console.WriteLine("12 - preciso apagar um episdio");
    Console.WriteLine(" ");
    Console.WriteLine("--------------Outros--------------");
    Console.WriteLine("99 - Voltar ao menu passado");
    Console.WriteLine("00 - Finalizar tudo");
    Console.Write("Opcao:  ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

  public static int MenuVisitante(){
    Console.WriteLine();
    Console.WriteLine("--------------Opções--------------");
    Console.WriteLine("01 - Exibir Gêneros");
    Console.WriteLine("02 - Exibir Animes");
    Console.WriteLine("03 - Exibir Episodios");
    Console.WriteLine("99 - Voltar ao menu passado");
    Console.WriteLine("00 - Finalizar tudo");
    Console.WriteLine("----------------------------------");
    Console.WriteLine("Qual sua escolha?");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }
  
  public static void GeneroInserir() {
    Console.WriteLine("::::coloca um gênero::::");
    GeneroListar();
    Console.Write("diz o id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("diz o titulo: ");
    string titulo = Console.ReadLine();
    Genero obj = new Genero(id, titulo);
    Sistema.GeneroInserir(obj);
    Console.WriteLine("::::::missão cumprida::::::");
}
  public static void GeneroListar() {
    Console.WriteLine("---------gêneros cadastrados---------");
    foreach(Genero obj in Sistema.GeneroListar())
      Console.WriteLine(obj);
    Console.WriteLine("-------------------------------------");
    
  }

  public static void GeneroAtualizar() {
    Console.WriteLine("::::Atualizar um gênero::::");
    GeneroListar();
    Console.Write("diz o id o gênero aí pra editar: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("diz o novo titulo: ");
    string titulo = Console.ReadLine();
    Genero obj = new Genero(id, titulo);
    Sistema.GeneroAtualizar(obj);
    Console.WriteLine("::::::missão cumprida::::::");
  }

  public static void GeneroExcluir() {
    Console.WriteLine(":::: apagar um gênero::::");
    GeneroListar();
    Console.Write("diz o id do gênero pra excluir: ");
    int id = int.Parse(Console.ReadLine());
    string titulo = "";
    Genero obj = new Genero(id, titulo);
    Sistema.GeneroExcluir(obj);
    Console.WriteLine("::::::missão cumprida::::::");
  }
  public static void AnimeInserir() {
    Console.WriteLine("::::adiciona um novo anime::::");
    AnimeListar();
    Console.Write("diz o id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("diz o titulo: ");
    string titulo = Console.ReadLine();

    GeneroListar();
    Console.Write("passa o id do Genero:");
    int idGenero = int.Parse(Console.ReadLine());
    Anime obj = new Anime(id, titulo, idGenero);
    Sistema.AnimeInserir(obj);
    Console.WriteLine(":::::::missão cumprida:::::::");
}
  public static void AnimeListar() {
    Console.WriteLine("-----------animes adicionados-----------");
    foreach(Anime obj in Sistema.AnimeListar())
      Console.WriteLine(obj);
    Console.WriteLine("----------------------------------------");
    
  }

  public static void AnimeAtualizar() {
    Console.WriteLine("::::editar um anime::::");
    AnimeListar();
    Console.Write("diz o id do anime pra editar: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("diz o titulo: ");
    string titulo = Console.ReadLine();
    GeneroListar();
    Console.Write("diz o id do Genero: ");
    int idGenero = int.Parse(Console.ReadLine());
    Anime obj = new Anime(id, titulo, idGenero);   
    Sistema.AnimeAtualizar(obj);
    Console.WriteLine("::::::::missão cumprida::::::::");
  }

  public static void AnimeExcluir() {
    Console.WriteLine("::::apagar um anime::::");
    AnimeListar();
    Console.Write("passa o id do anime pra ser apagado: ");
    int id = int.Parse(Console.ReadLine());
    Anime obj = new Anime(id);
    Sistema.AnimeExcluir(obj);
    Console.WriteLine("::::missão cumprida::::");
  } 
    public static void EpisodioInserir() {
    Console.WriteLine("::::adiciona um novo episodio::::");
    EpisodioListar();
    Console.Write("diz o id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("diz o titulo: ");
    string titulo = Console.ReadLine();

    AnimeListar();
    Console.Write("passa o nome do Anime: ");
    string tituloAnime = Console.ReadLine();
    Episodio obj = new Episodio(id, titulo, tituloAnime);
    Sistema.EpisodioInserir(obj);
    Console.WriteLine(":::::::missão cumprida:::::::");
}
  public static void EpisodioListar() {
    Console.WriteLine("----------episodios adicionados----------");
    foreach(Episodio obj in Sistema.EpisodioListar())
      Console.WriteLine(obj);
    Console.WriteLine("-----------------------------------------");
    
  }

  public static void EpisodioAtualizar() {
    Console.WriteLine("::::editar um episodio::::");
    EpisodioListar();
    Console.Write("diz o id do episodio pra editar: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("diz o titulo: ");
    string titulo = Console.ReadLine();
    AnimeListar();
    Console.Write("diz o titulo do Anime: ");
    string tituloAnime = Console.ReadLine();
    Episodio obj = new Episodio(id, titulo, tituloAnime);   
    Sistema.EpisodioAtualizar(obj);
    Console.WriteLine("::::::::missão cumprida::::::::");
  }

  public static void EpisodioExcluir() {
    Console.WriteLine("::::apagar um episodio::::");
    EpisodioListar();
    Console.Write("passa o id do episodio pra ser apagado: ");
    int id = int.Parse(Console.ReadLine());
    Episodio obj = new Episodio(id);
    Sistema.EpisodioExcluir(obj);
    Console.WriteLine("::::missão cumprida::::");
  }
}