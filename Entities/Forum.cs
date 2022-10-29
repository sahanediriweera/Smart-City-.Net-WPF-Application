namespace Testing_GUI_Project_DataBase
{
    public class Forum
    {
        public int ForumId { get; set; }

        public string Idea { get; set; }

        public virtual Citizen citizen { get; set; }

        public Forum(string idea)
        {
            Idea = idea;
        }

        public Forum()
        {
        }
    }
} 