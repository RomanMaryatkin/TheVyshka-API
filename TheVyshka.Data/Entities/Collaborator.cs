using System;
using System.Collections.Generic;

namespace TheVyshka.Data.Entities
{
    public class Collaborator
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Links { get; set; } // все линки будут в одной стороке с раметкой
        // public List<PostCollaborator> PostCollaborator { get; set; }
    }
}