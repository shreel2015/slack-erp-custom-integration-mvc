﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Promact.Erp.Util.Email_Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "F:\Siddhartha\slack-automation\slack-erp-custom-integration-mvc\Slack.Automation\Promact.Erp.Util\Email Templates\SickLeaveApplication.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class SickLeaveApplication : SickLeaveApplicationBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n\n\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n\n<!DOCTYPE> \n<html xmlns=\"http://www.w3.org/1999/xhtml\">\n<head>\n</head>\n<body>\n " +
                    "   LEAVE APPLICATION\n    <table>\n\t\t<tr>\n            <td><b>From :</b></td>\n     " +
                    "       <td>");
            
            #line 1 "F:\Siddhartha\slack-automation\slack-erp-custom-integration-mvc\Slack.Automation\Promact.Erp.Util\Email Templates\SickLeaveApplication.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(FromDate));
            
            #line default
            #line hidden
            this.Write("</td>\n        </tr>\n\t\t<tr>\n            <td><b>Reason :</b></td>\n            <td>");
            
            #line 1 "F:\Siddhartha\slack-automation\slack-erp-custom-integration-mvc\Slack.Automation\Promact.Erp.Util\Email Templates\SickLeaveApplication.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Reason));
            
            #line default
            #line hidden
            this.Write("</td>\n        </tr>\n\t\t<tr>\n            <td><b>Type :</b></td>\n            <td>");
            
            #line 1 "F:\Siddhartha\slack-automation\slack-erp-custom-integration-mvc\Slack.Automation\Promact.Erp.Util\Email Templates\SickLeaveApplication.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type));
            
            #line default
            #line hidden
            this.Write("</td>\n        </tr>\n\t\t<tr>\n            <td><b>Status :</b></td>\n            <td>");
            
            #line 1 "F:\Siddhartha\slack-automation\slack-erp-custom-integration-mvc\Slack.Automation\Promact.Erp.Util\Email Templates\SickLeaveApplication.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Status));
            
            #line default
            #line hidden
            this.Write("</td>\n        </tr>\n        <tr>\n            <td><b>Applied On :</b></td>\n       " +
                    "     <td>");
            
            #line 1 "F:\Siddhartha\slack-automation\slack-erp-custom-integration-mvc\Slack.Automation\Promact.Erp.Util\Email Templates\SickLeaveApplication.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CreatedOn));
            
            #line default
            #line hidden
            this.Write("</td>\n        </tr>\n    </table>\n</body>");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "F:\Siddhartha\slack-automation\slack-erp-custom-integration-mvc\Slack.Automation\Promact.Erp.Util\Email Templates\SickLeaveApplication.tt"

private string _FromDateField;

/// <summary>
/// Access the FromDate parameter of the template.
/// </summary>
private string FromDate
{
    get
    {
        return this._FromDateField;
    }
}

private string _EndDateField;

/// <summary>
/// Access the EndDate parameter of the template.
/// </summary>
private string EndDate
{
    get
    {
        return this._EndDateField;
    }
}

private string _ReasonField;

/// <summary>
/// Access the Reason parameter of the template.
/// </summary>
private string Reason
{
    get
    {
        return this._ReasonField;
    }
}

private string _TypeField;

/// <summary>
/// Access the Type parameter of the template.
/// </summary>
private string Type
{
    get
    {
        return this._TypeField;
    }
}

private string _StatusField;

/// <summary>
/// Access the Status parameter of the template.
/// </summary>
private string Status
{
    get
    {
        return this._StatusField;
    }
}

private string _ReJoinDateField;

/// <summary>
/// Access the ReJoinDate parameter of the template.
/// </summary>
private string ReJoinDate
{
    get
    {
        return this._ReJoinDateField;
    }
}

private string _CreatedOnField;

/// <summary>
/// Access the CreatedOn parameter of the template.
/// </summary>
private string CreatedOn
{
    get
    {
        return this._CreatedOnField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool FromDateValueAcquired = false;
if (this.Session.ContainsKey("FromDate"))
{
    this._FromDateField = ((string)(this.Session["FromDate"]));
    FromDateValueAcquired = true;
}
if ((FromDateValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("FromDate");
    if ((data != null))
    {
        this._FromDateField = ((string)(data));
    }
}
bool EndDateValueAcquired = false;
if (this.Session.ContainsKey("EndDate"))
{
    this._EndDateField = ((string)(this.Session["EndDate"]));
    EndDateValueAcquired = true;
}
if ((EndDateValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("EndDate");
    if ((data != null))
    {
        this._EndDateField = ((string)(data));
    }
}
bool ReasonValueAcquired = false;
if (this.Session.ContainsKey("Reason"))
{
    this._ReasonField = ((string)(this.Session["Reason"]));
    ReasonValueAcquired = true;
}
if ((ReasonValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Reason");
    if ((data != null))
    {
        this._ReasonField = ((string)(data));
    }
}
bool TypeValueAcquired = false;
if (this.Session.ContainsKey("Type"))
{
    this._TypeField = ((string)(this.Session["Type"]));
    TypeValueAcquired = true;
}
if ((TypeValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Type");
    if ((data != null))
    {
        this._TypeField = ((string)(data));
    }
}
bool StatusValueAcquired = false;
if (this.Session.ContainsKey("Status"))
{
    this._StatusField = ((string)(this.Session["Status"]));
    StatusValueAcquired = true;
}
if ((StatusValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Status");
    if ((data != null))
    {
        this._StatusField = ((string)(data));
    }
}
bool ReJoinDateValueAcquired = false;
if (this.Session.ContainsKey("ReJoinDate"))
{
    this._ReJoinDateField = ((string)(this.Session["ReJoinDate"]));
    ReJoinDateValueAcquired = true;
}
if ((ReJoinDateValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("ReJoinDate");
    if ((data != null))
    {
        this._ReJoinDateField = ((string)(data));
    }
}
bool CreatedOnValueAcquired = false;
if (this.Session.ContainsKey("CreatedOn"))
{
    this._CreatedOnField = ((string)(this.Session["CreatedOn"]));
    CreatedOnValueAcquired = true;
}
if ((CreatedOnValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("CreatedOn");
    if ((data != null))
    {
        this._CreatedOnField = ((string)(data));
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class SickLeaveApplicationBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
