﻿using System;
using System.Collections.Generic;
using System.Linq;
using SimpleInjector;

namespace Xamarin.Forms.Labs.Services.SimpleContainer
{
    /// <summary>
    /// The simple injector resolver.
    /// </summary>
    public class SimpleInjectorResolver : IResolver
    {
        private readonly Container container;

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleInjectorResolver"/> class.
        /// </summary>
        /// <param name="container">
        /// The container.
        /// </param>
        public SimpleInjectorResolver(Container container)
        {
            this.container = container;
        }

        #region IResolver Members

        /// <summary>
        /// Resolve a dependency.
        /// </summary>
        /// <typeparam name="T">Type of instance to get.</typeparam>
        /// <returns>An instance of {T} if successful, otherwise null.</returns>
        public T Resolve<T>() where T : class
        {
            try
            {
                return this.container.GetInstance<T>();
            }
            catch
            {

                return null;
            }
        }

        /// <summary>
        /// Resolve a dependency by type.
        /// </summary>
        /// <param name="type">Type of object.</param>
        /// <returns>An instance to type if found as <see cref="object"/>, otherwise null.</returns>
        public object Resolve(Type type)
        {
            try
            {
                return this.container.GetInstance(type);
            }
            catch
            {

                return null;
            }
        }

        /// <summary>
        /// Resolve a dependency.
        /// </summary>
        /// <typeparam name="T">Type of instance to get.</typeparam>
        /// <returns>All instances of {T} if successful, otherwise null.</returns>
        public IEnumerable<T> ResolveAll<T>() where T : class
        {
            try
            {
                return this.container.GetAllInstances<T>();
            }
            catch
            {
                return Enumerable.Empty<T>();
            }
        }

        /// <summary>
        /// Resolve a dependency by type.
        /// </summary>
        /// <param name="type">Type of object.</param>
        /// <returns>All instances of type if found as <see cref="object"/>, otherwise null.</returns>
        public IEnumerable<object> ResolveAll(Type type)
        {
            try
            {
                return this.container.GetAllInstances(type);
            }
            catch
            {
                return Enumerable.Empty<object>();
            }
        }

        #endregion
    }
}
