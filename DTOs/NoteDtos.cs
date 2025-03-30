
using System;

namespace NotesManager.DTOs
{
    public class NoteDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class CreateNoteDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class UpdateNoteDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
