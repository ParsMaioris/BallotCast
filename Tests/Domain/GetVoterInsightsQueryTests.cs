
using Moq;

using Xunit;

namespace BallotCast.Domain;

public class GetVoterInsightsQueryTests
{
    private readonly Mock<IVoterRepository> _voterRepositoryMock;
    private readonly Mock<IVoteRepository> _voteRepositoryMock;
    private readonly GetVoterInsightsQuery _getVoterInsightsQuery;

    public GetVoterInsightsQueryTests()
    {
        _voterRepositoryMock = new Mock<IVoterRepository>();
        _voteRepositoryMock = new Mock<IVoteRepository>();
        _getVoterInsightsQuery = new GetVoterInsightsQuery(_voterRepositoryMock.Object, _voteRepositoryMock.Object);
    }

    [Fact]
    public async Task ExecuteAsync_VoterExists_ReturnsVoterInsights()
    {
        // Arrange
        var voterId = 1;
        var voter = new Voter(voterId, "John Doe", "john.doe@example.com");
        var votes = new List<Vote>
            {
                new Vote(1, voter, new Referendum(1, "Test Referendum", "Test Question"), true)
            };

        _voterRepositoryMock.Setup(repo => repo.GetByIdAsync(voterId)).ReturnsAsync(voter);
        _voteRepositoryMock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(votes);

        // Act
        var result = await _getVoterInsightsQuery.ExecuteAsync(voterId);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(voter, result.Voter);
        Assert.Equal(1, result.TotalVotes);
        Assert.Equal(1, result.YesVotes);
        Assert.Equal(0, result.NoVotes);
        Assert.Single(result.VoteHistory);
    }

    [Fact]
    public async Task ExecuteAsync_VoterDoesNotExist_ReturnsNull()
    {
        // Arrange
        var voterId = 1;
        _voterRepositoryMock.Setup(repo => repo.GetByIdAsync(voterId)).ReturnsAsync((Voter)null);

        // Act
        var result = await _getVoterInsightsQuery.ExecuteAsync(voterId);

        // Assert
        Assert.Null(result);
    }
}
