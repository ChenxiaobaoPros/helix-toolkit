﻿#if !NETFX_CORE && !WINUI
namespace HelixToolkit.Wpf.SharpDX
#else
#if CORE
namespace HelixToolkit.SharpDX.Core
#elif WINUI
namespace HelixToolkit.WinUI
#else
namespace HelixToolkit.UWP
#endif
#endif
{
    public interface IApplyPostEffect
    {
        string PostEffects { set; get; }
    }
}
