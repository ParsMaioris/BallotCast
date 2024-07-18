namespace BallotCast.Domain
{
    public class ReferendumOption
    {
        public int Id { get; private set; }
        public string OptionText { get; private set; }
        public int VoteCount { get; private set; }
        public int ReferendumId { get; private set; }
        public Referendum Referendum { get; private set; }

        public ReferendumOption(string optionText)
        {
            if (string.IsNullOrWhiteSpace(optionText)) throw new ArgumentException("Option text is required", nameof(optionText));
            OptionText = optionText;
        }

        internal ReferendumOption(int id, string optionText, int voteCount, int referendumId, Referendum referendum)
        {
            Id = id;
            OptionText = optionText;
            VoteCount = voteCount;
            ReferendumId = referendumId;
            Referendum = referendum;
        }

        public void IncrementVoteCount()
        {
            VoteCount++;
        }

        internal void SetId(int id)
        {
            Id = id;
        }
    }
}