﻿using MySql.Data.MySqlClient;
using System;

using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos.Data.DataAccess
{
    internal class personajeDB
    {
        private String connectionString = "Server=localhost;Database=db_universidad;Uid=root;Pwd=Alejandro2005#;Convert Zero Datetime=true";
        public bool ProbarConexion()
        {
            using (MySqlConnection conection = new MySqlConnection(connectionString))
            {
                try
                {
                    conection.Open();
                    return true;
                }
                catch (Exception ex)
                { return false; }
            }
        }

        public DataTable LeerPersonajes()
        {
            DataTable personajes = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personajes);
                    }
                }
            }

            return personajes;
        }

        // Método para crear un nuevo personaje
        public int CrearPersonaje(string nombre, string raza, int nivelPoder,DateTime fecha_creacion,string historia )
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO personajes_dragon_ball (nombre, raza, nivel_poder,fecha_creacion,historia) VALUES (@nombre, @raza, @nivelPoder,@fecha_creacion,@historia)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);
                    command.Parameters.AddWithValue("@fecha_creacion", fecha_creacion);
                    command.Parameters.AddWithValue("@historia",historia);
                    return command.ExecuteNonQuery();
                }
            }
        }

        //Busca un personaje por su ID
        public DataTable BuscarPersonajePorId(int id)
        {
            DataTable personaje = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje);
                    }
                }
            }

            return personaje;
        }
    }
}
