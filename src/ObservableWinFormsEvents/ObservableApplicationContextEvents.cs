namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on ApplicationContext.
    /// </summary>
    public static class ObservableApplicationContextEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the ThreadExit event on the ApplicationContext instance.
        /// </summary>
        /// <param name="instance">The ApplicationContext instance to observe.</param>
        /// <returns>An observable sequence wrapping the ThreadExit event on the ApplicationContext instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ThreadExitObservable(this ApplicationContext instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ThreadExit += handler,
                handler => instance.ThreadExit -= handler);
        }
    }
}
