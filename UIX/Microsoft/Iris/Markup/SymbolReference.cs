﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Iris.Markup.SymbolReference
// Assembly: UIX, Version=4.8.0.0, Culture=neutral, PublicKeyToken=ddd0da4d3e678217
// MVID: A56C6C9D-B7F6-46A9-8BDE-B3D9B8D60B11
// Assembly location: C:\Program Files\Zune\UIX.dll

namespace Microsoft.Iris.Markup
{
    public struct SymbolReference
    {
        private string _symbol;
        private SymbolOrigin _origin;

        public SymbolReference(string symbol, SymbolOrigin origin)
        {
            _origin = origin;
            _symbol = NotifyService.CanonicalizeString(symbol);
        }

        public string Symbol => _symbol;

        public SymbolOrigin Origin => _origin;
    }
}
