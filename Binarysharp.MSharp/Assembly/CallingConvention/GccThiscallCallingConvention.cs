﻿/*
 * MemorySharp Library
 * http://www.binarysharp.com/
 *
 * Copyright (C) 2012-2016 Jämes Ménétrey (a.k.a. ZenLulz).
 * This library is released under the MIT License.
 * See the file LICENSE for more information.
*/

namespace Binarysharp.MSharp.Assembly.CallingConvention
{
    /// <summary>
    /// Define the 'This' Calling Convention, generated by GCC compiler.
    /// The first parameter must be the 'this' pointer. Internally, the 'this' pointer is pushed at the end on the stack.
    /// </summary>
    /// <remarks>
    /// This calling convention is used for calling C++ non-static member functions.
    /// The first parameter must be a pointer of the instance of the class.
    /// The parameter are pushed on the stack in the right-to-left order. The caller cleans the arguments from the stack.
    /// The return value is stored in the register EAX.
    /// </remarks>
    public class GccThiscallCallingConvention : CdeclCallingConvention
    {
    }
}
