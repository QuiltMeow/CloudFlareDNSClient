﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudFlareDNSClient.Properties {
    using System;
    
    
    /// <summary>
    ///   用於查詢當地語系化字串等的強類型資源類別。
    /// </summary>
    // 這個類別是自動產生的，是利用 StronglyTypedResourceBuilder
    // 類別透過 ResGen 或 Visual Studio 這類工具。
    // 若要加入或移除成員，請編輯您的 .ResX 檔，然後重新執行 ResGen
    // (利用 /str 選項)，或重建您的 VS 專案。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   傳回這個類別使用的快取的 ResourceManager 執行個體。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CloudFlareDNSClient.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   覆寫目前執行緒的 CurrentUICulture 屬性，對象是所有
        ///   使用這個強類型資源類別的資源查閱。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查詢類似 帳號 : 這是與本客戶端關聯的電子郵件位址，
        ///您可以使用該帳號於 Cloud Flare 官方網站進行網域管理
        ///
        ///存取方式 : 這是客戶端與 Cloud Flare API 進行通訊時所使用的媒介 的當地語系化字串。
        /// </summary>
        internal static string AccountToolTip {
            get {
                return ResourceManager.GetString("AccountToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        /// </summary>
        internal static System.Drawing.Bitmap Alert {
            get {
                object obj = ResourceManager.GetObject("Alert", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查詢類似 API 權杖必須包含 [區域檢視] 與 [DNS 編輯] 權限 的當地語系化字串。
        /// </summary>
        internal static string APITokenToolTip {
            get {
                return ResourceManager.GetString("APITokenToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        /// </summary>
        internal static System.Drawing.Bitmap Beast_Tamer {
            get {
                object obj = ResourceManager.GetObject("Beast Tamer", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        /// </summary>
        internal static System.Drawing.Bitmap Cloud_Flare {
            get {
                object obj = ResourceManager.GetObject("Cloud Flare", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        /// </summary>
        internal static System.Drawing.Bitmap Fail {
            get {
                object obj = ResourceManager.GetObject("Fail", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查詢類似 當有其他來源 (網頁或其他客戶端) 可能更新 IP 位址時請勾選此項目
        ///請注意 : 若使用者不斷進行手動更新可能遭到 Cloud Flare 限制存取 的當地語系化字串。
        /// </summary>
        internal static string ForceUpdateToolTip {
            get {
                return ResourceManager.GetString("ForceUpdateToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        /// </summary>
        internal static System.Drawing.Bitmap Help {
            get {
                object obj = ResourceManager.GetObject("Help", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查詢類似 當原先選取域名已經不存在 (可能由網頁端移除) 且已不再使用時，請點選此按紐 的當地語系化字串。
        /// </summary>
        internal static string HostResetToolTip {
            get {
                return ResourceManager.GetString("HostResetToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 更新 : 這是選擇已與本機關聯域名進行更新的數量 的當地語系化字串。
        /// </summary>
        internal static string HostToolTip {
            get {
                return ResourceManager.GetString("HostToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 IP : 這是目前由客戶端偵測到的 IP 位址，
        ///可以是本地 IP 位址，
        ///或經由 NAT / 路由器 / 代理伺服器的外部 IP 位址
        ///
        ///下次檢查 : 這是進行下一次 IP 變更檢查的倒數計時 的當地語系化字串。
        /// </summary>
        internal static string IPToolTip {
            get {
                return ResourceManager.GetString("IPToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        /// </summary>
        internal static System.Drawing.Bitmap Logo {
            get {
                object obj = ResourceManager.GetObject("Logo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        /// </summary>
        internal static System.Drawing.Bitmap Logo_Text {
            get {
                object obj = ResourceManager.GetObject("Logo Text", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        /// </summary>
        internal static System.Drawing.Bitmap Profile {
            get {
                object obj = ResourceManager.GetObject("Profile", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        /// </summary>
        internal static System.Drawing.Bitmap Spin {
            get {
                object obj = ResourceManager.GetObject("Spin", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        /// </summary>
        internal static System.Drawing.Bitmap Success {
            get {
                object obj = ResourceManager.GetObject("Success", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
