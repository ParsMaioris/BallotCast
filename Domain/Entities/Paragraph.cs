namespace BallotCast.Domain;

public class Paragraph
{
    public int Id { get; private set; }
    public string Content { get; private set; }
    public int ReferendumId { get; private set; }
    public Referendum Referendum { get; private set; }

    public Paragraph(int id, string content, Referendum referendum)
    {
        Id = id;
        Content = content ?? throw new ArgumentNullException(nameof(content));
        Referendum = referendum ?? throw new ArgumentNullException(nameof(referendum));
        ReferendumId = referendum.Id;
    }
}