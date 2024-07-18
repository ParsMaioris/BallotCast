using Microsoft.EntityFrameworkCore;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ReferendumResult>().HasData(
            new ReferendumResult
            {
                Id = 1,
                ResultDate = DateTime.UtcNow
            },
            new ReferendumResult
            {
                Id = 2,
                ResultDate = DateTime.UtcNow
            },
            new ReferendumResult
            {
                Id = 3,
                ResultDate = DateTime.UtcNow
            },
            new ReferendumResult
            {
                Id = 4,
                ResultDate = DateTime.UtcNow
            },
            new ReferendumResult
            {
                Id = 5,
                ResultDate = DateTime.UtcNow
            },
            new ReferendumResult
            {
                Id = 6,
                ResultDate = DateTime.UtcNow
            }
        );

        modelBuilder.Entity<Referendum>().HasData(
            new Referendum
            {
                Id = 1,
                Title = "Environmental Policy",
                Question = "Do you support the new environmental policy to reduce carbon emissions by 40% by 2030?",
                CreatedDate = DateTime.UtcNow,
                Status = ReferendumStatus.Active,
                ResultId = 1
            },
            new Referendum
            {
                Id = 2,
                Title = "Education Reform",
                Question = "Do you support the new education reform to introduce coding classes in all high schools?",
                CreatedDate = DateTime.UtcNow,
                Status = ReferendumStatus.Pending,
                ResultId = 2
            },
            new Referendum
            {
                Id = 3,
                Title = "Healthcare Improvement",
                Question = "Do you support the proposed improvements to the healthcare system to provide free healthcare to all citizens?",
                CreatedDate = DateTime.UtcNow,
                Status = ReferendumStatus.Active,
                ResultId = 3
            },
            new Referendum
            {
                Id = 4,
                Title = "Transport Infrastructure",
                Question = "Do you support the plan to develop new public transport infrastructure, including new bus and train routes?",
                CreatedDate = DateTime.UtcNow,
                Status = ReferendumStatus.Pending,
                ResultId = 4
            },
            new Referendum
            {
                Id = 5,
                Title = "Tax Reform",
                Question = "Do you support the proposed tax reform to reduce income tax rates for middle-class families?",
                CreatedDate = DateTime.UtcNow,
                Status = ReferendumStatus.Pending,
                ResultId = 5
            },
            new Referendum
            {
                Id = 6,
                Title = "Renewable Energy",
                Question = "Do you support the initiative to increase investment in renewable energy sources such as solar and wind power?",
                CreatedDate = DateTime.UtcNow,
                Status = ReferendumStatus.Active,
                ResultId = 6
            }
        );

        modelBuilder.Entity<Paragraph>().HasData(
            new Paragraph { Id = 1, ReferendumId = 1, Content = "This policy aims to address climate change by reducing carbon emissions." },
            new Paragraph { Id = 2, ReferendumId = 1, Content = "The policy includes measures such as promoting renewable energy sources." },
            new Paragraph { Id = 3, ReferendumId = 2, Content = "The reform aims to equip students with essential skills for the future job market." },
            new Paragraph { Id = 4, ReferendumId = 2, Content = "Coding classes will be mandatory for all high school students." },
            new Paragraph { Id = 5, ReferendumId = 3, Content = "The healthcare improvements include free healthcare services for all citizens." },
            new Paragraph { Id = 6, ReferendumId = 3, Content = "The plan includes increasing funding for hospitals and clinics." },
            new Paragraph { Id = 7, ReferendumId = 4, Content = "The new transport infrastructure plan aims to reduce traffic congestion." },
            new Paragraph { Id = 8, ReferendumId = 4, Content = "The plan includes new bus and train routes to improve public transport." },
            new Paragraph { Id = 9, ReferendumId = 5, Content = "The tax reform proposal aims to reduce the tax burden on middle-class families." },
            new Paragraph { Id = 10, ReferendumId = 5, Content = "The plan includes reducing income tax rates and increasing tax credits." },
            new Paragraph { Id = 11, ReferendumId = 6, Content = "The initiative aims to increase investment in renewable energy sources." },
            new Paragraph { Id = 12, ReferendumId = 6, Content = "The plan includes building new solar and wind power plants." }
        );

        modelBuilder.Entity<ReferendumOption>().HasData(
            new ReferendumOption { Id = 1, ReferendumId = 1, OptionText = "Yes" },
            new ReferendumOption { Id = 2, ReferendumId = 1, OptionText = "No" },
            new ReferendumOption { Id = 3, ReferendumId = 2, OptionText = "Yes" },
            new ReferendumOption { Id = 4, ReferendumId = 2, OptionText = "No" },
            new ReferendumOption { Id = 5, ReferendumId = 3, OptionText = "Yes" },
            new ReferendumOption { Id = 6, ReferendumId = 3, OptionText = "No" },
            new ReferendumOption { Id = 7, ReferendumId = 4, OptionText = "Yes" },
            new ReferendumOption { Id = 8, ReferendumId = 4, OptionText = "No" },
            new ReferendumOption { Id = 9, ReferendumId = 5, OptionText = "Yes" },
            new ReferendumOption { Id = 10, ReferendumId = 5, OptionText = "No" },
            new ReferendumOption { Id = 11, ReferendumId = 6, OptionText = "Yes" },
            new ReferendumOption { Id = 12, ReferendumId = 6, OptionText = "No" }
        );
    }
}