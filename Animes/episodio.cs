using System;

public class Episodio {
  private int id;
  private string titulo;
  private string tituloAnime;

  public int Id {
    get => id;
    set => id = value;
  }

  public string Titulo {
    get => titulo;
    set => titulo = value;
  }

  public string TituloAnime {
    get => tituloAnime;
    set => tituloAnime = value;
  }

  public Episodio() { }
  public Episodio(int id) {
    this.id = id;
  } 
  
  public Episodio(int id, string titulo, string tituloAnime) {
    this.id = id;
    this.titulo = titulo;
    this.tituloAnime = tituloAnime;
  }
  public void SetId(int id) {
    this.id = id;  
  }
  
  public void SetTitulo(string titulo){
    this.titulo = titulo;
  }

  public void SetAnime(string tituloAnime) {
    this.tituloAnime = tituloAnime;  
  }
  
  public int GetId(){
    return id;
  }

  public String GetTitulo() {
    return titulo;
  }
  
  public String GetTituloAnime(){
    return tituloAnime;
  }

  public override string ToString() {
    return $"{id} - {titulo} - {tituloAnime}";
  }
}