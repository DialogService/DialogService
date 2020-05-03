namespace DialogService.Items
{
    /// <summary>
    /// Defines an item with a content
    /// </summary>
    public interface IContainerItem : IContainerItem<IDialogItem>
    { }

    /// <summary>
    /// Defines an item with specific content type
    /// </summary>
    /// <typeparam name="T">Content type</typeparam>
    public interface IContainerItem<T> : IDialogItem
    {
        T Content { get; set; } 
    }
}
