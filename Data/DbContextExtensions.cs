using Microsoft.EntityFrameworkCore;

public static class DbContextExtensions
{
    public static bool IsCollectionLoaded<T>(this DbContext context, T entity, string propertyName) where T : class
    {
        var collection = context.Entry(entity).Collections.FirstOrDefault(c => c.Metadata.Name == propertyName);
        return collection?.IsLoaded ?? false;
    }
}