/**
 * @interface strange.extensions.dispatcher.eventdispatcher.api.IEventBinding
 * 
 * Binding interface for EventDispatcher.
 * 
 * EventBindings technically allow any Key, but require either an 
 * EmptyCallback (no arguments) or an EventCallback (one argument).
 * 
 * @see strange.extensions.dispatcher.eventdispatcher.impl.TmEvent
 */

using System;
using strange.framework.api;

namespace strange.extensions.dispatcher.eventdispatcher.api
{
	/// Delegate for adding a listener with a single argument
	public delegate void EventCallback(object payload);

	/// Delegate for adding a listener with a no arguments
	public delegate void EmptyCallback();

	public interface IEventBinding : IBinding
	{
		/// Retrieve the type of the provided callback
		EventCallbackType typeForCallback (EventCallback callback);

		/// Retrieve the type of the provided callback
		EventCallbackType typeForCallback (EmptyCallback callback);

		new IEventBinding Key (object key);
		IEventBinding To (EventCallback callback);
		IEventBinding To (EmptyCallback callback);
	}
}

