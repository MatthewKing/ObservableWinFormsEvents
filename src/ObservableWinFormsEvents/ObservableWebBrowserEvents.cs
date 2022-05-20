using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on WebBrowser.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableWebBrowserEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the PaddingChanged event on the WebBrowser instance.
    /// </summary>
    /// <param name="instance">The WebBrowser instance to observe.</param>
    /// <returns>An observable sequence wrapping the PaddingChanged event on the WebBrowser instance.</returns>
    public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this WebBrowser instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.PaddingChanged += handler,
            handler => instance.PaddingChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the CanGoBackChanged event on the WebBrowser instance.
    /// </summary>
    /// <param name="instance">The WebBrowser instance to observe.</param>
    /// <returns>An observable sequence wrapping the CanGoBackChanged event on the WebBrowser instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CanGoBackChangedObservable(this WebBrowser instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.CanGoBackChanged += handler,
            handler => instance.CanGoBackChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the CanGoForwardChanged event on the WebBrowser instance.
    /// </summary>
    /// <param name="instance">The WebBrowser instance to observe.</param>
    /// <returns>An observable sequence wrapping the CanGoForwardChanged event on the WebBrowser instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CanGoForwardChangedObservable(this WebBrowser instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.CanGoForwardChanged += handler,
            handler => instance.CanGoForwardChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DocumentCompleted event on the WebBrowser instance.
    /// </summary>
    /// <param name="instance">The WebBrowser instance to observe.</param>
    /// <returns>An observable sequence wrapping the DocumentCompleted event on the WebBrowser instance.</returns>
    public static IObservable<EventPattern<WebBrowserDocumentCompletedEventArgs>> DocumentCompletedObservable(this WebBrowser instance)
    {
        return Observable.FromEventPattern<WebBrowserDocumentCompletedEventHandler, WebBrowserDocumentCompletedEventArgs>(
            handler => instance.DocumentCompleted += handler,
            handler => instance.DocumentCompleted -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DocumentTitleChanged event on the WebBrowser instance.
    /// </summary>
    /// <param name="instance">The WebBrowser instance to observe.</param>
    /// <returns>An observable sequence wrapping the DocumentTitleChanged event on the WebBrowser instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DocumentTitleChangedObservable(this WebBrowser instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DocumentTitleChanged += handler,
            handler => instance.DocumentTitleChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the EncryptionLevelChanged event on the WebBrowser instance.
    /// </summary>
    /// <param name="instance">The WebBrowser instance to observe.</param>
    /// <returns>An observable sequence wrapping the EncryptionLevelChanged event on the WebBrowser instance.</returns>
    public static IObservable<EventPattern<EventArgs>> EncryptionLevelChangedObservable(this WebBrowser instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.EncryptionLevelChanged += handler,
            handler => instance.EncryptionLevelChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the FileDownload event on the WebBrowser instance.
    /// </summary>
    /// <param name="instance">The WebBrowser instance to observe.</param>
    /// <returns>An observable sequence wrapping the FileDownload event on the WebBrowser instance.</returns>
    public static IObservable<EventPattern<EventArgs>> FileDownloadObservable(this WebBrowser instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.FileDownload += handler,
            handler => instance.FileDownload -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Navigated event on the WebBrowser instance.
    /// </summary>
    /// <param name="instance">The WebBrowser instance to observe.</param>
    /// <returns>An observable sequence wrapping the Navigated event on the WebBrowser instance.</returns>
    public static IObservable<EventPattern<WebBrowserNavigatedEventArgs>> NavigatedObservable(this WebBrowser instance)
    {
        return Observable.FromEventPattern<WebBrowserNavigatedEventHandler, WebBrowserNavigatedEventArgs>(
            handler => instance.Navigated += handler,
            handler => instance.Navigated -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Navigating event on the WebBrowser instance.
    /// </summary>
    /// <param name="instance">The WebBrowser instance to observe.</param>
    /// <returns>An observable sequence wrapping the Navigating event on the WebBrowser instance.</returns>
    public static IObservable<EventPattern<WebBrowserNavigatingEventArgs>> NavigatingObservable(this WebBrowser instance)
    {
        return Observable.FromEventPattern<WebBrowserNavigatingEventHandler, WebBrowserNavigatingEventArgs>(
            handler => instance.Navigating += handler,
            handler => instance.Navigating -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the NewWindow event on the WebBrowser instance.
    /// </summary>
    /// <param name="instance">The WebBrowser instance to observe.</param>
    /// <returns>An observable sequence wrapping the NewWindow event on the WebBrowser instance.</returns>
    public static IObservable<EventPattern<CancelEventArgs>> NewWindowObservable(this WebBrowser instance)
    {
        return Observable.FromEventPattern<CancelEventHandler, CancelEventArgs>(
            handler => instance.NewWindow += handler,
            handler => instance.NewWindow -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ProgressChanged event on the WebBrowser instance.
    /// </summary>
    /// <param name="instance">The WebBrowser instance to observe.</param>
    /// <returns>An observable sequence wrapping the ProgressChanged event on the WebBrowser instance.</returns>
    public static IObservable<EventPattern<WebBrowserProgressChangedEventArgs>> ProgressChangedObservable(this WebBrowser instance)
    {
        return Observable.FromEventPattern<WebBrowserProgressChangedEventHandler, WebBrowserProgressChangedEventArgs>(
            handler => instance.ProgressChanged += handler,
            handler => instance.ProgressChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the StatusTextChanged event on the WebBrowser instance.
    /// </summary>
    /// <param name="instance">The WebBrowser instance to observe.</param>
    /// <returns>An observable sequence wrapping the StatusTextChanged event on the WebBrowser instance.</returns>
    public static IObservable<EventPattern<EventArgs>> StatusTextChangedObservable(this WebBrowser instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.StatusTextChanged += handler,
            handler => instance.StatusTextChanged -= handler);
    }
}
