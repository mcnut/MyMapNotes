using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMapNotes.DataModel
{
    public class MapNote
    {
        /*   Create a data model for the note.  */
        public string Title { get; set; }
        public string Note { get; set; }
        public DateTime Created { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    class DataSource
    {
        // Keeps a collection of notes and allows user to read, write, update and delete notes.
    }
}
