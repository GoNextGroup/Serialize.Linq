﻿#region Copyright
//  Copyright, Sascha Kiefer (esskar)
//  Released under LGPL License.
//  
//  License: https://raw.github.com/esskar/Serialize.Linq/master/LICENSE
//  Contributing: https://github.com/esskar/Serialize.Linq
#endregion

using System;
using System.Linq.Expressions;
using System.Reflection;
using Serialize.Linq.Factories;
using Serialize.Linq.Nodes;

namespace Serialize.Linq.Interfaces
{
    public interface INodeFactory
    {
        /// <summary>
        /// Returns the factory settings for this instance
        /// </summary>
        FactorySettings Settings { get; }

        /// <summary>
        /// Creates a node from the given object.
        /// </summary>
        /// <param name="expression">The object to create the node from.</param>
        /// <returns></returns>
        Node Create(object obj);

        /// <summary>
        /// Gets binding flags to be used when accessing type members.
        /// </summary>
        BindingFlags? GetBindingFlags();
    }    
}