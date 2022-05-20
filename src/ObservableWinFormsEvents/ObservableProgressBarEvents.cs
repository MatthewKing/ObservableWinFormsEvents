namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ProgressBar.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableProgressBarEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageChanged event on the ProgressBar instance.
    /// </summary>
    /// <param name="instance">The ProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the ProgressBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this ProgressBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageChanged += handler,
            handler => instance.BackgroundImageChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the ProgressBar instance.
    /// </summary>
    /// <param name="instance">The ProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the ProgressBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this ProgressBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageLayoutChanged += handler,
            handler => instance.BackgroundImageLayoutChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the CausesValidationChanged event on the ProgressBar instance.
    /// </summary>
    /// <param name="instance">The ProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the CausesValidationChanged event on the ProgressBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CausesValidationChangedObservable(this ProgressBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.CausesValidationChanged += handler,
            handler => instance.CausesValidationChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the FontChanged event on the ProgressBar instance.
    /// </summary>
    /// <param name="instance">The ProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the FontChanged event on the ProgressBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> FontChangedObservable(this ProgressBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.FontChanged += handler,
            handler => instance.FontChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ImeModeChanged event on the ProgressBar instance.
    /// </summary>
    /// <param name="instance">The ProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the ImeModeChanged event on the ProgressBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ImeModeChangedObservable(this ProgressBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ImeModeChanged += handler,
            handler => instance.ImeModeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the PaddingChanged event on the ProgressBar instance.
    /// </summary>
    /// <param name="instance">The ProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the PaddingChanged event on the ProgressBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this ProgressBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.PaddingChanged += handler,
            handler => instance.PaddingChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RightToLeftLayoutChanged event on the ProgressBar instance.
    /// </summary>
    /// <param name="instance">The ProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the RightToLeftLayoutChanged event on the ProgressBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> RightToLeftLayoutChangedObservable(this ProgressBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.RightToLeftLayoutChanged += handler,
            handler => instance.RightToLeftLayoutChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TabStopChanged event on the ProgressBar instance.
    /// </summary>
    /// <param name="instance">The ProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the TabStopChanged event on the ProgressBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TabStopChangedObservable(this ProgressBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TabStopChanged += handler,
            handler => instance.TabStopChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TextChanged event on the ProgressBar instance.
    /// </summary>
    /// <param name="instance">The ProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the TextChanged event on the ProgressBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this ProgressBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TextChanged += handler,
            handler => instance.TextChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DoubleClick event on the ProgressBar instance.
    /// </summary>
    /// <param name="instance">The ProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the DoubleClick event on the ProgressBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DoubleClickObservable(this ProgressBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DoubleClick += handler,
            handler => instance.DoubleClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseDoubleClick event on the ProgressBar instance.
    /// </summary>
    /// <param name="instance">The ProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseDoubleClick event on the ProgressBar instance.</returns>
    public static IObservable<EventPattern<MouseEventArgs>> MouseDoubleClickObservable(this ProgressBar instance)
    {
        return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
            handler => instance.MouseDoubleClick += handler,
            handler => instance.MouseDoubleClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyUp event on the ProgressBar instance.
    /// </summary>
    /// <param name="instance">The ProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyUp event on the ProgressBar instance.</returns>
    public static IObservable<EventPattern<KeyEventArgs>> KeyUpObservable(this ProgressBar instance)
    {
        return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
            handler => instance.KeyUp += handler,
            handler => instance.KeyUp -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyDown event on the ProgressBar instance.
    /// </summary>
    /// <param name="instance">The ProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyDown event on the ProgressBar instance.</returns>
    public static IObservable<EventPattern<KeyEventArgs>> KeyDownObservable(this ProgressBar instance)
    {
        return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
            handler => instance.KeyDown += handler,
            handler => instance.KeyDown -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyPress event on the ProgressBar instance.
    /// </summary>
    /// <param name="instance">The ProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyPress event on the ProgressBar instance.</returns>
    public static IObservable<EventPattern<KeyPressEventArgs>> KeyPressObservable(this ProgressBar instance)
    {
        return Observable.FromEventPattern<KeyPressEventHandler, KeyPressEventArgs>(
            handler => instance.KeyPress += handler,
            handler => instance.KeyPress -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Enter event on the ProgressBar instance.
    /// </summary>
    /// <param name="instance">The ProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the Enter event on the ProgressBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> EnterObservable(this ProgressBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.Enter += handler,
            handler => instance.Enter -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Leave event on the ProgressBar instance.
    /// </summary>
    /// <param name="instance">The ProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the Leave event on the ProgressBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> LeaveObservable(this ProgressBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.Leave += handler,
            handler => instance.Leave -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Paint event on the ProgressBar instance.
    /// </summary>
    /// <param name="instance">The ProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the Paint event on the ProgressBar instance.</returns>
    public static IObservable<EventPattern<PaintEventArgs>> PaintObservable(this ProgressBar instance)
    {
        return Observable.FromEventPattern<PaintEventHandler, PaintEventArgs>(
            handler => instance.Paint += handler,
            handler => instance.Paint -= handler);
    }
}
