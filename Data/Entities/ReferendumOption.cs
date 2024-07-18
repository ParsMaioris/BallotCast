using System.ComponentModel.DataAnnotations;

public class ReferendumOption
{
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string OptionText { get; set; }
    public int VoteCount { get; set; }

    public int ReferendumId { get; set; }
    public virtual Referendum Referendum { get; set; }
}