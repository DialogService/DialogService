namespace DialogService.Items
{
    /// <summary>
    /// Defines an item with content
    /// </summary>
    public interface IContentItem : IContentItem<object>
    { }

    /// <summary>
    /// Defines an item with specific content type
    /// </summary>
    /// <typeparam name="T">Content type</typeparam>
    public interface IContentItem<T> : IDialogItem
    {
        T Content { get; set; } 
    }
}
