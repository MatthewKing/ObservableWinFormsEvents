namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ScrollableControl.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableScrollableControlEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the Scroll event on the ScrollableControl instance.
    /// </summary>
    /// <param name="instance">The ScrollableControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the Scroll event on the ScrollableControl instance.</returns>
    public static IObservable<EventPattern<ScrollEventArgs>> ScrollObservable(this ScrollableControl instance)
    {
        return Observable.FromEventPattern<ScrollEventHandler, ScrollEventArgs>(
            handler => instance.Scroll += handler,
            handler => instance.Scroll -= handler);
    }
}
