using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace DialogService
{
    public class DialogPlatformBuilder : IDialogPlatformBuilder
    {
        private readonly List<AbstractPlatform> platforms = new List<AbstractPlatform>();

        public IDialogPlatformBuilder AddPlatform<T>() => AddPlatform(typeof(T));

        public IDialogPlatformBuilder AddPlatform(Type type)
        {
            if (type.BaseType != null && type.BaseType == typeof(AbstractPlatform))
            {
                var instance = (AbstractPlatform)Activator.CreateInstance(type);
                platforms.Add(instance);
            }
            else if (type.GetInterfaces().Contains(typeof(IDialogService)))
                throw new InvalidCastException($"Confused! You can't use IDialogService implementation, you need to use AbstractPlatform type. See https://dialogservice.github.io for examples.");
            else
                throw new InvalidCastException($"Platform type can be only AbstractPlatform, not '{type.Name}'. See https://dialogservice.github.io for examples.");

            return this;
        }

        public IDialogService GetService()
        {
            var rtPlatform = RuntimePlatform.Unknown;

            var isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            var isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
            var isMacOS = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);

            if (isWindows)
                rtPlatform = RuntimePlatform.Windows;
            else if (isLinux)
                rtPlatform = RuntimePlatform.Linux;
            else if (isMacOS)
                rtPlatform = RuntimePlatform.MacOS;

            foreach (var platform in platforms)
            {
                if (platform.Platform == rtPlatform)
                    return platform.Get();
            }

            throw new NoPlatformException($"Implementation for current platform not found ({rtPlatform})");
        }
    }
}
