using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Security;

namespace PdfLibCore.Bindings
{
    // ReSharper disable UnusedMember.Global
    // ReSharper disable UnusedParameter.Local
    // ReSharper disable PartialTypeWithSinglePart
    // ReSharper disable InconsistentNaming
    // ReSharper disable NotAccessedVariable
    // ReSharper disable RedundantCast
    // ReSharper disable MemberHidesStaticFromOuterClass
    // ReSharper disable RedundantUnsafeContext
    // ReSharper disable IdentifierTypo
    // ReSharper disable ArrangeAccessorOwnerBody
    // ReSharper disable MergeConditionalExpression
    
    public enum FPDF_DUPLEXTYPE_
    {
        DuplexUndefined = 0,
        Simplex = 1,
        DuplexFlipShortEdge = 2,
        DuplexFlipLongEdge = 3
    }
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Flags]
    internal enum FPDF
    {
        ANNOT = 0x1,
        LCD_TEXT = 0x2,
        NO_NATIVETEXT = 0x4,
        GRAYSCALE = 0x8,
        DEBUG_INFO = 0x80,
        NO_CATCH = 0x100,
        RENDER_LIMITEDIMAGECACHE = 0x200,
        RENDER_FORCEHALFTONE = 0x400,
        PRINTING = 0x800,
        REVERSE_BYTE_ORDER = 0x10,
        CORRECT_FROM_DPI = 0x2000
    }

    internal unsafe partial class FpdfActionT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr, FpdfActionT>
            NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfActionT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfActionT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfActionT(native.ToPointer(), skipVTables);
        }

        internal static FpdfActionT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfActionT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfActionT(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfActionT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfAnnotationT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FpdfAnnotationT> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfAnnotationT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfAnnotationT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfAnnotationT(native.ToPointer(), skipVTables);
        }

        internal static FpdfAnnotationT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfAnnotationT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfAnnotationT(__Internal native,
            bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfAnnotationT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfAttachmentT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FpdfAttachmentT> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfAttachmentT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfAttachmentT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfAttachmentT(native.ToPointer(), skipVTables);
        }

        internal static FpdfAttachmentT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfAttachmentT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfAttachmentT(__Internal native,
            bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfAttachmentT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfBitmapT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr, FpdfBitmapT>
            NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfBitmapT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfBitmapT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfBitmapT(native.ToPointer(), skipVTables);
        }

        internal static FpdfBitmapT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfBitmapT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfBitmapT(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfBitmapT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public object LockBits(Rectangle rectangle, ImageLockMode readWrite, object pixelFormat)
        {
            throw new NotImplementedException();
        }
    }

    internal unsafe partial class FpdfBookmarkT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FpdfBookmarkT> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfBookmarkT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfBookmarkT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfBookmarkT(native.ToPointer(), skipVTables);
        }

        internal static FpdfBookmarkT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfBookmarkT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfBookmarkT(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfBookmarkT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfClippathT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FpdfClippathT> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfClippathT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfClippathT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfClippathT(native.ToPointer(), skipVTables);
        }

        internal static FpdfClippathT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfClippathT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfClippathT(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfClippathT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfDestT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr, FpdfDestT>
            NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfDestT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfDestT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfDestT(native.ToPointer(), skipVTables);
        }

        internal static FpdfDestT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfDestT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfDestT(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfDestT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfDocumentT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FpdfDocumentT> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfDocumentT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfDocumentT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfDocumentT(native.ToPointer(), skipVTables);
        }

        internal static FpdfDocumentT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfDocumentT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfDocumentT(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfDocumentT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfFontT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr, FpdfFontT>
            NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfFontT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfFontT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfFontT(native.ToPointer(), skipVTables);
        }

        internal static FpdfFontT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfFontT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfFontT(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfFontT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfFormHandleT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FpdfFormHandleT> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfFormHandleT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfFormHandleT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfFormHandleT(native.ToPointer(), skipVTables);
        }

        internal static FpdfFormHandleT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfFormHandleT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfFormHandleT(__Internal native,
            bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfFormHandleT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfLinkT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr, FpdfLinkT>
            NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfLinkT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfLinkT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfLinkT(native.ToPointer(), skipVTables);
        }

        internal static FpdfLinkT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfLinkT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfLinkT(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfLinkT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfPageT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr, FpdfPageT>
            NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfPageT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfPageT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfPageT(native.ToPointer(), skipVTables);
        }

        internal static FpdfPageT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfPageT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfPageT(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfPageT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfPagelinkT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FpdfPagelinkT> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfPagelinkT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfPagelinkT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfPagelinkT(native.ToPointer(), skipVTables);
        }

        internal static FpdfPagelinkT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfPagelinkT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfPagelinkT(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfPagelinkT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfPageobjectT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FpdfPageobjectT> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfPageobjectT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfPageobjectT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfPageobjectT(native.ToPointer(), skipVTables);
        }

        internal static FpdfPageobjectT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfPageobjectT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfPageobjectT(__Internal native,
            bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfPageobjectT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfPageobjectmarkT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FpdfPageobjectmarkT> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfPageobjectmarkT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfPageobjectmarkT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfPageobjectmarkT(native.ToPointer(), skipVTables);
        }

        internal static FpdfPageobjectmarkT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfPageobjectmarkT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfPageobjectmarkT(__Internal native,
            bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfPageobjectmarkT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfPagerangeT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FpdfPagerangeT> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfPagerangeT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfPagerangeT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfPagerangeT(native.ToPointer(), skipVTables);
        }

        internal static FpdfPagerangeT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfPagerangeT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfPagerangeT(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfPagerangeT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfPathsegmentT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FpdfPathsegmentT> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfPathsegmentT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfPathsegmentT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfPathsegmentT(native.ToPointer(), skipVTables);
        }

        internal static FpdfPathsegmentT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfPathsegmentT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfPathsegmentT(__Internal native,
            bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfPathsegmentT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfSchhandleT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FpdfSchhandleT> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfSchhandleT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfSchhandleT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfSchhandleT(native.ToPointer(), skipVTables);
        }

        internal static FpdfSchhandleT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfSchhandleT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfSchhandleT(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfSchhandleT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfStructelementT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FpdfStructelementT> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfStructelementT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfStructelementT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfStructelementT(native.ToPointer(), skipVTables);
        }

        internal static FpdfStructelementT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfStructelementT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfStructelementT(__Internal native,
            bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfStructelementT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfStructtreeT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FpdfStructtreeT> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfStructtreeT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfStructtreeT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfStructtreeT(native.ToPointer(), skipVTables);
        }

        internal static FpdfStructtreeT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfStructtreeT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfStructtreeT(__Internal native,
            bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfStructtreeT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FpdfTextpageT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FpdfTextpageT> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FpdfTextpageT>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FpdfTextpageT __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FpdfTextpageT(native.ToPointer(), skipVTables);
        }

        internal static FpdfTextpageT __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FpdfTextpageT(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FpdfTextpageT(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FpdfTextpageT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }

    internal unsafe partial class FS_MATRIX_ : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public partial struct __Internal
        {
            [FieldOffset(0)] internal float a;

            [FieldOffset(4)] internal float b;

            [FieldOffset(8)] internal float c;

            [FieldOffset(12)] internal float d;

            [FieldOffset(16)] internal float e;

            [FieldOffset(20)] internal float f;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "??0_FS_MATRIX_@@QEAA@AEBU0@@Z")]
            internal static extern IntPtr
                cctor(IntPtr instance, IntPtr _0);
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr, FS_MATRIX_>
            NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FS_MATRIX_>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FS_MATRIX_ __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FS_MATRIX_(native.ToPointer(), skipVTables);
        }

        internal static FS_MATRIX_ __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FS_MATRIX_(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FS_MATRIX_(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FS_MATRIX_(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public FS_MATRIX_()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public FS_MATRIX_(FS_MATRIX_ _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((__Internal*)__Instance) =
                *((__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            FS_MATRIX_ __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public float A
        {
            get { return ((__Internal*)__Instance)->a; }

            set { ((__Internal*)__Instance)->a = value; }
        }

        public float B
        {
            get { return ((__Internal*)__Instance)->b; }

            set { ((__Internal*)__Instance)->b = value; }
        }

        public float C
        {
            get { return ((__Internal*)__Instance)->c; }

            set { ((__Internal*)__Instance)->c = value; }
        }

        public float D
        {
            get { return ((__Internal*)__Instance)->d; }

            set { ((__Internal*)__Instance)->d = value; }
        }

        public float E
        {
            get { return ((__Internal*)__Instance)->e; }

            set { ((__Internal*)__Instance)->e = value; }
        }

        public float F
        {
            get { return ((__Internal*)__Instance)->f; }

            set { ((__Internal*)__Instance)->f = value; }
        }
    }

    internal unsafe partial class FS_RECTF_ : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)] internal float left;

            [FieldOffset(4)] internal float top;

            [FieldOffset(8)] internal float right;

            [FieldOffset(12)] internal float bottom;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "??0_FS_RECTF_@@QEAA@AEBU0@@Z")]
            internal static extern IntPtr
                cctor(IntPtr instance, IntPtr _0);
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr, FS_RECTF_>
            NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FS_RECTF_>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FS_RECTF_ __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FS_RECTF_(native.ToPointer(), skipVTables);
        }

        internal static FS_RECTF_ __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FS_RECTF_(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FS_RECTF_(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FS_RECTF_(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public FS_RECTF_()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public FS_RECTF_(FS_RECTF_ _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((__Internal*)__Instance) =
                *((__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            FS_RECTF_ __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public float Left
        {
            get { return ((__Internal*)__Instance)->left; }

            set { ((__Internal*)__Instance)->left = value; }
        }

        public float Top
        {
            get { return ((__Internal*)__Instance)->top; }

            set { ((__Internal*)__Instance)->top = value; }
        }

        public float Right
        {
            get { return ((__Internal*)__Instance)->right; }

            set { ((__Internal*)__Instance)->right = value; }
        }

        public float Bottom
        {
            get { return ((__Internal*)__Instance)->bottom; }

            set { ((__Internal*)__Instance)->bottom = value; }
        }
    }

    internal unsafe partial class FPDF_LIBRARY_CONFIG_ : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)] internal int version;

            [FieldOffset(8)] internal IntPtr m_pUserFontPaths;

            [FieldOffset(16)] internal IntPtr m_pIsolate;

            [FieldOffset(24)] internal uint m_v8EmbedderSlot;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "??0FPDF_LIBRARY_CONFIG_@@QEAA@AEBU0@@Z")]
            internal static extern IntPtr
                cctor(IntPtr instance, IntPtr _0);
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FPDF_LIBRARY_CONFIG_> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FPDF_LIBRARY_CONFIG_>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FPDF_LIBRARY_CONFIG_ __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FPDF_LIBRARY_CONFIG_(native.ToPointer(), skipVTables);
        }

        internal static FPDF_LIBRARY_CONFIG_ __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FPDF_LIBRARY_CONFIG_(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FPDF_LIBRARY_CONFIG_(__Internal native,
            bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FPDF_LIBRARY_CONFIG_(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public FPDF_LIBRARY_CONFIG_()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public FPDF_LIBRARY_CONFIG_(FPDF_LIBRARY_CONFIG_ _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((__Internal*)__Instance) =
                *((__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            FPDF_LIBRARY_CONFIG_ __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int Version
        {
            get { return ((__Internal*)__Instance)->version; }

            set { ((__Internal*)__Instance)->version = value; }
        }

        public IntPtr MPIsolate
        {
            get { return ((__Internal*)__Instance)->m_pIsolate; }

            set
            {
                ((__Internal*)__Instance)->m_pIsolate =
                    (IntPtr)value;
            }
        }

        public uint MV8EmbedderSlot
        {
            get { return ((__Internal*)__Instance)->m_v8EmbedderSlot; }

            set { ((__Internal*)__Instance)->m_v8EmbedderSlot = value; }
        }
    }

    internal unsafe partial class FPDF_FILEACCESS : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public partial struct __Internal
        {
            [FieldOffset(0)] internal uint m_FileLen;

            [FieldOffset(8)] internal IntPtr m_GetBlock;

            [FieldOffset(16)] internal IntPtr m_Param;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "??0FPDF_FILEACCESS@@QEAA@AEBU0@@Z")]
            internal static extern IntPtr
                cctor(IntPtr instance, IntPtr _0);
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FPDF_FILEACCESS> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FPDF_FILEACCESS>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FPDF_FILEACCESS __CreateInstance(IntPtr native,
            bool skipVTables = false)
        {
            return new FPDF_FILEACCESS(native.ToPointer(), skipVTables);
        }

        internal static FPDF_FILEACCESS __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FPDF_FILEACCESS(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FPDF_FILEACCESS(__Internal native,
            bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FPDF_FILEACCESS(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public FPDF_FILEACCESS()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public FPDF_FILEACCESS(FPDF_FILEACCESS _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((__Internal*)__Instance) =
                *((__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            FPDF_FILEACCESS __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint MFileLen
        {
            get { return ((__Internal*)__Instance)->m_FileLen; }

            set { ((__Internal*)__Instance)->m_FileLen = value; }
        }

        public IntPtr MParam
        {
            get { return ((__Internal*)__Instance)->m_Param; }

            set
            {
                ((__Internal*)__Instance)->m_Param =
                    (IntPtr)value;
            }
        }
    }

    internal unsafe partial class fpdf_view
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_InitLibrary")]
            internal static extern void FPDF_InitLibrary();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_InitLibraryWithConfig")]
            internal static extern void FPDF_InitLibraryWithConfig(IntPtr config);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_DestroyLibrary")]
            internal static extern void FPDF_DestroyLibrary();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_SetSandBoxPolicy")]
            internal static extern void FPDF_SetSandBoxPolicy(uint policy, int enable);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_SetPrintMode")]
            internal static extern int FPDF_SetPrintMode(int mode);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_LoadDocument")]
            internal static extern IntPtr FPDF_LoadDocument(
                [MarshalAs(UnmanagedType.LPStr)] string file_path, [MarshalAs(UnmanagedType.LPStr)] string password);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_LoadMemDocument")]
            internal static extern IntPtr FPDF_LoadMemDocument(IntPtr data_buf, int size,
                [MarshalAs(UnmanagedType.LPStr)] string password);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_LoadCustomDocument")]
            internal static extern IntPtr FPDF_LoadCustomDocument(IntPtr pFileAccess,
                [MarshalAs(UnmanagedType.LPStr)] string password);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_GetFileVersion")]
            internal static extern int FPDF_GetFileVersion(IntPtr doc, int* fileVersion);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_GetLastError")]
            internal static extern uint FPDF_GetLastError();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_GetDocPermissions")]
            internal static extern uint FPDF_GetDocPermissions(IntPtr document);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_GetSecurityHandlerRevision")]
            internal static extern int FPDF_GetSecurityHandlerRevision(IntPtr document);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_GetPageCount")]
            internal static extern int FPDF_GetPageCount(IntPtr document);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_LoadPage")]
            internal static extern IntPtr FPDF_LoadPage(IntPtr document, int page_index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_GetPageWidth")]
            internal static extern double FPDF_GetPageWidth(IntPtr page);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_GetPageHeight")]
            internal static extern double FPDF_GetPageHeight(IntPtr page);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_GetPageBoundingBox")]
            internal static extern int FPDF_GetPageBoundingBox(IntPtr page, IntPtr rect);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_GetPageSizeByIndex")]
            internal static extern int FPDF_GetPageSizeByIndex(IntPtr document, int page_index,
                double* width, double* height);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_RenderPageBitmap")]
            internal static extern void FPDF_RenderPageBitmap(IntPtr bitmap, IntPtr page,
                int start_x, int start_y, int size_x, int size_y, int rotate, int flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_RenderPageBitmapWithMatrix")]
            internal static extern void FPDF_RenderPageBitmapWithMatrix(IntPtr bitmap,
                IntPtr page, IntPtr matrix, IntPtr clipping, int flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_ClosePage")]
            internal static extern void FPDF_ClosePage(IntPtr page);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_CloseDocument")]
            internal static extern void FPDF_CloseDocument(IntPtr document);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_DeviceToPage")]
            internal static extern int FPDF_DeviceToPage(IntPtr page, int start_x, int start_y,
                int size_x, int size_y, int rotate, int device_x, int device_y, double* page_x, double* page_y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_PageToDevice")]
            internal static extern int FPDF_PageToDevice(IntPtr page, int start_x, int start_y,
                int size_x, int size_y, int rotate, double page_x, double page_y, int* device_x, int* device_y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFBitmap_Create")]
            internal static extern IntPtr FPDFBitmapCreate(int width, int height, int alpha);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFBitmap_CreateEx")]
            internal static extern IntPtr FPDFBitmapCreateEx(int width, int height, int format,
                IntPtr first_scan, int stride);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFBitmap_GetFormat")]
            internal static extern int FPDFBitmapGetFormat(IntPtr bitmap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFBitmap_FillRect")]
            internal static extern void FPDFBitmapFillRect(IntPtr bitmap, int left, int top, int width,
                int height, uint color);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFBitmap_GetBuffer")]
            internal static extern IntPtr FPDFBitmapGetBuffer(IntPtr bitmap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFBitmap_GetWidth")]
            internal static extern int FPDFBitmapGetWidth(IntPtr bitmap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFBitmap_GetHeight")]
            internal static extern int FPDFBitmapGetHeight(IntPtr bitmap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFBitmap_GetStride")]
            internal static extern int FPDFBitmapGetStride(IntPtr bitmap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFBitmap_Destroy")]
            internal static extern void FPDFBitmapDestroy(IntPtr bitmap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_VIEWERREF_GetPrintScaling")]
            internal static extern int FPDF_VIEWERREF_GetPrintScaling(IntPtr document);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_VIEWERREF_GetNumCopies")]
            internal static extern int FPDF_VIEWERREF_GetNumCopies(IntPtr document);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_VIEWERREF_GetPrintPageRange")]
            internal static extern IntPtr FPDF_VIEWERREF_GetPrintPageRange(
                IntPtr document);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_VIEWERREF_GetPrintPageRangeCount")]
            internal static extern ulong FPDF_VIEWERREF_GetPrintPageRangeCount(IntPtr pagerange);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_VIEWERREF_GetPrintPageRangeElement")]
            internal static extern int FPDF_VIEWERREF_GetPrintPageRangeElement(IntPtr pagerange,
                ulong index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_VIEWERREF_GetDuplex")]
            internal static extern FPDF_DUPLEXTYPE_ FPDF_VIEWERREF_GetDuplex(
                IntPtr document);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_VIEWERREF_GetName")]
            internal static extern uint FPDF_VIEWERREF_GetName(IntPtr document,
                [MarshalAs(UnmanagedType.LPStr)] string key, sbyte* buffer, uint length);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_CountNamedDests")]
            internal static extern uint FPDF_CountNamedDests(IntPtr document);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_GetNamedDestByName")]
            internal static extern IntPtr FPDF_GetNamedDestByName(IntPtr document,
                [MarshalAs(UnmanagedType.LPStr)] string name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_GetNamedDest")]
            internal static extern IntPtr FPDF_GetNamedDest(IntPtr document, int index,
                IntPtr buffer, int* buflen);
        }

        public static void FPDF_InitLibrary()
        {
            __Internal.FPDF_InitLibrary();
        }

        public static void FPDF_InitLibraryWithConfig(FPDF_LIBRARY_CONFIG_ config)
        {
            var __arg0 = ReferenceEquals(config, null) ? IntPtr.Zero : config.__Instance;
            __Internal.FPDF_InitLibraryWithConfig(__arg0);
        }

        public static void FPDF_DestroyLibrary()
        {
            __Internal.FPDF_DestroyLibrary();
        }

        public static void FPDF_SetSandBoxPolicy(uint policy, int enable)
        {
            __Internal.FPDF_SetSandBoxPolicy(policy, enable);
        }

        public static int FPDF_SetPrintMode(int mode)
        {
            var __ret = __Internal.FPDF_SetPrintMode(mode);
            return __ret;
        }

        public static FpdfDocumentT FPDF_LoadDocument(string file_path, string password)
        {
            var __ret = __Internal.FPDF_LoadDocument(file_path, password);
            FpdfDocumentT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfDocumentT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfDocumentT)FpdfDocumentT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfDocumentT.__CreateInstance(__ret);
            return __result0;
        }

        public static FpdfDocumentT FPDF_LoadMemDocument(IntPtr data_buf,
            int size, string password)
        {
            var __ret = __Internal.FPDF_LoadMemDocument(data_buf, size, password);
            FpdfDocumentT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfDocumentT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfDocumentT)FpdfDocumentT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfDocumentT.__CreateInstance(__ret);
            return __result0;
        }

        public static FpdfDocumentT FPDF_LoadCustomDocument(
            FPDF_FILEACCESS pFileAccess, string password)
        {
            var __arg0 = ReferenceEquals(pFileAccess, null) ? IntPtr.Zero : pFileAccess.__Instance;
            var __ret = __Internal.FPDF_LoadCustomDocument(__arg0, password);
            FpdfDocumentT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfDocumentT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfDocumentT)FpdfDocumentT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfDocumentT.__CreateInstance(__ret);
            return __result0;
        }

        public static int FPDF_GetFileVersion(FpdfDocumentT doc, ref int fileVersion)
        {
            var __arg0 = ReferenceEquals(doc, null) ? IntPtr.Zero : doc.__Instance;
            fixed (int* __refParamPtr1 = &fileVersion)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.FPDF_GetFileVersion(__arg0, __arg1);
                return __ret;
            }
        }

        public static uint FPDF_GetLastError()
        {
            var __ret = __Internal.FPDF_GetLastError();
            return __ret;
        }

        public static uint FPDF_GetDocPermissions(FpdfDocumentT document)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __ret = __Internal.FPDF_GetDocPermissions(__arg0);
            return __ret;
        }

        public static int FPDF_GetSecurityHandlerRevision(FpdfDocumentT document)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __ret = __Internal.FPDF_GetSecurityHandlerRevision(__arg0);
            return __ret;
        }

        public static int FPDF_GetPageCount(FpdfDocumentT document)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __ret = __Internal.FPDF_GetPageCount(__arg0);
            return __ret;
        }

        public static FpdfPageT FPDF_LoadPage(
            FpdfDocumentT document, int page_index)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __ret = __Internal.FPDF_LoadPage(__arg0, page_index);
            FpdfPageT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfPageT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfPageT)FpdfPageT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfPageT.__CreateInstance(__ret);
            return __result0;
        }

        public static double FPDF_GetPageWidth(FpdfPageT page)
        {
            var __arg0 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            var __ret = __Internal.FPDF_GetPageWidth(__arg0);
            return __ret;
        }

        public static double FPDF_GetPageHeight(FpdfPageT page)
        {
            var __arg0 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            var __ret = __Internal.FPDF_GetPageHeight(__arg0);
            return __ret;
        }

        public static int FPDF_GetPageBoundingBox(FpdfPageT page,
            FS_RECTF_ rect)
        {
            var __arg0 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            var __arg1 = ReferenceEquals(rect, null) ? IntPtr.Zero : rect.__Instance;
            var __ret = __Internal.FPDF_GetPageBoundingBox(__arg0, __arg1);
            return __ret;
        }

        public static int FPDF_GetPageSizeByIndex(FpdfDocumentT document, int page_index,
            ref double width, ref double height)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            fixed (double* __refParamPtr2 = &width)
            {
                var __arg2 = __refParamPtr2;
                fixed (double* __refParamPtr3 = &height)
                {
                    var __arg3 = __refParamPtr3;
                    var __ret = __Internal.FPDF_GetPageSizeByIndex(__arg0, page_index, __arg2, __arg3);
                    return __ret;
                }
            }
        }

        public static void FPDF_RenderPageBitmap(FpdfBitmapT bitmap,
            FpdfPageT page, int start_x, int start_y, int size_x, int size_y, int rotate,
            int flags)
        {
            var __arg0 = ReferenceEquals(bitmap, null) ? IntPtr.Zero : bitmap.__Instance;
            var __arg1 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            __Internal.FPDF_RenderPageBitmap(__arg0, __arg1, start_x, start_y, size_x, size_y, rotate, flags);
        }

        public static void FPDF_RenderPageBitmapWithMatrix(FpdfBitmapT bitmap,
            FpdfPageT page, FS_MATRIX_ matrix,
            FS_RECTF_ clipping, int flags)
        {
            var __arg0 = ReferenceEquals(bitmap, null) ? IntPtr.Zero : bitmap.__Instance;
            var __arg1 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            var __arg2 = ReferenceEquals(matrix, null) ? IntPtr.Zero : matrix.__Instance;
            var __arg3 = ReferenceEquals(clipping, null) ? IntPtr.Zero : clipping.__Instance;
            __Internal.FPDF_RenderPageBitmapWithMatrix(__arg0, __arg1, __arg2, __arg3, flags);
        }

        public static void FPDF_ClosePage(FpdfPageT page)
        {
            var __arg0 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            __Internal.FPDF_ClosePage(__arg0);
        }

        public static void FPDF_CloseDocument(FpdfDocumentT document)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            __Internal.FPDF_CloseDocument(__arg0);
        }

        public static int FPDF_DeviceToPage(FpdfPageT page, int start_x, int start_y,
            int size_x, int size_y, int rotate, int device_x, int device_y, ref double page_x, ref double page_y)
        {
            var __arg0 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            fixed (double* __refParamPtr8 = &page_x)
            {
                var __arg8 = __refParamPtr8;
                fixed (double* __refParamPtr9 = &page_y)
                {
                    var __arg9 = __refParamPtr9;
                    var __ret = __Internal.FPDF_DeviceToPage(__arg0, start_x, start_y, size_x, size_y, rotate, device_x,
                        device_y, __arg8, __arg9);
                    return __ret;
                }
            }
        }

        public static int FPDF_PageToDevice(FpdfPageT page, int start_x, int start_y,
            int size_x, int size_y, int rotate, double page_x, double page_y, ref int device_x, ref int device_y)
        {
            var __arg0 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            fixed (int* __refParamPtr8 = &device_x)
            {
                var __arg8 = __refParamPtr8;
                fixed (int* __refParamPtr9 = &device_y)
                {
                    var __arg9 = __refParamPtr9;
                    var __ret = __Internal.FPDF_PageToDevice(__arg0, start_x, start_y, size_x, size_y, rotate, page_x,
                        page_y, __arg8, __arg9);
                    return __ret;
                }
            }
        }

        public static FpdfBitmapT FPDFBitmapCreate(int width, int height, int alpha)
        {
            var __ret = __Internal.FPDFBitmapCreate(width, height, alpha);
            FpdfBitmapT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfBitmapT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfBitmapT)FpdfBitmapT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfBitmapT.__CreateInstance(__ret);
            return __result0;
        }

        public static FpdfBitmapT FPDFBitmapCreateEx(int width, int height, int format,
            IntPtr first_scan, int stride)
        {
            var __ret = __Internal.FPDFBitmapCreateEx(width, height, format, first_scan, stride);
            FpdfBitmapT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfBitmapT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfBitmapT)FpdfBitmapT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfBitmapT.__CreateInstance(__ret);
            return __result0;
        }

        public static int FPDFBitmapGetFormat(FpdfBitmapT bitmap)
        {
            var __arg0 = ReferenceEquals(bitmap, null) ? IntPtr.Zero : bitmap.__Instance;
            var __ret = __Internal.FPDFBitmapGetFormat(__arg0);
            return __ret;
        }

        public static void FPDFBitmapFillRect(FpdfBitmapT bitmap, int left, int top,
            int width, int height, uint color)
        {
            var __arg0 = ReferenceEquals(bitmap, null) ? IntPtr.Zero : bitmap.__Instance;
            __Internal.FPDFBitmapFillRect(__arg0, left, top, width, height, color);
        }

        public static IntPtr FPDFBitmapGetBuffer(FpdfBitmapT bitmap)
        {
            var __arg0 = ReferenceEquals(bitmap, null) ? IntPtr.Zero : bitmap.__Instance;
            var __ret = __Internal.FPDFBitmapGetBuffer(__arg0);
            return __ret;
        }

        public static int FPDFBitmapGetWidth(FpdfBitmapT bitmap)
        {
            var __arg0 = ReferenceEquals(bitmap, null) ? IntPtr.Zero : bitmap.__Instance;
            var __ret = __Internal.FPDFBitmapGetWidth(__arg0);
            return __ret;
        }

        public static int FPDFBitmapGetHeight(FpdfBitmapT bitmap)
        {
            var __arg0 = ReferenceEquals(bitmap, null) ? IntPtr.Zero : bitmap.__Instance;
            var __ret = __Internal.FPDFBitmapGetHeight(__arg0);
            return __ret;
        }

        public static int FPDFBitmapGetStride(FpdfBitmapT bitmap)
        {
            var __arg0 = ReferenceEquals(bitmap, null) ? IntPtr.Zero : bitmap.__Instance;
            var __ret = __Internal.FPDFBitmapGetStride(__arg0);
            return __ret;
        }

        public static void FPDFBitmapDestroy(FpdfBitmapT bitmap)
        {
            var __arg0 = ReferenceEquals(bitmap, null) ? IntPtr.Zero : bitmap.__Instance;
            __Internal.FPDFBitmapDestroy(__arg0);
        }

        public static int FPDF_VIEWERREF_GetPrintScaling(FpdfDocumentT document)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __ret = __Internal.FPDF_VIEWERREF_GetPrintScaling(__arg0);
            return __ret;
        }

        public static int FPDF_VIEWERREF_GetNumCopies(FpdfDocumentT document)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __ret = __Internal.FPDF_VIEWERREF_GetNumCopies(__arg0);
            return __ret;
        }

        public static FpdfPagerangeT FPDF_VIEWERREF_GetPrintPageRange(
            FpdfDocumentT document)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __ret = __Internal.FPDF_VIEWERREF_GetPrintPageRange(__arg0);
            FpdfPagerangeT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfPagerangeT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfPagerangeT)FpdfPagerangeT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfPagerangeT.__CreateInstance(__ret);
            return __result0;
        }

        public static ulong FPDF_VIEWERREF_GetPrintPageRangeCount(FpdfPagerangeT pagerange)
        {
            var __arg0 = ReferenceEquals(pagerange, null) ? IntPtr.Zero : pagerange.__Instance;
            var __ret = __Internal.FPDF_VIEWERREF_GetPrintPageRangeCount(__arg0);
            return __ret;
        }

        public static int FPDF_VIEWERREF_GetPrintPageRangeElement(FpdfPagerangeT pagerange,
            ulong index)
        {
            var __arg0 = ReferenceEquals(pagerange, null) ? IntPtr.Zero : pagerange.__Instance;
            var __ret = __Internal.FPDF_VIEWERREF_GetPrintPageRangeElement(__arg0, index);
            return __ret;
        }

        public static FPDF_DUPLEXTYPE_ FPDF_VIEWERREF_GetDuplex(
            FpdfDocumentT document)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __ret = __Internal.FPDF_VIEWERREF_GetDuplex(__arg0);
            return __ret;
        }

        public static uint FPDF_VIEWERREF_GetName(FpdfDocumentT document, string key,
            sbyte* buffer, uint length)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __ret = __Internal.FPDF_VIEWERREF_GetName(__arg0, key, buffer, length);
            return __ret;
        }

        public static uint FPDF_CountNamedDests(FpdfDocumentT document)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __ret = __Internal.FPDF_CountNamedDests(__arg0);
            return __ret;
        }

        public static FpdfDestT FPDF_GetNamedDestByName(
            FpdfDocumentT document, string name)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __ret = __Internal.FPDF_GetNamedDestByName(__arg0, name);
            FpdfDestT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfDestT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfDestT)FpdfDestT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfDestT.__CreateInstance(__ret);
            return __result0;
        }

        public static FpdfDestT FPDF_GetNamedDest(
            FpdfDocumentT document, int index, IntPtr buffer,
            ref int buflen)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            fixed (int* __refParamPtr3 = &buflen)
            {
                var __arg3 = __refParamPtr3;
                var __ret = __Internal.FPDF_GetNamedDest(__arg0, index, buffer, __arg3);
                FpdfDestT __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (FpdfDestT.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (FpdfDestT)FpdfDestT
                        .NativeToManagedMap[__ret];
                else __result0 = FpdfDestT.__CreateInstance(__ret);
                return __result0;
            }
        }
    }

    internal unsafe partial class fpdf_text
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_LoadPage")]
            internal static extern IntPtr FPDFTextLoadPage(IntPtr page);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_ClosePage")]
            internal static extern void FPDFTextClosePage(IntPtr text_page);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_CountChars")]
            internal static extern int FPDFTextCountChars(IntPtr text_page);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_GetUnicode")]
            internal static extern uint FPDFTextGetUnicode(IntPtr text_page, int index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_GetFontSize")]
            internal static extern double FPDFTextGetFontSize(IntPtr text_page, int index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_GetFontInfo")]
            internal static extern uint FPDFTextGetFontInfo(IntPtr text_page, int index,
                IntPtr buffer, uint buflen, int* flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_GetCharBox")]
            internal static extern int FPDFTextGetCharBox(IntPtr text_page, int index, double* left,
                double* right, double* bottom, double* top);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_GetCharOrigin")]
            internal static extern int FPDFTextGetCharOrigin(IntPtr text_page, int index, double* x,
                double* y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_GetCharIndexAtPos")]
            internal static extern int FPDFTextGetCharIndexAtPos(IntPtr text_page, double x, double y,
                double xTolerance, double yTolerance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_GetText")]
            internal static extern int FPDFTextGetText(IntPtr text_page, int start_index, int count,
                ushort* result);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_CountRects")]
            internal static extern int FPDFTextCountRects(IntPtr text_page, int start_index, int count);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_GetRect")]
            internal static extern int FPDFTextGetRect(IntPtr text_page, int rect_index, double* left,
                double* top, double* right, double* bottom);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_GetBoundedText")]
            internal static extern int FPDFTextGetBoundedText(IntPtr text_page, double left, double top,
                double right, double bottom, ushort* buffer, int buflen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_FindStart")]
            internal static extern IntPtr FPDFTextFindStart(IntPtr text_page,
                ushort* findwhat, uint flags, int start_index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_FindNext")]
            internal static extern int FPDFTextFindNext(IntPtr handle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_FindPrev")]
            internal static extern int FPDFTextFindPrev(IntPtr handle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_GetSchResultIndex")]
            internal static extern int FPDFTextGetSchResultIndex(IntPtr handle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_GetSchCount")]
            internal static extern int FPDFTextGetSchCount(IntPtr handle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_FindClose")]
            internal static extern void FPDFTextFindClose(IntPtr handle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFLink_LoadWebLinks")]
            internal static extern IntPtr FPDFLinkLoadWebLinks(IntPtr text_page);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFLink_CountWebLinks")]
            internal static extern int FPDFLinkCountWebLinks(IntPtr link_page);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFLink_GetURL")]
            internal static extern int FPDFLinkGetURL(IntPtr link_page, int link_index, ushort* buffer,
                int buflen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFLink_CountRects")]
            internal static extern int FPDFLinkCountRects(IntPtr link_page, int link_index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFLink_GetRect")]
            internal static extern int FPDFLinkGetRect(IntPtr link_page, int link_index, int rect_index,
                double* left, double* top, double* right, double* bottom);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFLink_CloseWebLinks")]
            internal static extern void FPDFLinkCloseWebLinks(IntPtr link_page);
        }

        public static FpdfTextpageT FPDFTextLoadPage(
            FpdfPageT page)
        {
            var __arg0 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            var __ret = __Internal.FPDFTextLoadPage(__arg0);
            FpdfTextpageT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfTextpageT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfTextpageT)FpdfTextpageT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfTextpageT.__CreateInstance(__ret);
            return __result0;
        }

        public static void FPDFTextClosePage(FpdfTextpageT text_page)
        {
            var __arg0 = ReferenceEquals(text_page, null) ? IntPtr.Zero : text_page.__Instance;
            __Internal.FPDFTextClosePage(__arg0);
        }

        public static int FPDFTextCountChars(FpdfTextpageT text_page)
        {
            var __arg0 = ReferenceEquals(text_page, null) ? IntPtr.Zero : text_page.__Instance;
            var __ret = __Internal.FPDFTextCountChars(__arg0);
            return __ret;
        }

        public static uint FPDFTextGetUnicode(FpdfTextpageT text_page, int index)
        {
            var __arg0 = ReferenceEquals(text_page, null) ? IntPtr.Zero : text_page.__Instance;
            var __ret = __Internal.FPDFTextGetUnicode(__arg0, index);
            return __ret;
        }

        public static double FPDFTextGetFontSize(FpdfTextpageT text_page, int index)
        {
            var __arg0 = ReferenceEquals(text_page, null) ? IntPtr.Zero : text_page.__Instance;
            var __ret = __Internal.FPDFTextGetFontSize(__arg0, index);
            return __ret;
        }

        public static uint FPDFTextGetFontInfo(FpdfTextpageT text_page, int index,
            IntPtr buffer, uint buflen, ref int flags)
        {
            var __arg0 = ReferenceEquals(text_page, null) ? IntPtr.Zero : text_page.__Instance;
            fixed (int* __refParamPtr4 = &flags)
            {
                var __arg4 = __refParamPtr4;
                var __ret = __Internal.FPDFTextGetFontInfo(__arg0, index, buffer, buflen, __arg4);
                return __ret;
            }
        }

        public static int FPDFTextGetCharBox(FpdfTextpageT text_page, int index,
            ref double left, ref double right, ref double bottom, ref double top)
        {
            var __arg0 = ReferenceEquals(text_page, null) ? IntPtr.Zero : text_page.__Instance;
            fixed (double* __refParamPtr2 = &left)
            {
                var __arg2 = __refParamPtr2;
                fixed (double* __refParamPtr3 = &right)
                {
                    var __arg3 = __refParamPtr3;
                    fixed (double* __refParamPtr4 = &bottom)
                    {
                        var __arg4 = __refParamPtr4;
                        fixed (double* __refParamPtr5 = &top)
                        {
                            var __arg5 = __refParamPtr5;
                            var __ret = __Internal.FPDFTextGetCharBox(__arg0, index, __arg2, __arg3, __arg4, __arg5);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int FPDFTextGetCharOrigin(FpdfTextpageT text_page, int index,
            ref double x, ref double y)
        {
            var __arg0 = ReferenceEquals(text_page, null) ? IntPtr.Zero : text_page.__Instance;
            fixed (double* __refParamPtr2 = &x)
            {
                var __arg2 = __refParamPtr2;
                fixed (double* __refParamPtr3 = &y)
                {
                    var __arg3 = __refParamPtr3;
                    var __ret = __Internal.FPDFTextGetCharOrigin(__arg0, index, __arg2, __arg3);
                    return __ret;
                }
            }
        }

        public static int FPDFTextGetCharIndexAtPos(FpdfTextpageT text_page, double x,
            double y, double xTolerance, double yTolerance)
        {
            var __arg0 = ReferenceEquals(text_page, null) ? IntPtr.Zero : text_page.__Instance;
            var __ret = __Internal.FPDFTextGetCharIndexAtPos(__arg0, x, y, xTolerance, yTolerance);
            return __ret;
        }

        public static int FPDFTextGetText(FpdfTextpageT text_page, int start_index,
            int count, ref ushort result)
        {
            var __arg0 = ReferenceEquals(text_page, null) ? IntPtr.Zero : text_page.__Instance;
            fixed (ushort* __refParamPtr3 = &result)
            {
                var __arg3 = __refParamPtr3;
                var __ret = __Internal.FPDFTextGetText(__arg0, start_index, count, __arg3);
                return __ret;
            }
        }

        public static int FPDFTextCountRects(FpdfTextpageT text_page, int start_index,
            int count)
        {
            var __arg0 = ReferenceEquals(text_page, null) ? IntPtr.Zero : text_page.__Instance;
            var __ret = __Internal.FPDFTextCountRects(__arg0, start_index, count);
            return __ret;
        }

        public static int FPDFTextGetRect(FpdfTextpageT text_page, int rect_index,
            ref double left, ref double top, ref double right, ref double bottom)
        {
            var __arg0 = ReferenceEquals(text_page, null) ? IntPtr.Zero : text_page.__Instance;
            fixed (double* __refParamPtr2 = &left)
            {
                var __arg2 = __refParamPtr2;
                fixed (double* __refParamPtr3 = &top)
                {
                    var __arg3 = __refParamPtr3;
                    fixed (double* __refParamPtr4 = &right)
                    {
                        var __arg4 = __refParamPtr4;
                        fixed (double* __refParamPtr5 = &bottom)
                        {
                            var __arg5 = __refParamPtr5;
                            var __ret = __Internal.FPDFTextGetRect(__arg0, rect_index, __arg2, __arg3, __arg4, __arg5);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int FPDFTextGetBoundedText(FpdfTextpageT text_page, double left,
            double top, double right, double bottom, ref ushort buffer, int buflen)
        {
            var __arg0 = ReferenceEquals(text_page, null) ? IntPtr.Zero : text_page.__Instance;
            fixed (ushort* __refParamPtr5 = &buffer)
            {
                var __arg5 = __refParamPtr5;
                var __ret = __Internal.FPDFTextGetBoundedText(__arg0, left, top, right, bottom, __arg5, buflen);
                return __ret;
            }
        }

        public static FpdfSchhandleT FPDFTextFindStart(
            FpdfTextpageT text_page, ref ushort findwhat, uint flags, int start_index)
        {
            var __arg0 = ReferenceEquals(text_page, null) ? IntPtr.Zero : text_page.__Instance;
            fixed (ushort* __refParamPtr1 = &findwhat)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.FPDFTextFindStart(__arg0, __arg1, flags, start_index);
                FpdfSchhandleT __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (FpdfSchhandleT.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (FpdfSchhandleT)FpdfSchhandleT.NativeToManagedMap[__ret];
                else __result0 = FpdfSchhandleT.__CreateInstance(__ret);
                return __result0;
            }
        }

        public static int FPDFTextFindNext(FpdfSchhandleT handle)
        {
            var __arg0 = ReferenceEquals(handle, null) ? IntPtr.Zero : handle.__Instance;
            var __ret = __Internal.FPDFTextFindNext(__arg0);
            return __ret;
        }

        public static int FPDFTextFindPrev(FpdfSchhandleT handle)
        {
            var __arg0 = ReferenceEquals(handle, null) ? IntPtr.Zero : handle.__Instance;
            var __ret = __Internal.FPDFTextFindPrev(__arg0);
            return __ret;
        }

        public static int FPDFTextGetSchResultIndex(FpdfSchhandleT handle)
        {
            var __arg0 = ReferenceEquals(handle, null) ? IntPtr.Zero : handle.__Instance;
            var __ret = __Internal.FPDFTextGetSchResultIndex(__arg0);
            return __ret;
        }

        public static int FPDFTextGetSchCount(FpdfSchhandleT handle)
        {
            var __arg0 = ReferenceEquals(handle, null) ? IntPtr.Zero : handle.__Instance;
            var __ret = __Internal.FPDFTextGetSchCount(__arg0);
            return __ret;
        }

        public static void FPDFTextFindClose(FpdfSchhandleT handle)
        {
            var __arg0 = ReferenceEquals(handle, null) ? IntPtr.Zero : handle.__Instance;
            __Internal.FPDFTextFindClose(__arg0);
        }

        public static FpdfPagelinkT FPDFLinkLoadWebLinks(
            FpdfTextpageT text_page)
        {
            var __arg0 = ReferenceEquals(text_page, null) ? IntPtr.Zero : text_page.__Instance;
            var __ret = __Internal.FPDFLinkLoadWebLinks(__arg0);
            FpdfPagelinkT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfPagelinkT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfPagelinkT)FpdfPagelinkT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfPagelinkT.__CreateInstance(__ret);
            return __result0;
        }

        public static int FPDFLinkCountWebLinks(FpdfPagelinkT link_page)
        {
            var __arg0 = ReferenceEquals(link_page, null) ? IntPtr.Zero : link_page.__Instance;
            var __ret = __Internal.FPDFLinkCountWebLinks(__arg0);
            return __ret;
        }

        public static int FPDFLinkGetURL(FpdfPagelinkT link_page, int link_index,
            ref ushort buffer, int buflen)
        {
            var __arg0 = ReferenceEquals(link_page, null) ? IntPtr.Zero : link_page.__Instance;
            fixed (ushort* __refParamPtr2 = &buffer)
            {
                var __arg2 = __refParamPtr2;
                var __ret = __Internal.FPDFLinkGetURL(__arg0, link_index, __arg2, buflen);
                return __ret;
            }
        }

        public static int FPDFLinkCountRects(FpdfPagelinkT link_page, int link_index)
        {
            var __arg0 = ReferenceEquals(link_page, null) ? IntPtr.Zero : link_page.__Instance;
            var __ret = __Internal.FPDFLinkCountRects(__arg0, link_index);
            return __ret;
        }

        public static int FPDFLinkGetRect(FpdfPagelinkT link_page, int link_index,
            int rect_index, ref double left, ref double top, ref double right, ref double bottom)
        {
            var __arg0 = ReferenceEquals(link_page, null) ? IntPtr.Zero : link_page.__Instance;
            fixed (double* __refParamPtr3 = &left)
            {
                var __arg3 = __refParamPtr3;
                fixed (double* __refParamPtr4 = &top)
                {
                    var __arg4 = __refParamPtr4;
                    fixed (double* __refParamPtr5 = &right)
                    {
                        var __arg5 = __refParamPtr5;
                        fixed (double* __refParamPtr6 = &bottom)
                        {
                            var __arg6 = __refParamPtr6;
                            var __ret = __Internal.FPDFLinkGetRect(__arg0, link_index, rect_index, __arg3, __arg4,
                                __arg5, __arg6);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static void FPDFLinkCloseWebLinks(FpdfPagelinkT link_page)
        {
            var __arg0 = ReferenceEquals(link_page, null) ? IntPtr.Zero : link_page.__Instance;
            __Internal.FPDFLinkCloseWebLinks(__arg0);
        }
    }

    internal unsafe partial class fpdf_ppo
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_ImportPages")]
            internal static extern int FPDF_ImportPages(IntPtr dest_doc, IntPtr src_doc,
                [MarshalAs(UnmanagedType.LPStr)] string pagerange, int index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_ImportNPagesToOne")]
            internal static extern IntPtr FPDF_ImportNPagesToOne(IntPtr src_doc,
                float output_width, float output_height, uint num_pages_on_x_axis, uint num_pages_on_y_axis);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_CopyViewerPreferences")]
            internal static extern int FPDF_CopyViewerPreferences(IntPtr dest_doc,
                IntPtr src_doc);
        }

        public static int FPDF_ImportPages(FpdfDocumentT dest_doc,
            FpdfDocumentT src_doc, string pagerange, int index)
        {
            var __arg0 = ReferenceEquals(dest_doc, null) ? IntPtr.Zero : dest_doc.__Instance;
            var __arg1 = ReferenceEquals(src_doc, null) ? IntPtr.Zero : src_doc.__Instance;
            var __ret = __Internal.FPDF_ImportPages(__arg0, __arg1, pagerange, index);
            return __ret;
        }

        public static FpdfDocumentT FPDF_ImportNPagesToOne(
            FpdfDocumentT src_doc, float output_width, float output_height,
            uint num_pages_on_x_axis, uint num_pages_on_y_axis)
        {
            var __arg0 = ReferenceEquals(src_doc, null) ? IntPtr.Zero : src_doc.__Instance;
            var __ret = __Internal.FPDF_ImportNPagesToOne(__arg0, output_width, output_height, num_pages_on_x_axis,
                num_pages_on_y_axis);
            FpdfDocumentT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfDocumentT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfDocumentT)FpdfDocumentT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfDocumentT.__CreateInstance(__ret);
            return __result0;
        }

        public static int FPDF_CopyViewerPreferences(FpdfDocumentT dest_doc,
            FpdfDocumentT src_doc)
        {
            var __arg0 = ReferenceEquals(dest_doc, null) ? IntPtr.Zero : dest_doc.__Instance;
            var __arg1 = ReferenceEquals(src_doc, null) ? IntPtr.Zero : src_doc.__Instance;
            var __ret = __Internal.FPDF_CopyViewerPreferences(__arg0, __arg1);
            return __ret;
        }
    }

    internal unsafe partial class FPDF_IMAGEOBJ_METADATA : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 28)]
        public partial struct __Internal
        {
            [FieldOffset(0)] internal uint width;

            [FieldOffset(4)] internal uint height;

            [FieldOffset(8)] internal float horizontal_dpi;

            [FieldOffset(12)] internal float vertical_dpi;

            [FieldOffset(16)] internal uint bits_per_pixel;

            [FieldOffset(20)] internal int colorspace;

            [FieldOffset(24)] internal int marked_content_id;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "??0FPDF_IMAGEOBJ_METADATA@@QEAA@AEBU0@@Z")]
            internal static extern IntPtr
                cctor(IntPtr instance, IntPtr _0);
        }

        public IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;

        internal static readonly
            ConcurrentDictionary<IntPtr,
                FPDF_IMAGEOBJ_METADATA> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr,
                    FPDF_IMAGEOBJ_METADATA>();

        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static FPDF_IMAGEOBJ_METADATA __CreateInstance(
            IntPtr native, bool skipVTables = false)
        {
            return new FPDF_IMAGEOBJ_METADATA(native.ToPointer(), skipVTables);
        }

        internal static FPDF_IMAGEOBJ_METADATA __CreateInstance(
            __Internal native, bool skipVTables = false)
        {
            return new FPDF_IMAGEOBJ_METADATA(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FPDF_IMAGEOBJ_METADATA(__Internal native,
            bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FPDF_IMAGEOBJ_METADATA(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public FPDF_IMAGEOBJ_METADATA()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public FPDF_IMAGEOBJ_METADATA(FPDF_IMAGEOBJ_METADATA _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((__Internal*)__Instance) =
                *((__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            FPDF_IMAGEOBJ_METADATA __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint Width
        {
            get { return ((__Internal*)__Instance)->width; }

            set { ((__Internal*)__Instance)->width = value; }
        }

        public uint Height
        {
            get { return ((__Internal*)__Instance)->height; }

            set { ((__Internal*)__Instance)->height = value; }
        }

        public float HorizontalDpi
        {
            get { return ((__Internal*)__Instance)->horizontal_dpi; }

            set { ((__Internal*)__Instance)->horizontal_dpi = value; }
        }

        public float VerticalDpi
        {
            get { return ((__Internal*)__Instance)->vertical_dpi; }

            set { ((__Internal*)__Instance)->vertical_dpi = value; }
        }

        public uint BitsPerPixel
        {
            get { return ((__Internal*)__Instance)->bits_per_pixel; }

            set { ((__Internal*)__Instance)->bits_per_pixel = value; }
        }

        public int Colorspace
        {
            get { return ((__Internal*)__Instance)->colorspace; }

            set { ((__Internal*)__Instance)->colorspace = value; }
        }

        public int MarkedContentId
        {
            get
            {
                return
                    ((__Internal*)__Instance)->marked_content_id;
            }

            set
            {
                ((__Internal*)__Instance)->marked_content_id =
                    value;
            }
        }
    }

    internal unsafe partial class fpdf_edit
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDF_CreateNewDocument")]
            internal static extern IntPtr FPDF_CreateNewDocument();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPage_New")]
            internal static extern IntPtr FPDFPageNew(IntPtr document, int page_index,
                double width, double height);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPage_Delete")]
            internal static extern void FPDFPageDelete(IntPtr document, int page_index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPage_GetRotation")]
            internal static extern int FPDFPageGetRotation(IntPtr page);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPage_SetRotation")]
            internal static extern void FPDFPageSetRotation(IntPtr page, int rotate);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPage_InsertObject")]
            internal static extern void
                FPDFPageInsertObject(IntPtr page, IntPtr page_obj);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPage_RemoveObject")]
            internal static extern int FPDFPageRemoveObject(IntPtr page, IntPtr page_obj);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPage_CountObjects")]
            internal static extern int FPDFPageCountObjects(IntPtr page);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPage_GetObject")]
            internal static extern IntPtr FPDFPageGetObject(IntPtr page, int index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPage_HasTransparency")]
            internal static extern int FPDFPageHasTransparency(IntPtr page);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPage_GenerateContent")]
            internal static extern int FPDFPageGenerateContent(IntPtr page);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_Destroy")]
            internal static extern void FPDFPageObjDestroy(IntPtr page_obj);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_HasTransparency")]
            internal static extern int FPDFPageObjHasTransparency(IntPtr page_object);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_GetType")]
            internal static extern int FPDFPageObjGetType(IntPtr page_object);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_Transform")]
            internal static extern void FPDFPageObjTransform(IntPtr page_object, double a, double b,
                double c, double d, double e, double f);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPage_TransformAnnots")]
            internal static extern void FPDFPageTransformAnnots(IntPtr page, double a, double b,
                double c, double d, double e, double f);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_NewImageObj")]
            internal static extern IntPtr FPDFPageObjNewImageObj(IntPtr document);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_CountMarks")]
            internal static extern int FPDFPageObjCountMarks(IntPtr page_object);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_GetMark")]
            internal static extern IntPtr FPDFPageObjGetMark(IntPtr page_object,
                uint index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_AddMark")]
            internal static extern IntPtr FPDFPageObjAddMark(IntPtr page_object,
                [MarshalAs(UnmanagedType.LPStr)] string name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_RemoveMark")]
            internal static extern int FPDFPageObjRemoveMark(IntPtr page_object,
                IntPtr mark);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObjMark_GetName")]
            internal static extern int FPDFPageObjMarkGetName(IntPtr mark, IntPtr buffer,
                uint buflen, uint* out_buflen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObjMark_CountParams")]
            internal static extern int FPDFPageObjMarkCountParams(IntPtr mark);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObjMark_GetParamKey")]
            internal static extern int FPDFPageObjMarkGetParamKey(IntPtr mark, uint index,
                IntPtr buffer, uint buflen, uint* out_buflen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObjMark_GetParamValueType")]
            internal static extern int FPDFPageObjMarkGetParamValueType(IntPtr mark,
                [MarshalAs(UnmanagedType.LPStr)] string key);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObjMark_GetParamIntValue")]
            internal static extern int FPDFPageObjMarkGetParamIntValue(IntPtr mark,
                [MarshalAs(UnmanagedType.LPStr)] string key, int* out_value);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObjMark_GetParamStringValue")]
            internal static extern int FPDFPageObjMarkGetParamStringValue(IntPtr mark,
                [MarshalAs(UnmanagedType.LPStr)] string key, IntPtr buffer, uint buflen,
                uint* out_buflen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObjMark_GetParamBlobValue")]
            internal static extern int FPDFPageObjMarkGetParamBlobValue(IntPtr mark,
                [MarshalAs(UnmanagedType.LPStr)] string key, IntPtr buffer, uint buflen,
                uint* out_buflen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObjMark_SetIntParam")]
            internal static extern int FPDFPageObjMarkSetIntParam(IntPtr document,
                IntPtr page_object, IntPtr mark,
                [MarshalAs(UnmanagedType.LPStr)] string key, int value);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObjMark_SetStringParam")]
            internal static extern int FPDFPageObjMarkSetStringParam(IntPtr document,
                IntPtr page_object, IntPtr mark,
                [MarshalAs(UnmanagedType.LPStr)] string key, [MarshalAs(UnmanagedType.LPStr)] string value);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObjMark_SetBlobParam")]
            internal static extern int FPDFPageObjMarkSetBlobParam(IntPtr document,
                IntPtr page_object, IntPtr mark,
                [MarshalAs(UnmanagedType.LPStr)] string key, IntPtr value, uint value_len);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObjMark_RemoveParam")]
            internal static extern int FPDFPageObjMarkRemoveParam(IntPtr page_object,
                IntPtr mark, [MarshalAs(UnmanagedType.LPStr)] string key);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFImageObj_LoadJpegFile")]
            internal static extern int FPDFImageObjLoadJpegFile(IntPtr pages, int nCount,
                IntPtr image_object, IntPtr fileAccess);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFImageObj_LoadJpegFileInline")]
            internal static extern int FPDFImageObjLoadJpegFileInline(IntPtr pages, int nCount,
                IntPtr image_object, IntPtr fileAccess);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFImageObj_SetMatrix")]
            internal static extern int FPDFImageObjSetMatrix(IntPtr image_object, double a, double b,
                double c, double d, double e, double f);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFImageObj_SetBitmap")]
            internal static extern int FPDFImageObjSetBitmap(IntPtr pages, int nCount,
                IntPtr image_object, IntPtr bitmap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFImageObj_GetBitmap")]
            internal static extern IntPtr FPDFImageObjGetBitmap(IntPtr image_object);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFImageObj_GetImageDataDecoded")]
            internal static extern uint FPDFImageObjGetImageDataDecoded(IntPtr image_object,
                IntPtr buffer, uint buflen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFImageObj_GetImageDataRaw")]
            internal static extern uint FPDFImageObjGetImageDataRaw(IntPtr image_object,
                IntPtr buffer, uint buflen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFImageObj_GetImageFilterCount")]
            internal static extern int FPDFImageObjGetImageFilterCount(IntPtr image_object);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFImageObj_GetImageFilter")]
            internal static extern uint FPDFImageObjGetImageFilter(IntPtr image_object, int index,
                IntPtr buffer, uint buflen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFImageObj_GetImageMetadata")]
            internal static extern int FPDFImageObjGetImageMetadata(IntPtr image_object,
                IntPtr page, IntPtr metadata);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_CreateNewPath")]
            internal static extern IntPtr FPDFPageObjCreateNewPath(float x, float y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_CreateNewRect")]
            internal static extern IntPtr FPDFPageObjCreateNewRect(float x, float y, float w, float h);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_GetBounds")]
            internal static extern int FPDFPageObjGetBounds(IntPtr page_object, float* left,
                float* bottom, float* right, float* top);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_SetBlendMode")]
            internal static extern void FPDFPageObjSetBlendMode(IntPtr page_object,
                [MarshalAs(UnmanagedType.LPStr)] string blend_mode);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPath_SetStrokeColor")]
            internal static extern int FPDFPathSetStrokeColor(IntPtr path, uint R, uint G, uint B,
                uint A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_SetStrokeColor")]
            internal static extern int FPDFPageObjSetStrokeColor(IntPtr page_object, uint R, uint G,
                uint B, uint A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPath_GetStrokeColor")]
            internal static extern int FPDFPathGetStrokeColor(IntPtr path, uint* R, uint* G, uint* B,
                uint* A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_GetStrokeColor")]
            internal static extern int FPDFPageObjGetStrokeColor(IntPtr page_object, uint* R, uint* G,
                uint* B, uint* A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPath_SetStrokeWidth")]
            internal static extern int FPDFPathSetStrokeWidth(IntPtr path, float width);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_SetStrokeWidth")]
            internal static extern int FPDFPageObjSetStrokeWidth(IntPtr page_object, float width);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_GetStrokeWidth")]
            internal static extern int FPDFPageObjGetStrokeWidth(IntPtr page_object, float* width);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPath_SetLineJoin")]
            internal static extern void FPDFPathSetLineJoin(IntPtr page_object, int line_join);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_SetLineJoin")]
            internal static extern int FPDFPageObjSetLineJoin(IntPtr page_object, int line_join);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPath_SetLineCap")]
            internal static extern void FPDFPathSetLineCap(IntPtr page_object, int line_cap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_SetLineCap")]
            internal static extern int FPDFPageObjSetLineCap(IntPtr page_object, int line_cap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPath_SetFillColor")]
            internal static extern int FPDFPathSetFillColor(IntPtr path, uint R, uint G, uint B, uint A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_SetFillColor")]
            internal static extern int FPDFPageObjSetFillColor(IntPtr page_object, uint R, uint G,
                uint B, uint A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPath_GetFillColor")]
            internal static extern int FPDFPathGetFillColor(IntPtr path, uint* R, uint* G, uint* B,
                uint* A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_GetFillColor")]
            internal static extern int FPDFPageObjGetFillColor(IntPtr page_object, uint* R, uint* G,
                uint* B, uint* A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPath_CountSegments")]
            internal static extern int FPDFPathCountSegments(IntPtr path);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPath_GetPathSegment")]
            internal static extern IntPtr FPDFPathGetPathSegment(IntPtr path, int index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPathSegment_GetPoint")]
            internal static extern int FPDFPathSegmentGetPoint(IntPtr segment, float* x, float* y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPathSegment_GetType")]
            internal static extern int FPDFPathSegmentGetType(IntPtr segment);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPathSegment_GetClose")]
            internal static extern int FPDFPathSegmentGetClose(IntPtr segment);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPath_MoveTo")]
            internal static extern int FPDFPathMoveTo(IntPtr path, float x, float y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPath_LineTo")]
            internal static extern int FPDFPathLineTo(IntPtr path, float x, float y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPath_BezierTo")]
            internal static extern int FPDFPathBezierTo(IntPtr path, float x1, float y1, float x2,
                float y2, float x3, float y3);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPath_Close")]
            internal static extern int FPDFPathClose(IntPtr path);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPath_SetDrawMode")]
            internal static extern int FPDFPathSetDrawMode(IntPtr path, int fillmode, int stroke);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPath_GetDrawMode")]
            internal static extern int FPDFPathGetDrawMode(IntPtr path, int* fillmode, int* stroke);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPath_GetMatrix")]
            internal static extern int FPDFPathGetMatrix(IntPtr path, double* a, double* b, double* c,
                double* d, double* e, double* f);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPath_SetMatrix")]
            internal static extern int FPDFPathSetMatrix(IntPtr path, double a, double b, double c,
                double d, double e, double f);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_NewTextObj")]
            internal static extern IntPtr FPDFPageObjNewTextObj(IntPtr document,
                [MarshalAs(UnmanagedType.LPStr)] string font, float font_size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_SetText")]
            internal static extern int FPDFTextSetText(IntPtr text_object, ushort* text);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_LoadFont")]
            internal static extern IntPtr FPDFTextLoadFont(IntPtr document, byte* data,
                uint size, int font_type, int cid);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_LoadStandardFont")]
            internal static extern IntPtr FPDFTextLoadStandardFont(IntPtr document,
                [MarshalAs(UnmanagedType.LPStr)] string font);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_SetFillColor")]
            internal static extern int FPDFTextSetFillColor(IntPtr text_object, uint R, uint G, uint B,
                uint A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_GetMatrix")]
            internal static extern int FPDFTextGetMatrix(IntPtr text, double* a, double* b, double* c,
                double* d, double* e, double* f);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFTextObj_GetFontSize")]
            internal static extern double FPDFTextObjGetFontSize(IntPtr text);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFFont_Close")]
            internal static extern void FPDFFontClose(IntPtr font);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFPageObj_CreateTextObj")]
            internal static extern IntPtr FPDFPageObjCreateTextObj(IntPtr document,
                IntPtr font, float font_size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFText_GetTextRenderMode")]
            internal static extern int FPDFTextGetTextRenderMode(IntPtr text);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFTextObj_GetFontName")]
            internal static extern uint FPDFTextObjGetFontName(IntPtr text, IntPtr buffer,
                uint length);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFTextObj_GetText")]
            internal static extern uint FPDFTextObjGetText(IntPtr text_object,
                IntPtr text_page, IntPtr buffer, uint length);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFFormObj_CountObjects")]
            internal static extern int FPDFFormObjCountObjects(IntPtr form_object);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFFormObj_GetObject")]
            internal static extern IntPtr FPDFFormObjGetObject(IntPtr form_object,
                uint index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("pdfium", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "FPDFFormObj_GetMatrix")]
            internal static extern int FPDFFormObjGetMatrix(IntPtr form_object, double* a, double* b,
                double* c, double* d, double* e, double* f);
        }

        public static FpdfDocumentT FPDF_CreateNewDocument()
        {
            var __ret = __Internal.FPDF_CreateNewDocument();
            FpdfDocumentT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfDocumentT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfDocumentT)FpdfDocumentT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfDocumentT.__CreateInstance(__ret);
            return __result0;
        }

        public static FpdfPageT FPDFPageNew(
            FpdfDocumentT document, int page_index, double width, double height)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __ret = __Internal.FPDFPageNew(__arg0, page_index, width, height);
            FpdfPageT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfPageT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfPageT)FpdfPageT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfPageT.__CreateInstance(__ret);
            return __result0;
        }

        public static void FPDFPageDelete(FpdfDocumentT document, int page_index)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            __Internal.FPDFPageDelete(__arg0, page_index);
        }

        public static int FPDFPageGetRotation(FpdfPageT page)
        {
            var __arg0 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            var __ret = __Internal.FPDFPageGetRotation(__arg0);
            return __ret;
        }

        public static void FPDFPageSetRotation(FpdfPageT page, int rotate)
        {
            var __arg0 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            __Internal.FPDFPageSetRotation(__arg0, rotate);
        }

        public static void FPDFPageInsertObject(FpdfPageT page,
            FpdfPageobjectT page_obj)
        {
            var __arg0 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            var __arg1 = ReferenceEquals(page_obj, null) ? IntPtr.Zero : page_obj.__Instance;
            __Internal.FPDFPageInsertObject(__arg0, __arg1);
        }

        public static int FPDFPageRemoveObject(FpdfPageT page,
            FpdfPageobjectT page_obj)
        {
            var __arg0 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            var __arg1 = ReferenceEquals(page_obj, null) ? IntPtr.Zero : page_obj.__Instance;
            var __ret = __Internal.FPDFPageRemoveObject(__arg0, __arg1);
            return __ret;
        }

        public static int FPDFPageCountObjects(FpdfPageT page)
        {
            var __arg0 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            var __ret = __Internal.FPDFPageCountObjects(__arg0);
            return __ret;
        }

        public static FpdfPageobjectT FPDFPageGetObject(
            FpdfPageT page, int index)
        {
            var __arg0 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            var __ret = __Internal.FPDFPageGetObject(__arg0, index);
            FpdfPageobjectT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfPageobjectT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfPageobjectT)FpdfPageobjectT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfPageobjectT.__CreateInstance(__ret);
            return __result0;
        }

        public static int FPDFPageHasTransparency(FpdfPageT page)
        {
            var __arg0 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            var __ret = __Internal.FPDFPageHasTransparency(__arg0);
            return __ret;
        }

        public static int FPDFPageGenerateContent(FpdfPageT page)
        {
            var __arg0 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            var __ret = __Internal.FPDFPageGenerateContent(__arg0);
            return __ret;
        }

        public static void FPDFPageObjDestroy(FpdfPageobjectT page_obj)
        {
            var __arg0 = ReferenceEquals(page_obj, null) ? IntPtr.Zero : page_obj.__Instance;
            __Internal.FPDFPageObjDestroy(__arg0);
        }

        public static int FPDFPageObjHasTransparency(FpdfPageobjectT page_object)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            var __ret = __Internal.FPDFPageObjHasTransparency(__arg0);
            return __ret;
        }

        public static int FPDFPageObjGetType(FpdfPageobjectT page_object)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            var __ret = __Internal.FPDFPageObjGetType(__arg0);
            return __ret;
        }

        public static void FPDFPageObjTransform(FpdfPageobjectT page_object, double a,
            double b, double c, double d, double e, double f)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            __Internal.FPDFPageObjTransform(__arg0, a, b, c, d, e, f);
        }

        public static void FPDFPageTransformAnnots(FpdfPageT page, double a, double b,
            double c, double d, double e, double f)
        {
            var __arg0 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            __Internal.FPDFPageTransformAnnots(__arg0, a, b, c, d, e, f);
        }

        public static FpdfPageobjectT FPDFPageObjNewImageObj(
            FpdfDocumentT document)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __ret = __Internal.FPDFPageObjNewImageObj(__arg0);
            FpdfPageobjectT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfPageobjectT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfPageobjectT)FpdfPageobjectT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfPageobjectT.__CreateInstance(__ret);
            return __result0;
        }

        public static int FPDFPageObjCountMarks(FpdfPageobjectT page_object)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            var __ret = __Internal.FPDFPageObjCountMarks(__arg0);
            return __ret;
        }

        public static FpdfPageobjectmarkT FPDFPageObjGetMark(
            FpdfPageobjectT page_object, uint index)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            var __ret = __Internal.FPDFPageObjGetMark(__arg0, index);
            FpdfPageobjectmarkT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfPageobjectmarkT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfPageobjectmarkT)FpdfPageobjectmarkT.NativeToManagedMap[__ret];
            else __result0 = FpdfPageobjectmarkT.__CreateInstance(__ret);
            return __result0;
        }

        public static FpdfPageobjectmarkT FPDFPageObjAddMark(
            FpdfPageobjectT page_object, string name)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            var __ret = __Internal.FPDFPageObjAddMark(__arg0, name);
            FpdfPageobjectmarkT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfPageobjectmarkT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfPageobjectmarkT)FpdfPageobjectmarkT.NativeToManagedMap[__ret];
            else __result0 = FpdfPageobjectmarkT.__CreateInstance(__ret);
            return __result0;
        }

        public static int FPDFPageObjRemoveMark(FpdfPageobjectT page_object,
            FpdfPageobjectmarkT mark)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            var __arg1 = ReferenceEquals(mark, null) ? IntPtr.Zero : mark.__Instance;
            var __ret = __Internal.FPDFPageObjRemoveMark(__arg0, __arg1);
            return __ret;
        }

        public static int FPDFPageObjMarkGetName(FpdfPageobjectmarkT mark,
            IntPtr buffer, uint buflen, ref uint out_buflen)
        {
            var __arg0 = ReferenceEquals(mark, null) ? IntPtr.Zero : mark.__Instance;
            fixed (uint* __refParamPtr3 = &out_buflen)
            {
                var __arg3 = __refParamPtr3;
                var __ret = __Internal.FPDFPageObjMarkGetName(__arg0, buffer, buflen, __arg3);
                return __ret;
            }
        }

        public static int FPDFPageObjMarkCountParams(FpdfPageobjectmarkT mark)
        {
            var __arg0 = ReferenceEquals(mark, null) ? IntPtr.Zero : mark.__Instance;
            var __ret = __Internal.FPDFPageObjMarkCountParams(__arg0);
            return __ret;
        }

        public static int FPDFPageObjMarkGetParamKey(FpdfPageobjectmarkT mark, uint index,
            IntPtr buffer, uint buflen, ref uint out_buflen)
        {
            var __arg0 = ReferenceEquals(mark, null) ? IntPtr.Zero : mark.__Instance;
            fixed (uint* __refParamPtr4 = &out_buflen)
            {
                var __arg4 = __refParamPtr4;
                var __ret = __Internal.FPDFPageObjMarkGetParamKey(__arg0, index, buffer, buflen, __arg4);
                return __ret;
            }
        }

        public static int FPDFPageObjMarkGetParamValueType(FpdfPageobjectmarkT mark,
            string key)
        {
            var __arg0 = ReferenceEquals(mark, null) ? IntPtr.Zero : mark.__Instance;
            var __ret = __Internal.FPDFPageObjMarkGetParamValueType(__arg0, key);
            return __ret;
        }

        public static int FPDFPageObjMarkGetParamIntValue(FpdfPageobjectmarkT mark,
            string key, ref int out_value)
        {
            var __arg0 = ReferenceEquals(mark, null) ? IntPtr.Zero : mark.__Instance;
            fixed (int* __refParamPtr2 = &out_value)
            {
                var __arg2 = __refParamPtr2;
                var __ret = __Internal.FPDFPageObjMarkGetParamIntValue(__arg0, key, __arg2);
                return __ret;
            }
        }

        public static int FPDFPageObjMarkGetParamStringValue(FpdfPageobjectmarkT mark,
            string key, IntPtr buffer, uint buflen, ref uint out_buflen)
        {
            var __arg0 = ReferenceEquals(mark, null) ? IntPtr.Zero : mark.__Instance;
            fixed (uint* __refParamPtr4 = &out_buflen)
            {
                var __arg4 = __refParamPtr4;
                var __ret = __Internal.FPDFPageObjMarkGetParamStringValue(__arg0, key, buffer, buflen, __arg4);
                return __ret;
            }
        }

        public static int FPDFPageObjMarkGetParamBlobValue(FpdfPageobjectmarkT mark,
            string key, IntPtr buffer, uint buflen, ref uint out_buflen)
        {
            var __arg0 = ReferenceEquals(mark, null) ? IntPtr.Zero : mark.__Instance;
            fixed (uint* __refParamPtr4 = &out_buflen)
            {
                var __arg4 = __refParamPtr4;
                var __ret = __Internal.FPDFPageObjMarkGetParamBlobValue(__arg0, key, buffer, buflen, __arg4);
                return __ret;
            }
        }

        public static int FPDFPageObjMarkSetIntParam(FpdfDocumentT document,
            FpdfPageobjectT page_object,
            FpdfPageobjectmarkT mark, string key, int value)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __arg1 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            var __arg2 = ReferenceEquals(mark, null) ? IntPtr.Zero : mark.__Instance;
            var __ret = __Internal.FPDFPageObjMarkSetIntParam(__arg0, __arg1, __arg2, key, value);
            return __ret;
        }

        public static int FPDFPageObjMarkSetStringParam(FpdfDocumentT document,
            FpdfPageobjectT page_object,
            FpdfPageobjectmarkT mark, string key, string value)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __arg1 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            var __arg2 = ReferenceEquals(mark, null) ? IntPtr.Zero : mark.__Instance;
            var __ret = __Internal.FPDFPageObjMarkSetStringParam(__arg0, __arg1, __arg2, key, value);
            return __ret;
        }

        public static int FPDFPageObjMarkSetBlobParam(FpdfDocumentT document,
            FpdfPageobjectT page_object,
            FpdfPageobjectmarkT mark, string key, IntPtr value,
            uint value_len)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __arg1 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            var __arg2 = ReferenceEquals(mark, null) ? IntPtr.Zero : mark.__Instance;
            var __ret = __Internal.FPDFPageObjMarkSetBlobParam(__arg0, __arg1, __arg2, key, value, value_len);
            return __ret;
        }

        public static int FPDFPageObjMarkRemoveParam(FpdfPageobjectT page_object,
            FpdfPageobjectmarkT mark, string key)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            var __arg1 = ReferenceEquals(mark, null) ? IntPtr.Zero : mark.__Instance;
            var __ret = __Internal.FPDFPageObjMarkRemoveParam(__arg0, __arg1, key);
            return __ret;
        }

        public static int FPDFImageObjLoadJpegFile(FpdfPageT pages, int nCount,
            FpdfPageobjectT image_object,
            FPDF_FILEACCESS fileAccess)
        {
            var __arg0 = ReferenceEquals(pages, null) ? IntPtr.Zero : pages.__Instance;
            var __arg2 = ReferenceEquals(image_object, null) ? IntPtr.Zero : image_object.__Instance;
            var __arg3 = ReferenceEquals(fileAccess, null) ? IntPtr.Zero : fileAccess.__Instance;
            var __ret = __Internal.FPDFImageObjLoadJpegFile(__arg0, nCount, __arg2, __arg3);
            return __ret;
        }

        public static int FPDFImageObjLoadJpegFileInline(FpdfPageT pages, int nCount,
            FpdfPageobjectT image_object,
            FPDF_FILEACCESS fileAccess)
        {
            var __arg0 = ReferenceEquals(pages, null) ? IntPtr.Zero : pages.__Instance;
            var __arg2 = ReferenceEquals(image_object, null) ? IntPtr.Zero : image_object.__Instance;
            var __arg3 = ReferenceEquals(fileAccess, null) ? IntPtr.Zero : fileAccess.__Instance;
            var __ret = __Internal.FPDFImageObjLoadJpegFileInline(__arg0, nCount, __arg2, __arg3);
            return __ret;
        }

        public static int FPDFImageObjSetMatrix(FpdfPageobjectT image_object, double a,
            double b, double c, double d, double e, double f)
        {
            var __arg0 = ReferenceEquals(image_object, null) ? IntPtr.Zero : image_object.__Instance;
            var __ret = __Internal.FPDFImageObjSetMatrix(__arg0, a, b, c, d, e, f);
            return __ret;
        }

        public static int FPDFImageObjSetBitmap(FpdfPageT pages, int nCount,
            FpdfPageobjectT image_object, FpdfBitmapT bitmap)
        {
            var __arg0 = ReferenceEquals(pages, null) ? IntPtr.Zero : pages.__Instance;
            var __arg2 = ReferenceEquals(image_object, null) ? IntPtr.Zero : image_object.__Instance;
            var __arg3 = ReferenceEquals(bitmap, null) ? IntPtr.Zero : bitmap.__Instance;
            var __ret = __Internal.FPDFImageObjSetBitmap(__arg0, nCount, __arg2, __arg3);
            return __ret;
        }

        public static FpdfBitmapT FPDFImageObjGetBitmap(
            FpdfPageobjectT image_object)
        {
            var __arg0 = ReferenceEquals(image_object, null) ? IntPtr.Zero : image_object.__Instance;
            var __ret = __Internal.FPDFImageObjGetBitmap(__arg0);
            FpdfBitmapT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfBitmapT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfBitmapT)FpdfBitmapT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfBitmapT.__CreateInstance(__ret);
            return __result0;
        }

        public static uint FPDFImageObjGetImageDataDecoded(FpdfPageobjectT image_object,
            IntPtr buffer, uint buflen)
        {
            var __arg0 = ReferenceEquals(image_object, null) ? IntPtr.Zero : image_object.__Instance;
            var __ret = __Internal.FPDFImageObjGetImageDataDecoded(__arg0, buffer, buflen);
            return __ret;
        }

        public static uint FPDFImageObjGetImageDataRaw(FpdfPageobjectT image_object,
            IntPtr buffer, uint buflen)
        {
            var __arg0 = ReferenceEquals(image_object, null) ? IntPtr.Zero : image_object.__Instance;
            var __ret = __Internal.FPDFImageObjGetImageDataRaw(__arg0, buffer, buflen);
            return __ret;
        }

        public static int FPDFImageObjGetImageFilterCount(FpdfPageobjectT image_object)
        {
            var __arg0 = ReferenceEquals(image_object, null) ? IntPtr.Zero : image_object.__Instance;
            var __ret = __Internal.FPDFImageObjGetImageFilterCount(__arg0);
            return __ret;
        }

        public static uint FPDFImageObjGetImageFilter(FpdfPageobjectT image_object,
            int index, IntPtr buffer, uint buflen)
        {
            var __arg0 = ReferenceEquals(image_object, null) ? IntPtr.Zero : image_object.__Instance;
            var __ret = __Internal.FPDFImageObjGetImageFilter(__arg0, index, buffer, buflen);
            return __ret;
        }

        public static int FPDFImageObjGetImageMetadata(FpdfPageobjectT image_object,
            FpdfPageT page, FPDF_IMAGEOBJ_METADATA metadata)
        {
            var __arg0 = ReferenceEquals(image_object, null) ? IntPtr.Zero : image_object.__Instance;
            var __arg1 = ReferenceEquals(page, null) ? IntPtr.Zero : page.__Instance;
            var __arg2 = ReferenceEquals(metadata, null) ? IntPtr.Zero : metadata.__Instance;
            var __ret = __Internal.FPDFImageObjGetImageMetadata(__arg0, __arg1, __arg2);
            return __ret;
        }

        public static FpdfPageobjectT FPDFPageObjCreateNewPath(float x, float y)
        {
            var __ret = __Internal.FPDFPageObjCreateNewPath(x, y);
            FpdfPageobjectT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfPageobjectT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfPageobjectT)FpdfPageobjectT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfPageobjectT.__CreateInstance(__ret);
            return __result0;
        }

        public static FpdfPageobjectT FPDFPageObjCreateNewRect(float x, float y, float w,
            float h)
        {
            var __ret = __Internal.FPDFPageObjCreateNewRect(x, y, w, h);
            FpdfPageobjectT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfPageobjectT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfPageobjectT)FpdfPageobjectT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfPageobjectT.__CreateInstance(__ret);
            return __result0;
        }

        public static int FPDFPageObjGetBounds(FpdfPageobjectT page_object, ref float left,
            ref float bottom, ref float right, ref float top)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            fixed (float* __refParamPtr1 = &left)
            {
                var __arg1 = __refParamPtr1;
                fixed (float* __refParamPtr2 = &bottom)
                {
                    var __arg2 = __refParamPtr2;
                    fixed (float* __refParamPtr3 = &right)
                    {
                        var __arg3 = __refParamPtr3;
                        fixed (float* __refParamPtr4 = &top)
                        {
                            var __arg4 = __refParamPtr4;
                            var __ret = __Internal.FPDFPageObjGetBounds(__arg0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static void FPDFPageObjSetBlendMode(FpdfPageobjectT page_object,
            string blend_mode)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            __Internal.FPDFPageObjSetBlendMode(__arg0, blend_mode);
        }

        public static int FPDFPathSetStrokeColor(FpdfPageobjectT path, uint R, uint G,
            uint B, uint A)
        {
            var __arg0 = ReferenceEquals(path, null) ? IntPtr.Zero : path.__Instance;
            var __ret = __Internal.FPDFPathSetStrokeColor(__arg0, R, G, B, A);
            return __ret;
        }

        public static int FPDFPageObjSetStrokeColor(FpdfPageobjectT page_object, uint R,
            uint G, uint B, uint A)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            var __ret = __Internal.FPDFPageObjSetStrokeColor(__arg0, R, G, B, A);
            return __ret;
        }

        public static int FPDFPathGetStrokeColor(FpdfPageobjectT path, ref uint R,
            ref uint G, ref uint B, ref uint A)
        {
            var __arg0 = ReferenceEquals(path, null) ? IntPtr.Zero : path.__Instance;
            fixed (uint* __refParamPtr1 = &R)
            {
                var __arg1 = __refParamPtr1;
                fixed (uint* __refParamPtr2 = &G)
                {
                    var __arg2 = __refParamPtr2;
                    fixed (uint* __refParamPtr3 = &B)
                    {
                        var __arg3 = __refParamPtr3;
                        fixed (uint* __refParamPtr4 = &A)
                        {
                            var __arg4 = __refParamPtr4;
                            var __ret = __Internal.FPDFPathGetStrokeColor(__arg0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int FPDFPageObjGetStrokeColor(FpdfPageobjectT page_object,
            ref uint R, ref uint G, ref uint B, ref uint A)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            fixed (uint* __refParamPtr1 = &R)
            {
                var __arg1 = __refParamPtr1;
                fixed (uint* __refParamPtr2 = &G)
                {
                    var __arg2 = __refParamPtr2;
                    fixed (uint* __refParamPtr3 = &B)
                    {
                        var __arg3 = __refParamPtr3;
                        fixed (uint* __refParamPtr4 = &A)
                        {
                            var __arg4 = __refParamPtr4;
                            var __ret = __Internal.FPDFPageObjGetStrokeColor(__arg0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int FPDFPathSetStrokeWidth(FpdfPageobjectT path, float width)
        {
            var __arg0 = ReferenceEquals(path, null) ? IntPtr.Zero : path.__Instance;
            var __ret = __Internal.FPDFPathSetStrokeWidth(__arg0, width);
            return __ret;
        }

        public static int FPDFPageObjSetStrokeWidth(FpdfPageobjectT page_object,
            float width)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            var __ret = __Internal.FPDFPageObjSetStrokeWidth(__arg0, width);
            return __ret;
        }

        public static int FPDFPageObjGetStrokeWidth(FpdfPageobjectT page_object,
            ref float width)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            fixed (float* __refParamPtr1 = &width)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.FPDFPageObjGetStrokeWidth(__arg0, __arg1);
                return __ret;
            }
        }

        public static void FPDFPathSetLineJoin(FpdfPageobjectT page_object, int line_join)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            __Internal.FPDFPathSetLineJoin(__arg0, line_join);
        }

        public static int FPDFPageObjSetLineJoin(FpdfPageobjectT page_object,
            int line_join)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            var __ret = __Internal.FPDFPageObjSetLineJoin(__arg0, line_join);
            return __ret;
        }

        public static void FPDFPathSetLineCap(FpdfPageobjectT page_object, int line_cap)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            __Internal.FPDFPathSetLineCap(__arg0, line_cap);
        }

        public static int FPDFPageObjSetLineCap(FpdfPageobjectT page_object, int line_cap)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            var __ret = __Internal.FPDFPageObjSetLineCap(__arg0, line_cap);
            return __ret;
        }

        public static int FPDFPathSetFillColor(FpdfPageobjectT path, uint R, uint G,
            uint B, uint A)
        {
            var __arg0 = ReferenceEquals(path, null) ? IntPtr.Zero : path.__Instance;
            var __ret = __Internal.FPDFPathSetFillColor(__arg0, R, G, B, A);
            return __ret;
        }

        public static int FPDFPageObjSetFillColor(FpdfPageobjectT page_object, uint R,
            uint G, uint B, uint A)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            var __ret = __Internal.FPDFPageObjSetFillColor(__arg0, R, G, B, A);
            return __ret;
        }

        public static int FPDFPathGetFillColor(FpdfPageobjectT path, ref uint R,
            ref uint G, ref uint B, ref uint A)
        {
            var __arg0 = ReferenceEquals(path, null) ? IntPtr.Zero : path.__Instance;
            fixed (uint* __refParamPtr1 = &R)
            {
                var __arg1 = __refParamPtr1;
                fixed (uint* __refParamPtr2 = &G)
                {
                    var __arg2 = __refParamPtr2;
                    fixed (uint* __refParamPtr3 = &B)
                    {
                        var __arg3 = __refParamPtr3;
                        fixed (uint* __refParamPtr4 = &A)
                        {
                            var __arg4 = __refParamPtr4;
                            var __ret = __Internal.FPDFPathGetFillColor(__arg0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int FPDFPageObjGetFillColor(FpdfPageobjectT page_object, ref uint R,
            ref uint G, ref uint B, ref uint A)
        {
            var __arg0 = ReferenceEquals(page_object, null) ? IntPtr.Zero : page_object.__Instance;
            fixed (uint* __refParamPtr1 = &R)
            {
                var __arg1 = __refParamPtr1;
                fixed (uint* __refParamPtr2 = &G)
                {
                    var __arg2 = __refParamPtr2;
                    fixed (uint* __refParamPtr3 = &B)
                    {
                        var __arg3 = __refParamPtr3;
                        fixed (uint* __refParamPtr4 = &A)
                        {
                            var __arg4 = __refParamPtr4;
                            var __ret = __Internal.FPDFPageObjGetFillColor(__arg0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int FPDFPathCountSegments(FpdfPageobjectT path)
        {
            var __arg0 = ReferenceEquals(path, null) ? IntPtr.Zero : path.__Instance;
            var __ret = __Internal.FPDFPathCountSegments(__arg0);
            return __ret;
        }

        public static FpdfPathsegmentT FPDFPathGetPathSegment(
            FpdfPageobjectT path, int index)
        {
            var __arg0 = ReferenceEquals(path, null) ? IntPtr.Zero : path.__Instance;
            var __ret = __Internal.FPDFPathGetPathSegment(__arg0, index);
            FpdfPathsegmentT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfPathsegmentT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfPathsegmentT)FpdfPathsegmentT.NativeToManagedMap[__ret];
            else __result0 = FpdfPathsegmentT.__CreateInstance(__ret);
            return __result0;
        }

        public static int FPDFPathSegmentGetPoint(FpdfPathsegmentT segment, ref float x,
            ref float y)
        {
            var __arg0 = ReferenceEquals(segment, null) ? IntPtr.Zero : segment.__Instance;
            fixed (float* __refParamPtr1 = &x)
            {
                var __arg1 = __refParamPtr1;
                fixed (float* __refParamPtr2 = &y)
                {
                    var __arg2 = __refParamPtr2;
                    var __ret = __Internal.FPDFPathSegmentGetPoint(__arg0, __arg1, __arg2);
                    return __ret;
                }
            }
        }

        public static int FPDFPathSegmentGetType(FpdfPathsegmentT segment)
        {
            var __arg0 = ReferenceEquals(segment, null) ? IntPtr.Zero : segment.__Instance;
            var __ret = __Internal.FPDFPathSegmentGetType(__arg0);
            return __ret;
        }

        public static int FPDFPathSegmentGetClose(FpdfPathsegmentT segment)
        {
            var __arg0 = ReferenceEquals(segment, null) ? IntPtr.Zero : segment.__Instance;
            var __ret = __Internal.FPDFPathSegmentGetClose(__arg0);
            return __ret;
        }

        public static int FPDFPathMoveTo(FpdfPageobjectT path, float x, float y)
        {
            var __arg0 = ReferenceEquals(path, null) ? IntPtr.Zero : path.__Instance;
            var __ret = __Internal.FPDFPathMoveTo(__arg0, x, y);
            return __ret;
        }

        public static int FPDFPathLineTo(FpdfPageobjectT path, float x, float y)
        {
            var __arg0 = ReferenceEquals(path, null) ? IntPtr.Zero : path.__Instance;
            var __ret = __Internal.FPDFPathLineTo(__arg0, x, y);
            return __ret;
        }

        public static int FPDFPathBezierTo(FpdfPageobjectT path, float x1, float y1,
            float x2, float y2, float x3, float y3)
        {
            var __arg0 = ReferenceEquals(path, null) ? IntPtr.Zero : path.__Instance;
            var __ret = __Internal.FPDFPathBezierTo(__arg0, x1, y1, x2, y2, x3, y3);
            return __ret;
        }

        public static int FPDFPathClose(FpdfPageobjectT path)
        {
            var __arg0 = ReferenceEquals(path, null) ? IntPtr.Zero : path.__Instance;
            var __ret = __Internal.FPDFPathClose(__arg0);
            return __ret;
        }

        public static int FPDFPathSetDrawMode(FpdfPageobjectT path, int fillmode,
            int stroke)
        {
            var __arg0 = ReferenceEquals(path, null) ? IntPtr.Zero : path.__Instance;
            var __ret = __Internal.FPDFPathSetDrawMode(__arg0, fillmode, stroke);
            return __ret;
        }

        public static int FPDFPathGetDrawMode(FpdfPageobjectT path, ref int fillmode,
            ref int stroke)
        {
            var __arg0 = ReferenceEquals(path, null) ? IntPtr.Zero : path.__Instance;
            fixed (int* __refParamPtr1 = &fillmode)
            {
                var __arg1 = __refParamPtr1;
                fixed (int* __refParamPtr2 = &stroke)
                {
                    var __arg2 = __refParamPtr2;
                    var __ret = __Internal.FPDFPathGetDrawMode(__arg0, __arg1, __arg2);
                    return __ret;
                }
            }
        }

        public static int FPDFPathGetMatrix(FpdfPageobjectT path, ref double a,
            ref double b, ref double c, ref double d, ref double e, ref double f)
        {
            var __arg0 = ReferenceEquals(path, null) ? IntPtr.Zero : path.__Instance;
            fixed (double* __refParamPtr1 = &a)
            {
                var __arg1 = __refParamPtr1;
                fixed (double* __refParamPtr2 = &b)
                {
                    var __arg2 = __refParamPtr2;
                    fixed (double* __refParamPtr3 = &c)
                    {
                        var __arg3 = __refParamPtr3;
                        fixed (double* __refParamPtr4 = &d)
                        {
                            var __arg4 = __refParamPtr4;
                            fixed (double* __refParamPtr5 = &e)
                            {
                                var __arg5 = __refParamPtr5;
                                fixed (double* __refParamPtr6 = &f)
                                {
                                    var __arg6 = __refParamPtr6;
                                    var __ret = __Internal.FPDFPathGetMatrix(__arg0, __arg1, __arg2, __arg3, __arg4,
                                        __arg5, __arg6);
                                    return __ret;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int FPDFPathSetMatrix(FpdfPageobjectT path, double a, double b,
            double c, double d, double e, double f)
        {
            var __arg0 = ReferenceEquals(path, null) ? IntPtr.Zero : path.__Instance;
            var __ret = __Internal.FPDFPathSetMatrix(__arg0, a, b, c, d, e, f);
            return __ret;
        }

        public static FpdfPageobjectT FPDFPageObjNewTextObj(
            FpdfDocumentT document, string font, float font_size)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __ret = __Internal.FPDFPageObjNewTextObj(__arg0, font, font_size);
            FpdfPageobjectT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfPageobjectT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfPageobjectT)FpdfPageobjectT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfPageobjectT.__CreateInstance(__ret);
            return __result0;
        }

        public static int FPDFTextSetText(FpdfPageobjectT text_object, ref ushort text)
        {
            var __arg0 = ReferenceEquals(text_object, null) ? IntPtr.Zero : text_object.__Instance;
            fixed (ushort* __refParamPtr1 = &text)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.FPDFTextSetText(__arg0, __arg1);
                return __ret;
            }
        }

        public static FpdfFontT FPDFTextLoadFont(
            FpdfDocumentT document, byte* data, uint size, int font_type, int cid)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __ret = __Internal.FPDFTextLoadFont(__arg0, data, size, font_type, cid);
            FpdfFontT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfFontT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfFontT)FpdfFontT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfFontT.__CreateInstance(__ret);
            return __result0;
        }

        public static FpdfFontT FPDFTextLoadStandardFont(
            FpdfDocumentT document, string font)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __ret = __Internal.FPDFTextLoadStandardFont(__arg0, font);
            FpdfFontT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfFontT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfFontT)FpdfFontT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfFontT.__CreateInstance(__ret);
            return __result0;
        }

        public static int FPDFTextSetFillColor(FpdfPageobjectT text_object, uint R, uint G,
            uint B, uint A)
        {
            var __arg0 = ReferenceEquals(text_object, null) ? IntPtr.Zero : text_object.__Instance;
            var __ret = __Internal.FPDFTextSetFillColor(__arg0, R, G, B, A);
            return __ret;
        }

        public static int FPDFTextGetMatrix(FpdfPageobjectT text, ref double a,
            ref double b, ref double c, ref double d, ref double e, ref double f)
        {
            var __arg0 = ReferenceEquals(text, null) ? IntPtr.Zero : text.__Instance;
            fixed (double* __refParamPtr1 = &a)
            {
                var __arg1 = __refParamPtr1;
                fixed (double* __refParamPtr2 = &b)
                {
                    var __arg2 = __refParamPtr2;
                    fixed (double* __refParamPtr3 = &c)
                    {
                        var __arg3 = __refParamPtr3;
                        fixed (double* __refParamPtr4 = &d)
                        {
                            var __arg4 = __refParamPtr4;
                            fixed (double* __refParamPtr5 = &e)
                            {
                                var __arg5 = __refParamPtr5;
                                fixed (double* __refParamPtr6 = &f)
                                {
                                    var __arg6 = __refParamPtr6;
                                    var __ret = __Internal.FPDFTextGetMatrix(__arg0, __arg1, __arg2, __arg3, __arg4,
                                        __arg5, __arg6);
                                    return __ret;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static double FPDFTextObjGetFontSize(FpdfPageobjectT text)
        {
            var __arg0 = ReferenceEquals(text, null) ? IntPtr.Zero : text.__Instance;
            var __ret = __Internal.FPDFTextObjGetFontSize(__arg0);
            return __ret;
        }

        public static void FPDFFontClose(FpdfFontT font)
        {
            var __arg0 = ReferenceEquals(font, null) ? IntPtr.Zero : font.__Instance;
            __Internal.FPDFFontClose(__arg0);
        }

        public static FpdfPageobjectT FPDFPageObjCreateTextObj(
            FpdfDocumentT document, FpdfFontT font,
            float font_size)
        {
            var __arg0 = ReferenceEquals(document, null) ? IntPtr.Zero : document.__Instance;
            var __arg1 = ReferenceEquals(font, null) ? IntPtr.Zero : font.__Instance;
            var __ret = __Internal.FPDFPageObjCreateTextObj(__arg0, __arg1, font_size);
            FpdfPageobjectT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfPageobjectT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfPageobjectT)FpdfPageobjectT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfPageobjectT.__CreateInstance(__ret);
            return __result0;
        }

        public static int FPDFTextGetTextRenderMode(FpdfPageobjectT text)
        {
            var __arg0 = ReferenceEquals(text, null) ? IntPtr.Zero : text.__Instance;
            var __ret = __Internal.FPDFTextGetTextRenderMode(__arg0);
            return __ret;
        }

        public static uint FPDFTextObjGetFontName(FpdfPageobjectT text,
            IntPtr buffer, uint length)
        {
            var __arg0 = ReferenceEquals(text, null) ? IntPtr.Zero : text.__Instance;
            var __ret = __Internal.FPDFTextObjGetFontName(__arg0, buffer, length);
            return __ret;
        }

        public static uint FPDFTextObjGetText(FpdfPageobjectT text_object,
            FpdfTextpageT text_page, IntPtr buffer, uint length)
        {
            var __arg0 = ReferenceEquals(text_object, null) ? IntPtr.Zero : text_object.__Instance;
            var __arg1 = ReferenceEquals(text_page, null) ? IntPtr.Zero : text_page.__Instance;
            var __ret = __Internal.FPDFTextObjGetText(__arg0, __arg1, buffer, length);
            return __ret;
        }

        public static int FPDFFormObjCountObjects(FpdfPageobjectT form_object)
        {
            var __arg0 = ReferenceEquals(form_object, null) ? IntPtr.Zero : form_object.__Instance;
            var __ret = __Internal.FPDFFormObjCountObjects(__arg0);
            return __ret;
        }

        public static FpdfPageobjectT FPDFFormObjGetObject(
            FpdfPageobjectT form_object, uint index)
        {
            var __arg0 = ReferenceEquals(form_object, null) ? IntPtr.Zero : form_object.__Instance;
            var __ret = __Internal.FPDFFormObjGetObject(__arg0, index);
            FpdfPageobjectT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (FpdfPageobjectT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (FpdfPageobjectT)FpdfPageobjectT
                    .NativeToManagedMap[__ret];
            else __result0 = FpdfPageobjectT.__CreateInstance(__ret);
            return __result0;
        }

        public static int FPDFFormObjGetMatrix(FpdfPageobjectT form_object, ref double a,
            ref double b, ref double c, ref double d, ref double e, ref double f)
        {
            var __arg0 = ReferenceEquals(form_object, null) ? IntPtr.Zero : form_object.__Instance;
            fixed (double* __refParamPtr1 = &a)
            {
                var __arg1 = __refParamPtr1;
                fixed (double* __refParamPtr2 = &b)
                {
                    var __arg2 = __refParamPtr2;
                    fixed (double* __refParamPtr3 = &c)
                    {
                        var __arg3 = __refParamPtr3;
                        fixed (double* __refParamPtr4 = &d)
                        {
                            var __arg4 = __refParamPtr4;
                            fixed (double* __refParamPtr5 = &e)
                            {
                                var __arg5 = __refParamPtr5;
                                fixed (double* __refParamPtr6 = &f)
                                {
                                    var __arg6 = __refParamPtr6;
                                    var __ret = __Internal.FPDFFormObjGetMatrix(__arg0, __arg1, __arg2, __arg3, __arg4,
                                        __arg5, __arg6);
                                    return __ret;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}