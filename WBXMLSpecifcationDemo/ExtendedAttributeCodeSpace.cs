﻿// Copyright 2012 - Johan de Koning (johan@johandekoning.nl)
// 
// This file is part of WBXML .Net Library.
// Permission is hereby granted, free of charge, to any person obtaining a copy 
// of this software and associated documentation files (the "Software"), to deal in 
// the Software without restriction, including without limitation the rights to use, 
// copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the 
// Software, and to permit persons to whom the Software is furnished to do so, 
// subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies 
// or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE 
// FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR 
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE 
// USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// The WAP Binary XML (WBXML) specification is developed by the 
// Open Mobile Alliance (http://www.openmobilealliance.org/)
// Details about this specification can be found at
// http://www.openmobilealliance.org/tech/affiliates/wap/wap-192-wbxml-20010725-a.pdf
//
// Encoding sample which can be found inside section 8.2 of the WBXML Specification
using WBXML;

namespace WBXMLSpecifcationDemo
{
    public class ExtendedAttributeCodeSpace : AttributeCodeSpace
    {
        public ExtendedAttributeCodeSpace()
        {
            var codePage = new AttributeCodePage();
            codePage.AddAttributeStart(0x05, "STYLE", "LIST");
            codePage.AddAttributeStart(0x06, "TYPE");
            codePage.AddAttributeStart(0x07, "TYPE", "TEXT");
            codePage.AddAttributeStart(0x08, "URL", "http://");
            codePage.AddAttributeStart(0x09, "NAME");
            codePage.AddAttributeStart(0x0A, "KEY");

            codePage.AddAttributeValue(0x85, ".org");
            codePage.AddAttributeValue(0x86, "ACCEPT");

            AddCodePage(codePage);
        }
    }
}