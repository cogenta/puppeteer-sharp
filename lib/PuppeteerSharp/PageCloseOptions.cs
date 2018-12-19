namespace PuppeteerSharp
{
    /// <summary>
    /// Page close options.
    /// </summary>
    /// <seealso cref="Page.CloseAsync(PageCloseOptions)"/>
    public class PageCloseOptions
    {
        /// <summary>
        /// Defaults to <c>false</c>. Whether to run the beforeunload page handlers.
        /// </summary>
        /// <see href="https://developer.mozilla.org/en-US/docs/Web/Events/beforeunload"/>
        public bool RunBeforeUnload { get; set; }

        /// <summary>
        /// Determines whether or not to wait for the callback to take place when the page is closed
        /// </summary>
        public bool WaitForCallback { get; set; } = true;
    }
}