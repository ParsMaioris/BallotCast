namespace BallotCast.Domain
{
    public class Paragraph
    {
        public int Id { get; private set; }
        public string Content { get; private set; }
        public int ReferendumId { get; private set; }
        public Referendum Referendum { get; private set; }

        public Paragraph(string content)
        {
            if (string.IsNullOrWhiteSpace(content)) throw new ArgumentException("Content is required", nameof(content));
            Content = content;
        }

        internal Paragraph(int id, string content, int referendumId, Referendum referendum)
        {
            Id = id;
            Content = content;
            ReferendumId = referendumId;
            Referendum = referendum;
        }

        internal void UpdateContent(string newContent)
        {
            if (string.IsNullOrWhiteSpace(newContent)) throw new ArgumentException("Content is required", nameof(newContent));
            Content = newContent;
        }

        internal void SetId(int id)
        {
            Id = id;
        }
    }
}