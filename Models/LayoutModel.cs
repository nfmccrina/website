namespace Website.Models
{
    public class LayoutModel
    {
        public LayoutModel(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new System.ArgumentException("message", nameof(title));
            }

            Title = title;
        }

        public string Title { get; }
    }
}