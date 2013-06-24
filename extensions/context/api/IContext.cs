/*
 * Copyright 2013 ThirdMotion, Inc.
 *
 *	Licensed under the Apache License, Version 2.0 (the "License");
 *	you may not use this file except in compliance with the License.
 *	You may obtain a copy of the License at
 *
 *		http://www.apache.org/licenses/LICENSE-2.0
 *
 *		Unless required by applicable law or agreed to in writing, software
 *		distributed under the License is distributed on an "AS IS" BASIS,
 *		WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *		See the License for the specific language governing permissions and
 *		limitations under the License.
 */

/**
 * @interface strange.extensions.context.api.IContext
 * 
 * A Context is the entry point to the binding framework.
 * 
 * Implement this interface to create the binding context suitable for your application.
 * 
 * In a typical Unity3D setup, an extension of MVCSContext should be instantiated from the ContextView.
 */

using System;
using strange.framework.api;
using strange.extensions.dispatcher.api;

namespace strange.extensions.context.api
{
	public interface IContext : IBinder
	{
		/// Kick the context into action
		IContext Start();
		
		/// Request a component from the context (might be useful in certain cross-context situations)
		object GetComponent<T>();
		
		/// Request a component from the context (might be useful in certain cross-context situations)
		object GetComponent<T>(object name);
		
		/// Register a new context to this one
		IContext AddContext(IContext context);
		
		/// Remove a context from this one
		IContext RemoveContext(IContext context);
		
		/// Register a view with this context
		void AddView(object view);
		
		/// Remove a view from this context
		void RemoveView(object view);
		
		/// Set and get the shared system bus for communicating across contexts
		IDispatcher crossContextDispatcher{get;set;}
		
		/// Get the ContextView
		object GetContextView();
	}
}

