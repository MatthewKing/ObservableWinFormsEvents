namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on RichTextBox.
    /// </summary>
    public static class ObservableRichTextBoxEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageChanged event on the RichTextBox instance.
        /// </summary>
        /// <param name="instance">The RichTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the RichTextBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this RichTextBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageChanged += handler,
                handler => instance.BackgroundImageChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the RichTextBox instance.
        /// </summary>
        /// <param name="instance">The RichTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the RichTextBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this RichTextBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageLayoutChanged += handler,
                handler => instance.BackgroundImageLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ContentsResized event on the RichTextBox instance.
        /// </summary>
        /// <param name="instance">The RichTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the ContentsResized event on the RichTextBox instance.</returns>
        public static IObservable<EventPattern<ContentsResizedEventArgs>> ContentsResizedObservable(this RichTextBox instance)
        {
            return Observable.FromEventPattern<ContentsResizedEventHandler, ContentsResizedEventArgs>(
                handler => instance.ContentsResized += handler,
                handler => instance.ContentsResized -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DragDrop event on the RichTextBox instance.
        /// </summary>
        /// <param name="instance">The RichTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the DragDrop event on the RichTextBox instance.</returns>
        public static IObservable<EventPattern<DragEventArgs>> DragDropObservable(this RichTextBox instance)
        {
            return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(
                handler => instance.DragDrop += handler,
                handler => instance.DragDrop -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DragEnter event on the RichTextBox instance.
        /// </summary>
        /// <param name="instance">The RichTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the DragEnter event on the RichTextBox instance.</returns>
        public static IObservable<EventPattern<DragEventArgs>> DragEnterObservable(this RichTextBox instance)
        {
            return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(
                handler => instance.DragEnter += handler,
                handler => instance.DragEnter -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DragLeave event on the RichTextBox instance.
        /// </summary>
        /// <param name="instance">The RichTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the DragLeave event on the RichTextBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DragLeaveObservable(this RichTextBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DragLeave += handler,
                handler => instance.DragLeave -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DragOver event on the RichTextBox instance.
        /// </summary>
        /// <param name="instance">The RichTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the DragOver event on the RichTextBox instance.</returns>
        public static IObservable<EventPattern<DragEventArgs>> DragOverObservable(this RichTextBox instance)
        {
            return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(
                handler => instance.DragOver += handler,
                handler => instance.DragOver -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the GiveFeedback event on the RichTextBox instance.
        /// </summary>
        /// <param name="instance">The RichTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the GiveFeedback event on the RichTextBox instance.</returns>
        public static IObservable<EventPattern<GiveFeedbackEventArgs>> GiveFeedbackObservable(this RichTextBox instance)
        {
            return Observable.FromEventPattern<GiveFeedbackEventHandler, GiveFeedbackEventArgs>(
                handler => instance.GiveFeedback += handler,
                handler => instance.GiveFeedback -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the QueryContinueDrag event on the RichTextBox instance.
        /// </summary>
        /// <param name="instance">The RichTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the QueryContinueDrag event on the RichTextBox instance.</returns>
        public static IObservable<EventPattern<QueryContinueDragEventArgs>> QueryContinueDragObservable(this RichTextBox instance)
        {
            return Observable.FromEventPattern<QueryContinueDragEventHandler, QueryContinueDragEventArgs>(
                handler => instance.QueryContinueDrag += handler,
                handler => instance.QueryContinueDrag -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the HScroll event on the RichTextBox instance.
        /// </summary>
        /// <param name="instance">The RichTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the HScroll event on the RichTextBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> HScrollObservable(this RichTextBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.HScroll += handler,
                handler => instance.HScroll -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the LinkClicked event on the RichTextBox instance.
        /// </summary>
        /// <param name="instance">The RichTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the LinkClicked event on the RichTextBox instance.</returns>
        public static IObservable<EventPattern<LinkClickedEventArgs>> LinkClickedObservable(this RichTextBox instance)
        {
            return Observable.FromEventPattern<LinkClickedEventHandler, LinkClickedEventArgs>(
                handler => instance.LinkClicked += handler,
                handler => instance.LinkClicked -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ImeChange event on the RichTextBox instance.
        /// </summary>
        /// <param name="instance">The RichTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the ImeChange event on the RichTextBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ImeChangeObservable(this RichTextBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ImeChange += handler,
                handler => instance.ImeChange -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Protected event on the RichTextBox instance.
        /// </summary>
        /// <param name="instance">The RichTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the Protected event on the RichTextBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ProtectedObservable(this RichTextBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Protected += handler,
                handler => instance.Protected -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SelectionChanged event on the RichTextBox instance.
        /// </summary>
        /// <param name="instance">The RichTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the SelectionChanged event on the RichTextBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> SelectionChangedObservable(this RichTextBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.SelectionChanged += handler,
                handler => instance.SelectionChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the VScroll event on the RichTextBox instance.
        /// </summary>
        /// <param name="instance">The RichTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the VScroll event on the RichTextBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> VScrollObservable(this RichTextBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.VScroll += handler,
                handler => instance.VScroll -= handler);
        }
    }
}
