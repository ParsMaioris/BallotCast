namespace BallotCast.Domain;

public class ParagraphService
{
    private readonly IParagraphRepository _paragraphRepository;

    public ParagraphService(IParagraphRepository paragraphRepository)
    {
        _paragraphRepository = paragraphRepository;
    }

    public void UpdateParagraphContent(int paragraphId, string newContent)
    {
        var paragraph = _paragraphRepository.GetById(paragraphId);
        if (paragraph == null)
            throw new ArgumentException("Paragraph not found", nameof(paragraphId));

        paragraph.UpdateContent(newContent);
        _paragraphRepository.Update(paragraph);
    }
}
