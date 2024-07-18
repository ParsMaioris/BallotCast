using System.ComponentModel.DataAnnotations;

public class Paragraph
{
    public int Id { get; set; }

    [Required]
    [MaxLength(500)]
    public string Content { get; set; }

    public int ReferendumId { get; set; }
    public virtual Referendum Referendum { get; set; }
}