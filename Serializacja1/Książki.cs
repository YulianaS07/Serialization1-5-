using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacja1
{
    [Serializable]
    public class Książka
    {
        public string Tytuł { get; set; }
        public string Autor { get; set; }
        public int RokWydania { get; set; }
        public string Gatunek { get; set; }
        public double Ocena { get; set; }

        public Książka()
        {

        }

        public Książka(string tytuł, string autor, int rokWydania, string gatunek, double ocena)
        {
            Tytuł = tytuł;
            Autor = autor;
            RokWydania = rokWydania;
            Gatunek = gatunek;
            Ocena = ocena;
        }
    }

    [Serializable]
    public class ListaKsiążek
    {
        public List<Książka> ksiazki = new List<Książka>();

        public ListaKsiążek()
        {

        }

        public void Generate()
        {
            ksiazki.Add(new Książka("Harry Potter and the Philosopher's Stone", "J.K. Rowling", 1997, "Fantasy", 4.5));
            ksiazki.Add(new Książka("To Kill a Mockingbird", "Harper Lee", 1960, "Literary Fiction", 4.4));
            ksiazki.Add(new Książka("The Great Gatsby", "F. Scott Fitzgerald", 1925, "Classic", 4.3));
            ksiazki.Add(new Książka("1984", "George Orwell", 1949, "Dystopian", 4.3));
            ksiazki.Add(new Książka("The Catcher in the Rye", "J.D. Salinger", 1951, "Literary Fiction", 4.2));
            ksiazki.Add(new Książka("To Kill a Mockingbird", "Harper Lee", 1960, "Classic", 4.4));
            ksiazki.Add(new Książka("Animal Farm", "George Orwell", 1945, "Political Satire", 4.1));
            ksiazki.Add(new Książka("The Hobbit", "J.R.R. Tolkien", 1937, "Fantasy", 4.5));
            ksiazki.Add(new Książka("The Lord of the Rings", "J.R.R. Tolkien", 1954, "Fantasy", 4.6));
            ksiazki.Add(new Książka("Pride and Prejudice", "Jane Austen", 1813, "Romance", 4.4));
            ksiazki.Add(new Książka("Jane Eyre", "Charlotte Brontë", 1847, "Gothic", 4.2));
            ksiazki.Add(new Książka("Brave New World", "Aldous Huxley", 1932, "Dystopian", 4.3));
            ksiazki.Add(new Książka("The Da Vinci Code", "Dan Brown", 2003, "Thriller", 4.0));
            ksiazki.Add(new Książka("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", 1979, "Science Fiction", 4.2));
            ksiazki.Add(new Książka("The Picture of Dorian Gray", "Oscar Wilde", 1890, "Gothic", 4.1));
        }
        public static void Print(IEnumerable<Książka> książki)
        {
            foreach (var książka in książki)
            {
                Console.WriteLine($"Tytuł: {książka.Tytuł}, Autor: {książka.Autor}, Rok wydania: {książka.RokWydania}, Gatunek: {książka.Gatunek}, Ocena: {książka.Ocena}");
            }
        }
    }

}
