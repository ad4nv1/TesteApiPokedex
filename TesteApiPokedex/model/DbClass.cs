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
            conection = new SQLiteConnection("Data Source=C:\\Users\\Adan\\source\\repos\\TesteApiPokedex\\TesteApiPokedex\\dbfortest\\db_pokemon.db");
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
                    cmd.CommandText = "SELECT * FROM pokemon WHERE NAME='"+sql+"'";
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
        public static void Add(long id, string name)
        {
            try
            {
                using (var cmd = ConnectionDb().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO pokemon(NAME, IDENTIFICATION) values (@name, @identification)";
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Identification", id);
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
