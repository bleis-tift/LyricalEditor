// Guids.cs
// MUST match guids.h
using System;

namespace bleistift.LyricalEditor
{
    static class GuidList
    {
        public const string guidLyricalEditorPkgString = "5e80449c-5c27-4128-8848-c4ae6e3c27ee";
        public const string guidLyricalEditorCmdSetString = "75f5f8bc-dbf9-4e73-8df0-65cf4681eadc";

        public static readonly Guid guidLyricalEditorCmdSet = new Guid(guidLyricalEditorCmdSetString);
    };
}