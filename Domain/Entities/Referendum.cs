namespace BallotCast.Domain
{
    public class Referendum
    {
        private readonly List<Paragraph> _paragraphs = new List<Paragraph>();
        private readonly List<ReferendumOption> _options = new List<ReferendumOption>();

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Question { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime? LastModifiedDate { get; private set; }
        public ReferendumStatus Status { get; private set; }
        public IReadOnlyCollection<Paragraph> Paragraphs => _paragraphs.AsReadOnly();
        public IReadOnlyCollection<ReferendumOption> Options => _options.AsReadOnly();
        public ReferendumResult Result { get; private set; }

        public Referendum(string title, string question)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title is required", nameof(title));
            if (string.IsNullOrWhiteSpace(question)) throw new ArgumentException("Question is required", nameof(question));

            Title = title;
            Question = question;
            CreatedDate = DateTime.UtcNow;
            Status = ReferendumStatus.Pending;
        }

        internal Referendum(int id, string title, string question, DateTime createdDate, DateTime? lastModifiedDate, ReferendumStatus status)
        {
            Id = id;
            Title = title;
            Question = question;
            CreatedDate = createdDate;
            LastModifiedDate = lastModifiedDate;
            Status = status;
        }

        public void AddParagraph(string content)
        {
            if (string.IsNullOrWhiteSpace(content)) throw new ArgumentException("Content is required", nameof(content));
            _paragraphs.Add(new Paragraph(content));
        }

        public void AddOption(string optionText)
        {
            if (string.IsNullOrWhiteSpace(optionText)) throw new ArgumentException("Option text is required", nameof(optionText));
            _options.Add(new ReferendumOption(optionText));
        }

        public void SetStatus(ReferendumStatus status)
        {
            Status = status;
            LastModifiedDate = DateTime.UtcNow;
        }

        public void SetResult(ReferendumResult result)
        {
            Result = result ?? throw new ArgumentNullException(nameof(result));
        }

        internal void SetId(int id)
        {
            Id = id;
        }
    }
}