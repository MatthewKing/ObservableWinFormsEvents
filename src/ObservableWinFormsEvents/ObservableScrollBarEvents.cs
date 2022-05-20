namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ScrollBar.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableScrollBarEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AutoSizeChanged event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the AutoSizeChanged event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AutoSizeChanged += handler,
            handler => instance.AutoSizeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackColorChanged event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackColorChanged event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackColorChangedObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackColorChanged += handler,
            handler => instance.BackColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageChanged event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageChanged += handler,
            handler => instance.BackgroundImageChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageLayoutChanged += handler,
            handler => instance.BackgroundImageLayoutChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ForeColorChanged event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the ForeColorChanged event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ForeColorChanged += handler,
            handler => instance.ForeColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the FontChanged event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the FontChanged event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> FontChangedObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.FontChanged += handler,
            handler => instance.FontChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ImeModeChanged event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the ImeModeChanged event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ImeModeChangedObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ImeModeChanged += handler,
            handler => instance.ImeModeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TextChanged event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the TextChanged event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TextChanged += handler,
            handler => instance.TextChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Click event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the Click event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ClickObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.Click += handler,
            handler => instance.Click -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Paint event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the Paint event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<PaintEventArgs>> PaintObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<PaintEventHandler, PaintEventArgs>(
            handler => instance.Paint += handler,
            handler => instance.Paint -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DoubleClick event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the DoubleClick event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DoubleClickObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DoubleClick += handler,
            handler => instance.DoubleClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseClick event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseClick event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<MouseEventArgs>> MouseClickObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
            handler => instance.MouseClick += handler,
            handler => instance.MouseClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseDoubleClick event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseDoubleClick event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<MouseEventArgs>> MouseDoubleClickObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
            handler => instance.MouseDoubleClick += handler,
            handler => instance.MouseDoubleClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseDown event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseDown event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<MouseEventArgs>> MouseDownObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
            handler => instance.MouseDown += handler,
            handler => instance.MouseDown -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseUp event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseUp event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<MouseEventArgs>> MouseUpObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
            handler => instance.MouseUp += handler,
            handler => instance.MouseUp -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseMove event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseMove event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<MouseEventArgs>> MouseMoveObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
            handler => instance.MouseMove += handler,
            handler => instance.MouseMove -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Scroll event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the Scroll event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<ScrollEventArgs>> ScrollObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<ScrollEventHandler, ScrollEventArgs>(
            handler => instance.Scroll += handler,
            handler => instance.Scroll -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ValueChanged event on the ScrollBar instance.
    /// </summary>
    /// <param name="instance">The ScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the ValueChanged event on the ScrollBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ValueChangedObservable(this ScrollBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ValueChanged += handler,
            handler => instance.ValueChanged -= handler);
    }
}
