namespace BallotCast.Domain
{
    public class ReferendumService
    {
        private readonly IReferendumRepository _referendumRepository;
        private readonly IParagraphRepository _paragraphRepository;
        private readonly IReferendumOptionRepository _referendumOptionRepository;
        private readonly IReferendumResultRepository _referendumResultRepository;

        public ReferendumService(
            IReferendumRepository referendumRepository,
            IParagraphRepository paragraphRepository,
            IReferendumOptionRepository referendumOptionRepository,
            IReferendumResultRepository referendumResultRepository)
        {
            _referendumRepository = referendumRepository;
            _paragraphRepository = paragraphRepository;
            _referendumOptionRepository = referendumOptionRepository;
            _referendumResultRepository = referendumResultRepository;
        }

        public void CreateReferendum(string title, string question, List<string> paragraphs, List<string> options)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title is required", nameof(title));
            if (string.IsNullOrWhiteSpace(question))
                throw new ArgumentException("Question is required", nameof(question));
            if (paragraphs == null || !paragraphs.Any())
                throw new ArgumentException("At least one paragraph is required", nameof(paragraphs));
            if (options == null || !options.Any())
                throw new ArgumentException("At least one option is required", nameof(options));

            var referendum = new Referendum(title, question);

            foreach (var content in paragraphs)
            {
                referendum.AddParagraph(content);
            }

            foreach (var optionText in options)
            {
                referendum.AddOption(optionText);
            }

            _referendumRepository.Add(referendum);
        }

        public void CloseReferendum(int referendumId)
        {
            var referendum = _referendumRepository.GetById(referendumId);
            if (referendum == null)
                throw new ArgumentException("Referendum not found", nameof(referendumId));

            referendum.SetStatus(ReferendumStatus.Closed);
            _referendumRepository.Update(referendum);
        }

        public void RecordVote(int referendumId, string optionText)
        {
            var referendum = _referendumRepository.GetById(referendumId);
            if (referendum == null)
                throw new ArgumentException("Referendum not found", nameof(referendumId));

            var option = referendum.Options.SingleOrDefault(o => o.OptionText == optionText);
            if (option == null)
                throw new ArgumentException("Option not found", nameof(optionText));

            option.IncrementVoteCount();
            _referendumOptionRepository.Update(option);
        }

        public ReferendumResult CalculateResults(int referendumId)
        {
            var referendum = _referendumRepository.GetById(referendumId);
            if (referendum == null)
                throw new ArgumentException("Referendum not found", nameof(referendumId));

            var optionResults = referendum.Options.Select(option => new OptionResult(option.OptionText, option.VoteCount)).ToList();
            var result = new ReferendumResult(referendum.Id, DateTime.UtcNow, optionResults);

            referendum.SetResult(result);
            _referendumResultRepository.Add(result);
            _referendumRepository.Update(referendum);

            return result;
        }
    }
}