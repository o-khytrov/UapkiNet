﻿using System;
using System.IO;

// Note: Code in this file is maintained manually.

namespace UapkiNet.Common
{
    /// <summary>
    /// Utility class for runtime platform detection
    /// </summary>
    public static class Platform
    {
        /// <summary>
        /// True if 64-bit runtime is used
        /// </summary>
        public static bool Uses64BitRuntime => (IntPtr.Size == 8);

        /// <summary>
        /// True if 32-bit runtime is used
        /// </summary>
        public static bool Uses32BitRuntime => (IntPtr.Size == 4);

        /// <summary>
        /// True if runtime platform is Windows
        /// </summary>
        private static bool _isWindows;

        /// <summary>
        /// True if runtime platform is Windows
        /// </summary>
        public static bool IsWindows
        {
            get
            {
                DetectPlatform();
                return _isWindows;
            }
        }

        /// <summary>
        /// True if runtime platform is Linux
        /// </summary>
        private static bool _isLinux;

        /// <summary>
        /// True if runtime platform is Linux
        /// </summary>
        public static bool IsLinux
        {
            get
            {
                DetectPlatform();
                return _isLinux;
            }
        }

        /// <summary>
        /// True if runtime platform is Mac OS X
        /// </summary>
        private static bool _isMacOsX;

        /// <summary>
        /// True if runtime platform is Mac OS X
        /// </summary>
        public static bool IsMacOsX
        {
            get
            {
                DetectPlatform();
                return _isMacOsX;
            }
        }

        /// <summary>
        /// Size of native (unmanaged) long type
        /// </summary>
        private static int _nativeULongSize = 0;

        /// <summary>
        /// Controls the alignment of unmanaged struct fields
        /// </summary>
        private static int _structPackingSize = -1;

        /// <summary>
        /// Controls the alignment of unmanaged struct fields.
        /// This property is used by HighLevelAPI to choose correct set of LowLevelAPIs.
        /// Value of this property can be changed if needed.
        /// </summary>
        public static int StructPackingSize
        {
            get
            {
                if (_structPackingSize != -1)
                    return _structPackingSize;

                if (IsLinux || IsMacOsX)
                {
                    _structPackingSize = 0;
                }
                else
                {
                    _structPackingSize = 1;
                }

                return _structPackingSize;
            }

            set
            {
                if ((value != 0) && (value != 1))
                    throw new ArgumentException();

                // Automatic value detection can be overriden if needed
                _structPackingSize = value;
            }
        }

        /// <summary>
        /// Performs platform detection
        /// </summary>
        private static void DetectPlatform()
        {
            // Supported platform has already been detected
            if (_isWindows || _isLinux || _isMacOsX)
                return;

#if NETSTANDARD2_0
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                _isWindows = true;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                // Note: Android gets here too
                _isLinux = true;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                // Note: iOS gets here too
                _isMacOsX = true;
            }
            else
            {
                throw new PlatformNotSupportedException("Library is not supported on this platform");
            }

#else

            // Detect platform
            //
            // System.Environment.OSVersion.Platform is not used because:
            // - Mac OS X detection almost never works under Mono
            // - it is not implemented by .NET Core
            //
            // System.Runtime.InteropServices.RuntimeInformation is not used because:
            // - it is not implemented by full .NET and Mono
            // - it does not perform platform detection in runtime but uses hardcoded information instead
            //   See https://github.com/dotnet/corefx/issues/3032 for more info
            //
            // Pinvoking of platform specific unmanaged functions is not used because:
            // - it may cause segmentation fault on unknown platforms
            //
            // Following code may look silly but:
            // - it is 100% managed code
            // - it works under .NET, Mono and .NET Core
            // - it works like a charm so far

            string windir = Environment.GetEnvironmentVariable("windir");
            if (!string.IsNullOrEmpty(windir) && windir.Contains(@"\") && Directory.Exists(windir))
            {
                _isWindows = true;
            }
            else if (File.Exists(@"/proc/sys/kernel/ostype"))
            {
                string osType = File.ReadAllText(@"/proc/sys/kernel/ostype");
                if (osType.StartsWith("Linux", StringComparison.OrdinalIgnoreCase))
                {
                    // Note: Android gets here too
                    _isLinux = true;
                }
                else
                {
                    throw new PlatformNotSupportedException(string.Format("Library is not supported on \"{0}\" platform", osType));
                }
            }
            else if (File.Exists(@"/System/Library/CoreServices/SystemVersion.plist"))
            {
                // Note: iOS gets here too
                _isMacOsX = true;
            }
            else
            {
                throw new PlatformNotSupportedException("Library is not supported on this platform");
            }

#endif
        }
    }
}