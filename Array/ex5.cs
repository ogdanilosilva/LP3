
String aulaIntro = "Introdução às Coleções";
String aulaModelando = "Modelando a Classe Aula";
String aulaSeis = "Trabalhando com Conjuntos";

String [] aulas = new string[3];
aulas[0] = aulaIntro;
aulas[1] = aulaModelando;
aulas[2] = aulaSeis;

for (int i = 0; i < aulas.Length; i++)
{
    Console.WriteLine (aulas[i]);
}

Console.WriteLine ("Aula modelando está no indice " + Array.IndexOf( aulas, aulaModelando));
Console.WriteLine(Array.LastIndexOf( aulas, aulaModelando));