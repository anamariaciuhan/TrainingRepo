namespace MovieManager
{
    public class GenreType
    {
        public GenreType()
        { }
           public int Value { get; set; }
        public string DisplayText { get; set; }

        public override string ToString()
        {
            return DisplayText;
        }
    }
}