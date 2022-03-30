using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Text;

class Sistema {
  private static Genero[] generos = new Genero[10];
  private static int nGenero;
  private static List<Anime> animes = new List<Anime>();
  // private static List<Visitante> visitantes = new List<Visitante>()
  
  private static List<Episodio> episodios = new List<Episodio>();

  public static void ArquivosAbrir() {
    Arquivo<Genero[]> f1 = new Arquivo<Genero[]>();
    generos = f1.Abrir("./generos.xml");
    nGenero = generos.Length;

    Arquivo<List<Anime>> f2 = new Arquivo<List<Anime>>();
    animes = f2.Abrir("./animes.xml");

    Arquivo<List<Episodio>> f3 = new Arquivo<List<Episodio>>();
    episodios = f3.Abrir("./episodios.xml");
  }


  public static void ArquivosSalvar() {
    Arquivo<Genero[]> f1 = new Arquivo<Genero[]>();
    f1.Salvar("./generos.xml", GeneroListar());

    Arquivo<List<Anime>> f2 = new Arquivo<List<Anime>>();
    f2.Salvar("./animes.xml", animes);

    Arquivo<List<Episodio>> f3 = new Arquivo<List<Episodio>>();
    f3.Salvar("./episodios.xml", episodios);
  }

  public static void GeneroInserir(Genero obj) {
    if (nGenero == generos.Length)
      Array.Resize(ref generos, 2 * generos.Length);
      generos[nGenero] = obj;
      nGenero++;
  }
  public static Genero[] GeneroListar() {
    Genero[] aux = new Genero[nGenero];
    Array.Copy(generos, aux, nGenero);
    return aux;
  }

  public static Genero GeneroListar(int id) {
    foreach(Genero obj in generos)
      if (obj != null && obj.GetId() == id) return obj;
    return null;
  }
  public static void GeneroAtualizar(Genero obj){
    Genero aux = GeneroListar(obj.GetId());
      if (aux != null)
        aux.SetNome(obj.GetNome());
  }
  public static void GeneroExcluir(Genero obj) {
    int aux = GeneroIndice(obj.GetId());
    if (aux != -1) {
      for (int i = aux; i < nGenero - 1; i++)
        generos[i] = generos[i + 1];
      nGenero--;
    }
  }
  private static int GeneroIndice(int id){
    for(int i = 0; i < nGenero; i++){
      Genero obj = generos[i];
    if (obj.GetId() == id) return i;
    }
    return -1;
  }
  
  public static void AnimeInserir(Anime obj) {
      animes.Add(obj);
  }
  public static List<Anime> AnimeListar() {
    return animes;
  }

  public static Anime AnimeListar(int id) {
    foreach(Anime obj in animes)
      if (obj.GetId() == id) return obj;
    return null;
  }
  public static void AnimeAtualizar(Anime obj){
    Anime aux = AnimeListar(obj.GetId());
    if (aux != null){
      aux.SetTitulo(obj.GetTitulo());
      aux.SetGenero(obj.GetIdGenero());
    }
  }
  
  public static void AnimeExcluir(Anime obj) {
    Anime aux = AnimeListar(obj.GetId());

    if (aux != null) animes.Remove(aux);
    
  }
  public static void EpisodioInserir(Episodio obj) {
      episodios.Add(obj);
  }
  public static List<Episodio> EpisodioListar() {
    return episodios;
  }

  public static Episodio EpisodioListar(int id) {
    foreach(Episodio obj in episodios)
      if (obj.GetId() == id) return obj;
    return null;
  }
  public static void EpisodioAtualizar(Episodio obj){
    Episodio aux = EpisodioListar(obj.GetId());
    if (aux != null){
      aux.SetTitulo(obj.GetTitulo());
      aux.SetAnime(obj.GetTituloAnime());
    }
  }
  
  public static void EpisodioExcluir(Episodio obj) {
    Episodio aux = EpisodioListar(obj.GetId());

    if (aux != null) episodios.Remove(aux);
    
  }
}


