﻿namespace AntCommerce.Module.Modular
{
    using System;
    using System.Reflection;

    public class ModuleInfo
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool IsBundledWithHost { get; set; }

        public Version Version { get; set; }

        public Assembly Assembly { get; set; }
    }
}