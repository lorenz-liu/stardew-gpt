using System;
using System.Runtime.InteropServices;

namespace StardewGPT.Services
{
    /// <summary>Direct P/Invoke bindings to SQLite C API.</summary>
    internal static class SQLiteNative
    {
        private const string LibraryName = "sqlite3";

        // SQLite result codes
        public const int SQLITE_OK = 0;
        public const int SQLITE_ROW = 100;
        public const int SQLITE_DONE = 101;

        // SQLite open flags
        public const int SQLITE_OPEN_READONLY = 0x00000001;

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int sqlite3_open_v2(
            [MarshalAs(UnmanagedType.LPUTF8Str)] string filename,
            out IntPtr ppDb,
            int flags,
            IntPtr zVfs);

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int sqlite3_close(IntPtr db);

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int sqlite3_prepare_v2(
            IntPtr db,
            [MarshalAs(UnmanagedType.LPUTF8Str)] string sql,
            int nByte,
            out IntPtr ppStmt,
            IntPtr pzTail);

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int sqlite3_step(IntPtr stmt);

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int sqlite3_finalize(IntPtr stmt);

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr sqlite3_column_text(IntPtr stmt, int iCol);

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr sqlite3_column_blob(IntPtr stmt, int iCol);

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int sqlite3_column_bytes(IntPtr stmt, int iCol);

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern long sqlite3_column_int64(IntPtr stmt, int iCol);

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr sqlite3_errmsg(IntPtr db);

        /// <summary>Helper to convert UTF8 string pointer to C# string.</summary>
        public static string PtrToStringUTF8(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
                return string.Empty;

            int len = 0;
            while (Marshal.ReadByte(ptr, len) != 0)
                len++;

            if (len == 0)
                return string.Empty;

            byte[] buffer = new byte[len];
            Marshal.Copy(ptr, buffer, 0, len);
            return System.Text.Encoding.UTF8.GetString(buffer);
        }
    }
}
