using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace losowanie
{
    public class Losowanie
    {

        int previous;
        System.Windows.Forms.DataGridViewCellEventArgs active;
        public Losowanie()
        {
            previous = -1;
        }

        Random rnd = new Random();

        public List<int> Wylosowane = new List<int>();
        public class Zawodnik
        {
            public string nazwa;
            public string nazwaKraju;
            public int id;
            public int idKraju;
        }

        public List<Zawodnik> Zawodnicy = new List<Zawodnik>();
        public void addPlayer(string nazwa)
        {
            Zawodnik Nowy = new Zawodnik();
            Nowy.nazwa = nazwa;
            Nowy.id = Zawodnicy.Count;
            Zawodnicy.Add(Nowy);
        }
        public void show()
        {
            foreach (Zawodnik zawod in Zawodnicy)
            {
                System.Diagnostics.Debug.WriteLine(zawod.id);
            }
        }
        public class Kraj
        {
            public string Nazwa;
            public bool Hard;
            public int id;
        }


        public List<Kraj> Kraje = new List<Kraj>();
        public void addCountry(string Name, bool Hard)
        {
            Kraj Nowy = new Kraj();
            Nowy.Nazwa = Name;
            Nowy.Hard = Hard;
            Nowy.id = Kraje.Count;
            Kraje.Add(Nowy);
        }

        public void Losuj(System.Windows.Forms.DataGridView lv)
        {
            foreach (Zawodnik Player in Zawodnicy)
            {
                Player.idKraju = rnd.Next(0, Kraje.Count);
                while (Wylosowane.Contains(Player.idKraju))
                {
                    Player.idKraju = rnd.Next(0, Kraje.Count);
                }

                Wylosowane.Add(Player.idKraju);

                foreach (Kraj Wylosowany in Kraje)
                {
                    if (Wylosowany.id == Player.idKraju) Player.nazwaKraju = Wylosowany.Nazwa;
                }
            }

            lv.Rows.Clear();
            foreach (Zawodnik zawod in Zawodnicy)
            {
                int n = lv.Rows.Add();
                lv.Rows[n].Cells[0].Value = zawod.nazwa;
                lv.Rows[n].Cells[1].Value = zawod.nazwaKraju;
                lv.Rows[n].Cells[2].Value = "Jeszcze raz";

            };
        }

        public void dolosuj(System.Windows.Forms.DataGridView dgv, System.Windows.Forms.DataGridViewCellEventArgs cell)
        {
            if (active == null || active.RowIndex != cell.RowIndex) previous = -1;
            Zawodnik Player = new Zawodnik();
            Player.idKraju = rnd.Next(0, Kraje.Count);
            while (Wylosowane.Contains(Player.idKraju))
            {
                Player.idKraju = rnd.Next(0, Kraje.Count);
            }


            if (previous != -1) Wylosowane.Remove(previous);
            Wylosowane.Add(Player.idKraju);

            Zawodnik byl = new Zawodnik();

            foreach (Kraj byly in Kraje)
            {
                if (byly.Nazwa == dgv.Rows[cell.RowIndex].Cells[1].Value.ToString()) byl.idKraju = byly.id;
            }
            Wylosowane.Remove(byl.idKraju);
            previous = Player.idKraju;


            active = cell;

            foreach (Kraj Wylosowany in Kraje)
            {
                if (Wylosowany.id == Player.idKraju) Player.nazwaKraju = Wylosowany.Nazwa;
            }

            dgv.Rows[cell.RowIndex].Cells[1].Value = Player.nazwaKraju;

        }

        public int loadFile()
        {
            StreamReader plik;
            Encoding enc = Encoding.GetEncoding("Windows-1250");
            try
            {
                plik = new StreamReader("kraje.txt", enc);
            }
            catch
            {
                return -1;
            }

            string line;
            while ((line = plik.ReadLine()) != null)
            {
                addCountry(line, true);
            }
            plik.Close();

            plik = new StreamReader("gracze.txt", enc);

            while ((line = plik.ReadLine()) != null)
            {
                addPlayer(line);
            }
            plik.Close();
            return 0;
        }






    }
}
