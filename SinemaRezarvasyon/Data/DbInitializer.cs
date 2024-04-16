using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using SinemaRezarvasyon.Models;

namespace SinemaRezarvasyon
{
    public static class DbInitializer
    {
        private static string connectionString = "Data Source=..\\..\\files\\SinemaRezervasyonDb.db;Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists("..\\..\\files\\SinemaRezervasyonDb.db")) 
            {
                SQLiteConnection.CreateFile("..\\..\\files\\SinemaRezervasyonDb.db");
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                  
                    string createFilmTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Film(
                            id INTEGER PRIMARY KEY NOT NULL,
                            filmAdi TEXT NOT NULL
                            
                      );";
                    string insertFilmQuery = @"
                    INSERT INTO Film (FilmAdi) VALUES ('Deliha');
                    INSERT INTO Film (FilmAdi) VALUES ('Düğün Dernek');
                    INSERT INTO Film (FilmAdi) VALUES ('Batman');
                    INSERT INTO Film(FilmAdi) VALUES('Forest Gump');";

                    string createSalonTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Salon(
                            id INTEGER PRIMARY KEY NOT NULL,
                            SalonKapasite INTEGER NOT NULL
                        );";

                    string insertSalonQuery = @"
                    INSERT INTO Salon (SalonKapasite) VALUES (50);
                    INSERT INTO Salon (SalonKapasite) VALUES (50);
                    INSERT INTO Salon (SalonKapasite) VALUES (50);
                    INSERT INTO Salon (SalonKapasite) VALUES (50);";
                   
                    string createSeansTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Seans(
                            id INTEGER PRIMARY KEY NOT NULL,
                            tarih TEXT NOT NULL,
                            zaman TEXT NOT NULL,
                            filmId INTEGER NOT NULL,
                            salonId INTEGER NOT NULL,
                            FOREIGN KEY (filmId) REFERENCES Film(id),
                            FOREIGN KEY (salonId) REFERENCES Salon(id)

                        );";

                    string insertSeansQuery = @"
                    INSERT INTO Seans (tarih, zaman, filmId, salonId ) VALUES ('20.05.2024', '19:00', 2, 3);
                    INSERT INTO Seans (tarih, zaman, filmId, salonId ) VALUES ('20.05.2024', '19:00', 1, 7);
                    INSERT INTO Seans (tarih, zaman, filmId, salonId ) VALUES ('20.05.2024', '20:00', 3, 4);
                    INSERT INTO Seans (tarih, zaman, filmId, salonId ) VALUES ('22.05.2024', '23:00', 4, 5);
                    INSERT INTO Seans (tarih, zaman, filmId, salonId ) VALUES ('22.05.2024', '00:00', 5, 6);";


                    string createRezervasyonTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Seans(
                            id INTEGER PRIMARY KEY NOT NULL,
                            koltukNo TEXT NOT NULL,
                          
                            seansId INTEGER NOT NULL,
                            FOREIGN KEY (seansId) REFERENCES Seans(id)
                           
                        );";

                    string insertRezervasyonQuery = @"
                   ;";


                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = createFilmTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertFilmQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = createSalonTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertSalonQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = createSeansTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertSeansQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = createRezervasyonTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertRezervasyonQuery;
                        command.ExecuteNonQuery();


                    }

                }
            }
        }
    }
}