using System.ComponentModel.DataAnnotations;

public class Referendum
{
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Title { get; set; }

    [Required]
    [MaxLength(1000)]
    public string Question { get; set; }

    public virtual List<Paragraph> Paragraphs { get; set; } = new List<Paragraph>();

    public virtual List<ReferendumOption> Options { get; set; } = new List<ReferendumOption>();

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? LastModifiedDate { get; set; }
    public ReferendumStatus Status { get; set; } = ReferendumStatus.Pending;

    public virtual ReferendumResult Result { get; set; }
    public int? ResultId { get; set; }
}