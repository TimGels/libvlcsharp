// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace VideoLAN.LibVLC
{

    /// <summary>Category of a media discoverer</summary>
    /// <remarks>libvlc_media_discoverer_list_get()</remarks>
    public enum MediaDiscovererCategory
    {
        /// <summary>devices, like portable music player</summary>
        Devices = 0,
        /// <summary>LAN/WAN services, like Upnp, SMB, or SAP</summary>
        Lan = 1,
        /// <summary>Podcasts</summary>
        Podcasts = 2,
        /// <summary>Local directories, like Video, Music or Pictures directories</summary>
        Localdirs = 3
    }

    /// <summary>
    /// <para>LibVLC media discovery finds available media via various means.</para>
    /// <para>This corresponds to the service discovery functionality in VLC media player.</para>
    /// <para>Different plugins find potential medias locally (e.g. user media directory),</para>
    /// <para>from peripherals (e.g. video capture device), on the local network</para>
    /// <para>(e.g. SAP) or on the Internet (e.g. Internet radios).</para>
    /// <para>@{</para>
    /// <para></para>
    /// <para>LibVLC media discovery external API</para>
    /// </summary>
    public unsafe partial class MediaDiscoverer
    {
       

        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::VideoLAN.LibVLC.MediaDiscoverer> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::VideoLAN.LibVLC.MediaDiscoverer>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::VideoLAN.LibVLC.MediaDiscoverer __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::VideoLAN.LibVLC.MediaDiscoverer(native.ToPointer(), skipVTables);
        }

        internal static global::VideoLAN.LibVLC.MediaDiscoverer __CreateInstance(global::VideoLAN.LibVLC.MediaDiscoverer.__Internal native, bool skipVTables = false)
        {
            return new global::VideoLAN.LibVLC.MediaDiscoverer(native, skipVTables);
        }

        private static void* __CopyValue(global::VideoLAN.LibVLC.MediaDiscoverer.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::VideoLAN.LibVLC.MediaDiscoverer.__Internal));
            *(global::VideoLAN.LibVLC.MediaDiscoverer.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private MediaDiscoverer(global::VideoLAN.LibVLC.MediaDiscoverer.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected MediaDiscoverer(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    /// <summary>Media discoverer description</summary>
    /// <remarks>libvlc_media_discoverer_list_get()</remarks>
    public unsafe class MediaDiscovererDescription //: IDisposable
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct __Internal
        {
            internal IntPtr psz_name;

            internal IntPtr psz_longname;

            internal int i_cat;
        }

        public IntPtr NativeReference { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::VideoLAN.LibVLC.MediaDiscovererDescription> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::VideoLAN.LibVLC.MediaDiscovererDescription>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::VideoLAN.LibVLC.MediaDiscovererDescription __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::VideoLAN.LibVLC.MediaDiscovererDescription(native.ToPointer(), skipVTables);
        }

        internal static global::VideoLAN.LibVLC.MediaDiscovererDescription __CreateInstance(global::VideoLAN.LibVLC.MediaDiscovererDescription.__Internal native, bool skipVTables = false)
        {
            return new global::VideoLAN.LibVLC.MediaDiscovererDescription(native, skipVTables);
        }

        private static void* __CopyValue(global::VideoLAN.LibVLC.MediaDiscovererDescription.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::VideoLAN.LibVLC.MediaDiscovererDescription.__Internal));
            *(global::VideoLAN.LibVLC.MediaDiscovererDescription.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private MediaDiscovererDescription(global::VideoLAN.LibVLC.MediaDiscovererDescription.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[NativeReference] = this;
        }

        protected MediaDiscovererDescription(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            NativeReference = new global::System.IntPtr(native);
        }

        public MediaDiscovererDescription()
        {
            NativeReference = Marshal.AllocHGlobal(sizeof(global::VideoLAN.LibVLC.MediaDiscovererDescription.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[NativeReference] = this;
        }

        public MediaDiscovererDescription(global::VideoLAN.LibVLC.MediaDiscovererDescription _0)
        {
            NativeReference = Marshal.AllocHGlobal(sizeof(global::VideoLAN.LibVLC.MediaDiscovererDescription.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[NativeReference] = this;
            *((global::VideoLAN.LibVLC.MediaDiscovererDescription.__Internal*)NativeReference) = *((global::VideoLAN.LibVLC.MediaDiscovererDescription.__Internal*) _0.NativeReference);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (NativeReference == IntPtr.Zero)
                return;
            global::VideoLAN.LibVLC.MediaDiscovererDescription __dummy;
            NativeToManagedMap.TryRemove(NativeReference, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(NativeReference);
            NativeReference = IntPtr.Zero;
        }

        public string Name => (string)Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(((__Internal*)NativeReference)->psz_name);
        public string Longname => (string)Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(((__Internal*)NativeReference)->psz_longname);
        public MediaDiscovererCategory Category => (MediaDiscovererCategory)((__Internal*)NativeReference)->i_cat;
    }

    public unsafe partial class libvlc_media_discoverer
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvlc", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="libvlc_media_discoverer_new")]
            internal static extern global::System.IntPtr LibvlcMediaDiscovererNew(global::System.IntPtr p_inst, [MarshalAs(UnmanagedType.LPStr)] string psz_name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvlc", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="libvlc_media_discoverer_start")]
            internal static extern int LibvlcMediaDiscovererStart(global::System.IntPtr p_mdis);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvlc", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="libvlc_media_discoverer_stop")]
            internal static extern void LibvlcMediaDiscovererStop(global::System.IntPtr p_mdis);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvlc", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="libvlc_media_discoverer_release")]
            internal static extern void LibvlcMediaDiscovererRelease(global::System.IntPtr p_mdis);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvlc", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="libvlc_media_discoverer_media_list")]
            internal static extern global::System.IntPtr LibvlcMediaDiscovererMediaList(global::System.IntPtr p_mdis);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvlc", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="libvlc_media_discoverer_is_running")]
            internal static extern int LibvlcMediaDiscovererIsRunning(global::System.IntPtr p_mdis);

        }

        /// <summary>Create a media discoverer object by name.</summary>
        /// <param name="p_inst">libvlc instance</param>
        /// <param name="psz_name">
        /// <para>service name; use libvlc_media_discoverer_list_get() to get</para>
        /// <para>a list of the discoverer names available in this libVLC instance</para>
        /// </param>
        /// <returns>media discover object or NULL in case of error</returns>
        /// <remarks>
        /// <para>After this object is created, you should attach to media_list events in</para>
        /// <para>order to be notified of new items discovered.</para>
        /// <para>You need to call libvlc_media_discoverer_start() in order to start the</para>
        /// <para>discovery.</para>
        /// <para>libvlc_media_discoverer_media_list</para>
        /// <para>libvlc_media_discoverer_event_manager</para>
        /// <para>libvlc_media_discoverer_start</para>
        /// <para>LibVLC 3.0.0 or later</para>
        /// </remarks>
        public static global::VideoLAN.LibVLC.MediaDiscoverer LibvlcMediaDiscovererNew(global::VideoLAN.LibVLC.Manual.Instance p_inst, string psz_name)
        {
            var __arg0 = ReferenceEquals(p_inst, null) ? global::System.IntPtr.Zero : p_inst.NativeReference;
            var __ret = __Internal.LibvlcMediaDiscovererNew(__arg0, psz_name);
            global::VideoLAN.LibVLC.MediaDiscoverer __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::VideoLAN.LibVLC.MediaDiscoverer.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::VideoLAN.LibVLC.MediaDiscoverer) global::VideoLAN.LibVLC.MediaDiscoverer.NativeToManagedMap[__ret];
            else __result0 = global::VideoLAN.LibVLC.MediaDiscoverer.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Start media discovery.</summary>
        /// <param name="p_mdis">media discover object</param>
        /// <returns>-1 in case of error, 0 otherwise</returns>
        /// <remarks>
        /// <para>To stop it, call libvlc_media_discoverer_stop() or</para>
        /// <para>libvlc_media_discoverer_list_release() directly.</para>
        /// <para>libvlc_media_discoverer_stop</para>
        /// <para>LibVLC 3.0.0 or later</para>
        /// </remarks>
        public static int LibvlcMediaDiscovererStart(global::VideoLAN.LibVLC.MediaDiscoverer p_mdis)
        {
            var __arg0 = ReferenceEquals(p_mdis, null) ? global::System.IntPtr.Zero : p_mdis.__Instance;
            var __ret = __Internal.LibvlcMediaDiscovererStart(__arg0);
            return __ret;
        }

        /// <summary>Stop media discovery.</summary>
        /// <param name="p_mdis">media discover object</param>
        /// <remarks>
        /// <para>libvlc_media_discoverer_start</para>
        /// <para>LibVLC 3.0.0 or later</para>
        /// </remarks>
        public static void LibvlcMediaDiscovererStop(global::VideoLAN.LibVLC.MediaDiscoverer p_mdis)
        {
            var __arg0 = ReferenceEquals(p_mdis, null) ? global::System.IntPtr.Zero : p_mdis.__Instance;
            __Internal.LibvlcMediaDiscovererStop(__arg0);
        }

        /// <summary>
        /// <para>Release media discover object. If the reference count reaches 0, then</para>
        /// <para>the object will be released.</para>
        /// </summary>
        /// <param name="p_mdis">media service discover object</param>
        public static void LibvlcMediaDiscovererRelease(global::VideoLAN.LibVLC.MediaDiscoverer p_mdis)
        {
            var __arg0 = ReferenceEquals(p_mdis, null) ? global::System.IntPtr.Zero : p_mdis.__Instance;
            __Internal.LibvlcMediaDiscovererRelease(__arg0);
        }

        /// <summary>Get media service discover media list.</summary>
        /// <param name="p_mdis">media service discover object</param>
        /// <returns>list of media items</returns>
        public static global::VideoLAN.LibVLC.MediaList LibvlcMediaDiscovererMediaList(global::VideoLAN.LibVLC.MediaDiscoverer p_mdis)
        {
            var __arg0 = ReferenceEquals(p_mdis, null) ? global::System.IntPtr.Zero : p_mdis.__Instance;
            var __ret = __Internal.LibvlcMediaDiscovererMediaList(__arg0);
            global::VideoLAN.LibVLC.MediaList __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::VideoLAN.LibVLC.MediaList.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::VideoLAN.LibVLC.MediaList) global::VideoLAN.LibVLC.MediaList.NativeToManagedMap[__ret];
            else __result0 = global::VideoLAN.LibVLC.MediaList.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Query if media service discover object is running.</summary>
        /// <param name="p_mdis">media service discover object</param>
        /// <returns>true if running, false if not</returns>
        public static int LibvlcMediaDiscovererIsRunning(global::VideoLAN.LibVLC.MediaDiscoverer p_mdis)
        {
            var __arg0 = ReferenceEquals(p_mdis, null) ? global::System.IntPtr.Zero : p_mdis.__Instance;
            var __ret = __Internal.LibvlcMediaDiscovererIsRunning(__arg0);
            return __ret;
        }

        
    }
}
