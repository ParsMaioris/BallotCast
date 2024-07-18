public class OptionResult
{
    public int Id { get; set; }
    public string OptionText { get; set; }
    public int VoteCount { get; set; }

    public int ReferendumResultId { get; set; }
    public virtual ReferendumResult ReferendumResult { get; set; }
}