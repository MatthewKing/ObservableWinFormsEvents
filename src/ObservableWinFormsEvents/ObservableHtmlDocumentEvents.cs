namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on HtmlDocument.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableHtmlDocumentEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the Click event on the HtmlDocument instance.
    /// </summary>
    /// <param name="instance">The HtmlDocument instance to observe.</param>
    /// <returns>An observable sequence wrapping the Click event on the HtmlDocument instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> ClickObservable(this HtmlDocument instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.Click += handler,
            handler => instance.Click -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ContextMenuShowing event on the HtmlDocument instance.
    /// </summary>
    /// <param name="instance">The HtmlDocument instance to observe.</param>
    /// <returns>An observable sequence wrapping the ContextMenuShowing event on the HtmlDocument instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> ContextMenuShowingObservable(this HtmlDocument instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.ContextMenuShowing += handler,
            handler => instance.ContextMenuShowing -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Focusing event on the HtmlDocument instance.
    /// </summary>
    /// <param name="instance">The HtmlDocument instance to observe.</param>
    /// <returns>An observable sequence wrapping the Focusing event on the HtmlDocument instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> FocusingObservable(this HtmlDocument instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.Focusing += handler,
            handler => instance.Focusing -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the LosingFocus event on the HtmlDocument instance.
    /// </summary>
    /// <param name="instance">The HtmlDocument instance to observe.</param>
    /// <returns>An observable sequence wrapping the LosingFocus event on the HtmlDocument instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> LosingFocusObservable(this HtmlDocument instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.LosingFocus += handler,
            handler => instance.LosingFocus -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseDown event on the HtmlDocument instance.
    /// </summary>
    /// <param name="instance">The HtmlDocument instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseDown event on the HtmlDocument instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> MouseDownObservable(this HtmlDocument instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.MouseDown += handler,
            handler => instance.MouseDown -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseLeave event on the HtmlDocument instance.
    /// </summary>
    /// <param name="instance">The HtmlDocument instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseLeave event on the HtmlDocument instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> MouseLeaveObservable(this HtmlDocument instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.MouseLeave += handler,
            handler => instance.MouseLeave -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseMove event on the HtmlDocument instance.
    /// </summary>
    /// <param name="instance">The HtmlDocument instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseMove event on the HtmlDocument instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> MouseMoveObservable(this HtmlDocument instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.MouseMove += handler,
            handler => instance.MouseMove -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseOver event on the HtmlDocument instance.
    /// </summary>
    /// <param name="instance">The HtmlDocument instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseOver event on the HtmlDocument instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> MouseOverObservable(this HtmlDocument instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.MouseOver += handler,
            handler => instance.MouseOver -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseUp event on the HtmlDocument instance.
    /// </summary>
    /// <param name="instance">The HtmlDocument instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseUp event on the HtmlDocument instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> MouseUpObservable(this HtmlDocument instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.MouseUp += handler,
            handler => instance.MouseUp -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Stop event on the HtmlDocument instance.
    /// </summary>
    /// <param name="instance">The HtmlDocument instance to observe.</param>
    /// <returns>An observable sequence wrapping the Stop event on the HtmlDocument instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> StopObservable(this HtmlDocument instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.Stop += handler,
            handler => instance.Stop -= handler);
    }
}
