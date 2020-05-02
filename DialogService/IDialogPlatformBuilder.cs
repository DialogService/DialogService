using System;

namespace DialogService
{
    public interface IDialogPlatformBuilder
    {
        /// <summary>
        /// Adds a platform type to a builder
        /// </summary>
        /// <typeparam name="T"><see cref="AbstractPlatform"/></typeparam>
        /// <returns><see cref="IDialogPlatformBuilder"/></returns>
        IDialogPlatformBuilder AddPlatform<T>();

        /// <summary>
        /// Adds a platform type to a builder
        /// </summary>
        /// <typeparam name="type"><see cref="AbstractPlatform"/> type</typeparam>
        /// <returns><see cref="IDialogPlatformBuilder"/></returns>
        IDialogPlatformBuilder AddPlatform(Type type);

        /// <summary>
        /// Gets an <see cref="IDialogService"/> implementation from available platforms
        /// </summary>
        /// <returns><see cref="IDialogService"/></returns>
        IDialogService GetService();
    }
}
