﻿#pragma checksum "C:\Users\yehonatan\source\repos\inventorySoftware2\storageUniversal\Register.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9CEEF87CF55D0669E553064B9A1F8DE0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace storageUniversal
{
    partial class Register : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Register.xaml line 12
                {
                    this.FN = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // Register.xaml line 13
                {
                    this.LN = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Register.xaml line 14
                {
                    this.BDate = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 5: // Register.xaml line 15
                {
                    this.compeny = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Register.xaml line 16
                {
                    this.email = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Register.xaml line 17
                {
                    this.pass = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Register.xaml line 18
                {
                    this.regBot = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.regBot).Click += this.RegBot_Click;
                }
                break;
            case 9: // Register.xaml line 19
                {
                    this.isDone = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

