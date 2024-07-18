public class ReferendumResult
{
    public int Id { get; set; }
    public DateTime ResultDate { get; set; } = DateTime.UtcNow;
    public virtual List<OptionResult> OptionResults { get; set; } = new List<OptionResult>();
}