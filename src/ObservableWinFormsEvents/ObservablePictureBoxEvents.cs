namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on PictureBox.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservablePictureBoxEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the CausesValidationChanged event on the PictureBox instance.
    /// </summary>
    /// <param name="instance">The PictureBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the CausesValidationChanged event on the PictureBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CausesValidationChangedObservable(this PictureBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.CausesValidationChanged += handler,
            handler => instance.CausesValidationChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ForeColorChanged event on the PictureBox instance.
    /// </summary>
    /// <param name="instance">The PictureBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the ForeColorChanged event on the PictureBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this PictureBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ForeColorChanged += handler,
            handler => instance.ForeColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the FontChanged event on the PictureBox instance.
    /// </summary>
    /// <param name="instance">The PictureBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the FontChanged event on the PictureBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> FontChangedObservable(this PictureBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.FontChanged += handler,
            handler => instance.FontChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ImeModeChanged event on the PictureBox instance.
    /// </summary>
    /// <param name="instance">The PictureBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the ImeModeChanged event on the PictureBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ImeModeChangedObservable(this PictureBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ImeModeChanged += handler,
            handler => instance.ImeModeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the LoadCompleted event on the PictureBox instance.
    /// </summary>
    /// <param name="instance">The PictureBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the LoadCompleted event on the PictureBox instance.</returns>
    public static IObservable<EventPattern<AsyncCompletedEventArgs>> LoadCompletedObservable(this PictureBox instance)
    {
        return Observable.FromEventPattern<AsyncCompletedEventHandler, AsyncCompletedEventArgs>(
            handler => instance.LoadCompleted += handler,
            handler => instance.LoadCompleted -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the LoadProgressChanged event on the PictureBox instance.
    /// </summary>
    /// <param name="instance">The PictureBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the LoadProgressChanged event on the PictureBox instance.</returns>
    public static IObservable<EventPattern<ProgressChangedEventArgs>> LoadProgressChangedObservable(this PictureBox instance)
    {
        return Observable.FromEventPattern<ProgressChangedEventHandler, ProgressChangedEventArgs>(
            handler => instance.LoadProgressChanged += handler,
            handler => instance.LoadProgressChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RightToLeftChanged event on the PictureBox instance.
    /// </summary>
    /// <param name="instance">The PictureBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the RightToLeftChanged event on the PictureBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> RightToLeftChangedObservable(this PictureBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.RightToLeftChanged += handler,
            handler => instance.RightToLeftChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the SizeModeChanged event on the PictureBox instance.
    /// </summary>
    /// <param name="instance">The PictureBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the SizeModeChanged event on the PictureBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> SizeModeChangedObservable(this PictureBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.SizeModeChanged += handler,
            handler => instance.SizeModeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TabStopChanged event on the PictureBox instance.
    /// </summary>
    /// <param name="instance">The PictureBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the TabStopChanged event on the PictureBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TabStopChangedObservable(this PictureBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TabStopChanged += handler,
            handler => instance.TabStopChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TabIndexChanged event on the PictureBox instance.
    /// </summary>
    /// <param name="instance">The PictureBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the TabIndexChanged event on the PictureBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TabIndexChangedObservable(this PictureBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TabIndexChanged += handler,
            handler => instance.TabIndexChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TextChanged event on the PictureBox instance.
    /// </summary>
    /// <param name="instance">The PictureBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the TextChanged event on the PictureBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this PictureBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TextChanged += handler,
            handler => instance.TextChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Enter event on the PictureBox instance.
    /// </summary>
    /// <param name="instance">The PictureBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the Enter event on the PictureBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> EnterObservable(this PictureBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.Enter += handler,
            handler => instance.Enter -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyUp event on the PictureBox instance.
    /// </summary>
    /// <param name="instance">The PictureBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyUp event on the PictureBox instance.</returns>
    public static IObservable<EventPattern<KeyEventArgs>> KeyUpObservable(this PictureBox instance)
    {
        return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
            handler => instance.KeyUp += handler,
            handler => instance.KeyUp -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyDown event on the PictureBox instance.
    /// </summary>
    /// <param name="instance">The PictureBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyDown event on the PictureBox instance.</returns>
    public static IObservable<EventPattern<KeyEventArgs>> KeyDownObservable(this PictureBox instance)
    {
        return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
            handler => instance.KeyDown += handler,
            handler => instance.KeyDown -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyPress event on the PictureBox instance.
    /// </summary>
    /// <param name="instance">The PictureBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyPress event on the PictureBox instance.</returns>
    public static IObservable<EventPattern<KeyPressEventArgs>> KeyPressObservable(this PictureBox instance)
    {
        return Observable.FromEventPattern<KeyPressEventHandler, KeyPressEventArgs>(
            handler => instance.KeyPress += handler,
            handler => instance.KeyPress -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Leave event on the PictureBox instance.
    /// </summary>
    /// <param name="instance">The PictureBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the Leave event on the PictureBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> LeaveObservable(this PictureBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.Leave += handler,
            handler => instance.Leave -= handler);
    }
}
