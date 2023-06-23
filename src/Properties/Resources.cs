// Decompiled with JetBrains decompiler
// Type: FBBack.Properties.Resources
// Assembly: FBBack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 74E6CE95-B82B-47A8-B247-C1E09D172782
// Assembly location: C:\Users\jarek.INFOSERWIS\Desktop\info-sys_fb25to30\FBBack.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace FBBack.Properties
{
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    internal class Resources
    {
        private static ResourceManager resourceMan;
        private static CultureInfo resourceCulture;

        internal Resources()
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (FBBack.Properties.Resources.resourceMan == null)
                    FBBack.Properties.Resources.resourceMan = new ResourceManager("FBBack.Properties.Resources", typeof(FBBack.Properties.Resources).Assembly);
                return FBBack.Properties.Resources.resourceMan;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get => FBBack.Properties.Resources.resourceCulture;
            set => FBBack.Properties.Resources.resourceCulture = value;
        }
    }
}
