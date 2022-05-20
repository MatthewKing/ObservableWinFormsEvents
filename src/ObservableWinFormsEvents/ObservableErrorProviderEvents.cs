namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ErrorProvider.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableErrorProviderEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the RightToLeftChanged event on the ErrorProvider instance.
    /// </summary>
    /// <param name="instance">The ErrorProvider instance to observe.</param>
    /// <returns>An observable sequence wrapping the RightToLeftChanged event on the ErrorProvider instance.</returns>
    public static IObservable<EventPattern<EventArgs>> RightToLeftChangedObservable(this ErrorProvider instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.RightToLeftChanged += handler,
            handler => instance.RightToLeftChanged -= handler);
    }
}
