using Xunit;


namespace BallotCast.Domain;

public class ReferendumTests
{
    [Fact]
    public void Constructor_ShouldInitializeCorrectly()
    {
        // Arrange
        var title = "New Referendum";
        var question = "Do you agree?";

        // Act
        var referendum = new Referendum(title, question);

        // Assert
        Assert.Equal(title, referendum.Title);
        Assert.Equal(question, referendum.Question);
        Assert.Equal(ReferendumStatus.Pending, referendum.Status);
        Assert.NotNull(referendum.Paragraphs);
        Assert.Empty(referendum.Paragraphs);
        Assert.NotNull(referendum.Options);
        Assert.Empty(referendum.Options);
    }

    [Fact]
    public void AddParagraph_ShouldAddParagraphToList()
    {
        // Arrange
        var referendum = new Referendum("New Referendum", "Do you agree?");
        var content = "This is a paragraph.";

        // Act
        referendum.AddParagraph(content);

        // Assert
        Assert.Single(referendum.Paragraphs);
        Assert.Equal(content, referendum.Paragraphs.First().Content);
    }

    [Fact]
    public void AddParagraph_ShouldThrowException_WhenContentIsNullOrWhiteSpace()
    {
        // Arrange
        var referendum = new Referendum("New Referendum", "Do you agree?");

        // Act & Assert
        Assert.Throws<ArgumentException>(() => referendum.AddParagraph(null));
        Assert.Throws<ArgumentException>(() => referendum.AddParagraph(string.Empty));
        Assert.Throws<ArgumentException>(() => referendum.AddParagraph(" "));
    }

    [Fact]
    public void AddOption_ShouldAddOptionToList()
    {
        // Arrange
        var referendum = new Referendum("New Referendum", "Do you agree?");
        var optionText = "Option 1";

        // Act
        referendum.AddOption(optionText);

        // Assert
        Assert.Single(referendum.Options);
        Assert.Equal(optionText, referendum.Options.First().OptionText);
    }

    [Fact]
    public void AddOption_ShouldThrowException_WhenOptionTextIsNullOrWhiteSpace()
    {
        // Arrange
        var referendum = new Referendum("New Referendum", "Do you agree?");

        // Act & Assert
        Assert.Throws<ArgumentException>(() => referendum.AddOption(null));
        Assert.Throws<ArgumentException>(() => referendum.AddOption(string.Empty));
        Assert.Throws<ArgumentException>(() => referendum.AddOption(" "));
    }

    [Fact]
    public void SetStatus_ShouldUpdateStatusAndLastModifiedDate()
    {
        // Arrange
        var referendum = new Referendum("New Referendum", "Do you agree?");
        var newStatus = ReferendumStatus.Closed;

        // Act
        referendum.SetStatus(newStatus);

        // Assert
        Assert.Equal(newStatus, referendum.Status);
        Assert.True(referendum.LastModifiedDate.HasValue);
        Assert.Equal(DateTime.UtcNow.Date, referendum.LastModifiedDate.Value.Date);
    }

    [Fact]
    public void SetResult_ShouldUpdateResult()
    {
        // Arrange
        var referendum = new Referendum("New Referendum", "Do you agree?");
        var optionResults = new List<OptionResult> { new OptionResult("Option 1", 10) };
        var result = new ReferendumResult(DateTime.UtcNow, optionResults);

        // Act
        referendum.SetResult(result);

        // Assert
        Assert.Equal(result, referendum.Result);
    }

    [Fact]
    public void Constructor_ShouldThrowException_WhenTitleIsNullOrWhiteSpace()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Referendum(null, "Do you agree?"));
        Assert.Throws<ArgumentException>(() => new Referendum(string.Empty, "Do you agree?"));
        Assert.Throws<ArgumentException>(() => new Referendum(" ", "Do you agree?"));
    }

    [Fact]
    public void Constructor_ShouldThrowException_WhenQuestionIsNullOrWhiteSpace()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Referendum("New Referendum", null));
        Assert.Throws<ArgumentException>(() => new Referendum("New Referendum", string.Empty));
        Assert.Throws<ArgumentException>(() => new Referendum("New Referendum", " "));
    }
}
