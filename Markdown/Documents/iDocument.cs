﻿namespace Markdown.Documents
{
    /// <summary>
    /// Interface for documents that can generate fragments by fragment types.
    /// </summary>
    public interface iDocument
    {
        /// <summary>
        /// Builds a list of text fragments for a specific scope. This method is optimized
        /// to store types in a memory cache for faster retrieval.
        /// </summary>
        Fragment[] getFragments(string pType, DocumentCursor pCursor);
    }
}