namespace DialogService
{
    public interface IContentItem : IContentItem<object>
    { }

    public interface IContentItem<T>
    {
        T Content { get; set; } 
    }
}
