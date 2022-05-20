namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on HtmlElement.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableHtmlElementEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the Click event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the Click event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> ClickObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.Click += handler,
            handler => instance.Click -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DoubleClick event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the DoubleClick event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> DoubleClickObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.DoubleClick += handler,
            handler => instance.DoubleClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Drag event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the Drag event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> DragObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.Drag += handler,
            handler => instance.Drag -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DragEnd event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the DragEnd event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> DragEndObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.DragEnd += handler,
            handler => instance.DragEnd -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DragLeave event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the DragLeave event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> DragLeaveObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.DragLeave += handler,
            handler => instance.DragLeave -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DragOver event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the DragOver event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> DragOverObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.DragOver += handler,
            handler => instance.DragOver -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Focusing event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the Focusing event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> FocusingObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.Focusing += handler,
            handler => instance.Focusing -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the GotFocus event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the GotFocus event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> GotFocusObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.GotFocus += handler,
            handler => instance.GotFocus -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the LosingFocus event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the LosingFocus event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> LosingFocusObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.LosingFocus += handler,
            handler => instance.LosingFocus -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the LostFocus event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the LostFocus event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> LostFocusObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.LostFocus += handler,
            handler => instance.LostFocus -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyDown event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyDown event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> KeyDownObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.KeyDown += handler,
            handler => instance.KeyDown -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyPress event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyPress event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> KeyPressObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.KeyPress += handler,
            handler => instance.KeyPress -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyUp event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyUp event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> KeyUpObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.KeyUp += handler,
            handler => instance.KeyUp -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseMove event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseMove event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> MouseMoveObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.MouseMove += handler,
            handler => instance.MouseMove -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseDown event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseDown event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> MouseDownObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.MouseDown += handler,
            handler => instance.MouseDown -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseOver event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseOver event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> MouseOverObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.MouseOver += handler,
            handler => instance.MouseOver -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseUp event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseUp event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> MouseUpObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.MouseUp += handler,
            handler => instance.MouseUp -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseEnter event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseEnter event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> MouseEnterObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.MouseEnter += handler,
            handler => instance.MouseEnter -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseLeave event on the HtmlElement instance.
    /// </summary>
    /// <param name="instance">The HtmlElement instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseLeave event on the HtmlElement instance.</returns>
    public static IObservable<EventPattern<HtmlElementEventArgs>> MouseLeaveObservable(this HtmlElement instance)
    {
        return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
            handler => instance.MouseLeave += handler,
            handler => instance.MouseLeave -= handler);
    }
}
