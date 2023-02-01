using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABExamen3P.ABModels
{
    [Table("ABPokemon")]
    public class ABPokemonDataCompleta
    {
        [PrimaryKey,AutoIncrement]
        public int ABId { get; set; }
        public String ABNombre { get; set; }
        public String ABTipo { get; set; }
        public String ABDescripcion { get; set; }

        public DateTime ABFecha { get; set; }

    }
}
