using BallotCast.Domain;

namespace BallotCast.Infrastructure
{
    public static class EntityMapper
    {
        public static Voter MapToDomain(VoterEntity entity)
        {
            if (entity == null) return null;
            var voter = new Voter(entity.Id, entity.Name, entity.Email);

            foreach (var voterReferendumEntity in entity.EligibleReferendums)
            {
                var referendum = new Referendum(voterReferendumEntity.Referendum.Id, voterReferendumEntity.Referendum.Title, voterReferendumEntity.Referendum.Question);
                var voterReferendum = new VoterReferendum(voter, referendum, voterReferendumEntity.CanVote);
                voter.AddEligibleReferendum(voterReferendum);
            }

            foreach (var voteEntity in entity.CastVotes)
            {
                var referendum = new Referendum(voteEntity.Referendum.Id, voteEntity.Referendum.Title, voteEntity.Referendum.Question);
                var vote = new Vote(voteEntity.Id, voter, referendum, voteEntity.IsYes);
                voter.AddVote(vote);
            }
            return voter;
        }

        public static VoterEntity MapToInfrastructure(Voter domain)
        {
            if (domain == null) return null;
            var voterEntity = new VoterEntity
            {
                Id = domain.Id,
                Name = domain.Name,
                Email = domain.Email
            };

            foreach (var voterReferendum in domain.EligibleReferendums)
            {
                var referendumEntity = new ReferendumEntity
                {
                    Id = voterReferendum.Referendum.Id,
                    Title = voterReferendum.Referendum.Title,
                    Question = voterReferendum.Referendum.Question
                };

                var voterReferendumEntity = new VoterReferendumEntity
                {
                    VoterId = voterReferendum.VoterId,
                    ReferendumId = voterReferendum.ReferendumId,
                    CanVote = voterReferendum.CanVote,
                    Voter = voterEntity,
                    Referendum = referendumEntity
                };

                voterEntity.EligibleReferendums.Add(voterReferendumEntity);
            }

            foreach (var vote in domain.CastVotes)
            {
                var referendumEntity = new ReferendumEntity
                {
                    Id = vote.Referendum.Id,
                    Title = vote.Referendum.Title,
                    Question = vote.Referendum.Question
                };

                var voteEntity = new VoteEntity
                {
                    Id = vote.Id,
                    VoterId = vote.VoterId,
                    ReferendumId = vote.ReferendumId,
                    IsYes = vote.IsYes,
                    VoteDate = vote.VoteDate,
                    Voter = voterEntity,
                    Referendum = referendumEntity
                };

                voterEntity.CastVotes.Add(voteEntity);
            }

            return voterEntity;
        }

        public static Referendum MapToDomain(ReferendumEntity entity)
        {
            if (entity == null) return null;
            var referendum = new Referendum(entity.Id, entity.Title, entity.Question);

            foreach (var paragraphEntity in entity.Paragraphs)
            {
                var paragraph = new Paragraph(paragraphEntity.Id, paragraphEntity.Content, referendum);
                referendum.AddParagraph(paragraph);
            }

            foreach (var voterReferendumEntity in entity.EligibleVoters)
            {
                var voter = new Voter(voterReferendumEntity.Voter.Id, voterReferendumEntity.Voter.Name, voterReferendumEntity.Voter.Email);
                var voterReferendum = new VoterReferendum(voter, referendum, voterReferendumEntity.CanVote);
                referendum.AddEligibleVoter(voterReferendum);
            }

            foreach (var voteEntity in entity.Votes)
            {
                var voter = new Voter(voteEntity.Voter.Id, voteEntity.Voter.Name, voteEntity.Voter.Email);
                var vote = new Vote(voteEntity.Id, voter, referendum, voteEntity.IsYes);
                referendum.AddVote(vote);
            }

            referendum.SetResult(MapToDomain(entity.Result));
            return referendum;
        }

        public static ReferendumEntity MapToInfrastructure(Referendum domain)
        {
            if (domain == null) return null;
            var referendumEntity = new ReferendumEntity
            {
                Id = domain.Id,
                Title = domain.Title,
                Question = domain.Question,
                Status = (ReferendumStatusEntity)domain.Status,
                Result = MapToInfrastructure(domain.Result)
            };

            foreach (var paragraph in domain.Paragraphs)
            {
                var paragraphEntity = new ParagraphEntity
                {
                    Id = paragraph.Id,
                    Content = paragraph.Content,
                    ReferendumId = paragraph.ReferendumId,
                    Referendum = referendumEntity
                };
                referendumEntity.Paragraphs.Add(paragraphEntity);
            }

            foreach (var voterReferendum in domain.EligibleVoters)
            {
                var voterEntity = new VoterEntity
                {
                    Id = voterReferendum.Voter.Id,
                    Name = voterReferendum.Voter.Name,
                    Email = voterReferendum.Voter.Email
                };

                var voterReferendumEntity = new VoterReferendumEntity
                {
                    VoterId = voterReferendum.VoterId,
                    ReferendumId = voterReferendum.ReferendumId,
                    CanVote = voterReferendum.CanVote,
                    Voter = voterEntity,
                    Referendum = referendumEntity
                };

                referendumEntity.EligibleVoters.Add(voterReferendumEntity);
            }

            foreach (var vote in domain.Votes)
            {
                var voterEntity = new VoterEntity
                {
                    Id = vote.Voter.Id,
                    Name = vote.Voter.Name,
                    Email = vote.Voter.Email
                };

                var voteEntity = new VoteEntity
                {
                    Id = vote.Id,
                    VoterId = vote.VoterId,
                    ReferendumId = vote.ReferendumId,
                    IsYes = vote.IsYes,
                    VoteDate = vote.VoteDate,
                    Voter = voterEntity,
                    Referendum = referendumEntity
                };

                referendumEntity.Votes.Add(voteEntity);
            }

            return referendumEntity;
        }

        public static Paragraph MapToDomain(ParagraphEntity entity)
        {
            if (entity == null) return null;
            return new Paragraph(entity.Id, entity.Content, null);
        }

        public static ParagraphEntity MapToInfrastructure(Paragraph domain)
        {
            if (domain == null) return null;
            return new ParagraphEntity
            {
                Id = domain.Id,
                Content = domain.Content,
                ReferendumId = domain.ReferendumId,
                Referendum = null
            };
        }

        public static ReferendumResult MapToDomain(ReferendumResultEntity entity)
        {
            if (entity == null) return null;
            return new ReferendumResult(entity.Id, entity.YesCount, entity.NoCount);
        }

        public static ReferendumResultEntity MapToInfrastructure(ReferendumResult domain)
        {
            if (domain == null) return null;
            return new ReferendumResultEntity
            {
                Id = domain.Id,
                YesCount = domain.YesCount,
                NoCount = domain.NoCount,
                ResultDate = domain.ResultDate,
            };
        }

        public static Vote MapToDomain(VoteEntity entity)
        {
            if (entity == null) return null;
            var voter = new Voter(entity.Voter.Id, entity.Voter.Name, entity.Voter.Email);
            var referendum = new Referendum(entity.Referendum.Id, entity.Referendum.Title, entity.Referendum.Question);
            return new Vote(entity.Id, voter, referendum, entity.IsYes);
        }

        public static VoteEntity MapToInfrastructure(Vote domain)
        {
            if (domain == null) return null;
            return new VoteEntity
            {
                Id = domain.Id,
                VoterId = domain.VoterId,
                ReferendumId = domain.ReferendumId,
                IsYes = domain.IsYes,
                VoteDate = domain.VoteDate,
                Voter = new VoterEntity
                {
                    Id = domain.Voter.Id,
                    Name = domain.Voter.Name,
                    Email = domain.Voter.Email
                },
                Referendum = new ReferendumEntity
                {
                    Id = domain.Referendum.Id,
                    Title = domain.Referendum.Title,
                    Question = domain.Referendum.Question
                }
            };
        }

        public static VoterReferendum MapToDomain(VoterReferendumEntity entity)
        {
            if (entity == null) return null;
            var voter = new Voter(entity.Voter.Id, entity.Voter.Name, entity.Voter.Email);
            var referendum = new Referendum(entity.Referendum.Id, entity.Referendum.Title, entity.Referendum.Question);
            return new VoterReferendum(voter, referendum, entity.CanVote);
        }

        public static VoterReferendumEntity MapToInfrastructure(VoterReferendum domain)
        {
            if (domain == null) return null;
            return new VoterReferendumEntity
            {
                VoterId = domain.VoterId,
                ReferendumId = domain.ReferendumId,
                CanVote = domain.CanVote,
                Voter = new VoterEntity
                {
                    Id = domain.Voter.Id,
                    Name = domain.Voter.Name,
                    Email = domain.Voter.Email
                },
                Referendum = new ReferendumEntity
                {
                    Id = domain.Referendum.Id,
                    Title = domain.Referendum.Title,
                    Question = domain.Referendum.Question
                }
            };
        }
    }
}