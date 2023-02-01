using ABExamen3P.ABModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABExamen3P.ABData
{
    public class ABDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;

        public ABDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<ABPokemonDataCompleta>();
        }

        public int AddNewPokemon(ABPokemonDataCompleta pokemon)
        {
            Init();
            int result = conn.Insert(pokemon);
            return result;
        }

        public int UpdatePokemon(ABPokemonDataCompleta pokemon)
        {
            Init();
            int result = conn.Update(pokemon);
            return result;
        }

        public int DeletePokemon(ABPokemonDataCompleta pokemon)
        {
            Init();
            int result = conn.Delete(pokemon);
            return result;
        }

        public List<ABPokemonDataCompleta> GetAllVehicles()
        {
            Init();
            List<ABPokemonDataCompleta> pokemons = conn.Table<ABPokemonDataCompleta>().ToList();
            return pokemons;
        }
    }
}
