﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace N_m3u8DL_RE.Common.Resource {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ResString {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResString() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("N_m3u8DL_RE.Common.Resource.ResString", typeof(ResString).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 错误的m3u8 的本地化字符串。
        /// </summary>
        public static string badM3u8 {
            get {
                return ResourceManager.GetString("badM3u8", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 验证最后一个分片有效性 的本地化字符串。
        /// </summary>
        public static string checkingLast {
            get {
                return ResourceManager.GetString("checkingLast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 获取:  的本地化字符串。
        /// </summary>
        public static string fetch {
            get {
                return ResourceManager.GetString("fetch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 检测到直播流 的本地化字符串。
        /// </summary>
        public static string liveFound {
            get {
                return ResourceManager.GetString("liveFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 加载URL:  的本地化字符串。
        /// </summary>
        public static string loadingUrl {
            get {
                return ResourceManager.GetString("loadingUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 检测到Master列表，开始解析全部流信息 的本地化字符串。
        /// </summary>
        public static string masterM3u8Found {
            get {
                return ResourceManager.GetString("masterM3u8Found", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 内容匹配: [white on mediumorchid1]Dynamic Adaptive Streaming over HTTP[/] 的本地化字符串。
        /// </summary>
        public static string matchDASH {
            get {
                return ResourceManager.GetString("matchDASH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 内容匹配: [white on deepskyblue1]HTTP Live Streaming[/] 的本地化字符串。
        /// </summary>
        public static string matchHLS {
            get {
                return ResourceManager.GetString("matchHLS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 当前输入不受支持:  的本地化字符串。
        /// </summary>
        public static string notSupported {
            get {
                return ResourceManager.GetString("notSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 正在解析媒体信息... 的本地化字符串。
        /// </summary>
        public static string parsingStream {
            get {
                return ResourceManager.GetString("parsingStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 [grey](按键盘上下键以浏览更多内容)[/] 的本地化字符串。
        /// </summary>
        public static string promptChoiceText {
            get {
                return ResourceManager.GetString("promptChoiceText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 (按 [blue]空格键[/] 选择流, [green]回车键[/] 完成选择) 的本地化字符串。
        /// </summary>
        public static string promptInfo {
            get {
                return ResourceManager.GetString("promptInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请选择 [green]你要下载的内容[/]: 的本地化字符串。
        /// </summary>
        public static string promptTitle {
            get {
                return ResourceManager.GetString("promptTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 已选择的流: 的本地化字符串。
        /// </summary>
        public static string selectedStream {
            get {
                return ResourceManager.GetString("selectedStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 已解析, 共计 {} 条媒体流, 基本流 {} 条, 可选音频流 {} 条, 可选字幕流 {} 条 的本地化字符串。
        /// </summary>
        public static string streamsInfo {
            get {
                return ResourceManager.GetString("streamsInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 写出meta.json 的本地化字符串。
        /// </summary>
        public static string writeJson {
            get {
                return ResourceManager.GetString("writeJson", resourceCulture);
            }
        }
    }
}
