using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;


namespace TesteApiPokedex.model
{
    class DbClass
    {
        public static SQLiteConnection conection;

        public static SQLiteConnection ConnectionDb()
        {
            conection = new SQLiteConnection("Data Source=C:\\Users\\Adan\\source\\repos\\TesteApiPokedex\\TesteApiPokedex\\dbfortest\\db_teste.db");
            conection.Open();
            return conection;
        }

        public static DataTable GetPokemon()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConnectionDb().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM pokemon";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionDb());
                    da.Fill(dt);
                    ConnectionDb().Close();
                    return dt;
                }
            }catch(Exception ex)
            {
                ConnectionDb().Close();
                throw ex;
            }
        }

        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConnectionDb().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM pokemon WHERE name='"+sql+"'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionDb());
                    da.Fill(dt);
                    ConnectionDb().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConnectionDb().Close();
                throw ex;
            }

        }

        //public static void Add(TableSearch tableSearch)
        //public static void Add(long id, string name, string type, long height, long weight, string image)
        public static async Task Add(long id, string name, string type, long height, long weight, string image)
        {
            //tableSearch  = new TableSearch();
            try
            {
                using (var cmd = ConnectionDb().CreateCommand())
                {
                    //cmd.CommandText = "INSERT INTO pokemon(id_pokemon, name, type, height, weight, image) values (@id_pokemon, @name, @type, @height, @weight, @image)";
                    //cmd.Parameters.AddWithValue("@id_pokemon", TableSearch.id);
                    //cmd.Parameters.AddWithValue("@name", TableSearch.name);
                    //cmd.Parameters.AddWithValue("@type", TableSearch.type);
                    //cmd.Parameters.AddWithValue("@height", TableSearch.height);
                    //cmd.Parameters.AddWithValue("@weight", TableSearch.weight);
                    //cmd.Parameters.AddWithValue("@image", TableSearch.image);
                    //cmd.ExecuteNonQuery();INSERT INTO pokemon(id_poke
                    cmd.CommandText = "mon, name, type, height, weight, image) values (@id_pokemon, @name, @type, @height, @weight, @image)";
                    cmd.Parameters.AddWithValue("@id_pokemon", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@height", height);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    cmd.Parameters.AddWithValue("@image", image);
                    cmd.ExecuteNonQuery();
                }
        }
            catch (Exception ex)
            {
                throw ex;
            }
}
    }
}
